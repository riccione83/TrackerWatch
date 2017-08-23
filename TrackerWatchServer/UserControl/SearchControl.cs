using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerWatchServer.View;

namespace TrackerWatchServer
{
    public partial class SearchControl : UserControl
    {
        List<User> users = new List<User>();
        List<Device> devices = new List<Device>();

        public SearchControl()
        {
            InitializeComponent();
            //If users aren't loaded Update users list
            if (!UserController.SharedInstance.usersLoaded)
            {
                //I show all the user in the list
                users = UserController.SharedInstance.loadUsers();
                updateSearchWithResults(users, devices);
            }
            //if (!DeviceController.SharedInstance.devicesLoaded)
            //    DeviceController.SharedInstance.getDevices();
        }

        //This text works like a filter
        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchText.Text.Length > 0)
            {
                users = UserController.SharedInstance.search(txtSearchText.Text);
                devices = DeviceController.SharedInstance.search(txtSearchText.Text);
            }
            else
            {
                //I show all the user in the list
                users = UserController.SharedInstance.loadUsers();
            }
            updateSearchWithResults(users, devices);
        }

        private void updateSearchWithResults(List<User> users, List<Device> devices)
        {
            //Clean the result list
            lstUser.Items.Clear();
            lstDevice.Items.Clear();

            foreach (User user in users)
            {
                lstUser.Items.Add(user.Name + " - " + user.Address + " (" + user.City + ")");
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

        private void lstDevice_DoubleClick(object sender, EventArgs e)
        {
            if (lstDevice.SelectedIndex > -1)
            {
                Console.WriteLine("Device selected: " + devices[lstDevice.SelectedIndex]);
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUser.SelectedIndex > -1)
            {
                Console.WriteLine("User selected: " + users[lstUser.SelectedIndex]);
                devices = DeviceController.SharedInstance.getDevicesByUserID(users[lstUser.SelectedIndex].Id);
                lstDevice.Items.Clear();
                foreach (Device device in devices)
                {
                    lstDevice.Items.Add(device.Note + " [" + device.DeviceID + " - " + device.TelephoneNumber + "]");
                }
            }
        }
    }
}
