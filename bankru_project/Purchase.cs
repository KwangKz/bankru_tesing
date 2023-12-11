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
    public partial class Purchase : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=PTECPOS;Persist Security Info=True;User ID=Pong;Password=Pong555;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        private PictureBox pic = new PictureBox();

        public Purchase()
        {
            InitializeComponent();
        }

        private void GetData()
        {
            con.Open();

            con.Close();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {

        }
    }
}
