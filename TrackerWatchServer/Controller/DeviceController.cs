using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerWatchServer
{
    class DeviceController
    {
        public List<Device> devices = new List<Device>();
        public bool devicesLoaded = false;

        private const string cmdGetDeviceByID = "SELECT devices.* FROM devices WHERE devices.ID = '{0}'";
        private const string cmdGetDevicesByUserID = "SELECT devices.* FROM devices WHERE devices.UserID = '{0}'";
        private const string cmdGetDevices = "SELECT devices.* FROM devices";
        private const string cmdUpdateDevice = @"UPDATE devices SET
        devices.IMEI = '{0}', devices.Version = '{1}', 
        devices.IP = '{2}', devices.PORT = '{3}', 
        devices.CenterNumber = '{4}', devices.SlaveNumber = '{5}',
        devices.SOS1 = '{6}', devices.SOS2 = '{7}', devices.SOS3 = '{8}',
        devices.UploadTime = '{9}', devices.BatteryLevel = '{10}', 
        devices.Language = '{11}', devices.TimeZone = '{12}', 
        devices.GPS = '{13}', devices.GPRS = '{14}',
        devices.LastPositionLatitude = '{15}', devices.LastPositionLongitude = '{16}' WHERE id = {17}";

        private const string cmdInsertDevice = @"INSERT INTO devices (devices.IMEI, devices.Version ,
        devices.IP, devices.PORT,
        devices.CenterNumber, devices.SlaveNumber',
        devices.SOS1, devices.SOS2, devices.SOS3',
        devices.UploadTime', devices.BatteryLevel,
        devices.Language, devices.TimeZone,
        devices.GPS, devices.GPRS',
        devices.LastPositionLatitud, devices.LastPositionLongitude VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')";

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

        public bool updateDevice(Device device)
        {
            string cmd = cmdUpdateDevice.Replace("{0}", device.IMEI);
            cmd = cmd.Replace("{1}", device.Version);
            cmd = cmd.Replace("{2}", device.Ip);
            cmd = cmd.Replace("{3}", device.Port);
            cmd = cmd.Replace("{4}", device.Center);
            cmd = cmd.Replace("{5}", device.Slave);
            cmd = cmd.Replace("{6}", device.Sos1);
            cmd = cmd.Replace("{7}", device.Sos2);
            cmd = cmd.Replace("{8}", device.Sos3);
            cmd = cmd.Replace("{9}", device.Upload_time);
            cmd = cmd.Replace("{10}", device.Battery_level);
            cmd = cmd.Replace("{11}", device.Language);
            cmd = cmd.Replace("{12}", device.Time_zone);
            cmd = cmd.Replace("{13}", device.Gps);
            cmd = cmd.Replace("{14}", device.Gprs);
            cmd = cmd.Replace("{15}", device.LastPositionLatitude);
            cmd = cmd.Replace("{16}", device.LastPositionLongitude);
            cmd = cmd.Replace("{17}", device.DeviceID);

            devicesLoaded = false;

            int cn1 = Database.SharedInstance.Update(cmd);
            //int cn2 = Database.SharedInstance.Update(cmd2);
            return (cn1 == 1) ? true : false;
        }

        public List<Device> getDevices()
        {
            List<Device> devices = new List<Device>();

            String cmd = cmdGetDevices;

            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmd);

            foreach (Dictionary<String, Object> device in returnedData)
            {
                Device _device = new Device();
                _device.DeviceID = device["ID"].ToString();
                _device.User = device["UserID"].ToString();
                _device.TelephoneNumber = device["TelephoneNumber"].ToString();
                _device.IMEI = device["IMEI"].ToString();
                _device.Note = device["Note"].ToString();
                _device.Version = device["Version"].ToString();
                _device.Ip = device["IP"].ToString();
                _device.Port = device["Port"].ToString();
                _device.Center = device["CenterNumber"].ToString();
                _device.Slave = device["SlaveNumber"].ToString();
                _device.Sos1 = device["SOS1"].ToString();
                _device.Sos2 = device["SOS2"].ToString();
                _device.Sos3 = device["SOS3"].ToString();
                _device.Version = device["Version"].ToString();
                _device.Upload_time = device["UploadTime"].ToString();
                _device.Battery_level = device["BatteryLevel"].ToString();
                _device.Language = device["Language"].ToString();
                _device.Time_zone = device["TimeZone"].ToString();
                _device.Gps = device["GPS"].ToString();
                _device.Gprs = device["GPRS"].ToString();
                _device.LastComunicationTime = device["LastComunicationTime"].ToString();
                _device.LastPositionLatitude = device["LastPositionLatitude"].ToString();
                _device.LastPositionLongitude = device["LastPositionLongitude"].ToString();

                devices.Add(_device);
            }

            devicesLoaded = true;
            this.devices = devices;

            return devices;
        }

        public List<Device> getDevicesByUserID(String userID)
        {
            List<Device> devices = new List<Device>();

            String cmd = cmdGetDevicesByUserID.Replace("{0}", userID); ;

            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmd);

            foreach (Dictionary<String, Object> device in returnedData)
            {
                Device _device = new Device();
                _device.DeviceID = device["ID"].ToString();
                _device.User = device["UserID"].ToString();
                _device.TelephoneNumber = device["TelephoneNumber"].ToString();
                _device.IMEI = device["IMEI"].ToString();
                _device.Note = device["Note"].ToString();
                _device.Version = device["Version"].ToString();
                _device.Ip = device["IP"].ToString();
                _device.Port = device["Port"].ToString();
                _device.Center = device["CenterNumber"].ToString();
                _device.Slave = device["SlaveNumber"].ToString();
                _device.Sos1 = device["SOS1"].ToString();
                _device.Sos2 = device["SOS2"].ToString();
                _device.Sos3 = device["SOS3"].ToString();
                _device.Version = device["Version"].ToString();
                _device.Upload_time = device["UploadTime"].ToString();
                _device.Battery_level = device["BatteryLevel"].ToString();
                _device.Language = device["Language"].ToString();
                _device.Time_zone = device["TimeZone"].ToString();
                _device.Gps = device["GPS"].ToString();
                _device.Gprs = device["GPRS"].ToString();
                _device.LastComunicationTime = device["LastComunicationTime"].ToString();
                _device.LastPositionLatitude = device["LastPositionLatitude"].ToString();
                _device.LastPositionLongitude = device["LastPositionLongitude"].ToString();

                devices.Add(_device);
            }

            return devices;
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

        public List<Device> search(string text)
        {
            List<Device> prova = this.devices.FindAll(p => p.TelephoneNumber.ToLower().Contains(text.ToLower()) || p.Note.ToLower().Contains(text.ToLower()));

            return prova;
        }
    }
}
