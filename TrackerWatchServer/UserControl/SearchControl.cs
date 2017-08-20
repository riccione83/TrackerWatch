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
    public partial class SearchControl : UserControl
    {
        List<User> users = new List<User>();
        List<Device> devices = new List<Device>();

        public SearchControl()
        {
            InitializeComponent();
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

            foreach (User user in users)
            {
                lstUser.Items.Add(user.Name + " - " + user.Address + " (" + user.City + ")");
            }

            foreach (Device device in devices)
            {
                lstDevice.Items.Add(device.Note + " [" + device.DeviceID + " - " + device.TelephoneNumber + "]");
            }
        }

    }
}
