using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerWatchServer
{
    class CommandController
    {
        private const string cmdGetNextCommand = "SELECT * FROM commands ORDER BY Id LIMIT 1";                                                     //ok
        private const string cmdDeleteCommand = "DELETE FROM commands WHERE commands.id={0}";
        private const string cmdCheckForCommand = "SELECT Count(*) FROM commands";
        private const string cmdInsertCommand = "INSERT INTO commands (commands.command, commands.deviceID) VALUES('{0}','{1}')";

        private static CommandController sharedInstance;
        private CommandController() { }

        public static CommandController SharedInstance
        {
            get
            {
                if (sharedInstance == null)
                {
                    sharedInstance = new CommandController();
                }
                return sharedInstance;
            }
        }

        public bool newCommand(string command, string deviceID)
        {
            String cmd = cmdInsertCommand.Replace("{0}", command);
            cmd = cmd.Replace("{1}", deviceID);

            int cnt = Database.SharedInstance.Insert(cmd);

            AppController.SharedInstance.connectToServer();

            return cnt == 1 ? true : false;
        }

        public Command getLastCommand()
        {
            String cmd = cmdGetNextCommand;
            Command returnValue = null;
            List<Dictionary<String, Object>> commands = Database.SharedInstance.getData(cmd);
            if(commands.Count > 0)
            {
                Dictionary<String, Object> command = commands[0];
                returnValue = new Command();
                returnValue.Id = command["id"].ToString();
                returnValue.DeviceID = command["deviceID"].ToString();
                returnValue.CommandText = command["command"].ToString();

                //** Preso il comando lo cancelliamo dalla lista
                String cmdDelete = cmdDeleteCommand.Replace("{0}", returnValue.Id);
                Database.SharedInstance.Delete(cmdDelete);
            }
            return returnValue;
        }

        public bool commandAvailable()
        {
            String cmd = cmdCheckForCommand;
            int cnt = Database.SharedInstance.Count(cmd);

            //Check if user has deleted or not
            return cnt > 0 ? true : false;
        }
    }
}
