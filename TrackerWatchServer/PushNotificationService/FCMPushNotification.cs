using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace TrackerWatchServer
{
    public class FCMPushNotification
    {
        const string FCM_API_SERVER_KEY = "AAAA7pgyYws:APA91bHeztLDHB_zGMJIYZ7zqIl_hQU85E4JqOom2OH1BAH1TKBjJ8PYEkxnipC-081BDf7kRY6Xiq1yhWX_PWRh7cA5hYnBzvUS2Q5W4y1WuOeCMAxvz_uvh9USYt7VQX_SCdTnnAZb";
        const string FCM_SENDER_ID = "1024755655435 ";

        public FCMPushNotification()
        {
           
        }

         public string SendNotification(string _title, string _message, string _topic, string deviceUID = "")
        {
            var result = "-1";
            var webAddr = "https://fcm.googleapis.com/fcm/send";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Authorization:key=" + FCM_API_SERVER_KEY);
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "";
                if (deviceUID == "")
                    json = "{\"to\": \"/topics/news\",\"data\": {\"message\": \""+ _message +"\",}}";
                else
                    json = "{\"to\": \""+ deviceUID+ "\",\"data\": {\"message\": \"" + _message + "\",}}";

                streamWriter.Write(json);
                streamWriter.Flush();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }
    }
}
