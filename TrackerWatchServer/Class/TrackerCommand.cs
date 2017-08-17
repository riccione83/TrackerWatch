using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElzeKool.Devices;
using System.Net.Sockets;
using System.IO;

namespace TrackerWatchServer
{
    class TrackerCommand
    {
        bool isServer = true;

        GM862GPS modem = null;
        public bool useGPRS = true;
        public Form1 mainForm = null;

        const string cmdSetCenterNumber = "pw,123456, center,xxxx#";
        const string cmdSetAssistantCenterNumber = "pw,123456,slave,xxxx#";
        const string cmdSetPassword = "set password:pw,123456#";
        const string cmdSetThreeSOSNumbers = "pw,123456,sos,xxxx,yyyy,zzzz#";
        const string cmdSetSOSNumber1 = "pw,123456,sos1,xxxx#";
        const string cmdSetSOSNumber2 = "pw,123456,sos2,xxxx#";
        const string cmdSetSOSNumber3 = "pw,123456,sos3,xxxx#";
        const string cmdDeleteSOSNumber = "pw,123456,sosx#&sosx,d#";
        const string cmdSetMonitor = "pw,123456,monitor,xxxx#";
        const string cmdSetUploadTimeInterval = "pw,123456,upload,xxxx#"; //300
        const string cmdGetPosition = "pw,123456,url#";
        const string cmdGetParameters = "pw,123456,ts#\r\n";
        const string cmdGetVersion = "pw,123456,verno#";
        const string cmdResetDevice = "pw,123456,reset#";
        const string cmdRestoreFactorySettings = "pw,123456,factory#";
        const string cmdSetIpAndPort = "pw,123456,ip,xxxx,y#";
        const string cmdSetLanguageAndTimezone = "pw,123456,lz,1,8#";
        const string cmdSetIMEI = "pw,123456,imei,xxxx#";
        const string cmdSetAPN = "pw,123456,apn,xxxx,,,22288#";
        const string cmdGetIMSI = "pw,123456,imsi#";
        const string cmdSetDate = "pw,123456,time,hour.min.sec,date,year.month.day#";

