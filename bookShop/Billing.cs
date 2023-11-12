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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            viewTbl();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Savinda\Documents\bookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        int key = 0;
        int stock = 0;
        int subTotal=0;

        //display databse details
        public void viewTbl()
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

        //when click display datagridview details in textbox
        private void bookGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itemTxt.Text = bookGDV.SelectedRows[0].Cells[1].Value.ToString();
            priceTxt.Text = bookGDV.SelectedRows[0].Cells[5].Value.ToString();

            if (itemTxt.Text.Length == 0)
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = int.Parse(bookGDV.SelectedRows[0].Cells[0].Value.ToString());
                stock = int.Parse(bookGDV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            itemTxt.Clear();
            priceTxt.Clear();
            qtyTxt.Clear();
        }

        //update qty
        public void update()
        {

            int newQty = stock - Convert.ToInt32(qtyTxt.Text);

            try
            {
                con.Open();

                string query = " UPDATE bookTbl SET Bqty = '" + newQty + "' WHERE Bid = '" + key + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                clear();

                con.Close();

                viewTbl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            viewTbl();
        }

        private void addToBillBtn_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (qtyTxt.Text.Length == 0 || int.Parse(qtyTxt.Text) > stock)
            {
                MessageBox.Show("Not enough stock");
            }
            else
            {
                int total = int.Parse(qtyTxt.Text) * int.Parse(priceTxt.Text);

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(billGDV);

                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = itemTxt.Text;
                newRow.Cells[2].Value = qtyTxt.Text;
                newRow.Cells[3].Value = priceTxt.Text;
                newRow.Cells[4].Value = total;
                billGDV.Rows.Add(newRow);
                n++;
                subTotal += total;

                totalLbl.Text = subTotal.ToString();

                update();

                clear();
            }
        }
    }
}
