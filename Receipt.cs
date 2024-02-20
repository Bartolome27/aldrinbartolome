using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bartolome
{
    public partial class Receipt : Form
    {
        public string ReceiptTotal
        {
            set { lblReceiptTotal.Text = value; }
        }
        public string ReceiptCash
        {
            set { lblReceiptCash.Text = value; }
        }
        public Receipt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = double.Parse(lblReceiptTotal.Text);
            double vat = total * 0.10;
            lblReceiptVAT.Text = vat.ToString();
            double cash = double.Parse(lblReceiptCash.Text);
            double change = cash - total;
            lblChange.Text = change.ToString();

        }

        private void lblReceiptTotal_Click(object sender, EventArgs e)
        {

        }
        private void VoidOrder(object sender, EventArgs e)
        {
            this.Hide();
            Receipt rec = new Receipt();
            rec.FormClosed += (s, args) => this.Show();
            rec.ShowDialog();
        }
        private void Purchase(object sender, EventArgs e)
        {
            this.Hide();
            Receipt rec = new Receipt();
            rec.FormClosed += (s, args) => this.Show();
            rec.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }
        private void btnPurchase_click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }
        private void Logout(object sender, EventArgs e)
        {
            this.Hide();
            Receipt rec = new Receipt();
            rec.FormClosed += (s, args) => this.Show();
            rec.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }
    }
}

