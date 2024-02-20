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
    public partial class Login : Form
    {
        bool isLogin(string Username, string Password)
        {
            if (Username == "aldrin" && Password == "272004")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public Login()
        {
            InitializeComponent(GetButton1());
        }

        private void button1_click(object sender, EventArgs e)
        {
                if (isLogin(txtUsername.Text, txtPassword.Text))
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        private void button2_click(object  sender, EventArgs e) 
        {
            this.Close();
        }
    }
}
