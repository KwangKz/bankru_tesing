using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankru_project
{
    public partial class ProductManagementForm : Form
    {
        private Timer labelTimer = new Timer();
        public ProductManagementForm()
        {
            InitializeComponent();

            // Set up the labelTimer
            timerDate.Interval = 1000; // Set the interval in milliseconds
            timerDate.Tick += timerDate_Tick;

            // Start the timer
            timerDate.Start();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            DatetimeLabel.Text = DateTime.Now.ToString();
        }

    }
}
