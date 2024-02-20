namespace bartolome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int starting = 0;

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            progressBar1.Value = starting;
            label2.Text = "" + starting;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
