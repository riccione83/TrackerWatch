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
    public partial class frmUserDetails : Form
    {
        User userSelected;

        public frmUserDetails()
        {
            InitializeComponent();
        }

        public frmUserDetails(User userSelected) : this()
        {
            this.userSelected = userSelected;
            tbName.Text = userSelected.Name;
            tbAddress.Text = userSelected.Address;
            tbCity.Text = userSelected.City;
            cbProvinces.Text = userSelected.Province;
            tbCAP.Text = userSelected.CAP;
            try
            {
                rtbContacts.Rtf = Helper.decodeRTF(userSelected.References);
            }
            catch
            {
                rtbContacts.Text = Helper.getTextFromRTF(userSelected.References);
            }
            try
            {
                rtbNotes.Rtf = Helper.decodeRTF(userSelected.Note);
            }
            catch
            {
                rtbNotes.Text = Helper.getTextFromRTF(userSelected.Note);
            }
        }

        //menu for Contacts
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!rtbContacts.SelectionFont.Bold)
            {
                rtbContacts.SelectionFont = new Font(rtbContacts.SelectionFont.OriginalFontName, rtbContacts.SelectionFont.Size, FontStyle.Bold);
            }
            else
            {
                rtbContacts.SelectionFont = new Font(rtbContacts.SelectionFont.OriginalFontName, rtbContacts.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void italicToolStripMenuItemContacts_Click(object sender, EventArgs e)
        {
            if (!rtbContacts.SelectionFont.Italic)
            {
                rtbContacts.SelectionFont = new Font(rtbContacts.SelectionFont.OriginalFontName, rtbContacts.SelectionFont.Size, FontStyle.Italic);
            }
            else
            {
                rtbContacts.SelectionFont = new Font(rtbContacts.SelectionFont.OriginalFontName, rtbContacts.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void leftAlignTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContacts.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContacts.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void formatListBullettedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!rtbContacts.SelectionBullet)
                rtbContacts.SelectionBullet = true;
            else
                rtbContacts.SelectionBullet = false;
        }

        private void characterDimensionToolStripComboBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbContacts.SelectionFont = new System.Drawing.Font(rtbContacts.SelectionFont.FontFamily, float.Parse(characterDimensionToolStripComboBoxContacts.SelectedItem.ToString()), rtbContacts.SelectionFont.Style);
        }




        //menù for Notes
        private void boldToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            if (!rtbNotes.SelectionFont.Bold)
            {
                rtbNotes.SelectionFont = new Font(rtbNotes.SelectionFont.FontFamily,rtbNotes.SelectionFont.Size, FontStyle.Bold);
            }
            else
            {
                rtbNotes.SelectionFont = new Font(rtbNotes.SelectionFont.FontFamily, rtbNotes.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void italicToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            if (!rtbNotes.SelectionFont.Italic)
            {
                rtbNotes.SelectionFont = new Font(rtbNotes.SelectionFont.FontFamily, rtbNotes.SelectionFont.Size, FontStyle.Italic);
            }
            else
            {
                rtbNotes.SelectionFont = new Font(rtbNotes.SelectionFont.FontFamily, rtbNotes.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void leftAlignTextToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            rtbNotes.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignTextToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            rtbNotes.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void formatListBullettedToolStripMenuItemNotes_Click(object sender, EventArgs e)
        {
            if (!rtbNotes.SelectionBullet)
                rtbNotes.SelectionBullet = true;
            else
                rtbNotes.SelectionBullet = false;
        }

        private void characterDimensionToolStripComboBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbNotes.SelectionFont = new System.Drawing.Font(rtbNotes.SelectionFont.FontFamily, float.Parse(characterDimensionToolStripComboBoxNotes.SelectedItem.ToString()), rtbNotes.SelectionFont.Style);
        }



        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            frmDevice frm = new frmDevice(userSelected);
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User newUser;

            //I cliccked on un existing user
            if (userSelected != null)
            {
               newUser = userSelected;
            }//I want to create a new user
            else { newUser = new User(); }
          
            newUser.Name = tbName.Text;
            newUser.Address = tbAddress.Text;
            newUser.Province = cbProvinces.SelectedItem.ToString();
            newUser.CAP = tbCAP.Text;
            newUser.City = tbCity.Text;
            newUser.References = Helper.encodeRTF(rtbContacts.Rtf);
            newUser.Note = Helper.encodeRTF(rtbNotes.Rtf);
            if (UserController.SharedInstance.updateUser(newUser))
                this.Close();
            else
            {
                MessageBox.Show("Errore nel salvataggio dell'utente.", "Errore.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
