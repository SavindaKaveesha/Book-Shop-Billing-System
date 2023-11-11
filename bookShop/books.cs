using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bookShop
{
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savinda\Documents\bookShopDb.mdf;Integrated Security=True;Connect Timeout=30");


        public void populate()
        {
            con.Open();

            string query = "SELECT * FROM bookTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            bookGDV.DataSource = ds.Tables[0];
            con.Close();
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (authorTxt.Text.Length == 0 || bookTxt.Text.Length == 0 || priceTxt.Text.Length == 0 || qtyTxt.Text.Length == 0 || catBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = " INSERT INTO  bookTbl VALUES ('" + bookTxt.Text + "', '" + authorTxt.Text + "', '" + catBox.SelectedItem.ToString() + "', '" + int.Parse(qtyTxt.Text) + "', '" + int.Parse(priceTxt.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            populate();
            reset();

        }


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            con.Open();

            string query = "SELECT * FROM bookTbl WHERE bcat = '" + (selectBox.SelectedItem).ToString() + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            bookGDV.DataSource = ds.Tables[0];

            con.Close();

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            authorTxt.Clear();
            bookTxt.Clear();
            priceTxt.Clear();
            qtyTxt.Clear();
            catBox.SelectedIndex = -1;
        }

        int key = 0;

        private void bookGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookTxt.Text = bookGDV.SelectedRows[0].Cells[1].Value.ToString();
            authorTxt.Text = bookGDV.SelectedRows[0].Cells[2].Value.ToString();
            catBox.SelectedItem = bookGDV.SelectedRows[0].Cells[3].Value.ToString();
            qtyTxt.Text = bookGDV.SelectedRows[0].Cells[4].Value.ToString();
            priceTxt.Text = bookGDV.SelectedRows[0].Cells[5].Value.ToString();

            if (bookTxt.Text.Length == 0)
            {
                key = 0;
            }
            else
            {
                key = int.Parse(bookGDV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

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

                    string query = " DELETE FROM bookTbl WHERE  Bid = '" + key + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sucessfuly Deleted !");

                    reset();

                    con.Close();

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (authorTxt.Text.Length == 0 || bookTxt.Text.Length == 0 || priceTxt.Text.Length == 0 || qtyTxt.Text.Length == 0 || catBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = " UPDATE bookTbl SET btitle = '"+bookTxt.Text+"', Bauthor = '"+authorTxt.Text+"', Bcat = '"+ catBox.SelectedItem +"', Bqty = '"+ int.Parse(qtyTxt.Text) +"', bprice = '"+ int.Parse(priceTxt.Text) +"' WHERE Bid = '"+key+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Updated");

                    reset();

                    con.Close();

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
