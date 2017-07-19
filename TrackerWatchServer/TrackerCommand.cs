using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElzeKool.Devices;

namespace TrackerWatchServer
{
    class TrackerCommand
    {
        GM862GPS modem = null;

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

        public void syncDateTime(Device device)
        {
            DateTime now = new DateTime();
            String command = "";
        }

        public void setCenterNumber(String centerNumber, Device device)
        {
            String command = cmdSetCenterNumber.Replace("xxxx", centerNumber);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setAssistantCenterNumber(String assistantCenterNumber, Device device)
        {
            String command = cmdSetAssistantCenterNumber.Replace("xxxx", assistantCenterNumber);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setThreeSOSNumbers(String SOSNumber1, String SOSNumber2, String SOSNumber3, Device device)
        {
            String command = cmdSetThreeSOSNumbers.Replace("xxxx", SOSNumber1).Replace("yyyy", SOSNumber2).Replace("zzzz", SOSNumber3);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setSOSNumber_1(String SOSNumber, Device device)
        {
            String command = cmdSetSOSNumber1.Replace("xxxx", SOSNumber);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setSOSNumber_2(String SOSNumber, Device device)
        {
            String command = cmdSetSOSNumber2.Replace("xxxx", SOSNumber);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setSOSNumber_3(String SOSNumber, Device device)
        {
            String command = cmdSetSOSNumber3.Replace("xxxx", SOSNumber);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void deleteteSOSNumber(String numberSOSNumber, Device device)
        {
            String command = cmdDeleteSOSNumber.Replace("x", numberSOSNumber);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setMonitorNumber(String monitorNumber, Device device)
        {
            String command = cmdSetMonitor.Replace("xxxx", monitorNumber);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setUploadTimeInterval(String uploadTimeInterval, Device device)
        {
            String command = cmdSetUploadTimeInterval.Replace("x", uploadTimeInterval);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void getPosition(Device device)
        {
            String command = cmdGetPosition;
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void getParameters(Device device)
        {
            String command = cmdGetParameters;
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void getVersion(Device device)
        {
            String command = cmdGetVersion;
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void resetDevice(Device device)
        {
            String command = cmdResetDevice;
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void restoreFactorySettings(Device device)
        {
            String command = cmdRestoreFactorySettings;
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setLanguageAndTimezone(String language, String timezone, Device device)
        {
            String command = cmdSetLanguageAndTimezone.Replace("x", language).Replace("y", timezone);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setIPandPort(String IP, String port, Device device)
        {
            String command = cmdSetIpAndPort.Replace("x", IP).Replace("y", port);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setIMEINumber(String imei, Device device)
        {
            String command = cmdSetIMEI.Replace("xxxx", imei);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setAPN(String apnString, Device device)
        {
            String command = cmdSetAPN.Replace("xxxx", apnString);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public TrackerCommand(GM862GPS device)
        {
            this.modem = device;
        }

    }
}