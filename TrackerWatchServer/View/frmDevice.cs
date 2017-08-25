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
    public partial class frmDevice : Form
    {
        User userToAssociateTo;
        Device deviceSelected;

        private TrackerCommand command = null;
        Device newDevice;

        public frmDevice()
        {
            InitializeComponent();
        }

        //I came from UserDetails and I want to associate a device to un user
        public frmDevice(User user):this()
        {
            userToAssociateTo = user;
            tbUserID.Text = userToAssociateTo.Id;       
        }

        //I came from double clicking on a device
        public frmDevice(Device device) : this()
        {          
            deviceSelected = device;
            tbSerial.Text = deviceSelected.DeviceID;
            tbTelephoneNumber.Text = deviceSelected.TelephoneNumber;
            tbUserID.Text = deviceSelected.User;
            tbNotes.Text = deviceSelected.Note;
            lIMEI.Text = System.String.Format("IMEI: {0} ", deviceSelected.IMEI); 
            lsos1.Text = System.String.Format("SOS 1: {0} ", deviceSelected.Sos1);
            lsos2.Text = System.String.Format("SOS 2: {0} ", deviceSelected.Sos2);
            lsos3.Text = System.String.Format("SOS 3: {0} ", deviceSelected.Sos3);
            lCenterNumber.Text = System.String.Format("Center: {0} ", deviceSelected.Center);
            lSlaveNumber.Text = System.String.Format("Slave: {0} ", deviceSelected.Slave);
            lIP.Text = System.String.Format("IP: {0} ", deviceSelected.Ip);
            lPorta.Text = System.String.Format("Porta: {0} ", deviceSelected.Port);
            lLevelBattery.Text = System.String.Format("Livello batteria: {0} ", deviceSelected.Battery_level);
        }

        private void btnSaveDevice_Click(object sender, EventArgs e)
        {
            
            //I cliccked on un existing user
            if (deviceSelected != null)
            {
                newDevice = deviceSelected;
            }//I want to create a new user
            else
            {
                newDevice = new Device();
            }

            newDevice.DeviceID = tbSerial.Text;
            newDevice.User = tbUserID.Text;
            newDevice.Note = tbNotes.Text;

            //TODO magari prendere gli altri campi o dalle label se riempite e si vuol fare in questo caso un aggiornamento op
            //dal risultato del getParameter

            if (DeviceController.SharedInstance.updateDevice(newDevice))
                this.Close();
            else
            {
                MessageBox.Show("Errore nel salvataggio del device.", "Errore.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGetParametersTest_Click(object sender, EventArgs e)
        {
            if (!command.getParameters(newDevice))
                MessageBox.Show("Error on send command GetParameters");
        }
    }
}
