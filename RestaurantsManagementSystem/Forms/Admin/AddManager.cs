using Database;
using Database.Entities;
using Presentation.RandomSample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.Admin
{
    public partial class AddManager : Form
    {
        DataAccess dataAccess = new DataAccess();
        RandomGenerator randomGenerator = new RandomGenerator();
        public AddManager()
        {
            InitializeComponent();
            panelAddManagerInformation.Enabled = false;
            txtUserId.Enabled = false;
            txtPassword.Enabled = false;
            string userId = randomGenerator.RandomString(5, true);
            string password = randomGenerator.RandomPassword();
            txtUserId.Text = userId;
            txtPassword.Text = password;
        }

        private void btnAddManagerIdpass_Click(object sender, EventArgs e)
        {
            panelAddManagerInformation.Enabled = true;
            
            int userType = (int)User.UserTypeEnum.Manager;
            bool isUserInsert = dataAccess.InsertUser(txtUserId.Text, txtPassword.Text, userType);
            if (isUserInsert)
            {
                MessageBox.Show("Insert Successfully"); 
            }

            else
            {
                MessageBox.Show("Unsuccessfull & Try again");
            }
        }
    }
}
