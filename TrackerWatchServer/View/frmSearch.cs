using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerWatchServer
{
    public partial class frmSearch : Form
    {


        public frmAlarm mainFrm = null;

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            if (!UserController.SharedInstance.usersLoaded)   //If users aren't loaded 
                UserController.SharedInstance.loadUsers();    //Update users list

            if (!DeviceController.SharedInstance.devicesLoaded)
                DeviceController.SharedInstance.getDevices();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            List<Device> devices = new List<Device>();

            if (txtSearchText.Text.Length > 0)
            {
                users = UserController.SharedInstance.search(txtSearchText.Text);
                devices = DeviceController.SharedInstance.search(txtSearchText.Text);
            }
            updateSearchWithResults(users, devices);
        }

        private void updateSearchWithResults(List<User> users, List<Device> devices)
        {
            //Clean the result list
            lstUser.Items.Clear();
            lstDevice.Items.Clear();

            foreach(User user in users)
            {
                lstUser.Items.Add(user.Name + " - " + user.Address + " ("+user.City+")");
            }

            foreach (Device device in devices)
            {
                lstDevice.Items.Add(device.Note + " [" + device.DeviceID + " - " + device.TelephoneNumber + "]");
            }
        }
    }
}
