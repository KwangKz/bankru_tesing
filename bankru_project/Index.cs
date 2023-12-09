using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankru_project
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductManagementForm pmf = new ProductManagementForm();
            pmf.TopLevel = false;
            OutputPanel.Controls.Add(pmf);
            pmf.BringToFront();
            pmf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dsb = new Dashboard();
            dsb.TopLevel = false;
            OutputPanel.Controls.Add(dsb);
            dsb.BringToFront();
            dsb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member mb = new Member();
            mb.TopLevel = false;
            OutputPanel.Controls.Add(mb);
            mb.BringToFront();
            mb.Show();
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to leave the program?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return;
            } else
            {
                e.Cancel = true;
            }
        }

        private void Addproductbtn_Click(object sender, EventArgs e)
        {
            ManageProduct mpd = new ManageProduct();
            mpd.TopLevel = false;
            OutputPanel.Controls.Add(mpd);
            mpd.BringToFront();
            mpd.Show();
        }

        private void OutputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
