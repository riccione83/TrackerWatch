using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerWatchServer
{
    class UserController
    {
        public List<User> users = new List<User>();
        public bool usersLoaded = false;

        private const string cmdGetAllUser = "SELECT * FROM users";                                                     //ok
        private const string cmdGetUser = "SELECT * from users WHERE users.id={0}";                                     //ok
        private const string cmdDeleteUser = "DELETE FROM users WHERE users.id={0}";                                    //ok
        private const string cmdUpdateUser = "UPDATE users SET users.Name = '{0}', users.References = '{1}', users.Note = '{2}', users.Address = '{3}', users.City = '{4}', users.Province = '{5}', users.CAP = '{6}' WHERE id = {7}";
        private const string cmdInsertNewUser = "INSERT INTO users (users.Name, users.References, users.Note, users.Address, users.City, users.Province, users.CAP) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
        private const string cmdCheckIfUserExist = "SELECT Count(*) FROM users WHERE id= {0}";                          //ok

        private const string cmdGetUserByDeviceID = "SELECT users.* FROM users,devices WHERE devices.UserID = users.id AND devices.ID = '{0}'";

        private static UserController sharedInstance;
        private UserController() { }

        public static UserController SharedInstance
        {
            get
            {
                if (sharedInstance == null)
                {
                    sharedInstance = new UserController();
                }
                return sharedInstance;
            }
        }

        
        public User getUserByDeviceId(String deviceID)
        {
            String cmd = cmdGetUserByDeviceID.Replace("{0}", deviceID);
            User _user = null;
            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmd);
            if (returnedData.Count > 0)
            {
                Dictionary<String, Object> user = returnedData[0];
                _user = new User();
                _user.Id = user["id"].ToString();
                _user.Name = user["Name"].ToString();
                _user.Note = user["Note"].ToString();
                _user.References = user["References"].ToString();
                _user.City = user["City"].ToString();
                _user.Address = user["Address"].ToString();
                _user.Province = user["Province"].ToString();
                _user.CAP = user["CAP"].ToString();
            }
            return _user;
        }

         // (users.Name, users.References, users.Note, users.Address, users.City, user.Province, user.CAP)
         // Facciamo un controllo sulla id. Se non è presente è un nuovo record da inserire, altrimenti lo aggiorniamo.
        public bool updateUser(User user)
        {
            int cnt = 0;

            if (user.Id == "" || user.Id == null)
            {
               bool res = insertNewUser(user);
               return res;
            }
            else
            {
                String cmd = cmdUpdateUser.Replace("{0}", user.Name);
                cmd = cmd.Replace("{1}", user.References);
                cmd = cmd.Replace("{2}", user.Note);
                cmd = cmd.Replace("{3}", user.Address);
                cmd = cmd.Replace("{4}", user.City);
                cmd = cmd.Replace("{5}", user.Province);
                cmd = cmd.Replace("{6}", user.CAP);
                cmd = cmd.Replace("{7}", user.Id);

                cnt = Database.SharedInstance.Update(cmd);
            }
            return cnt == 1 ? true : false;
        }

        /* User field:
         * id, name, references, note, address, city
         * check for id
         * */
        public bool insertNewUser(User user)
        {
            String cmd = cmdInsertNewUser.Replace("{0}", user.Name);
            cmd = cmd.Replace("{1}", user.References);
            cmd = cmd.Replace("{2}", user.Note);
            cmd = cmd.Replace("{3}", user.Address);
            cmd = cmd.Replace("{4}", user.City);
            cmd = cmd.Replace("{5}", user.Province);
            cmd = cmd.Replace("{6}", user.CAP);

            int cnt = Database.SharedInstance.Insert(cmd);

            return cnt == 1 ? true : false;
        }

        public bool deleteUser(string id)
        {
            String cmd = cmdDeleteUser.Replace("{0}", id);
            int cnt = Database.SharedInstance.Delete(cmd);

            //Check if user has deleted or not
            return cnt == 1 ? true : false;
        }

        public User getUser(string id)
        {
            String cmd = cmdGetUser.Replace("{0}", id);
            User _user = null;
            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmd);
            if(returnedData.Count>0)
            {
                Dictionary<String, Object> user = returnedData[0];
                _user = new User();
                _user.Id = user["id"].ToString();
                _user.Name = user["Name"].ToString();
                _user.Note = user["Note"].ToString();
                _user.References = user["References"].ToString();
                _user.City = user["City"].ToString();
                _user.Address = user["Address"].ToString();
                _user.Province = user["Province"].ToString();
                _user.CAP = user["CAP"].ToString();

            }
            return _user;
        }

        public List<User> loadUsers()
        {
            List<User> users = new List<User>();

            List<Dictionary<String, Object>> returnedData = Database.SharedInstance.getData(cmdGetAllUser);

            foreach(Dictionary<String, Object> user in returnedData)
            {
                User _user = new User();
                _user.Id = user["id"].ToString();
                _user.Name = user["Name"].ToString();
                _user.Note = user["Note"].ToString();
                _user.References = user["References"].ToString();
                _user.City = user["City"].ToString();
                _user.Address = user["Address"].ToString();
                _user.Province = user["Province"].ToString();
                _user.CAP = user["CAP"].ToString();

                users.Add(_user);
            }
            usersLoaded = true;
            this.users = users;
            return users;
        }

        public List<User> search(string text)
        {
            List<User> prova = this.users.FindAll(p => p.Name.ToLower().Contains(text.ToLower()) || p.Note.ToLower().Contains(text.ToLower()) || p.Address.ToLower().Contains(text.ToLower()));

            return prova;
        }
    }
}
