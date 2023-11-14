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
using System.Data.SqlClient;

namespace bookShop
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            viewTbl();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savinda\Documents\bookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        int key = 0;

        private void users_Load(object sender, EventArgs e)
        {

        }

        //close button
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            uAddressTxt.Clear();
            uNameTxt.Clear();
            uPhoneTxt.Clear();
            uPwTxt.Clear();
        }

        //show database data in table 
        public void viewTbl()
        {
            con.Open();

            string query = "SELECT * FROM userTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            userGDV.DataSource = ds.Tables[0];
            con.Close();
        }

        //adding data into database
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (uAddressTxt.Text.Length == 0 || uNameTxt.Text.Length == 0 || uPhoneTxt.Text.Length == 0 || uPwTxt.Text.Length == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = " INSERT INTO  userTbl VALUES ('" + uNameTxt.Text + "', '" + uPhoneTxt.Text + "', '" + uAddressTxt.Text + "', '" + uPwTxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            viewTbl();
            reset();

        }


        //when click on the table cell the selected row was display in text boxes
        private void userGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uNameTxt.Text = userGDV.SelectedRows[0].Cells[1].Value.ToString();
            uPhoneTxt.Text = userGDV.SelectedRows[0].Cells[2].Value.ToString();
            uAddressTxt.Text = userGDV.SelectedRows[0].Cells[3].Value.ToString();
            uPwTxt.Text = userGDV.SelectedRows[0].Cells[4].Value.ToString();

            if (uNameTxt.Text.Length == 0)
            {
                key = 0;
            }
            else
            {
                key = int.Parse(userGDV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        //delete selected row from database
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = " DELETE FROM userTbl WHERE  Uid = '" + key + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sucessfuly Deleted !");

                    reset();

                    con.Close();

                    viewTbl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //refresh datagridview data
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            viewTbl();
        }

        //edit selected row data
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (uAddressTxt.Text.Length == 0 || uNameTxt.Text.Length == 0 || uPhoneTxt.Text.Length == 0 || uPwTxt.Text.Length == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = " UPDATE userTbl SET  Uname = '" + uNameTxt.Text + "', Uadd = '" + uAddressTxt.Text + "', Upass = '" + uPwTxt.Text + "' WHERE Uid = '" + key + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Updated");

                    reset();

                    con.Close();

                    viewTbl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void showLogin()
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            showLogin();
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

        private void label5_Click(object sender, EventArgs e)
        {
            showBooks();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showBooks();
        }

        public void showDashboard()
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            showDashboard();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            showDashboard();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            showDashboard();
        }
    }
}

