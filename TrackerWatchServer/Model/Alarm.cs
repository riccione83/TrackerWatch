using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerWatchServer
{
    public enum AlarmTypeCode
    {
        High = 0,
        Medium = 1,
        Low = 2,
        Message = 3
    }

    public class Alarm
    {
        public Color[] alarmColor = {Color.Red, Color.Yellow, Color.Green, Color.White };

        private String arrivalTime = "";
        private String id = "";
        private Device device;
        private User user;
        private String managed = "";
        private String eventText = "";
        private AlarmTypeCode alarmType;
        private String note = "";
        private String lastModifiedTime = "";

        public AlarmTypeCode AlarmType
        {
            get
            {
                return alarmType;
            }

            set
            {
                alarmType = value;
            }
        }

        public string ArrivalTime
        {
            get
            {
                return arrivalTime;
            }

            set
            {
                arrivalTime = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Device Device
        {
            get
            {
                return device;
            }

            set
            {
                device = value;
            }
        }

        public string Managed
        {
            get
            {
                return managed;
            }

            set
            {
                managed = value;
            }
        }

        public string EventText
        {
            get
            {
                return eventText;
            }

            set
            {
                eventText = value;
            }
        }

        public User User
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

        public string LastModifiedTime
        {
            get
            {
                return lastModifiedTime;
            }

            set
            {
                lastModifiedTime = value;
            }
        }
    }
}
