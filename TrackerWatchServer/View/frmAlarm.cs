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

        //***********************   CHIAMATE JAVASCRIPT *************************************

        /*  Help per la chiamata:
         *  object[] ob = new object[6];
            ob[0] = lat;
            ob[1] = lon;
            ob[2] = pp.Description + " (" + number + ")"; //descrizione
            ob[3] = TimeDate;   //descrizione
            ob[4] = pp.image;   //immagine del pushpin
            ob[5] = true;       //Se deve essere centrato
           webBrowser1.Invoke(new SetPushpinDelegate(SetPushpin), new object[] { ob });
        */
        public delegate void SetPushpinDelegate(object[] o);
        public void SetPushpin(object[] o)
        {
            lock (this)
            {
                webBrowser1.Document.InvokeScript("AddPushPinOnMap", o);
            }
        }

        /*
         * Help per la chiamata
         * webBrowser1.Invoke(new ClearMapDelegate(ClearMap), null);
         * */
        public delegate void ClearMapDelegate();
        public void ClearMap()
        {
            lock (this)
            {
                webBrowser1.Document.InvokeScript("ClearMap");
            }
        }

        public delegate void GoToPointDelegate(object[] o);
        public void GoToPoint(object[] o)
        {
            lock (this)
            {
                webBrowser1.Document.InvokeScript("getRouteToPoint", o);
            }
        }


        public delegate void SetObjectDelegate(object[] o);
        public void SetObject(object[] o)
        {
            lock (this)
            {
                webBrowser1.Document.InvokeScript("AddPolygonPinOnMap", o);
            }
        }

        /*
         * Help per le chiamate
         *  object[] ob = new object[4];
            ob = new object[4];
            ob[0] = p.Lat;          //current latitude
            ob[1] = p.Lon;          //Current longitude
            ob[2] = coord[1];       //Dest latitude
            ob[3] = coord[2];       //Dest longiture
            frmSatelliteMap.satelliteMap.Invoke(new getDistanceToPointDelegate(getDistanceToPoint), new object[] { ob });
        */
        public delegate void getDistanceToPointDelegate(object[] o);
        public void getDistanceToPoint(object[] o)
        {
            lock (this)
            {
                webBrowser1.Document.InvokeScript("getDistanceToPoint", o);
            }
        }
        //*********************************************************************************************

        private void frmAlarm_Load(object sender, EventArgs e)
        {
            AlarmController.SharedInstance.mainAlarmForm = this;

            List<Alarm> allarmi = AlarmController.SharedInstance.loadAlarm();

            foreach(Alarm evento in allarmi)
            {
                newEvent(evento);
            }

            String mapPath = Application.StartupPath + "\\Support\\map.htm";
            webBrowser1.Navigate(mapPath);
            webBrowser1.Document.InvokeScript("SetMapStyle", new object[] { "VEMapStyle.Hybrid" });
            webBrowser1.Invoke(new ClearMapDelegate(ClearMap), null);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //AlarmController.SharedInstance.buildAlarm("1111", "Allarme di prova");


        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eventGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                Console.WriteLine("Selected alarm ID: " + eventGrid.Rows[rowIndex].Cells["ID"].Value);

                //Test
                object[] ob = new object[6];
                ob[0] = 37.537211;
                ob[1] = 15.094644;
                ob[2] = "Posizione di prova (Orologio Blu)"; //descrizione
                ob[3] = "Descrizione bla bla bla <br> Numero 1: 123456 <br> Numero 2: 22222 <br> <b>Chiamare solo in caso di necessità</b>";
                ob[4] = Application.StartupPath + "\\Support\\Images\\pushpin_blue.png";   //immagine del pushpin
                ob[5] = true;       //Se deve essere selezionato
                webBrowser1.Invoke(new SetPushpinDelegate(SetPushpin), new object[] { ob });
            }
        }

        private void eventGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void eventGrid_KeyDown(object sender, KeyEventArgs e)
        {

            if (eventGrid.Rows.Count > 0)
            {
                if (e.Control && e.KeyCode == Keys.D1)
                {
                    Console.WriteLine("Key pressed");
                    int rowIndex = eventGrid.SelectedRows[0].Index;
                    if (rowIndex > -1)
                    {
                        eventGrid.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmSearch frmsearch = new frmSearch();
            frmsearch.mainFrm = this;
            frmsearch.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
