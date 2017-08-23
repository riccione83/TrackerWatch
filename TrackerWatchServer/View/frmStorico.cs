using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerWatchServer
{
    public partial class frmStorico : Form
    {
        List<Device> devices = new List<Device>();
        int selectedIndex = -1;
        public frmAlarm mainFrm;

        public frmStorico()
        {
            InitializeComponent();
        }

        private void frmStorico_Load(object sender, EventArgs e)
        {
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dtFinish.Format = DateTimePickerFormat.Custom;
            dtFinish.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            if (!DeviceController.SharedInstance.devicesLoaded)
                devices = DeviceController.SharedInstance.getDevices();

             updateSearchWithResults(devices);
         }


        private void showNewStorico(Alarm evento)
        {
            eventGrid.Rows.Add();
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["DataEvento"].Value = evento.ArrivalTime;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["ID"].Value = evento.Device.DeviceID + " - " + evento.Device.Note;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["Evento"].Value = evento.EventText;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["Latitudine"].Value = evento.Latitude;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["Longitudine"].Value = evento.Longitude;
            eventGrid.Rows[eventGrid.RowCount - 1].DefaultCellStyle.BackColor = evento.alarmColor[(int)evento.AlarmType];
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

            if (eventGrid.Rows.Count == 0) return;

            object[] lat = new object[eventGrid.Rows.Count];
            object[] lon = new object[eventGrid.Rows.Count];
            object[] desc = new object[eventGrid.Rows.Count];
            bool validPoint = false;

            for (int i = 0; i < eventGrid.Rows.Count; i++)
            {
                string latitude = eventGrid.Rows[i].Cells["Latitudine"].Value.ToString();
                string longitude = eventGrid.Rows[i].Cells["Longitudine"].Value.ToString();
                if (latitude != "" && longitude != "")
                {
                    lat[i] = latitude;
                    lon[i] = longitude;
                    desc[i] = eventGrid.Rows[i].Cells["Evento"].Value.ToString() + " - " + eventGrid.Rows[i].Cells["DataEvento"].Value.ToString();
                    validPoint = true;
                }
            }

            if (validPoint)
            {
                for (int i = 0; i < lat.Length; i++)
                {
                    object[] ob = new object[3];
                    ob[0] = lat[i];
                    ob[1] = lon[i];
                    ob[2] = desc[i];
                    if(ob[0] != null)
                        mainFrm.printStorico(ob);
                }
            }
        }

        private void lstDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = lstDevice.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1)
            {
                eventGrid.Rows.Clear();

                var start = dtStart.Value;
                var stop = dtFinish.Value;
                var alarmList = AlarmController.SharedInstance.loadAlarm(start, stop, devices[selectedIndex]);

                foreach (Alarm alarm in alarmList)
                    showNewStorico(alarm);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (eventGrid.Rows.Count == 0)
                return;

            if (saveFileDialogTXT.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveFileDialogTXT.FileName;
                using (StreamWriter wr = new StreamWriter(fileName))
                {
                    wr.WriteLine("Esportazione storico del dispositivo: " + eventGrid.Rows[0].Cells["ID"].Value);

                    for (int i = 0; i < eventGrid.Rows.Count; i++)
                    {
                        string newLineStoric = eventGrid.Rows[i].Cells["DataEvento"].Value.ToString();
                        newLineStoric += " " + eventGrid.Rows[i].Cells["Evento"].Value.ToString();
                        newLineStoric += " " + eventGrid.Rows[i].Cells["Latitudine"].Value.ToString();
                        newLineStoric += " " + eventGrid.Rows[i].Cells["Longitudine"].Value.ToString();
                        wr.WriteLine(newLineStoric);
                    }

                    MessageBox.Show("Esportazione completata.", "Esportazione Testo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (eventGrid.Rows.Count == 0)
                return;

            if (saveFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveFileDialogCSV.FileName;
                using (StreamWriter wr = new StreamWriter(fileName))
                {
                    wr.WriteLine("Esportazione storico del dispositivo: " + eventGrid.Rows[0].Cells["ID"].Value);
                    wr.WriteLine("Data Evento;Evento;Latitudine;Longitudine");
                    for (int i = 0; i < eventGrid.Rows.Count; i++)
                    {
                        string newLineStoric = eventGrid.Rows[i].Cells["DataEvento"].Value.ToString();
                        newLineStoric += ";" + eventGrid.Rows[i].Cells["Evento"].Value.ToString();
                        newLineStoric += ";" + eventGrid.Rows[i].Cells["Latitudine"].Value.ToString();
                        newLineStoric += ";" + eventGrid.Rows[i].Cells["Longitudine"].Value.ToString();
                        wr.WriteLine(newLineStoric);
                    }

                    MessageBox.Show("Esportazione completata.", "Esportazione CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
