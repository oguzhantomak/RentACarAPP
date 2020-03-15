using MetroFramework.Controls;
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
    public partial class SignUp : MetroForm
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public static void Temizle(Control.ControlCollection ctrl)
        {
            foreach (Control item in ctrl)
            {
                if (item is MetroTextBox)
                {
                    MetroTextBox mtb = (MetroTextBox)item;
                    mtb.Clear();
                }
            }
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.Name = txtName.Text;
            user.LastName = txtLastName.Text;

            menu.users.Add(user);
            Temizle(this.Controls);
        }
    }
}
