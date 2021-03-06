﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerWatchServer
{
    public partial class frmAlarm: Form
    {
        SearchControl searchControl;
        SearchDeviceControl searchDeviceControl;
        AlarmMgmCtrl alarmManagementControl;
        Thread ckAlarmThread;
        string lastAlarmID;
        bool EndAlarmCheckThread = false;



        delegate void dl(Alarm evento);

        public void newEvent(Alarm evento)
        {
            if (this.eventGrid.InvokeRequired)
            {
                dl stc = new dl(newEvent);
                this.Invoke(stc, new object[] { evento});
            }
            else
            {
                eventGrid.Rows.Add();
                eventGrid.Rows[eventGrid.RowCount - 1].Cells["Arrivo"].Value = evento.ArrivalTime;
                eventGrid.Rows[eventGrid.RowCount - 1].Cells["Codice"].Value = evento.Device.Note + " - " + evento.Device.DeviceID;
                eventGrid.Rows[eventGrid.RowCount - 1].Cells["Evento"].Value = evento.EventText;
                eventGrid.Rows[eventGrid.RowCount - 1].Cells["Utente"].Value = evento.User.Name + "\r\n" + evento.User.Address;
                eventGrid.Rows[eventGrid.RowCount - 1].Cells["Gestito"].Value = evento.Managed;
                eventGrid.Rows[eventGrid.RowCount - 1].Cells["ID"].Value = evento.Id;
                eventGrid.Rows[eventGrid.RowCount - 1].Cells["Latitude"].Value = evento.Latitude;
                eventGrid.Rows[eventGrid.RowCount - 1].Cells["Longitude"].Value = evento.Longitude;

                eventGrid.Rows[eventGrid.RowCount - 1].DefaultCellStyle.BackColor = evento.alarmColor[(int)evento.AlarmType];
            }
        }

        private void newEvent(Alarm evento, params object[] args)
        {
            newEvent(evento);
        }

        public frmAlarm()
        {
            InitializeComponent();
        }


        public void printStorico(object[] o)
        {
            webBrowser1.Invoke(new SetMultipinDelegate(SetMultipin), new object[] { o });
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
        public delegate void SetMultipinDelegate(object[] o);
        public void SetMultipin(object[] o)
        {
            lock (this)
            {
                webBrowser1.Document.InvokeScript("AddMultiPinOnMap",o);
            }
        }

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
         *  Help per le chiamate
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

        private void checkForNewAlarm()
        {
            //Thread.CurrentThread.Name = "CheckForAlarmThread";
            while(!EndAlarmCheckThread) //(Thread.CurrentThread.ThreadState == ThreadState.Background || EndAlarmCheckThread)
            {
                List<Alarm> allarmi = AlarmController.SharedInstance.loadAlarm();
                if (allarmi.Count > 0)
                {

                    if (allarmi.Last().Id != lastAlarmID)
                    {
                        if (AlarmController.SharedInstance.ErrorCode == 0)
                        {
                            foreach (Alarm evento in allarmi)
                            {
                                newEvent(evento);
                                lastAlarmID = evento.Id;
                            }
                        }
                        else
                        {
                            switch (AlarmController.SharedInstance.ErrorCode)
                            {
                                case 1:
                                    MessageBox.Show("Cannot Connect to Server. Plese Contact Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 2:
                                    MessageBox.Show("Invalid Database Username or Password, please contact Administrator", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 3:
                                    MessageBox.Show("Unable to connect with Database Server", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                default:
                                    MessageBox.Show("Unknow Error: " + AlarmController.SharedInstance.ErrorCode.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                            EndAlarmCheckThread = true;
                        }
                    }
                }
               // else
              //  {
                    try
                    {
                        Thread.Sleep(3000);
                    }
                    catch
                    {
                        EndAlarmCheckThread = true;
                    }
             //   }
            }
        }
        
        private void showHelp()
        {
            HelpControl hlp = new HelpControl();
            splitContainer1.Panel1.Controls.Clear();  //Close all previus control
            hlp.BorderStyle = BorderStyle.FixedSingle;

            splitContainer1.Panel1.Controls.Add(hlp);
            hlp.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            hlp.Dock = DockStyle.Fill;
            hlp.deselectAll();
        }

        private void frmAlarm_Load(object sender, EventArgs e)
        {
            showHelp();

            AlarmController.SharedInstance.mainAlarmForm = this;

            ckAlarmThread = new Thread(checkForNewAlarm);
            ckAlarmThread.Name = "CheckAlarmThread";
         //   ckAlarmThread.IsBackground = true;
            ckAlarmThread.Start();

            eventGrid.Focus();

            String mapPath = Application.StartupPath + "\\Support\\map.htm";
            webBrowser1.Navigate(mapPath);
            webBrowser1.Document.InvokeScript("SetMapStyle", new object[] { "VEMapStyle.Hybrid" });
            webBrowser1.Invoke(new ClearMapDelegate(ClearMap), null);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //AlarmController.SharedInstance.buildAlarm("1111", "Allarme di prova");
        }

        private void terminate()
        {
            ckAlarmThread.Interrupt();
            ckAlarmThread = null;
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
                string alarmID = eventGrid.Rows[rowIndex].Cells["ID"].Value.ToString();
                if (alarmID != "")
                {
                    Console.WriteLine("Selected alarm ID: " + alarmID);
                    Alarm alarmSelected = AlarmController.SharedInstance.alarms.First(x => x.Id == alarmID);
                    object[] ob = new object[6];
                    if (alarmSelected.Latitude != "")
                        ob[0] = alarmSelected.Latitude;
                    else
                        ob[0] = 0.00;
                    if (alarmSelected.Longitude != "")
                        ob[1] = alarmSelected.Longitude;
                    else
                        ob[1] = 0.00;

                    ob[2] = alarmSelected.Device.Note + "[" + alarmSelected.Device.DeviceID + "]"; //descrizione
                    ob[3] = Helper.getTextFromRTF(alarmSelected.User.References).Replace("\n", "<br>") + "<hr><br>" + Helper.getTextFromRTF(alarmSelected.User.Note).Replace("\n", "<br>");// "Descrizione bla bla bla <br> Numero 1: 123456 <br> Numero 2: 22222 <br> <b>Chiamare solo in caso di necessità</b>";
                    ob[4] = Application.StartupPath + "\\Support\\Images\\pushpin_blue.png";   //immagine del pushpin
                    ob[5] = true;       //Se deve essere centrato
                    webBrowser1.Invoke(new ClearMapDelegate(ClearMap));
                    webBrowser1.Invoke(new SetPushpinDelegate(SetPushpin), new object[] { ob });
                }
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
                    closeAllarm();
                }

                if (e.KeyCode == Keys.F4)
                {
                    openManagementAlarmCtrl();
                }

            }
        }

        
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmStorico frm = new frmStorico();
            frm.mainFrm = this;
            frm.Show();
        }

        private void toolStripBtnUser_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1.Controls.Contains(searchControl))
                searchControl.refreshData();
            else
            {
                searchControl = new SearchControl();
                splitContainer1.Panel1.Controls.Clear();  //Close all previus control
                searchControl.BorderStyle = BorderStyle.FixedSingle;
                
                splitContainer1.Panel1.Controls.Add(searchControl);
                searchControl.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                searchControl.Dock = DockStyle.Fill;
            }
        }

        private void toolStripBtnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frm1 = new frmSearch();
            frm1.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkAllarmTimer_Tick(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void closeAllarm()
        {
            int rowIndex = eventGrid.SelectedRows[0].Index;
            if (rowIndex > -1)
            {
                string alarmID = eventGrid.Rows[rowIndex].Cells["ID"].Value.ToString();
                if (alarmID != "")
                {
                    Console.WriteLine("Selected alarm ID: " + alarmID);
                    Alarm alarm = AlarmController.SharedInstance.alarms.First(x => x.Id == alarmID);
                    if (alarm != null)
                    {
                        AlarmController.SharedInstance.setAlarmAsClosed(alarm);
                        eventGrid.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }

        private void openManagementAlarmCtrl()
        {
            int rowIndex = eventGrid.SelectedRows[0].Index;
            if (rowIndex > -1)
            {
                string alarmID = eventGrid.Rows[rowIndex].Cells["ID"].Value.ToString();
                if (alarmID != "")
                {
                    Console.WriteLine("Selected alarm ID: " + alarmID);
                    alarmManagementControl = new AlarmMgmCtrl();
                    alarmManagementControl.currentAlarmID = alarmID;
                    alarmManagementControl.refresh();
                    splitContainer1.Panel1.Controls.Clear();  //Close all previus control
                    alarmManagementControl.BorderStyle = BorderStyle.FixedSingle;

                    splitContainer1.Panel1.Controls.Add(alarmManagementControl);
                    alarmManagementControl.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    alarmManagementControl.Dock = DockStyle.Fill;
                }
            }
        }

        private void eventGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openManagementAlarmCtrl();
        }

        private void gestisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openManagementAlarmCtrl();
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sicuro di voler chiudere l'evento?","Seresitter",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                closeAllarm();
        }

        private void frmAlarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.EndAlarmCheckThread = true;
            this.terminate();
        }

        private void programmazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 programmingForm = new Form1();
            programmingForm.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.SharedInstance.Backup();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.SharedInstance.Restore();
        }

        private void toolStripBtnDevice_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1.Controls.Contains(searchDeviceControl))
                searchDeviceControl.refreshData();
            else
            {
                searchDeviceControl = new SearchDeviceControl();
                splitContainer1.Panel1.Controls.Clear();  //Close all previus control
                searchDeviceControl.BorderStyle = BorderStyle.FixedSingle;

                splitContainer1.Panel1.Controls.Add(searchDeviceControl);
                searchDeviceControl.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                searchDeviceControl.Dock = DockStyle.Fill;
            }
        }
    }
}
