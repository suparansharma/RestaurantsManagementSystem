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
    public partial class AddChef : Form
    {
        DataAccess dataAccess = new DataAccess();
        RandomGenerator randomGenerator = new RandomGenerator();
        public AddChef()
        {
            
            InitializeComponent();
            panelAddChefInformation.Enabled = false;
            txtUserId.Enabled = false;
            txtPassword.Enabled = false;
            string userId = randomGenerator.RandomString(5, true);
            string password = randomGenerator.RandomPassword();
            txtUserId.Text = userId;
            txtPassword.Text = password;
        }

        private void btnAddChefIdpass_Click(object sender, EventArgs e)
        {
            panelAddChefInformation.Enabled = true;
            string userId = txtUserId.Text;
            int userType = (int)User.UserTypeEnum.Chef;


            bool isUserInsert = dataAccess.InsertUser(userId, txtPassword.Text, userType);

            if (isUserInsert)
            {
                MessageBox.Show("Insert Successfully");
            }

            else
            {
                MessageBox.Show("Unsuccessfull & Try again");
            }
        }

        private void btnEmployeeInformation_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            int userType = (int)User.UserTypeEnum.Chef;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string gender = (rbMale.Checked) ? "Male" : "Female";
            string phoneNumber = txtPhonenumber.Text;
            string email = txtEmail.Text;
            string joinDate = DateTime.Now.ToString("MM/dd/yyyy");
            int salary = Int32.Parse(cbSalary.SelectedItem.ToString());
            string time = cbTimeShedule.SelectedItem.ToString();

            bool isUserInsert = dataAccess.InsertEmployee(userId, fname, lname, gender, phoneNumber, email, joinDate, salary, userType, time);

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
