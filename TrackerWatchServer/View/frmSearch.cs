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
        List<User> users = new List<User>();
        List<Device> devices = new List<Device>();

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

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstUser_DoubleClick(object sender, EventArgs e)
        {
            if (lstUser.SelectedIndex > -1)
            {              
                    Console.WriteLine("User selected: " + users[lstUser.SelectedIndex]);
                    this.Close();
                    //pass the user selected to the UserDetails Form
                    frmUserDetails frmdetails = new frmUserDetails(users[lstUser.SelectedIndex]);
                    frmdetails.Show();
            }

        }
        private void lstDevice_DoubleClick(object sender, EventArgs e)
        {

            if (lstDevice.SelectedIndex > -1)
            {             
                    Console.WriteLine("Device selected: " + devices[lstDevice.SelectedIndex]);
                    //pass the device selected to the Device Form
                    frmDevice frmdevice = new frmDevice(devices[lstDevice.SelectedIndex]);
                    frmdevice.Show();
            }
        }
    }
}
