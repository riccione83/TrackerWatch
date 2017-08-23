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
    public partial class frmStorico : Form
    {
        List<Device> devices = new List<Device>();
        public frmAlarm mainFrm;

        public frmStorico()
        {
            InitializeComponent();
        }

        private void frmStorico_Load(object sender, EventArgs e)
        {
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            dtFinish.Format = DateTimePickerFormat.Custom;
            dtFinish.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            if (!DeviceController.SharedInstance.devicesLoaded)
                devices = DeviceController.SharedInstance.getDevices();

            updateSearchWithResults(devices);
        }

        private void updateSearchWithResults(List<Device> devices)
        {
            //Clean the result list
            lstDevice.Items.Clear();

            foreach (Device device in devices)
                lstDevice.Items.Add(device.Note + " [" + device.DeviceID + " - " + device.TelephoneNumber + "]");
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchText.Text.Length > 0)
            {
                devices = DeviceController.SharedInstance.search(txtSearchText.Text);
            }
            updateSearchWithResults(devices);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object[] lat = new object[5];
            lat[0] = "37.537211";
            lat[1] = "37.537311";
            lat[2] = "37.537411";
            lat[3] = "37.537511";
            lat[4] = "37.537611";

            object[] lon = new object[5];
            lon[0] = 15.094644;
            lon[1] = 15.094744;
            lon[2] = 15.094844;
            lon[3] = 15.094944;
            lon[4] = 15.094044;

            object[] desc = new object[5];
            desc[0] = "Posizione 0";
            desc[1] = "Posizione 1";
            desc[2] = "Posizione 2";
            desc[3] = "Posizione 3";
            desc[4] = "Posizione 4";

            for(int i=0;i<lat.Length;i++)
            {
                object[] ob = new object[3];
                ob[0] = lat[i];
                ob[1] = lon[i];
                ob[2] = desc[i];
                mainFrm.printStorico(ob);
            }

            this.Close();
        }
    }
}
