using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bankru_project
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=PTECPOS;Persist Security Info=True;User ID=Pong;Password=Pong555;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                DialogResult result = MessageBox.Show("Do you want to add the cagetory?","Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    string query = "insert into Cagetorytbl values(" + idinsert.Text + ",'" + Nameinsert.Text + "','" + desinsert.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cagetory Added Successfully");
                } else
                {
                    idinsert.Focus();
                    idinsert.Text = "";
                    Nameinsert.Text = "";
                    desinsert.Text = "";
                }
                

                Con.Close();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

private void showtodgv()
        {
            Con.Open();
            string query = "select * from Cagetorytbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatData.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Member_Load(object sender, EventArgs e)
        {
            showtodgv();
        }

        private void CatData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            idinsert.Text = CatData.Rows[e.RowIndex].Cells[0].Value.ToString();
            Nameinsert.Text = CatData.Rows[e.RowIndex].Cells[1].Value.ToString();
            desinsert.Text = CatData.Rows[e.RowIndex].Cells[2].Value.ToString();

            testingbox.Text = CatData.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                if (idinsert.Text == "")
                {
                    MessageBox.Show("Select The Cagetory To Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    DialogResult result = MessageBox.Show("Are you sure to delete the cagetory? ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                   
                        string query = "delete from Cagetorytbl where Id=" + idinsert.Text + "";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cagetory Has been Deleted successfully!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        return;
                    }

                    Con.Close();
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
