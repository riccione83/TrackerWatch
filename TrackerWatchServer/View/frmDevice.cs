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

        public frmDevice()
        {
            InitializeComponent();
        }

        public frmDevice(User user)
        {
            InitializeComponent();
            userToAssociateTo = user;
        }

     
        private void boldToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            if (!rtbDeviceNotes.SelectionFont.Bold)
            {
                rtbDeviceNotes.SelectionFont = new Font(rtbDeviceNotes.SelectionFont.FontFamily, rtbDeviceNotes.SelectionFont.Size, FontStyle.Bold);
            }
            else
            {
                rtbDeviceNotes.SelectionFont = new Font(rtbDeviceNotes.SelectionFont.FontFamily, rtbDeviceNotes.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void italicToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            if (!rtbDeviceNotes.SelectionFont.Italic)
            {
                rtbDeviceNotes.SelectionFont = new Font(rtbDeviceNotes.SelectionFont.FontFamily, rtbDeviceNotes.SelectionFont.Size, FontStyle.Italic);
            }
            else
            {
                rtbDeviceNotes.SelectionFont = new Font(rtbDeviceNotes.SelectionFont.FontFamily, rtbDeviceNotes.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void leftAlignTextToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            rtbDeviceNotes.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignTextToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            rtbDeviceNotes.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void formatListBullettedToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            if (!rtbDeviceNotes.SelectionBullet)
                rtbDeviceNotes.SelectionBullet = true;
            else
                rtbDeviceNotes.SelectionBullet = false;
        }

        private void btnSaveDevice_Click(object sender, EventArgs e)
        {

        }
    }
}
