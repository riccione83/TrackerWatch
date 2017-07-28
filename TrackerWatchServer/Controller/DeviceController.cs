using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerWatchServer
{
    class DeviceController
    {
        private const string cmdGetDeviceByID = "SELECT devices.* FROM devices WHERE devices.ID = '{0}'";


        private static DeviceController sharedInstance;
        private DeviceController() { }

        public static DeviceController SharedInstance
        {
            get
            {
                if (sharedInstance == null)
                {
                    sharedInstance = new DeviceController();
                }
                return sharedInstance;
            }
        }

        public Device getDeviceById(String deviceID)
        {
            String cmd = cmdGetDeviceByID.Replace("{0}", deviceID);
            Device _device = null;
            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmd);
            if (returnedData.Count > 0)
            {
                Dictionary<String, Object> user = returnedData[0];
                _device = new Device();
                _device.DeviceID = user["ID"].ToString();
                _device.User = user["UserID"].ToString();
                _device.TelephoneNumber = user["TelephoneNumber"].ToString();
                _device.IMEI = user["IMEI"].ToString();
                _device.Note = user["Note"].ToString();
                _device.Version = user["Version"].ToString();
                _device.Ip = user["IP"].ToString();
                _device.Port = user["Port"].ToString();
                _device.Center = user["CenterNumber"].ToString();
                _device.Slave = user["SlaveNumber"].ToString();
                _device.Sos1 = user["SOS1"].ToString();
                _device.Sos2 = user["SOS2"].ToString();
                _device.Sos3 = user["SOS3"].ToString();
                _device.Version = user["Version"].ToString();
                _device.Upload_time = user["UploadTime"].ToString();
                _device.Battery_level = user["BatteryLevel"].ToString();
                _device.Language = user["Language"].ToString();
                _device.Time_zone = user["TimeZone"].ToString();
                _device.Gps = user["GPS"].ToString();
                _device.Gprs = user["GPRS"].ToString();
                _device.LastComunicationTime = user["LastComunicationTime"].ToString();
                _device.LastPositionLatitude = user["LastPositionLatitude"].ToString();
                _device.LastPositionLongitude = user["LastPositionLongitude"].ToString();

            }
            return _device;
        }
    }
}
