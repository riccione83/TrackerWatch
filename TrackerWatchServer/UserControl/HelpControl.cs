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
    public partial class HelpControl : UserControl
    {
        public HelpControl()
        {
            InitializeComponent();
        }

        public void deselectAll()
        {
            textBox1.DeselectAll();
        }
    }
}
