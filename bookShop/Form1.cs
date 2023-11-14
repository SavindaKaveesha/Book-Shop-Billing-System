namespace bookShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int startpos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 10;
            Myprogress.Value = startpos;
            presentageLab.Text = startpos.ToString() + "%";

            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Close button  
            Application.Exit();
        }

    }
}