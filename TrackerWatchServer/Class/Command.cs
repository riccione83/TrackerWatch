using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerWatchServer
{
    public class Command
    {
        private String id = "";
        private String commandText = "";
        private String deviceID = "";

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

        public string CommandText
        {
            get
            {
                return commandText;
            }

            set
            {
                commandText = value;
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
    }
}
