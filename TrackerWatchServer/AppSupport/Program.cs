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
            
            if(!File.Exists(Application.StartupPath + "\\server.txt"))
                Application.Run(new frmAlarm()); 
            else
                Application.Run(new Form1());
        }
    }
}
