using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class menu : MetroForm
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
        public static List<User> users = new List<User>();
        public static List<string> passwords = new List<string>();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            if (users.Exists(x => x.UserName == txtUserName.Text) && users.Exists(x => x.Password == txtPass.Text))
            {
                MetroMessageBox.Show(this, "Congratulations, you have successfully logged in. !");
                this.Hide();
                MainMenu main = new MainMenu();
                main.ShowDialog();
                
            }
            else
            {
                MetroMessageBox.Show(this, "You have logged in incorrectly !");
                SignUp.Temizle(this.Controls);
            }
        }
    }
}
