using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElzeKool.Devices;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace TrackerWatchServer
{
    public partial class Form1 : Form
    {
        private delegate void SetTextCallback(string log_string);
        private delegate void CreateCompomentCallback(string deviceID);
        private delegate void DeleteCompomentCallback(string deviceID);
        private delegate void SetGPRSTextCallback(string deviceID, string text);

        private GM862GPS modem = null;
        private List<Device> devices = new List<Device>();
        private Device currentDevice = null;
        private  TrackerCommand command = null;
        private Dictionary<String,String> SMSMessage = new Dictionary<String, String>();   //was a string

        public Dictionary<string, NetworkStream> Connessioni = new Dictionary<string, NetworkStream>();

        Thread checkCommandThread = null;


        public Form1()
        {
            InitializeComponent();
        }

        public void setGPRSText(string deviceID, string text)
        {
              if (this.flowLayoutPanel1.InvokeRequired)
              {
                  SetGPRSTextCallback stc = new SetGPRSTextCallback(setGPRSText);
                  this.Invoke(stc, new object[] { deviceID, text });
              }
              else
              {
                    System.Windows.Forms.Control ctrl = flowLayoutPanel1.Controls.Find(deviceID, true)[0];
                    UserControl1 ct = (UserControl1)ctrl;
                    if (ctrl.Name == deviceID)
                    {
                        if (ct.txtGprsComm.Text.Length >= 500)   //Pulisce la lista di comunicazioni
                            ct.txtGprsComm.Text = "";
                        ct.txtGprsComm.Text += text;
                    }

               }
        }

        private void setGPRSText(string deviceID, string text, params object[] args)
        {
           // string msg = string.Format(deviceID, args);
            setGPRSText(deviceID, text);
        }

        public void deleteCompoment(string deviceID)
        {
            if (this.flowLayoutPanel1.InvokeRequired)
            {
                DeleteCompomentCallback stc = new DeleteCompomentCallback(deleteCompoment);
                this.Invoke(stc, new object[] { deviceID });
            }
            else
            {
                System.Windows.Forms.Control[] ctrl = flowLayoutPanel1.Controls.Find(deviceID, true);
                if (ctrl[0].Name == deviceID)
                {
                    flowLayoutPanel1.Controls.Remove(ctrl[0]);
                }
            }
        }

        private void deleteCompoment(string deviceID, params object[] args)
        {
            string msg = string.Format(deviceID, args);
            deleteCompoment(msg);
        }


        public void createCompoment(string deviceID)
        {
            if (this.flowLayoutPanel1.InvokeRequired)
            {
                CreateCompomentCallback stc = new CreateCompomentCallback(createCompoment);
                this.Invoke(stc, new object[] { deviceID });
            }
            else
            {
                UserControl1 ctrl = new UserControl1();
                ctrl.txtID.Text = deviceID;
                ctrl.Name = deviceID;
                flowLayoutPanel1.Controls.Add(ctrl);
            }
        }

        private void createCompoment(string deviceID, params object[] args)
        {
            string msg = string.Format(deviceID, args);
            createCompoment(msg);
        }

        public void log(string log_string)
        {
            if (this.txtLog.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(log);
                this.Invoke(stc, new object[] { log_string });
            }
            else
            {
                txtLog.Text += (log_string);
                txtLog.Text += ("\r\n");
            }
        }

        private void log(string text, params object[] args)
        {
            string msg = string.Format(text, args);
            log(msg);
        }

        void saveDevices(List<Device> listofa)
        {

            string dir = Application.StartupPath;
            string serializationFile = Path.Combine(dir, "devices.bin");

            //serialize
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, devices);
            }

            
        }

        List<Device> loadDevices()
        {

            return DeviceController.SharedInstance.getDevices(); 

        }

        List<Device> importDevice()
        {
            List<Device> temp = new List<Device>();

            if (!File.Exists(Application.StartupPath + "\\devices.txt"))
                return null;

            using (StreamReader rd = new StreamReader(Application.StartupPath + "\\devices.txt"))
            {
                while(!rd.EndOfStream)
                {
                    string[] tmp = rd.ReadLine().Split('\t');
                    Device device = new Device(tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]);
                    //deviceList.Items.Add(device.User);
                    temp.Add(device);
                }
                return temp;
            }
        }

        void refreshDevice()
        {
            foreach(Device d in devices) {
                deviceList.Items.Add(d.Note + " ["+d.DeviceID+"]");
            }
            
        }

        string fixDataTimeString(string data, char separator)
        {
            String[] dataString = data.Split(separator);
            string[] newData = new string[3];

            int c = 0;
            foreach(string s in dataString)
            {
                if (s.Length == 1)
                    newData[c] = "0" + s;
                else
                    newData[c] = s;
                c++;
            }

            return newData[0] + separator + newData[1] + separator + newData[2];
        }


        /*Valori di ritorno: Tupla
         * ID,Messaggio,GoogleURL,Data e Ora
         * ID e Messaggio potrebbero essere vuoti nel caso ria una riposta al comando
         * getPosition
         * */
        Tuple<String,String,String,DateTime> test(String smsMessage)
        {
            smsMessage = smsMessage.Replace(" ", "");     //puliamo la stringa da spazi inutili...
            smsMessage = smsMessage.Replace("\n", "");    //..e da eventuali caratteri newline
            String[] message = smsMessage.Split('\r');    //Verificare se realmente viene inviato dall'sms

            if (message.Length > 4)
            {
                int start = message[0].IndexOf("ID:");
                int comma = message[0].IndexOf(",");
                int urlPos = message[0].IndexOf("url:");
                string id = message[0].Substring(start + 3, start + (comma - 3));
                string alarmMessage = message[0].Split(',')[1];
                string url = message[2];
                string locateData = fixDataTimeString(message[3].Split(':')[1].ToString(), '-');
                string locateTime = fixDataTimeString(message[4].Split(':')[1] + ":" + message[4].Split(':')[2] + ":" + message[4].Split(':')[3], ':');

                DateTime date = DateTime.ParseExact(locateData + " " + locateTime, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                return new Tuple<string, string, string, DateTime>(id, alarmMessage, url, date);
            }
            else
            {
                string url = message[1];
                string locateData = fixDataTimeString(message[2].Split(':')[1].ToString(), '-');
                string locateTime = fixDataTimeString(message[3].Split(':')[1] + ":" + message[3].Split(':')[2] + ":" + message[3].Split(':')[3], ':');

                DateTime date = DateTime.ParseExact(locateData + " " + locateTime, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                return new Tuple<string, string, string, DateTime>("", "", url, date);
            }
        }

        private void newConnection(String deviceID, NetworkStream st)
        {
            if (!Connessioni.ContainsKey(deviceID))
            {
                log("L'ID: " + deviceID + " si è connesso.");
                Connessioni.Add(deviceID, st);
                createCompoment(deviceID);
            }
            else
                Connessioni[deviceID] = st;
        }

        private void deleteConnection(String deviceID)
        {
            Connessioni.Remove(deviceID);
            log("L'ID: " + deviceID + " si è disconnesso.");
            if (deviceID != "")
            {
                deleteCompoment(deviceID);
            }
        }

        private void startGSM()
        {
            if(modem != null)
            {
                modem.Dispose();
                modem = null;
            }

            modem = new GM862GPS(AppController.SharedInstance.COM_PORT);
            log("Modem active on " + AppController.SharedInstance.COM_PORT);

            if (!modem.RegisteredOnNetwork(true))
            {
                //modem.ExecuteCommand("AT+CFUN=0", 1000);
                //modem.ExecuteCommand("AT+CFUN=1", 1000);
                modem.ExecuteCommand("ATZ", 1000);
            }

            modem.InitializeBasicGSM();
            log("GSM Initialized success");



            modem.InitializeSMS();

            modem.ExecuteCommand("AT+CMGD=1,4", 5000);
            log("SMS reset success");

            modem.OnRecievedSMS += ReceivedSMS;
            log("SMS Initialized success");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlServer.Visible = false;

            devices = loadDevices();
            refreshDevice();
            log("Command ready");

            testMethod();

            if (AppController.SharedInstance.isServer)
            {
                if (CommandController.SharedInstance.commandAvailable())
                {
                    Command cmd = CommandController.SharedInstance.getLastCommand();
                    Console.WriteLine(cmd);
                }
                try
                {

                    startGSM();

                }
                catch
                {
                    log("Unable to open GSM on port");
                    modem = null;
                }

                command = new TrackerCommand(modem);
                command.useGPRS = false;
                command.mainForm = this;

                Thread listen = new Thread(listenClient);
                listen.Start();

                checkCommandThread = new Thread(checkForCommandThread);
                checkCommandThread.IsBackground = true;
                checkCommandThread.Start();
            }
            else
            {
                command = new TrackerCommand(null);
                if (command != null)
                {
                    command.mainForm = this;
                    command.useGPRS = false;
                }
                gPRSToolStripMenuItem.Checked = false;
                sMSToolStripMenuItem.Checked = true;
                gPRSToolStripMenuItem.Enabled = false;
                sMSToolStripMenuItem.Enabled = false;
                log("Programming console as Client");

                checkCommandThread = new Thread(checkForCommandThread);
                checkCommandThread.IsBackground = true;
                checkCommandThread.Start();
            }
        }

        private void NewVoiceCall()
        {
            Console.WriteLine("New voice call...");
        }

        private void checkForCommandThread()
        {
            try
            {
                Thread.CurrentThread.Name = "Command Thread";
                while (Thread.CurrentThread.ThreadState == ThreadState.Background)
                {
                    if (CommandController.SharedInstance.commandAvailable())
                    {
                        Command cmd = CommandController.SharedInstance.getLastCommand();
                        command.sendCommand(cmd.CommandText, cmd.DeviceID);
                        Console.WriteLine("Send a queued command: " + cmd.CommandText + " to: " + cmd.DeviceID);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Fine del processo checkForCommandThread");
            }
        }

        public static byte[] FromHex(string hex)
        {
            if(hex.IndexOf("00") == 0)
                hex = hex.Replace("00", "");

            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        string convertHEXtoString(String Hex_String)
        {
            byte[] data = FromHex(Hex_String);
            string s = Encoding.ASCII.GetString(data); // GatewayServer
            return s;
        }

        void testMethod()
        {
         /*   string test1 = @"ID:1208302416,SOS Alarm
url:http://maps.google.com/maps?q=N37.512393,E15.031840
Locate date:2017-7-20
Locate time:12:13:23";*/

           // string test2 = @"apn:internet.wind;user:;passwork:;userdata:22288";
            string test3 = @"url:
http://maps.google.com/maps?q=N37.512477,E15.032072
Locate date:2017-8-24
Locate time:16:9:4
";

            string testStr = test3;

            if (testStr.Substring(0, 4).Contains("ver:")  && testStr.Substring(testStr.Length - 20, 20).Contains("GPRS:")) //GetParameters Command
            {
                Console.WriteLine("TEST: Get Parameters - PASSED");
            }

            if (testStr.Substring(0, 4).IndexOf("apn:") > -1 && testStr.Substring(testStr.Length - 5, 5).IndexOf("22288") > -1) //Apn Command
            {
                Console.WriteLine("TEST: Apn response - PASSED");
            }

            if (testStr.Substring(0, 3).IndexOf("ID:") > -1 && testStr.Substring(testStr.Length - 20, 10).IndexOf("Locate") > -1) //SOS Message Command
            {
                Console.WriteLine("TEST: SOS Message - PASSED");
            }

            if (testStr.Substring(0, 4).Contains("url:") && testStr.Substring(testStr.Length - 20, 10).Contains("Locate")) //SOS Message Command
            {
                string[] str_tmp = testStr.Split('\r');
                if(str_tmp[0].Contains("url:") && str_tmp[1].Contains("maps.google.com"))
                {
                    string[] location = str_tmp[1].Split('=')[1].Split(',');
                    string latitude = location[0].Substring(1, location[0].Length-1);
                    string longitude = location[1].Substring(1, location[1].Length-1);
                }
            }

        }

        void ReceivedSMS(String Storage, int Number)
        {
            GM862GPS.SMSMessage sms = modem.ReadMessage(Storage, Number);
            string strSMS = sms.Message;
            string telNumber = sms.Orginator;

           
                if (strSMS.IndexOf("00") >-1 )
                    strSMS = convertHEXtoString(strSMS);
            

                   

            Console.WriteLine(strSMS);

            if (telNumber != "")
            {
                if (SMSMessage.ContainsKey(telNumber))
                    SMSMessage[telNumber] += strSMS;
                else
                    SMSMessage.Add(telNumber, strSMS);

                /*if(strSMS.IndexOf("GPRS:") > -1)        //If parameters command has sent
                {
                    checkForCommand(SMSMessage[telNumber]);
                    log("Parse new string: " + SMSMessage[telNumber]);
                    Console.WriteLine(SMSMessage[telNumber]);
                    SMSMessage.Remove(telNumber);
                }*/

                if (SMSMessage[telNumber].Substring(0, 4).IndexOf("ver:") > -1 && SMSMessage[telNumber].Substring(SMSMessage[telNumber].Length - 20, 20).IndexOf("GPRS:") > -1) //GetParameters Command
                {
                    checkForCommand(SMSMessage[telNumber]);
                    log("Parse new string: " + SMSMessage[telNumber]);
                    Console.WriteLine(SMSMessage[telNumber]);
                    SMSMessage.Remove(telNumber);
                }
                else if (SMSMessage[telNumber].Substring(0, 4).Contains("url:") && SMSMessage[telNumber].Substring(SMSMessage[telNumber].Length - 20, 10).Contains("Locate")) //Get Position Message Command
                {
                    string[] str_tmp = SMSMessage[telNumber].Split('\n');
                    if (str_tmp[0].Contains("url:") && str_tmp[1].Contains("maps.google.com"))
                    {
                        string[] location = str_tmp[1].Split('=')[1].Split(',');
                        string latitude = location[0].Substring(1, location[0].Length - 1);
                        string longitude = location[1].Substring(1, location[1].Length - 1).Split(':')[0];

                        Device device = DeviceController.SharedInstance.devices.Find(x => x.TelephoneNumber.Contains(telNumber.Substring(3, telNumber.Length - 3)));
                        device.LastPositionLatitude = latitude;
                        device.LastPositionLongitude = longitude;
                        DeviceController.SharedInstance.updateDevice(device);
                        AlarmController.SharedInstance.buildAlarm(AlarmTypeCode.Message, device.DeviceID, "Nuova posizione GPS", latitude, longitude);
                    }
                }
                else if (SMSMessage[telNumber].Substring(0, 4).Contains("ID:") && SMSMessage[telNumber].Substring(SMSMessage[telNumber].Length - 20, 15).Contains("time:")) //SOS Message Command
                {
                    string[] str_tmp = SMSMessage[telNumber].Split('\n');
                    if (str_tmp[0].Contains("ID:") && str_tmp[4].Contains("time:"))
                    {
                        string typeMessage = str_tmp[0].Split(',')[1];
                      
                        string[] location = str_tmp[2].Split('=')[1].Split(',');
                        string latitude = location[0].Substring(1, location[0].Length - 1);
                        string longitude = location[1].Substring(1, location[1].Length - 1).Split(':')[0];

                        Device device = DeviceController.SharedInstance.devices.Find(x => x.TelephoneNumber.Contains(telNumber.Substring(3, telNumber.Length - 3)));
                        device.LastPositionLatitude = latitude;
                        device.LastPositionLongitude = longitude;
                        DeviceController.SharedInstance.updateDevice(device);
                        AlarmController.SharedInstance.buildAlarm(AlarmTypeCode.Message, device.DeviceID, typeMessage, latitude, longitude);
                    }
                }
            }
        }

        private void checkForCommand(String smsMessage)
        {
            /* Se arriva una string contenente 'url:' probabilmente è un messaggio di allarme*/

            if(smsMessage.IndexOf("url:") > -1)
            {
                int start = smsMessage.IndexOf("ID:");
                int end = smsMessage.IndexOf(",");
                string id = "";
                if (start > -1 && end > -1)
                    id = smsMessage.Substring(start, start + end);
            } 
            if(smsMessage.IndexOf("ID:") > -1)
            {
                String[] listCommand = smsMessage.Split(';');

                string version = listCommand[0].Split(':')[1];
                string id = listCommand[1].Split(':')[1];
                string imei = listCommand[2].Split(':')[1];
                string ip = listCommand[3].Split(':')[1];
                string port = listCommand[4].Split(':')[1];
                string center = listCommand[5].Split(':')[1];
                string slave = listCommand[6].Split(':')[1];
                string sos1 = listCommand[7].Split(':')[1];
                string sos2 = listCommand[8].Split(':')[1];
                string sos3 = listCommand[9].Split(':')[1];
                string profile = listCommand[10].Split(':')[1];
                string upload = listCommand[11].Split(':')[1];
                string batt_lev = listCommand[12].Split(':')[1];
                string language = listCommand[13].Split(':')[1];
                string time_zone = listCommand[14].Split(':')[1];
                string gps = listCommand[15].Split(':')[1];
                string gprs = listCommand[16].Split(':')[1].Split('(')[1].Replace(")","");

                Device device = devices.Find(x => x.DeviceID == id);
                device.Version = version;
                device.Upload_time = upload;
                device.Time_zone = time_zone;
                device.IMEI = imei;
                device.Ip = ip;
                device.Port = port;
                device.Center = center;
                device.Slave = slave;
                device.Sos1 = sos1;
                device.Sos2 = sos2;
                device.Sos3 = sos3;
                device.Profile = profile;
                device.Battery_level = batt_lev;
                device.Language = language;
                device.Gps = gps;
                device.Gprs = gprs;
                DeviceController.SharedInstance.updateDevice(device);
            }
        }


        private void deviceList_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSetAPN_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setAPN(cbAPN.Text, currentDevice);
            }
        }

        private void btnSetSOS1_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setSOSNumber_1(cbSOS1.Text, currentDevice);
            }
        }

        private void btnSetSOS2_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setSOSNumber_2(cbSOS2.Text, currentDevice);
            }
        }
  
        private void btnSetSOS3_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setSOSNumber_3(cbSOS3.Text, currentDevice);
            }
        }

        private void btnSetMonitorNumber_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setMonitorNumber(cbMonitor.Text, currentDevice);
            }
        }

        private void btnSetIMEINumber_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setIMEINumber(cbIMEI.Text, currentDevice);
            }
        }

        private void btnGetPosition_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                if(!command.getPosition(currentDevice))
                    MessageBox.Show("Error on send command GetPosition");
            }
        }

        private void BtnGetParameters_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                if (!command.getParameters(currentDevice))
                    MessageBox.Show("Error on send command GetParameters");
            }
        }

        private void btnResetDevice_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.resetDevice(currentDevice);
            }
        }

        private void btnGetVersion_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.getVersion(currentDevice);
            }
        }

        private void btnRestoreFactorySettings_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.restoreFactorySettings(currentDevice);
            }
        }

        private void btnSetIPandPort_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setIPandPort(tbIP.Text, tbPort.Text,currentDevice);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modem != null)
            {
                modem.Dispose();
                modem = null;
            }
            if (command != null)
                command = null;
            if (checkCommandThread != null)
                checkCommandThread.Interrupt();
            this.Dispose();
        }

        private void btnSetCenterNumber_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setCenterNumber( tbCenterNumber.Text, currentDevice);
            }
        }

        private void btnSetAssistantCenterNumber_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setAssistantCenterNumber(tbAssistantCenterNumber.Text, currentDevice);
            }
        }

        private void btnSetUploadTimeInterval_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setUploadTimeInterval(tbUploadTimeInterval.Text, currentDevice);
            }
        }

        private void btnSetLanguageAndTimezone_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setLanguageAndTimezone(cbLanguage.Text,cbTimezone.Text, currentDevice);
            }
        }

        private void DeleteSOSNumber_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.deleteteSOSNumber(cbSOSNumberToDelete.Text, currentDevice);
            }
        }

        private void btnSetThreeSOSNumbers_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.setThreeSOSNumbers(cbSOS1.Text,cbSOS2.Text,cbSOS3.Text, currentDevice);
            }
        }

        private void listenClient()
        {
            Thread.CurrentThread.Name = "TCP Thread";
            TcpListener tcpListener = new TcpListener(IPAddress.Any, int.Parse(AppController.SharedInstance.TCP_PORT));
            try
            {
                tcpListener.Start();
                while (this.Visible == true)
                {
                    if (tcpListener.Pending())
                    {
                        Socket soTcp = tcpListener.AcceptSocket();
                        ThreadPool.QueueUserWorkItem(new WaitCallback(acceptClientConnection), soTcp);
                        tcpListener.Stop();
                        tcpListener.Start();
                    }
                    else
                        Thread.Sleep(500);
                }
                tcpListener.Stop();
            }
            catch (SocketException se)
            {
                Console.WriteLine("A Socket Exception has occurred!" + se.ToString());
            }
        }

        bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        /*
         * Accetta una nuova connessione via TCP e legge i dati del nuovo Host
         */
        public void acceptClientConnection(Object sock)
        {
            acceptClientConnection((Socket)sock);
        }

       public void acceptClientConnection(Socket oldsock)
        {
            string sEndPoint = "";
            //CLIENT_COUNT++;
            Socket sock = new Socket(oldsock.DuplicateAndClose(System.Diagnostics.Process.GetCurrentProcess().Id));
            sEndPoint = sock.RemoteEndPoint.ToString();
            sock.ReceiveTimeout = 1000;
            NetworkStream st = new NetworkStream(sock);
            StreamReader rd = null;
            int base_cnt = 0;
            string currentID = "";
            string rcvString = "";
            while (SocketConnected(sock)) // sock.Connected)
            {
                if (st.DataAvailable)
                {
                    rd = new StreamReader(st);

                    char c = (char)rd.Read();   // rd.ReadLine();
                    rcvString = "";
                    while (c != ']')
                    {
                        if (c > -1)
                        {
                            rcvString += c;
                        }
                        else
                        {
                            // No work to do sleep some
                            Thread.Sleep(10);
                        }
                        c = (char)rd.Read();
                    }

                    log("DEBUG: TCP_RCV ->" + rcvString);

                   // rcvString = rcvString.Replace("[", "");
                   //   rcvString = rcvString.Replace("]", "");

                    /*Separiamo la stringa:
                    [0] = CS/3G/GS
                    [1] = ID Dispositivo
                    [2] = Lunghezza comando
                    [3] = Comando */
                    string[] rcvData = rcvString.Split('*');


                    if (rcvString.IndexOf("TKQ2") > -1)
                    {
                        log("Received TKQ2 command.");
                        currentID = rcvData[1];

                        newConnection(currentID, st);
                        command.sendTKQ2_ACK(currentID);
                    }

                    if (rcvString.IndexOf("TKQ") > -1)
                    {
                        log("Received TKQ command.");
                        currentID = rcvData[1];
                        newConnection(currentID, st);
                        command.sendTKQ_ACK(currentID);
                    }

                    if (rcvString.IndexOf("*LK") > -1)                              
                    {
                        log("Received LK command.");
                        currentID = rcvData[1];

                        newConnection(currentID, st);
                        setGPRSText(currentID, rcvString);
                        command.sendACK(currentID);
                    }

                    
                    //gestiamo la risposta
                    manageResponse(currentID, rcvString, rcvData, st);

                }
                else
                {
                    Thread.Sleep(100);
                    base_cnt++;
                    if (base_cnt >= 100)
                    {
                        base_cnt = 0;
                    }
                }
            }
            //  Alla Disconnessione
            deleteConnection(currentID);

        }

        //Check the kind of response and handle it
        private void manageResponse(string currentID, string rcvString, string[] rcvData, NetworkStream st) {

            //[CS*YYYYYYYYYY*LEN*UD, the position data]
            if (rcvString.IndexOf("UD") > -1) {
                log("Received UD command.");


                currentID = rcvData[1];
                if (!Connessioni.ContainsKey(currentID))
                {
                    log("L'ID: " + currentID + " si è connesso.");
                    Connessioni.Add(currentID, st);
                }
                else
                {
                    Connessioni[currentID] = st;
                }

                string[] positionData = rcvData[3].Split(',');

                string date = positionData[1];
                string time = positionData[2];
                if (positionData[3] == "A")
                {
                    log("GpsPositioning is valid");
                }
                else if (positionData[3] == "V")
                {
                    log("No positioning");
                }

                string latitude = positionData[4];
                string markOfLatitude = positionData[5];  //N or S
                string longitude = positionData[6];
                string markOfLongitude = positionData[7]; //E OR W
                string speed = positionData[8];
                string direction = positionData[9];
                string altitude = positionData[10];
                string satelliteNumbers = positionData[11];
                string gsmSignalStrenght = positionData[12];
                string batteryStatus = positionData[13];
                string pedometer = positionData[14];
                string tumblingTimes = positionData[15];
                string terminalStatus = String.Join("", positionData[16].Select(x => Convert.ToString(Convert.ToInt32(x + "", 16), 2).PadLeft(4, '0')));
                string highTerminalStatus = terminalStatus.Substring(0, 16);
                int highTerminalStatusValue = Convert.ToInt32(highTerminalStatus, 2);
                string lowTerminalStatus = terminalStatus.Substring(16, 16);
                int lowTerminalStatusValue = Convert.ToInt32(lowTerminalStatus, 2);
                string baseStationInformation = positionData[17]; //più i seguenti 23 con , in mezzo
                                                                  //string wifiNumber = positionData[41];
                                                                  //string positionAccuracy = positionData[42];
            }
            // [CS*YYYYYYYYYY*LEN*UD2, the position data]
            else if (rcvString.IndexOf("UD2") > -1) {
                log("Received UD2 command.");

                currentID = rcvData[1];
                if (!Connessioni.ContainsKey(currentID))
                {
                    log("L'ID: " + currentID + " si è connesso.");
                    Connessioni.Add(currentID, st);
                }
                else
                {
                    Connessioni[currentID] = st;
                }

                string[] positionData = rcvData[3].Split(',');

                string date = positionData[1];
                string time = positionData[2];
                if (positionData[3] == "A")
                {
                    log("GpsPositioning is valid");
                }
                else if (positionData[3] == "V")
                {
                    log("No positioning");
                }

                string latitude = positionData[4];
                string markOfLatitude = positionData[5];  //N or S
                string longitude = positionData[6];
                string markOfLongitude = positionData[7]; //E OR W
                string speed = positionData[8];
                string direction = positionData[9];
                string altitude = positionData[10];
                string satelliteNumbers = positionData[11];
                string gsmSignalStrenght = positionData[12];
                string batteryStatus = positionData[13];
                string pedometer = positionData[14];
                string tumblingTimes = positionData[15];
                string terminalStatus = String.Join("", positionData[16].Select(x => Convert.ToString(Convert.ToInt32(x + "", 16), 2).PadLeft(4, '0')));
                string highTerminalStatus = terminalStatus.Substring(0, 16);
                int highTerminalStatusValue = Convert.ToInt32(highTerminalStatus, 2);
                string lowTerminalStatus = terminalStatus.Substring(16, 16);
                int lowTerminalStatusValue = Convert.ToInt32(lowTerminalStatus, 2);
                string baseStationInformation = positionData[17]; //più i seguenti 23 con , in mezzo
                                                                  //string wifiNumber = positionData[41];
                                                                  //string positionAccuracy = positionData[42];

            }
            //[CS*YYYYYYYYYY*LEN*AL, the position data] 
            else if (rcvString.IndexOf("AL") > -1)
            {
                log("Received AL command.");

                currentID = rcvData[1];
                if (!Connessioni.ContainsKey(currentID))
                {
                    log("L'ID: " + currentID + " si è connesso.");
                    Connessioni.Add(currentID, st);
                }
                else
                    Connessioni[currentID] = st;

                string[] positionData = rcvData[3].Split(',');

                string date = positionData[1];
                string time = positionData[2];
                if (positionData[3] == "A")
                {
                    log("GpsPositioning is valid");
                }
                else if (positionData[3] == "V")
                {
                    log("No positioning");
                }

                string latitude = positionData[4];
                string markOfLatitude = positionData[5];  //N or S
                string longitude = positionData[6];
                string markOfLongitude = positionData[7]; //E OR W
                string speed = positionData[8];
                string direction = positionData[9];
                string altitude = positionData[10];
                string satelliteNumbers = positionData[11];
                string gsmSignalStrenght = positionData[12];
                string batteryStatus = positionData[13];
                string pedometer = positionData[14];
                string tumblingTimes = positionData[15];

                string terminalStatus = String.Join("", positionData[16].Select(x => Convert.ToString(Convert.ToInt32(x + "", 16), 2).PadLeft(4, '0')));
                string test = terminalStatus.Substring(0, 16);
                int b = Convert.ToInt32(test, 2);
                string test2 = terminalStatus.Substring(16, 16);
                int b2 = Convert.ToInt32(test2, 2);
                
                string baseStationInformation = positionData[17]; //più i seguenti 23 con , in mezzo
                                                                  //string wifiNumber = positionData[41];
                                                                  //string positionAccuracy = positionData[42];

                //command.sendGPRSCommand(st,TrackerCommand.gprsCmdConfirmAlarm);

            }


            if (rcvString.IndexOf("TKQ2") > -1)
            {
                log("Received TKQ2 command.");
                currentID = rcvData[1];
                if (!Connessioni.ContainsKey(currentID))
                {
                    log("L'ID: " + currentID + " si è connesso.");
                    Connessioni.Add(currentID, st);
                }
                else
                    Connessioni[currentID] = st;

                command.sendTKQ2_ACK(currentID);
            }

            if (rcvString.IndexOf("TKQ") > -1)
            {
                log("Received TKQ command.");
                currentID = rcvData[1];
                if (!Connessioni.ContainsKey(currentID))
                {
                    log("L'ID: " + currentID + " si è connesso.");
                    Connessioni.Add(currentID, st);
                }
                else
                    Connessioni[currentID] = st;

                command.sendTKQ_ACK(currentID);
            }

            if (rcvString.IndexOf("*LK") > -1)
            {
                log("Received LK command.");
                currentID = rcvData[1];
                if (!Connessioni.ContainsKey(currentID))
                {
                    log("L'ID: " + currentID + " si è connesso.");
                    Connessioni.Add(currentID, st);
                }
                else
                    Connessioni[currentID] = st;

                command.sendACK(currentID);
            }
        }


        private void comunicazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gPRSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gPRSToolStripMenuItem.Checked = true;
            sMSToolStripMenuItem.Checked = false;

            if (command != null)
                command.useGPRS = true;
        }

        private void sMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gPRSToolStripMenuItem.Checked = false;
            sMSToolStripMenuItem.Checked = true;

            if (command != null)
                command.useGPRS = false;
        }

        private void programmazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlServer.Visible = false;
            webBrowser.Visible = true;
            pnlProgrammazione.Visible = true;
        }

        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlServer.Visible = true;
            webBrowser.Visible = false;
            pnlProgrammazione.Visible = false;
        }

        private void azioniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alarmCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAlarm alarmCenter = new frmAlarm();
            alarmCenter.Show();
        }

        private void resetModemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startGSM();
        }

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = deviceList.SelectedIndex;
            if (index > -1)
            {
                currentDevice = devices[index];
                label1.Text = "IMEI: " + currentDevice.IMEI;
                label2.Text = "Serial: " + currentDevice.DeviceID;
                label3.Text = "Telephone: " + currentDevice.TelephoneNumber;
                label4.Text = "Note: " + currentDevice.Note;

                if (currentDevice.Gprs != "")
                {
                    progressBar1.Value = int.Parse(currentDevice.Gprs);
                    label11.Text = currentDevice.Gps;
                }
                else
                {
                    progressBar1.Value = 0;
                    label11.Text = "No GPS Data";
                }
                if (currentDevice.LastComunicationTime == "")
                    txtLastComunication.Text = "Last Comunication: ND";
                else
                {
                    DateTime lastTime = DateTime.Parse(currentDevice.LastComunicationTime);
                    txtLastComunication.Text = "Last Comunication: " + String.Format("{0:MM/dd/yy HH:mm:ss}", lastTime);
                }
            }
            else
            {
                currentDevice = null;
            }
        }

        private void pnlServer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}