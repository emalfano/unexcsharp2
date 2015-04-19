using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            int radius = 4;
            const double PI = 3.14;
            double volume;
            // Do calculation for volume of a sphere
            volume = 4.0 / 3.0 * PI * radius * radius * radius;
            txtOutput.Text = "Radius = " + radius + ", PI = " + PI;
            txtOutput.Text = txtOutput.Text + " volume = "
                + volume.ToString("##.00");
        }




    }
}
