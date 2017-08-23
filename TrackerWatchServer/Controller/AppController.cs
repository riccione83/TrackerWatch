using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerWatchServer
{
    class AppController
    {
        public bool isServer;
        public string COM_PORT;
        public string TCP_PORT;
        public string SQL_SERVER_IP;
        public string DATABASE;
        public string DB_USER;
        public string DB_PASSWORD;

        private static AppController sharedInstance;
        private AppController()
        {
            loadOptions();
        }

        public bool loadOptions()
        {
            if (File.Exists(Application.StartupPath + "\\options.txt"))
            {
                using (StreamReader rd = new StreamReader(Application.StartupPath + "\\options.txt"))
                {
                    while (!rd.EndOfStream)
                    {
                        string[] par = rd.ReadLine().Replace(" ", "").Split('=');
                        switch (par[0])
                        {
                            case "COM_PORT":
                                COM_PORT = par[1];
                                break;
                            case "TCP_PORT":
                                TCP_PORT = par[1];
                                break;
                            case "SQL_SERVER_IP":
                                SQL_SERVER_IP = par[1];
                                break;
                            case "DATABASE":
                                DATABASE = par[1];
                                break;
                            case "DB_USER":
                                DB_USER = par[1];
                                break;
                            case "DB_PASSWORD":
                                DB_PASSWORD = par[1];
                                break;
                            case "IS_SERVER":
                                isServer = Boolean.Parse(par[1]);
                                break;
                            default:
                                break;
                        }
                    }
                }
                return true;
            }
            return false;
        }

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
