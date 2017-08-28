using System;
using System.Collections.Generic;
using System.Globalization;
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
        private const string cmdSetNoteForAlarm = "UPDATE alarm SET alarm.Note = '{0}' WHERE ID = {1}";
        private const string cmdInsertNewAlarm = "INSERT INTO alarm (alarm.DeviceID, alarm.Type, alarm.ManagedByID, alarm.Note, alarm.Latitude, alarm.Longitude, alarm.Event) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
        private const string cmdGetAlarm = "SELECT * FROM alarm WHERE Closed = 0";
        private const string cmgGetAllAlarm = "SELECT * FROM alarm WHERE alarm.DeviceID = {0} AND alarm.ArrivalTimeDate >= '{1}' AND alarm.ArrivalTimeDate <= '{2}'";
        public int ErrorCode = 0;

        private static AlarmController sharedInstance;
        private AlarmController() { }
        public frmAlarm mainAlarmForm;
        public List<Alarm> alarms;


        public List<Alarm> loadAlarm(DateTime from, DateTime to, Device device)
        {
            // just to shorten the code
            var isoDateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;
            // "1976-04-12T22:10:00"
            var startDateTime = from.ToString(isoDateTimeFormat.SortableDateTimePattern);
            var endDateTime = to.ToString(isoDateTimeFormat.SortableDateTimePattern);

            List<Alarm> alarms = new List<Alarm>();

            String cmd = cmgGetAllAlarm.Replace("{0}", device.DeviceID);
            cmd = cmd.Replace("{1}", startDateTime);
            cmd = cmd.Replace("{2}", endDateTime);

            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmd);
            ErrorCode = Database.SharedInstance.Error;
            foreach (Dictionary<String, Object> alarm in returnedData)
            {
                Alarm _alarm = new Alarm();
                _alarm.Id = alarm["ID"].ToString();
                _alarm.Device = DeviceController.SharedInstance.getDeviceById(alarm["DeviceID"].ToString());
                _alarm.User = UserController.SharedInstance.getUserByDeviceId(_alarm.Device.DeviceID);
                switch (alarm["Type"].ToString())
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
                _alarm.Latitude = alarm["Latitude"].ToString();
                _alarm.Longitude = alarm["Longitude"].ToString();
                _alarm.EventText = alarm["Event"].ToString();
                alarms.Add(_alarm);
            }

            return alarms;
        }

        public List<Alarm> loadAlarm()
        {
            List<Alarm> alarms = new List<Alarm>();

            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmdGetAlarm);
            ErrorCode = Database.SharedInstance.Error;

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
                _alarm.Latitude = alarm["Latitude"].ToString();
                _alarm.Longitude = alarm["Longitude"].ToString();
                _alarm.EventText = alarm["Event"].ToString();
                alarms.Add(_alarm);
            }
            this.alarms = alarms;
            return alarms;
        }

        private bool saveNewAlarm(Alarm alarm)
        {
            String cmd = cmdInsertNewAlarm.Replace("{0}", alarm.Device.DeviceID);
            cmd = cmd.Replace("{1}", alarm.AlarmType.ToString());
            cmd = cmd.Replace("{2}", alarm.Managed);
            cmd = cmd.Replace("{3}", alarm.Note);
            cmd = cmd.Replace("{4}", alarm.Latitude);
            cmd = cmd.Replace("{5}", alarm.Longitude);
            cmd = cmd.Replace("{6}", alarm.EventText);

            int cnt = Database.SharedInstance.Insert(cmd);
            ErrorCode = Database.SharedInstance.Error;
            return cnt == 1 ? true : false;
        }

        public bool updateNoteForAlarm(string note, Alarm alarm)
        {
            String cmd = cmdSetNoteForAlarm.Replace("{0}", note);
            cmd = cmd.Replace("{1}", alarm.Id);

            int cnt = Database.SharedInstance.Update(cmd);
            ErrorCode = Database.SharedInstance.Error;
            return cnt == 1 ? true : false;
        }

        private bool deleteAlarmByID(string ID)
        {
            String cmd = cmdDeleteAlarm.Replace("{0}", ID);
            int cnt = Database.SharedInstance.Delete(cmd);
            ErrorCode = Database.SharedInstance.Error;
            //Check if user has deleted or not
            return cnt == 1 ? true : false;
        }

        /*
         * Questa funzione prende come parametro in id dispositivo,
         * cerca l'utente associato e crea un nuovo allarme.
         * Poi lo invia al form principale con il 'pushNewEvent'
         * 
         */
        public Alarm buildAlarm(AlarmTypeCode alarmType, String deviceID, String Alarm, string Latitude="", string Longitude="")
        {
            User user = UserController.SharedInstance.getUserByDeviceId(deviceID);
            Device device = DeviceController.SharedInstance.getDeviceById(deviceID);
            Alarm alarm = new Alarm();

            alarm.Device = device;
            alarm.User = user;
            alarm.EventText = Alarm;
            alarm.Managed = "No";
            alarm.AlarmType = alarmType;
            alarm.Latitude = Latitude;
            alarm.Longitude = Longitude;
            pushNewEvent(alarm);
            return alarm;
        }

        public void pushNewEvent(Alarm evento)
        {
            saveNewAlarm(evento);
            if (mainAlarmForm != null)
            {
                mainAlarmForm.newEvent(evento);
               // FCMPushNotification pushNotificationService = new FCMPushNotification();
              //  pushNotificationService.SendNotification("SOS Reminder", "Warning a SOS was sent", "Un sms è stato inviato","1234567890123456");
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