        /*
         * Per i comandi gprs fare un replace per:
         * YYYYYYYYYY -> Device ID
         * XXXXXXXXXX -> Command lenght
         * ZZZZZZZZZZ -> Value command
         * */
        const string gprsCmdKeepLink = "[SG*YYYYYYYYYY*0002*LK]";                                        //[CS*YYYYYYYYYY*LEN*LK]
        const string gprsCmdTKQResponse = "[CS*YYYYYYYYYY*LEN*TKQ]";
        const string gprsCmdTKQ2Response = "[CS*YYYYYYYYYY*LEN*TKQ2]";
        const string gprsCmdConfirmAlarm = "[CS*YYYYYYYYYY*LEN*AL]";                                //[CS*YYYYYYYYYY*LEN*AL]
        const string gprsCmdUploadInterval = "[SG*YYYYYYYYYY*XXXXXXXXXX*UPLOAD,ZZZZZZZZZZ]";                      //[CS*YYYYYYYYYY*LEN*UPLOAD,interval]
        const string gprsCmdCenterNumber = "[SG*YYYYYYYYYY*0012*CENTER,ZZZZZZZZZZ]";               //[CS*YYYYYYYYYY*LEN*CENTER,center number]
        const string gprsCmdSetPassword = "[SG*YYYYYYYYYY*0009*PW,111111]";                         //[CS*YYYYYYYYYY*LEN*PW,password]
        const string gprsCmdDialNumber = "[SG*YYYYYYYYYY*0010*CALL,00000000000]";                   //[CS*YYYYYYYYYY*LEN*CALL,phone number]
        const string gprsCmdDialMonitorNumber = "[SG*YYYYYYYYYY*XXXXXXXXXX*MONITOR,ZZZZZZZZZZ]";         //[CS*YYYYYYYYYY*LEN*MONITOR,00000000000]
        const string gprsCmdSetSOS1 = "[SG*YYYYYYYYYY*XXXXXXXXXX*SOS1,ZZZZZZZZZZ]";                      //[CS*YYYYYYYYYY*LEN*SOS1,phone number]
        const string gprsCmdSetSOS2 = "[SG*YYYYYYYYYY*XXXXXXXXXX*SOS2,ZZZZZZZZZZ]";                      //[CS*YYYYYYYYYY*LEN*SOS1,phone number]
        const string gprsCmdSetSOS3 = "[SG*YYYYYYYYYY*XXXXXXXXXX*SOS3,ZZZZZZZZZZ]";                      //[CS*YYYYYYYYYY*LEN*SOS1,phone number]
        const string gprsCmdSetThreeSOS = "[SG*YYYYYYYYYY*XXXXXXXXXX*SOS,Z1Z1Z1Z1Z1,Z2Z2Z2Z2Z2,Z3Z3Z3Z3Z3]";
        const string gprsCmdPortAndIP = "[SG*YYYYYYYYYY*XXXXXXXXXX*IP,Z1Z1Z1Z1Z1,Z2Z2Z2Z2Z2]";                //[CS*YYYYYYYYYY*LEN*IP,IP or URL,port]
        const string gprsCmdFactoryDefault = "[SG*YYYYYYYYYY*0007*FACTORY]";                        //[CS*YYYYYYYYYY*LEN*FACTORY]
        const string gprsCmdSetLanguageAndTimezone = "[SG*YYYYYYYYYY*XXXXXXXXXX*LZ,Z1Z1Z1Z1Z1,Z2Z2Z2Z2Z2]";                 //[CS*YYYYYYYYYY*LEN*LZ,language,time zone]
        const string gprsCmdSOSSwitchSet = "[SG*YYYYYYYYYY*0008*SOSSMS,0]";                         //[CS*YYYYYYYYYY*LEN*SOSSMS,0 OR 1] - Note: send sms to sos numbers or not when there is sos alarming(0:OFF, 1:ON).
        const string gprsCmdLowBatteryAlarmSwitch = "[SG*YYYYYYYYYY*0008*LOWBAT,1]";                //[CS*YYYYYYYYYY*LEN*LOWBAT,0 or 1]
        const string gprsCmdGetVersionNumber = "[SG*YYYYYYYYYY*0005*VERNO]";                        //[CS*YYYYYYYYYY*LEN*VERNO]
        const string gprsCmdRestart = "[SG*YYYYYYYYYY*0005*RESET]";                                 //[CS*YYYYYYYYYY*LEN*RESET]
        const string gprsCmdGetPosition = "[SG*YYYYYYYYYY*0002*CR]";                                //[CS*YYYYYYYYYY*LEN*CR] - Note: Track for 3 minutes
        const string gprsCmdPowerOff = "[SG*YYYYYYYYYY*0008*POWEROFF]";                       //[CS*YYYYYYYYYY*LEN*POWEROFF]
        const string gprsCmdTakeOffSwitch = "[SG*YYYYYYYYYY*0008*REMOVE,1]";                        //1 on 0 off
        const string gprsCmdSetPedometerSwitch = "[SG*YYYYYYYYYY*0004*PEDO,0]";                     //1 on 0 off
        const string gprsCmdFindMyWatch = "[SG*YYYYYYYYYY*0004*FIND]";                              //The watch ring for 1 minute

        public void sendGPRSCommand(NetworkStream stream, String command)
        {
            StreamWriter wr = new StreamWriter(stream);
            wr.Write(command);
            wr.Flush();
            Console.WriteLine("Sent GPRS command: " + command);
        }

        public void syncDateTime(Device device)
        {
            DateTime now = new DateTime();
            String command = "";
        }
                
        public void sendTKQ_ACK(String deviceID)
        {
            NetworkStream deviceStream = mainForm.Connessioni[deviceID];
            String command = gprsCmdTKQResponse.Replace("YYYYYYYYYY", deviceID);
            sendGPRSCommand(deviceStream, command);
        }

        public void sendTKQ2_ACK(String deviceID)
        {
            NetworkStream deviceStream = mainForm.Connessioni[deviceID];
            String command = gprsCmdTKQ2Response.Replace("YYYYYYYYYY", deviceID);
            sendGPRSCommand(deviceStream, command);
        }

        public void sendACK(String deviceID)
        {
            NetworkStream deviceStream = mainForm.Connessioni[deviceID];
            String command = gprsCmdKeepLink.Replace("YYYYYYYYYY", deviceID);
            sendGPRSCommand(deviceStream, command);
        }

