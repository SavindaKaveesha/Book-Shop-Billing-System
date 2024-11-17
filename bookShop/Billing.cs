using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

        }

        SqlConnection con = new SqlConnection(@"Data Source=SAVINDA;Initial Catalog=bookShopDb;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"); int key = 0;
        int stock = 0;
        decimal subTotal = 0;

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
            if (ValidateFields() == true) { 

                int n = 0;

            // Ensure qtyTxt and priceTxt are not empty and contain valid numbers
            if (string.IsNullOrWhiteSpace(priceTxt.Text) || !decimal.TryParse(priceTxt.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (string.IsNullOrWhiteSpace(priceTxt.Text) || !decimal.TryParse(priceTxt.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Check stock availability
            if (qty > stock)
            {
                MessageBox.Show("Not enough stock");
                return;
            }


            qty = Convert.ToInt32(qtyTxt.Text);


            // Calculate the total
            decimal total = qty * price;

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(billGDV);

            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = itemTxt.Text;
            newRow.Cells[2].Value = qty.ToString();
            newRow.Cells[3].Value = price.ToString();
            newRow.Cells[4].Value = total.ToString();
            billGDV.Rows.Add(newRow);

            n++;
            subTotal += total;

            totalLbl.Text = subTotal.ToString();

            update();

            clear();

        }
        }


        private void label6_Click(object sender, EventArgs e)
        {
            showLogin();
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

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        int id, qty;
        decimal price, tot;
        string prodName;
        int Yposition = 60;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("INVOICE", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(100, 10));
            e.Graphics.DrawString("ID      Name            Price    Quantity    Total", new Font("Century Gothic", 8), Brushes.Red, new Point(26, 40));

            foreach (DataGridViewRow row in billGDV.Rows)
            {

                if (Convert.ToInt32(row.Cells[0].Value) == 0)
                {
                    break;
                }
                else
                {
                    id = Convert.ToInt32(row.Cells[0].Value);
                    prodName = "" + row.Cells[1].Value;
                    price = Convert.ToDecimal(row.Cells[3].Value);
                    qty = Convert.ToInt32(row.Cells[2].Value);
                    tot = Convert.ToDecimal(row.Cells[4].Value);

                    e.Graphics.DrawString(" " + id.ToString(), new Font("Century Gothic", 8), Brushes.Blue, new Point(20, Yposition));
                    e.Graphics.DrawString(" " + prodName.ToString(), new Font("Century Gothic", 6), Brushes.Blue, new Point(55, Yposition + 2));
                    e.Graphics.DrawString(" " + price.ToString(), new Font("Century Gothic", 8), Brushes.Blue, new Point(130, Yposition));
                    e.Graphics.DrawString(" " + qty.ToString(), new Font("Century Gothic", 8), Brushes.Blue, new Point(200, Yposition));
                    e.Graphics.DrawString(" " + tot.ToString(), new Font("Century Gothic", 8), Brushes.Blue, new Point(235, Yposition));
                    Yposition = Yposition + 20;
                }
            }
            e.Graphics.DrawString("Net Total Payment: " + subTotal, new Font("Century Gothic", 8), Brushes.Black, new Point(80, Yposition + 30));
            e.Graphics.DrawString("THANK YOU !", new Font("Century Gothic", 12), Brushes.Black, new Point(80, Yposition + 60));


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool ValidateFields()
        {
            // Validate qtyTxt: Ensure it's not empty and contains a valid integer
            if (string.IsNullOrWhiteSpace(qtyTxt.Text) || !int.TryParse(qtyTxt.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.");
                return false;  // Invalid input
            }

            // Validate priceTxt: Ensure it's not empty and contains a valid decimal value
            if (string.IsNullOrWhiteSpace(priceTxt.Text) || !decimal.TryParse(priceTxt.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than zero.");
                return false;  // Invalid input
            }

            return true;  // Both fields are valid
        }

    }
}
