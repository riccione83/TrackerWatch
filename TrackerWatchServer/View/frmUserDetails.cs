﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerWatchServer.View
{
    public partial class frmUserDetails : Form
    {
        public frmUserDetails()
        {
            InitializeComponent();
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
            frmDevice frm = new frmDevice();
            frm.Show();
        }

        
    }
}
