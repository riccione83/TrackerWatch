using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerWatchServer
{
    class AppController
    {
        public bool isServer;

        private static AppController sharedInstance;
        private AppController() { }

        public static AppController SharedInstance
        {
            get
            {
                if (sharedInstance == null)
                {
                    sharedInstance = new AppController();
                }
                return sharedInstance;
            }
        }

        public void setInstanceType(bool isServer)
        {
            this.isServer = isServer;
        }

    }
}
