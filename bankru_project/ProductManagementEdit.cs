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
using System.Xml.Linq;

namespace bankru_project
{
    public partial class ProductManagementEdit : Form
    {
        private string editid;
        private string editbar;
        private string editname;
        private string editcost;
        private string editselling;
        private string editcage;
        private string editnote;
        private string editunit;

        public ProductManagementEdit()
        {
            InitializeComponent();
        }

        public ProductManagementEdit(string barcode, string name, string costprice, string sellingprice, string cagetory, string note, string unit)
        {
            InitializeComponent();

            // Set the Editbarcode, Editname, and Ediitcostprice with the values from ProductManagementForm
            editbar = barcode;
            editname = name;
            editcost = costprice;
            editselling = sellingprice;
            editcage = cagetory;
            editnote = note;
            editunit = unit;
        }



        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=PTECPOS;Persist Security Info=True;User ID=Pong;Password=Pong555;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showcagetorybox()
        {
            Con.Open();

            string query = "SELECT DISTINCT CatName FROM Cagetorytbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table1 = new DataTable();
            ad.Fill(table1);
            Editcagetory.DataSource = table1;
            Editcagetory.DisplayMember = "CatName";

            Con.Close();
        }

        private void ProductManagementEdit_Load(object sender, EventArgs e)
        {
            showcagetorybox();

            Editbarcode.Text = editbar;
            Editname.Text = editname;
            Editcostprice.Text = editcost;
            Editsellingprice.Text = editselling;
            Editcagetory.Text = editcage;
            Editnote.Text = editnote;
            Editunit.Text = editunit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string checkCategoryQuery = "SELECT COUNT(*) FROM Products WHERE CagetoryName = '" + Editcagetory.Text + "'";
                SqlCommand checkCategoryCmd = new SqlCommand(checkCategoryQuery, Con);
                int categoryCount = Convert.ToInt32(checkCategoryCmd.ExecuteScalar());
                Con.Close();

                if (categoryCount == 0)
                {
                    MessageBox.Show("The entered category does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    if (MessageBox.Show("Are you sure to update the data?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        // Assuming 'editingid' is a TextBox, parse the text value to an int
                        string autoIDValue = editingid.Text;
                        
                            Con.Open();

                            // Use the values from TextBoxes to update the record
                            SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName = @ProductName, " +
                                                            "CostPrice = @CostPrice, " +
                                                            "SellingPrice = @SellingPrice, CagetoryName = @Category, " +
                                                            "Note = @Note, UnitsInStock = @Unit " +
                                                            "WHERE ProductBarcode = @ProductBarcode", Con);

                            cmd.Parameters.AddWithValue("@ProductBarcode", Editbarcode.Text);
                            cmd.Parameters.AddWithValue("@ProductName", Editname.Text);
                            cmd.Parameters.AddWithValue("@CostPrice", Editcostprice.Text);
                            cmd.Parameters.AddWithValue("@SellingPrice", Editsellingprice.Text);
                            cmd.Parameters.AddWithValue("@Category", Editcagetory.Text);
                            cmd.Parameters.AddWithValue("@Note", Editnote.Text);

                            cmd.Parameters.AddWithValue("@Unit", SqlDbType.Float).Value = Convert.ToDouble(Editunit.Text);

                            cmd.ExecuteNonQuery();
                            Con.Close();

                            MessageBox.Show("Your Data has been updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Editcagetory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
