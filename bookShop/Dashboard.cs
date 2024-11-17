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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SAVINDA;Initial Catalog=bookShopDb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = " SELECT SUM(Bqty) FROM bookTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            bookStockLbl.Text = dataTable.Rows[0][0].ToString();

            query = " SELECT SUM(amount) FROM billTbl ";
            SqlDataAdapter sda2 = new SqlDataAdapter(query, con);
            DataTable dataTable2 = new DataTable();
            sda2.Fill(dataTable2);
            totalAmountLbl.Text = dataTable2.Rows[0][0].ToString();

            query = " SELECT count(*) FROM userTbl ";
            SqlDataAdapter sda3 = new SqlDataAdapter(query, con);
            DataTable dataTable3 = new DataTable();
            sda3.Fill(dataTable3);
            userCountLbl.Text = dataTable3.Rows[0][0].ToString();

            con.Close();
        }

        public void showLogin()
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        public void showBooks()
        {
            books obj = new books();
            this.Hide();
            obj.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            showBooks();
        }


        private void panel6_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        public void showUser()
        {
            users obj = new users();
            this.Hide();
            obj.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            showUser();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            showUser();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showUser();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            showBooks();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showBooks();
        }
    }
}
