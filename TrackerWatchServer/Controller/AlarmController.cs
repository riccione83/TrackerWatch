using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrackerWatchServer
{
    interface alarmDelegate
    {
        void newEvent(Alarm evento);
    }

    class AlarmController
    {
        private const string cmdDeleteAlarm = "DELETE FROM alarm WHERE alarm.ID={0}";                                  
        private const string cmdUpdateAlarm = "UPDATE alarm SET alarm..ManagedByID = '{0}', alarm.Note = '{1}' WHERE ID = {2}";
        private const string cmdInsertNewAlarm = "INSERT INTO alarm (alarm.DeviceID, alarm.Type, alarm.ArrivalTimeDate, alarm.ManagedByID, alarm.Note) VALUES('{0}','{1}','{2}','{3}','{4}')";
        private const string cmdGetAlarm = "SELECT * FROM alarm WHERE Closed = 0";                        


        private static AlarmController sharedInstance;
        private AlarmController() { }
        public frmAlarm mainAlarmForm;

        public List<Alarm> loadAlarm()
        {
            List<Alarm> alarms = new List<Alarm>();

            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmdGetAlarm);

            foreach (Dictionary<String, Object> alarm in returnedData)
            {
                Alarm _alarm = new Alarm();
                _alarm.Id = alarm["ID"].ToString();
                _alarm.Device = DeviceController.SharedInstance.getDeviceById(alarm["DeviceID"].ToString());
                _alarm.User = UserController.SharedInstance.getUserByDeviceId(_alarm.Device.DeviceID);
                switch(alarm["Type"].ToString())
                {
                    case "High":
                        _alarm.AlarmType = AlarmTypeCode.High;
                        break;
                    case "Medium":
                        _alarm.AlarmType = AlarmTypeCode.Medium;
                        break;
                    case "Low":
                        _alarm.AlarmType = AlarmTypeCode.Low;
                        break;
                    default:
                        _alarm.AlarmType = AlarmTypeCode.Message;
                        break;
                }
                _alarm.ArrivalTime = alarm["ArrivalTimeDate"].ToString();
                _alarm.Managed = alarm["ManagedByID"].ToString();
                _alarm.Note = alarm["Note"].ToString();
                _alarm.LastModifiedTime = alarm["LastModifiedTime"].ToString();
                alarms.Add(_alarm);
            }
            return alarms;
        }

        private bool saveNewAlarm(Alarm alarm)
        {
            String cmd = cmdInsertNewAlarm.Replace("{0}", alarm.Device.DeviceID);
            cmd = cmd.Replace("{1}", alarm.AlarmType.ToString());
            cmd = cmd.Replace("{2}", alarm.ArrivalTime);
            cmd = cmd.Replace("{3}", alarm.Managed);
            cmd = cmd.Replace("{4}", alarm.Note);

            int cnt = Database.SharedInstance.Insert(cmd);

            return cnt == 1 ? true : false;
        }

        private bool deleteAlarmByID(string ID)
        {
            String cmd = cmdDeleteAlarm.Replace("{0}", ID);
            int cnt = Database.SharedInstance.Delete(cmd);

            //Check if user has deleted or not
            return cnt == 1 ? true : false;
        }

        /*
         * Questa funzione prende come parametro in id dispositivo,
         * cerca l'utente associato e crea un nuovo allarme.
         * Poi lo invia al form principale con il 'pushNewEvent'
         * 
         */
        public Alarm buildAlarm(String deviceID, String Alarm)
        {
            User user = UserController.SharedInstance.getUserByDeviceId(deviceID);
            Device device = DeviceController.SharedInstance.getDeviceById(deviceID);
            Alarm alarm = new Alarm();

            alarm.Device = device;
            alarm.User = user;
            alarm.EventText = Alarm;
            alarm.Managed = "No";
            alarm.ArrivalTime = DateTime.Now.ToString();
            alarm.AlarmType = AlarmTypeCode.High;

            pushNewEvent(alarm);
            return alarm;
        }

        public void pushNewEvent(Alarm evento)
        {
            if(mainAlarmForm != null)
            {
                mainAlarmForm.newEvent(evento);
                saveNewAlarm(evento);
            }
        }

        public static AlarmController SharedInstance
        {
            get
            {
                if (sharedInstance == null)
                {
                    sharedInstance = new AlarmController();
                }
                return sharedInstance;
            }
        }


    }
}
