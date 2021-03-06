﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using System.Windows.Forms;

namespace TrackerWatchServer
{
    public class Database
    {
        private static Database sharedInstance;
        private Database() { }
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public int Error = 0;
        private bool busy = false;

        public static Database SharedInstance
        {
            get
            {
                if (sharedInstance == null)
                {
                    sharedInstance = new Database();
                    sharedInstance.initialize();
                }
                return sharedInstance;
            }
        }

        ~Database()
        {
            sharedInstance.CloseConnection();
        }

        public void initialize()
        {
            server = AppController.SharedInstance.SQL_SERVER_IP;
            database = AppController.SharedInstance.DATABASE;
            uid = AppController.SharedInstance.DB_USER;
            password = AppController.SharedInstance.DB_PASSWORD;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                while (busy) // connection.State == System.Data.ConnectionState.Open)
                {
                     Thread.Sleep(10);
                }
                connection.Open();
                busy = true;
                Console.WriteLine("Thread: " + Thread.CurrentThread.Name + " - DB Occupato");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        Error = 1;
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        Error = 2;
                        break;
                    case 1130:
                        Console.WriteLine("Unable to connect with DB Server");
                        Error = 3;
                        break;
                    default:
                        Error = ex.Number;
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                busy = false;
                Console.WriteLine("Thread: " + Thread.CurrentThread.GetHashCode() + " - DB Liberato");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Insert statement
        public int Insert(string SQL)
        {
            string query = SQL; 

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int cnt;
                try
                {
                    cnt = cmd.ExecuteNonQuery();
                }
                catch
                {
                    cnt = 0;
                }
                //close connection
                this.CloseConnection();
                return cnt;
            }
            return 0;
        }

        //Update statement
        public int Update(string SQL)
        {
            string query = SQL;  //"UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                int cnt = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

                return cnt;
            }
            return 0;
        }

        //Delete statement
        public int Delete(string SQL)
        {
            string query = SQL; // "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int cnt = cmd.ExecuteNonQuery();
                this.CloseConnection();
                return cnt;
            }
            return 0;
        }

        public List<Dictionary<String, Object>> getData(string SQL)
        {
            string query = SQL;
            List<Dictionary<String, Object>> ret = new List<Dictionary<String, Object>>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ret.Add(Enumerable.Range(0, dataReader.FieldCount).ToDictionary(dataReader.GetName, dataReader.GetValue));
                }
                    
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return ret;
            }
            else
            {
                return ret;
            }
        }

        //Count statement
        public int Count(string SQL)
        {
            string query = SQL;
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                var exportDB = new SaveFileDialog();
                exportDB.Filter = "SQL File (*.sql)|*.sql";
                if (exportDB.ShowDialog() == DialogResult.OK)
                {

                    //Save file to C:\ with the current date as a filename
                    string path;
                    path = exportDB.FileName; //"C:\\MySqlBackup" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                    StreamWriter file = new StreamWriter(path);
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = Application.StartupPath + "\\Support\\mysqldump.exe";
                    if (File.Exists(psi.FileName))
                    {
                        psi.RedirectStandardInput = false;
                        psi.RedirectStandardOutput = true;
                        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                        psi.UseShellExecute = false;

                        Process process = Process.Start(psi);

                        string output;
                        output = process.StandardOutput.ReadToEnd();
                        file.WriteLine(output);
                        process.WaitForExit();
                        file.Close();
                        process.Close();
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error , unable to backup!");
            }
        }

        public void Restore()
        {
            try
            {
                //Read file from C:\
                var loadDB = new OpenFileDialog();
                loadDB.Filter = "SQL File (*.sql)|*.sql";
                if (loadDB.ShowDialog() == DialogResult.OK)
                {
                    string path;
                    path = loadDB.FileName;
                    StreamReader file = new StreamReader(path);
                    string input = file.ReadToEnd();
                    file.Close();

                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = @"C:\Program Files\MySQL\MySQL Server 5.1\bin\mysql.exe";
                    if (File.Exists(psi.FileName))
                    {
                        psi.RedirectStandardInput = true;
                        psi.RedirectStandardOutput = false;
                        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                        psi.UseShellExecute = false;

                        Process process = Process.Start(psi);
                        process.StandardInput.WriteLine(input);
                        process.StandardInput.Close();
                        process.WaitForExit();
                        process.Close();
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error , unable to Restore!");
            }
        }
    }
}
