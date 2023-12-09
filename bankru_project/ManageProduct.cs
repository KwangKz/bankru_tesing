using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace bankru_project
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=PTECPOS;Persist Security Info=True;User ID=Pong;Password=Pong555;Encrypt=False");

        private void showtodgv()
        {
            Con.Open();
            string query = "select * from Products";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MPdgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ManageProduct_Load(object sender, EventArgs e)
        {
            showtodgv();
        }

        private void Addmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MPbarcode.Text == "" || MPname.Text == "" || MPcostprice.Text == "" || 
                    MPsellingprice.Text == "" || MPcagetory.Text == "" || MPunit.Text == "")
                {
                    MessageBox.Show("Please Enter Data Complete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                Con.Open();
                DialogResult result = MessageBox.Show("Are you sure to add product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string query = "insert into Products values(" + MPbarcode.Text + ",'" + MPname.Text + "','" + MPcostprice.Text + "','" + MPsellingprice.Text + "','" + MPunit.Text + "','" + MPcagetory.Text + "','" + null + "','" + MPnote.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Added Successfully!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    return;
                }
                
                
                Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                DialogResult result = MessageBox.Show("Do you want to delete the product?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    string query = "delete from Products where ProductBarcode=" + MPbarcode.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cagetory Has been Deleted successfully!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
                Con.Close();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void MPdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MPbarcode.Text = MPdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            MPname.Text = MPdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            MPcostprice.Text = MPdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            MPsellingprice.Text = MPdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            MPunit.Text = MPdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            MPcagetory.Text = MPdgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            MPnote.Text = MPdgv.Rows[e.RowIndex].Cells[8].Value.ToString();
       

        }
    }
}
