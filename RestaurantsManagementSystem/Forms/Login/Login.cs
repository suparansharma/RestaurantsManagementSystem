using Database;
using Database.Entities;
using Presentation.Forms.Admin;
using Presentation.Forms.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantsManagementSystem
{
    public partial class Login : Form
    {
        DataAccess dataAccess = new DataAccess();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = dataAccess.LoginAccess(textBoxUserid.Text, textBoxPassword.Text);
            if(user != null)
            {
                if(user.UserType == (int)User.UserTypeEnum.Admin)
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else if(user.UserType == (int)User.UserTypeEnum.Manager)
                {
                    Manager manager = new Manager(user);
                    manager.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Ivalid User");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
