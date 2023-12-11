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
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace bankru_project
{
    public partial class CounterTest : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=PTECPOS;Persist Security Info=True;User ID=Pong;Password=Pong555;Encrypt=False");

        private void showcagetorybox()
        {
            Con.Open();

            string query = "SELECT DISTINCT CatName FROM Cagetorytbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table1 = new DataTable();
            ad.Fill(table1);
            CTcagetory.DataSource = table1;
            CTcagetory.DisplayMember = "CatName";

            Con.Close();
        }

        public CounterTest()
        {
            InitializeComponent();
            CTtime.Interval = 1000; // Set the interval in milliseconds
            CTtime.Tick += CTtime_Tick;

            // Start the timer
            CTtime.Start();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void showtodgv()
        {
                Con.Open();
                string query = "select ProductBarcode, ProductName, Sellingprice, UnitsInStock, CagetoryName, Note from Products";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CTdgv.DataSource = ds.Tables[0];
                Con.Close();
        }

        private void CounterTest_Load(object sender, EventArgs e)
        {
            showtodgv();
            showcagetorybox();
        }

        private void CTtime_Tick(object sender, EventArgs e)
        {
            CTdate.Text = DateTime.Now.ToString();
        }

        private void CTdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CTbarcode.Text = CTdgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            CTname.Text = CTdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            CTsellingprice.Text = CTdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            CTnote.Text = CTdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            CTcagetory.Text = CTdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            CTunit.Text = CTdgv.Rows[e.RowIndex].Cells[3].Value.ToString();

            /*MPbarcode.Text = MPdgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            MPname.Text = MPdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            MPcostprice.Text = MPdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            MPsellingprice.Text = MPdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            MPunit.Text = MPdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            MPcagetory.Text = MPdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            MPnote.Text = MPdgv.Rows[e.RowIndex].Cells[6].Value.ToString();*/
        }

        private void CTadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CTAmount.Text) || string.IsNullOrWhiteSpace(CTbarcode.Text))
            {
                MessageBox.Show("Please enter all required data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add data to the DataGridView
            ProductcurrentDGV.Rows.Add(CTname.Text, CTAmount.Text, CTsellingprice.Text);

            // Clear the input textboxes after adding data
            CTname.Clear();
            CTAmount.Clear();
            CTsellingprice.Clear();
        }
    }
}
