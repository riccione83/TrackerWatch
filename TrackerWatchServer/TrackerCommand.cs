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

        const string cmdSetCenterNumber = "pw,123456, center,13640897062#";
        const string cmdSetAssistantCenterNumber = "pw,123456,slave,13579276134#";
        const string cmdSetPassword = "set password:pw,123456#";
        const string cmdSetThreeSOSNumbers = "pw,123456,sos,667061,666135,664215#";
        const string cmdSetSOSNumber1 = "pw,123456,sos1,xxxx#";
        const string cmdSetSOSNumber2 = "pw,123456,sos2,xxxx#";
        const string cmdSetSOSNumber3 = "pw,123456,sos3,xxxx#";
        const string cmdSeleteSOSNumber = "pw,123456,sosx#&sosx,d#";
        const string cmdSetMonitor = "pw,123456,monitor,xxxx#";
        const string cmdSetUploadTime = "pw,123456,upload,300#";
        const string cmdGetPosition = "pw,123456,url#";
        const string cmdGetParameters = "pw,123456,ts#\r\n";
        const string cmdGetVersion = "pw,123456,verno#";
        const string cmdResetDevice = "pw,123456,reset#";
        const string cmdRestoreFactorySettings = "pw,123456,factory#";
        const string cmdSetIpAndPort = "pw,123456,ip,x.x.x.x,y#";
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

        public void getParameters(Device device)
        {
            String command = cmdGetParameters;
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void getPosition(Device device)
        {
            String command = cmdGetPosition;
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setIMEINumber(String imei, Device device)
        {
            String command = cmdSetIMEI.Replace("xxxx", imei);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setMonitorNumber(String monitorNumber, Device device)
        {
            String command = cmdSetMonitor.Replace("xxxx", monitorNumber);
            modem.SendSMSMessage(device.TelephoneNumber, command);
        }

        public void setAPN(String apnString, Device device)
        {
            String command = cmdSetAPN.Replace("xxxx", apnString);
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

        public TrackerCommand(GM862GPS device)
        {
            this.modem = device;
        }

    }
}