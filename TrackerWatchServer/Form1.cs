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

namespace TrackerWatchServer
{
    public partial class Form1 : Form
    {
        private delegate void SetTextCallback(string log_string);

        GM862GPS modem = null;
        List<Device> devices = new List<Device>();
        Device currentDevice = null;
        TrackerCommand command = null;
        string SMSMessage = "";

        public Form1()
        {
            InitializeComponent();
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

        /*
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
        */

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
            string dir = Application.StartupPath;
            string serializationFile = Path.Combine(dir, "devices.bin");
            List<Device> temp_dev;

            if (!File.Exists(serializationFile))
                return null;

            //deserialize
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                temp_dev = (List<Device>)bformatter.Deserialize(stream);
            }
            return temp_dev;
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
                deviceList.Items.Add(d.User);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            devices = loadDevices();
            if (devices == null)
            {
                devices = importDevice();
                if (devices != null)
                    saveDevices(devices);
            }
            if(devices != null)
            {
                refreshDevice();
            }
            try
            {
                modem = new GM862GPS("COM5");
                log("Modem active on COM5");

                command = new TrackerCommand(modem);
                log("Command ready");

                modem.InitializeBasicGSM();
                log("GSM Initialized success");

                modem.InitializeSMS();
                modem.OnRecievedSMS += ReceivedSMS;
                log("SMS Initialized success");
            }
            catch
            {
                modem = null;
                command = null;
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

        void ReceivedSMS(String Storage, int Number)
        {
                GM862GPS.SMSMessage sms = modem.ReadMessage(Storage, Number);
                string strSMS = sms.Message;
                
                if (strSMS.IndexOf("00") > -1)
                    strSMS = convertHEXtoString(strSMS);

                Console.WriteLine(strSMS);

                SMSMessage += strSMS;
                
                if(strSMS.IndexOf("GPRS:") > -1)        //If parameters command has sent
                {
                    checkForCommand(SMSMessage);
                    log("Parse new string: " + SMSMessage);
                    Console.WriteLine(SMSMessage);
                    SMSMessage = "";
                }
        }

        private void checkForCommand(String smsMessage)
        {
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
                device.LastComunicationTime = DateTime.Now.ToString();
                saveDevices(devices);
            }
        }


        private void deviceList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = deviceList.SelectedIndex;
            if(index > -1)
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
                if (currentDevice.LastComunicationTime != "")
                    txtLastComunication.Text = "Last Comunication: ND";
                else
                    txtLastComunication.Text = "Last Comunication: " + currentDevice.LastComunicationTime;
            }
            else
            {
                currentDevice = null;
            }
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
                command.getPosition(currentDevice);
            }
        }

        private void BtnGetParameters_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                command.getParameters(currentDevice);
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
                modem = null;
            if (command != null)
                command = null;
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
    }
}
