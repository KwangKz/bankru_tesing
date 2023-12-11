using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankru_project
{
    public partial class AddCagetory : Form
    {
        public AddCagetory()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=PTECPOS;Persist Security Info=True;User ID=Pong;Password=Pong555;Encrypt=False");

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showtodgv()
        {
            Con.Open();

            string countQuery = "SELECT CagetoryName, COUNT(*) AS Amount FROM Products GROUP BY CagetoryName";
            SqlDataAdapter sda = new SqlDataAdapter(countQuery, Con);

            // Fill the dataset
            var ds = new DataSet();
            sda.Fill(ds);

            CageDGV.DataSource = ds.Tables[0];
            CageDGV.DataSource = ds.Tables[0];
            DataGridViewColumn column = CageDGV.Columns[0];
            DataGridViewColumn column1 = CageDGV.Columns[1];
            column.Width = 150;
            column1.Width = 150;

            Con.Close();
        }

        private void showtodgvcurrent()
        {
            Con.Open();

            string countQuery = "SELECT CatName, COUNT(*) AS Amount FROM Cagetorytbl GROUP BY CatName";
            SqlDataAdapter sda = new SqlDataAdapter(countQuery, Con);

            // Fill the dataset
            var ds = new DataSet();
            sda.Fill(ds);

            DGVcurrent.DataSource = ds.Tables[0];
            DataGridViewColumn column = DGVcurrent.Columns[0];
            column.Width = 150;

            Con.Close();
        }

        private void AddCagetory_Load(object sender, EventArgs e)
        {
            showcagetorybox();
            delinput.Visible = false;
            OKdel.Visible = false;
            Candel.Visible = false;
            showtodgvcurrent();
            showtodgv();
        }

        private void CageDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addcagebtn_Click(object sender, EventArgs e)
        {
            if (inputcagetory.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Category name must not contain numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Con.Open();

            // Check if the category name already exists in the database
            string checkQuery = "SELECT COUNT(*) FROM Cagetorytbl WHERE CatName = @CatName";
            SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
            checkCmd.Parameters.AddWithValue("@CatName", inputcagetory.Text);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Category with the same name already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Con.Close();
                return;
            }

            if (MessageBox.Show("Are you sure to add the Category?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // Use parameterized query to avoid SQL injection
                string insertQuery = "INSERT INTO Cagetorytbl(CatName, CatDes) VALUES(@CatName, @CatDes)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, Con);
                insertCmd.Parameters.AddWithValue("@CatName", inputcagetory.Text);
                insertCmd.Parameters.AddWithValue("@CatDes", "");
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Category has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                this.Close();
            }
            else
            {
                Con.Close();
            }
        }


        private void showcagetorybox()
        {
            Con.Open();

            string query = "SELECT DISTINCT CatName FROM Cagetorytbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table1 = new DataTable();
            ad.Fill(table1);
            delinput.DataSource = table1;
            delinput.DisplayMember = "CatName";

            Con.Close();
        }

        private void deletecagetorybtn_Click(object sender, EventArgs e)
        {
            inputcagetory.Visible = false;
            delinput.Visible = true;
            deletecagetorybtn.Visible = false;
            Addcagebtn.Visible = false;

            Candel.Visible = true;
            OKdel.Visible = true;
            
        }

        private void Candel_Click(object sender, EventArgs e)
        {
            Candel.Visible = false;
            OKdel.Visible = false;
            delinput.Visible = false;

            deletecagetorybtn.Visible = true;
            inputcagetory.Visible = true;
            Addcagebtn.Visible = true;
        }

        private void OKdel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete Cagetory?","Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

            Con.Open();
                string query = "DELETE FROM Cagetorytbl WHERE CatName = '" + delinput.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cagetory has been deleted successfully!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Con.Close();

                Candel.Visible = false;
                OKdel.Visible = false;
                delinput.Visible = false;

                deletecagetorybtn.Visible = true;
                inputcagetory.Visible = true;
                Addcagebtn.Visible = true;

                this.Close();

            } else
            {
                Candel.Visible = false;
                OKdel.Visible = false;
                delinput.Visible = false;

                deletecagetorybtn.Visible = true;
                inputcagetory.Visible = true;
                Addcagebtn.Visible = true;
                return;
            }
        }

        private void DGVcurrent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
