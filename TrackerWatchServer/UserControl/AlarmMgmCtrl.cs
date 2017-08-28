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
    public partial class AlarmMgmCtrl : UserControl
    {
        public string currentAlarmID;

        public AlarmMgmCtrl()
        {
            InitializeComponent();
        }

        public void addNewRow(string text)
        {
            txtAlarmNote.Text += DateTime.Now.ToString() + " - " + text + "\r\n";
            saveNoteForAlarm(txtAlarmNote.Text);
        }

        public void refresh()
        {
            if(currentAlarmID != "")
            {
                Alarm alarm = AlarmController.SharedInstance.alarms.Find(x => x.Id == currentAlarmID);
                txtAlarmNote.Text = alarm.Note;
            }
        }

        public bool saveNoteForAlarm(string note)
        {
            Alarm alarm = AlarmController.SharedInstance.alarms.Find(x => x.Id == currentAlarmID);
            if(alarm != null)
            {
                return AlarmController.SharedInstance.updateNoteForAlarm(note, alarm);
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNewRow(cbNote.Text);
        }

        private void cbNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                addNewRow(cbNote.Text);
            }
        }
    }
}
