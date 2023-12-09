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
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userlogin.Text = "";
            passwordlogin.Text = "";
            permislogin.Text = "Select Permission";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userlogin.Text == "" || passwordlogin.Text == "")
            {
                MessageBox.Show("Please Enter Your username or password","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (permislogin.SelectedIndex > -1)
                {

                    if (permislogin.SelectedItem.ToString() == "Admin")
                    {
                        if (userlogin.Text == "Admin" && passwordlogin.Text == "Admin")
                        {
                            Index index = new Index();
                            index.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the Admin, please enter the username and password correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } else
                    {
                        MessageBox.Show("You In the Seller Section!");
                    }
                }
                else if (permislogin.SelectedItem.ToString() == "Seller")
                {
                    MessageBox.Show("You are the Seller");
                }
                else
                {
                    MessageBox.Show("Select A Permission!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
