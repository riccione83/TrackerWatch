using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerWatchServer
{
    public partial class SearchDeviceControl : UserControl
    {
        List<User> users = new List<User>();
        List<Device> devices = new List<Device>();

        public SearchDeviceControl()
        {
            InitializeComponent();
            refreshData();
        }

        public void refreshData()
        {
            //I show all the devices in the list
            devices = DeviceController.SharedInstance.getDevices();
            updateSearchWithResults(users, devices);
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchText.Text.Length > 0)
            {
                users = UserController.SharedInstance.search(txtSearchText.Text);
                devices = DeviceController.SharedInstance.search(txtSearchText.Text);
            }
            else
            {
                //I show all the device in the list
                devices = DeviceController.SharedInstance.getDevices();
            }
            updateSearchWithResults(users, devices);
        }

        private void updateSearchWithResults(List<User> users, List<Device> devices)
        {
            //Clean the result list
            lstUser.Items.Clear();
            lstDevice.Items.Clear();

            foreach (Device device in devices)
            {
                lstDevice.Items.Add(device.Note + " [" + device.DeviceID + " - " + device.TelephoneNumber + "]");
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

        private void lstUser_DoubleClick(object sender, EventArgs e)
        {
            if (lstUser.SelectedIndex > -1)
            {
                Console.WriteLine("User selected: " + users[lstUser.SelectedIndex]);
                //pass the user selected to the UserDetails Form
                frmUserDetails frmdetails = new frmUserDetails(users[lstUser.SelectedIndex]);
                frmdetails.Show();
            }
        }

        private void txtSearchText_Enter(object sender, EventArgs e)
        {
            if (txtSearchText.Text == "Termine Ricerca")
            {
                txtSearchText.Text = "";
                txtSearchText.ForeColor = Color.Black;
            }
        }

        private void lstDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDevice.SelectedIndex > -1)
            {
                Console.WriteLine("Device selected: " + devices[lstDevice.SelectedIndex]);
                User user = UserController.SharedInstance.getUserByDeviceId(devices[lstDevice.SelectedIndex].DeviceID);
                lstUser.Items.Clear();
                users.Add(user);
                lstUser.Items.Add(user.Name + " - " + user.Address + " (" + user.City + ")");
            }
        }
    }
}
