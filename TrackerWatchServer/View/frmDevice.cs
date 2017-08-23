using System;
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
    }
}
