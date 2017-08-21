using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerWatchServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //if(!File.Exists(Application.StartupPath + "\\server.txt"))
            if (!AppController.SharedInstance.isServer)
            {
                AppController.SharedInstance.setInstanceType(false);
                Application.Run(new frmAlarm());
            }
                
            else
            {
                AppController.SharedInstance.setInstanceType(true);
                Application.Run(new Form1());
            }
                
        }
    }
}
