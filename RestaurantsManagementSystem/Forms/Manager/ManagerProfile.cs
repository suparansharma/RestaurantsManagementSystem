using Database;
using Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.Manager
{
    public partial class ManagerProfile : Form
    {
        DataAccess dataAccess = new DataAccess();
        User user;
        public ManagerProfile(User user)
        {
            InitializeComponent();
            this.user = user;
            loadData();
        }

        private void loadData()
        {
           Employee employee = dataAccess.GetAllEmployeeByUserId(user.UserId);
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            if (employee.Gender.Trim() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtPhonenumber.Text = employee.PhoneNumber;
            txtEmail.Text = employee.Email;
            cbSalary.SelectedItem = employee.Salary.ToString();
            cbTimeShedule.SelectedItem = employee.TimeShedule;
            
            
        }
    }
}