        public void setCenterNumber(String centerNumber, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetCenterNumber.Replace("xxxx", centerNumber);

                if (isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdCenterNumber.Replace("YYYYYYYYYY", device.DeviceID);
                    int msgLen = centerNumber.Length;
                    command = command.Replace("XXXXXXXXXX", msgLen.ToString("X4"));
                    command = command.Replace("ZZZZZZZZZZ", centerNumber);
                    sendGPRSCommand(deviceStream, command);
                }
            }
            
        }

        public void setAssistantCenterNumber(String assistantCenterNumber, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetAssistantCenterNumber.Replace("xxxx", assistantCenterNumber);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                mainForm.log("Unable to send SetAssistantNumber command via GPRS");
            }
        }

        public void setThreeSOSNumbers(String SOSNumber1, String SOSNumber2, String SOSNumber3, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetThreeSOSNumbers.Replace("xxxx", SOSNumber1).Replace("yyyy", SOSNumber2).Replace("zzzz", SOSNumber3);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdSetThreeSOS.Replace("YYYYYYYYYY", device.DeviceID);
                    int msgLen = SOSNumber1.Length + SOSNumber2.Length + SOSNumber3.Length;
                    command = command.Replace("XXXXXXXXXX", msgLen.ToString("X4"));
                    command = command.Replace("Z1Z1Z1Z1Z1", SOSNumber1);
                    command = command.Replace("Z2Z2Z2Z2Z2", SOSNumber2);
                    command = command.Replace("Z3Z3Z3Z3Z3", SOSNumber3);
                    sendGPRSCommand(deviceStream, command);
                }
                else
                {
                    mainForm.log("Impossibile inviare il comando, dipositivo [" + device.DeviceID + "] non connesso");
                }
            }

            
        }

        public void setSOSNumber_1(String SOSNumber, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetSOSNumber1.Replace("xxxx", SOSNumber);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdSetSOS1.Replace("YYYYYYYYYY", device.DeviceID);
                    command = command.Replace("XXXXXXXXXX", SOSNumber.Length.ToString("X4"));
                    command = command.Replace("ZZZZZZZZZZ", SOSNumber);
                    sendGPRSCommand(deviceStream, command);
                }
                else
                {
                    mainForm.log("Impossibile inviare il comando, dipositivo [" + device.DeviceID + "] non connesso");
                }
            }
        }

        public void setSOSNumber_2(String SOSNumber, Device device)
        {
            if (!useGPRS)
            { 
                String command = cmdSetSOSNumber2.Replace("xxxx", SOSNumber);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdSetSOS2.Replace("YYYYYYYYYY", device.DeviceID);
                    command = command.Replace("XXXXXXXXXX", SOSNumber.Length.ToString("X4"));
                    command = command.Replace("ZZZZZZZZZZ", SOSNumber);
                    sendGPRSCommand(deviceStream, command);
                }
                else
                {
                    mainForm.log("Impossibile inviare il comando, dipositivo [" + device.DeviceID + "] non connesso");
                }
            }

        }

        public void setSOSNumber_3(String SOSNumber, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetSOSNumber3.Replace("xxxx", SOSNumber);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdSetSOS3.Replace("YYYYYYYYYY", device.DeviceID);
                    command = command.Replace("XXXXXXXXXX", SOSNumber.Length.ToString("X4"));
                    command = command.Replace("ZZZZZZZZZZ", SOSNumber);
                    sendGPRSCommand(deviceStream, command);
                }
                else
                {
                    mainForm.log("Impossibile inviare il comando, dipositivo [" + device.DeviceID + "] non connesso");
                }
            }

        }

        public void deleteteSOSNumber(String numberSOSNumber, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdDeleteSOSNumber.Replace("x", numberSOSNumber);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                mainForm.log("Unable to send DeleteSOSNumber command via GPRS");
            }
        }

        public void setMonitorNumber(String monitorNumber, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetMonitor.Replace("xxxx", monitorNumber);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdDialMonitorNumber.Replace("YYYYYYYYYY", device.DeviceID);
                    command = command.Replace("XXXXXXXXXX", monitorNumber.Length.ToString("X4"));
                    command = command.Replace("ZZZZZZZZZZ", monitorNumber);
                    sendGPRSCommand(deviceStream, command);
                }
                else
                {
                    mainForm.log("Impossibile inviare il comando, dipositivo [" + device.DeviceID + "] non connesso");
                }
            }
            
        }

        public void setUploadTimeInterval(String uploadTimeInterval, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetUploadTimeInterval.Replace("xxxx", uploadTimeInterval);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdUploadInterval.Replace("YYYYYYYYYY", device.DeviceID);
                    command = command.Replace("XXXXXXXXXX", ("UPLOAD," + uploadTimeInterval).Length.ToString("X4"));
                    command = command.Replace("ZZZZZZZZZZ", uploadTimeInterval);
                    sendGPRSCommand(deviceStream, command);
                }
            }
        }

        public void getPosition(Device device)
        {
            if (!useGPRS)
            {
                String command = cmdGetPosition;
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdGetPosition.Replace("YYYYYYYYYY", device.DeviceID);
                    sendGPRSCommand(deviceStream, command);
                }
            }
        }

        public void getParameters(Device device)
        {
            if (!useGPRS)
            {
                String command = cmdGetParameters;
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                mainForm.log("Unable to send GetParameter command via GPRS");
            }
        }

        public void getVersion(Device device)
        {
            if (!useGPRS)
            {
                String command = cmdGetVersion;
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdGetVersionNumber.Replace("YYYYYYYYYY", device.DeviceID);
                    sendGPRSCommand(deviceStream, command);
                }
            }
        }

        public void resetDevice(Device device)
        {
            if (!useGPRS)
            {
                String command = cmdResetDevice;
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdRestart.Replace("YYYYYYYYYY", device.DeviceID);
                    sendGPRSCommand(deviceStream, command);
                }
            }
        }

        public void restoreFactorySettings(Device device)
        {
            if (!useGPRS)
            {
                String command = cmdRestoreFactorySettings;
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdFactoryDefault.Replace("YYYYYYYYYY", device.DeviceID);
                    sendGPRSCommand(deviceStream, command);
                }
            }
        }

        public void setLanguageAndTimezone(String language, String timezone, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetLanguageAndTimezone.Replace("x", language).Replace("y", timezone);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdSetLanguageAndTimezone.Replace("YYYYYYYYYY", device.DeviceID);
                    command = command.Replace("XXXXXXXXXX", ("LZ," + language + "," + timezone).Length.ToString("X4"));
                    command = command.Replace("Z1Z1Z1Z1Z1", language);
                    command = command.Replace("Z2Z2Z2Z2Z2", timezone);
                    sendGPRSCommand(deviceStream, command);
                }
            }
        }

        public void setIPandPort(String IP, String port, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetIpAndPort.Replace("x", IP).Replace("y", port);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                if (mainForm.Connessioni.ContainsKey(device.DeviceID))
                {
                    NetworkStream deviceStream = mainForm.Connessioni[device.DeviceID];
                    String command = gprsCmdPortAndIP.Replace("YYYYYYYYYY", device.DeviceID);
                    command = command.Replace("XXXXXXXXXX", ("IP," + IP + "," + port).Length.ToString("X4"));
                    command = command.Replace("Z1Z1Z1Z1Z1", IP);
                    command = command.Replace("Z2Z2Z2Z2Z2", port);
                    sendGPRSCommand(deviceStream, command);
                }
            }
        }

        public void setIMEINumber(String imei, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetIMEI.Replace("xxxx", imei);
                if(isServer)
                     modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                mainForm.log("Unable to send IMEI command via GPRS");
            }
        }

        public void setAPN(String apnString, Device device)
        {
            if (!useGPRS)
            {
                String command = cmdSetAPN.Replace("xxxx", apnString);
                if(isServer)
                    modem.SendSMSMessage(device.TelephoneNumber, command);
                else
                    CommandController.SharedInstance.newCommand(command, device.TelephoneNumber);
            }
            else
            {
                mainForm.log("Unable to send APN command via GPRS");
            }
        }

        public TrackerCommand(GM862GPS device)
        {
            this.modem = device;
            this.isServer = AppController.SharedInstance.isServer;
        }

    }
}