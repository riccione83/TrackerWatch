﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
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

        public string SERVER_IP;
        public string SERVER_PORT;

        private static AppController sharedInstance;

        private AppController()
        {
            loadOptions();
        }


        public void connectToServer()
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(SERVER_IP, int.Parse(SERVER_PORT));
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
                            case "SERVER_IP":
                                SERVER_IP = par[1];
                                break;
                            case "SERVER_PORT":
                                SERVER_PORT = par[1];
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
    }
}
