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
    public partial class frmAlarm: Form, alarmDelegate
    {
        public void newEvent(Alarm evento)
        {
            eventGrid.Rows.Add();
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["Arrivo"].Value = evento.ArrivalTime;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["Codice"].Value = evento.Device.DeviceID;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["Evento"].Value = evento.EventText;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["Utente"].Value = evento.User.Name + "\r\n" + evento.User.Address;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["Gestito"].Value = evento.Managed;
            eventGrid.Rows[eventGrid.RowCount - 1].Cells["ID"].Value = evento.Id;

            eventGrid.Rows[eventGrid.RowCount - 1].DefaultCellStyle.BackColor = evento.alarmColor[(int)evento.AlarmType];
        }

        public frmAlarm()
        {
            InitializeComponent();
        }

        private void frmAlarm_Load(object sender, EventArgs e)
        {
            AlarmController.SharedInstance.mainAlarmForm = this;

            List<Alarm> allarmi = AlarmController.SharedInstance.loadAlarm();

            foreach(Alarm evento in allarmi)
            {
                newEvent(evento);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AlarmController.SharedInstance.buildAlarm("1111", "Allarme di prova");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eventGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex > -1)
                Console.WriteLine("Selected alarm ID: " + eventGrid.Rows[rowIndex].Cells["ID"].Value);
        }
    }
}
