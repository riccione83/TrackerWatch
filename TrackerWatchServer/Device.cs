using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerWatchServer
{
    [Serializable]
    public class Device
    {
        private String telephoneNumber = "";
        private String iMEI = "";
        private String deviceID = "";
        private String note = "";
        private String user = "";
        private String version = "";
        private String ip = "";
        private String port = "";
        private String center = "";
        private String slave = "";
        private String sos1 = "";
        private String sos2 = "";
        private String sos3 = "";
        private String profile = "";
        private String upload_time = "";
        private String battery_level = "";
        private String language = "";
        private String time_zone = "";
        private String gps = "";
        private String gprs = "";
        private String lastComunicationTime = "";

        public string TelephoneNumber
        {
            get
            {
                return telephoneNumber;
            }

            set
            {
                telephoneNumber = value;
            }
        }

        public string IMEI
        {
            get
            {
                return iMEI;
            }

            set
            {
                iMEI = value;
            }
        }

        public string DeviceID
        {
            get
            {
                return deviceID;
            }

            set
            {
                deviceID = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public string Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

        public string Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        public string Slave
        {
            get
            {
                return slave;
            }

            set
            {
                slave = value;
            }
        }

        public string Sos1
        {
            get
            {
                return sos1;
            }

            set
            {
                sos1 = value;
            }
        }

        public string Sos3
        {
            get
            {
                return sos3;
            }

            set
            {
                sos3 = value;
            }
        }

        public string Upload_time
        {
            get
            {
                return upload_time;
            }

            set
            {
                upload_time = value;
            }
        }

        public string Language
        {
            get
            {
                return language;
            }

            set
            {
                language = value;
            }
        }

        public string Time_zone
        {
            get
            {
                return time_zone;
            }

            set
            {
                time_zone = value;
            }
        }

        public string Gps
        {
            get
            {
                return gps;
            }

            set
            {
                gps = value;
            }
        }

        public string Gprs
        {
            get
            {
                return gprs;
            }

            set
            {
                gprs = value;
            }
        }

        public string Sos2
        {
            get
            {
                return sos2;
            }

            set
            {
                sos2 = value;
            }
        }

        public string Profile
        {
            get
            {
                return profile;
            }

            set
            {
                profile = value;
            }
        }

        public string Battery_level
        {
            get
            {
                return battery_level;
            }

            set
            {
                battery_level = value;
            }
        }

        public string LastComunicationTime
        {
            get
            {
                return lastComunicationTime;
            }

            set
            {
                lastComunicationTime = value;
            }
        }

        public Device()
        {

        }

        public Device(String telephoneNumber, String IMEI, String DeviceID, String Note, String User)
        {

            this.telephoneNumber = telephoneNumber;
            this.IMEI = IMEI;
            this.DeviceID = DeviceID;
            this.Note = Note;
            this.User = User;

        }
    }
}
