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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChickenjoy.Text == "C1")
            {
                lblPriceChicken.Text = "99";
                pbxChicken.Image = Properties.Resources.C1;
            }
            else if (cboChickenjoy.Text == "C2")
            {
                lblPriceChicken.Text = "120";
                pbxChicken.Image = Properties.Resources.c2;
            }
            else if (cboChickenjoy.Text == "C3")
            {
                lblPriceChicken.Text = "130";
                pbxChicken.Image = Properties.Resources.C3;
            }
            else if (cboChickenjoy.Text == "C4")
            {
                lblPriceChicken.Text = "140";
                pbxChicken.Image = Properties.Resources.c4;
            }
            else if (cboChickenjoy.Text == "C5")
            {
                lblPriceChicken.Text = "150";
                pbxChicken.Image = Properties.Resources.c5;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBSteak.Text == "B1")
            {
                lblPriceSteak.Text = "79";
                pbxSteak.Image = Properties.Resources.b1;
            }
            else if (cboBSteak.Text == "B2")
            {
                lblPriceSteak.Text = "89";
                pbxSteak.Image = Properties.Resources.b2;
            }
            else if (cboBSteak.Text == "B3")
            {
                lblPriceSteak.Text = "99";
                pbxSteak.Image = Properties.Resources.b3;
            }
            else if (cboBSteak.Text == "B4")
            {
                lblPriceSteak.Text = "109";
                pbxSteak.Image = Properties.Resources.b4;
            }
            else if (cboBSteak.Text == "B5")
            {
                lblPriceSteak.Text = "119";
                pbxSteak.Image = Properties.Resources.B5;
            }
        }

        private void cboBurgers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBurgers.Text == "Yumburger")
            {
                lblPriceBurger.Text = "65";
                pbxBurger.Image = Properties.Resources.Yumburger;
            }
            else if (cboBurgers.Text == "Cheesy Yumburger")
            {
                lblPriceBurger.Text = "85";
                pbxBurger.Image = Properties.Resources.CheesyYum2;
            }
            else if (cboBurgers.Text == "Bacon Cheesy Yumburger")
            {
                lblPriceBurger.Text = "100";
                pbxBurger.Image = Properties.Resources.bacon;
            }
        }

        private void cboFFries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFFries.Text == "Regular")
            {
                lblPriceFries.Text = "45";
                pbxFries.Image = Properties.Resources.reg;
            }
            else if (cboFFries.Text == "Large")
            {
                lblPriceFries.Text = "67";
                pbxFries.Image = Properties.Resources.large;
            }
            else if (cboFFries.Text == "Jumbo")
            {
                lblPriceFries.Text = "89";
                pbxFries.Image = Properties.Resources.jumbo;
            }
        }

        private void cboDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesserts.Text == "Sundae")
            {
                lblPriceDessert.Text = "45";
                pbxDessert.Image = Properties.Resources.sundae;
            }
            else if (cboDesserts.Text == "Peach Mango Pie")
            {
                lblPriceDessert.Text = "55";
                pbxDessert.Image = Properties.Resources.pie;
            }
            else if (cboDesserts.Text == "Coke Float")
            {
                lblPriceDessert.Text = "60";
                pbxDessert.Image = Properties.Resources._float;
            }
        }

        private void cboJDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJDrinks.Text == "Coke")
            {
                lblPriceDrinks.Text = "30";
                pbxDrinks.Image = Properties.Resources.coke;
            }
            else if (cboJDrinks.Text == "Sprite")
            {
                lblPriceDrinks.Text = "30";
                pbxDrinks.Image = Properties.Resources.Sprite;
            }
            else if (cboJDrinks.Text == "Pineapple Juice")
            {
                lblPriceDrinks.Text = "25";
                pbxDrinks.Image = Properties.Resources.juice;
            }
            else if (cboJDrinks.Text == "Iced Tea")
            {
                lblPriceDrinks.Text = "25";
                pbxDrinks.Image = Properties.Resources.lemon_tea;
            }
            double priceChicken = double.Parse(lblPriceChicken.Text);
            double priceSteak = double.Parse(lblPriceSteak.Text);
            double priceBurger = double.Parse(lblPriceBurger.Text);
            double priceFries = double.Parse(lblPriceFries.Text);
            double priceDessert = double.Parse(lblPriceDessert.Text);
            double priceDrinks = double.Parse(lblPriceDrinks.Text);
            double total = priceChicken + priceSteak + priceBurger + priceFries + priceDessert + priceDrinks;
            lblMenuTotal.Text = total.ToString();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (txtCash.Text != "")
            {
                double total = double.Parse(lblMenuTotal.Text);
                double cash = double.Parse(txtCash.Text);
                if (cash >= total)
                {
                    btnProceed.Enabled = true;
                }
                else
                {
                    btnProceed.Enabled = false;
                }
            }
        }

        private void lblMenuTotal_Click(object sender, EventArgs e)
        {
            double priceChicken = double.Parse(lblPriceChicken.Text);
            double priceSteak = double.Parse(lblPriceSteak.Text);
            double priceBurger = double.Parse(lblPriceBurger.Text);
            double priceFries = double.Parse(lblPriceFries.Text);
            double priceDessert = double.Parse(lblPriceDessert.Text);
            double priceDrinks = double.Parse(lblPriceDrinks.Text);
            double total = priceChicken + priceSteak + priceBurger + priceFries + priceDessert + priceDrinks;
            lblMenuTotal.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtCash.Text != "")
            {
                double total = double.Parse(lblMenuTotal.Text);
                double cash = double.Parse(txtCash.Text);
                if (cash >= total)
                {
                    btnProceed.Enabled = true;
                }
                else
                {
                    btnProceed.Enabled = false;
                }
            }
            Receipt rec = new Receipt();
            rec.ReceiptTotal = lblMenuTotal.Text;
            rec.ReceiptCash = txtCash.Text;
            this.Hide();
            rec.Show();
            }
        }
    }

