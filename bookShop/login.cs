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

namespace bookShop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SAVINDA;Initial Catalog=bookShopDb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;");
        public static string userName = "";


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = " SELECT count (*) FROM userTbl WHERE  Uname = '" + uNameTxt.Text + "' and Upass = '" + pwTxt.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            userName = uNameTxt.Text;

            if (dt.Rows[0][0].ToString() == "1")
            {
                Billing obj = new Billing();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Incorrect user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}