using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneCustomer_Classes;


namespace OneCustomer_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thresholdValue_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(thresholdValue, thresholdValue.Value.ToString() + "%");
        }
    }
}
