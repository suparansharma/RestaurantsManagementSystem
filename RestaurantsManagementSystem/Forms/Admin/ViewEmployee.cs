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

namespace Presentation.Forms.Admin
{
    public partial class ViewEmployee : Form
    {
        DataAccess dataAccess = new DataAccess();
        public int userType { get; set; }
        public ViewEmployee(int userType)
        {
            InitializeComponent();
            this.userType = userType;
            LoadData();
        }
        private void LoadData()
        {
            dataAccess.GetAllEmployeeByUserType(dataGridViewEmployee, userType);
            panelviewemployeedata.Visible = false;
            txtUserId.Enabled = false;
            txtJoinDate.Enabled = false;
        }

        private void dataGridViewEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panelviewemployeedata.Visible = true;
            var userId = dataGridViewEmployee.SelectedRows[0].Cells[0].Value.ToString();
            var firstName = dataGridViewEmployee.SelectedRows[0].Cells[1].Value.ToString();
            var lastName = dataGridViewEmployee.SelectedRows[0].Cells[2].Value.ToString();
            string gender = dataGridViewEmployee.SelectedRows[0].Cells[3].Value.ToString();
            var phoneNumber = dataGridViewEmployee.SelectedRows[0].Cells[4].Value.ToString();
            var email = dataGridViewEmployee.SelectedRows[0].Cells[5].Value.ToString();
            var joinDate = dataGridViewEmployee.SelectedRows[0].Cells[6].Value.ToString();
            string salary = dataGridViewEmployee.SelectedRows[0].Cells[7].Value.ToString();
            var userType = dataGridViewEmployee.SelectedRows[0].Cells[8].Value.ToString();
            var timeSchedule = dataGridViewEmployee.SelectedRows[0].Cells[9].Value.ToString();
            txtUserId.Text = userId;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            if (gender.Trim() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtPhonenumber.Text = phoneNumber;
            txtEmail.Text = email;
            cbSalary.SelectedItem = salary;
            cbTimeShedule.SelectedItem = timeSchedule;
            txtJoinDate.Text = joinDate;
        }

        private void btnUpdateEployee_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string gender = (rbMale.Checked) ? "Male" : "Female";
            string phoneNumber = txtPhonenumber.Text;
            string email = txtEmail.Text;
            string joinDate = DateTime.Now.ToString("MM/dd/yyyy");
            int salary = Int32.Parse(cbSalary.SelectedItem.ToString());
            string time = cbTimeShedule.SelectedItem.ToString();
            bool isEmplyeeUpdate = dataAccess.UpdateEmploye(userId, fname, lname, gender, phoneNumber, email, salary);
            if (isEmplyeeUpdate)
            {
                MessageBox.Show("Upadte Successfully");
                LoadData();
            }

            else
            {
                MessageBox.Show("Unsuccessfull & Try again");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            bool isDeleteUser = dataAccess.DeleteUser(userId);
            bool isDeleteEmployee = dataAccess.DeleteEmployee(userId);
            if (isDeleteUser && isDeleteEmployee)
            {
                MessageBox.Show("Delete Successfully");
                LoadData();
            }

            else
            {
                MessageBox.Show("Unsuccessfull & Try again");
            }
        }

        private void dataGridViewEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panelviewemployeedata.Visible = true;
            var userId = dataGridViewEmployee.SelectedRows[0].Cells[0].Value.ToString();
            var firstName = dataGridViewEmployee.SelectedRows[0].Cells[1].Value.ToString();
            var lastName = dataGridViewEmployee.SelectedRows[0].Cells[2].Value.ToString();
            string gender = dataGridViewEmployee.SelectedRows[0].Cells[3].Value.ToString();
            var phoneNumber = dataGridViewEmployee.SelectedRows[0].Cells[4].Value.ToString();
            var email = dataGridViewEmployee.SelectedRows[0].Cells[5].Value.ToString();
            var joinDate = dataGridViewEmployee.SelectedRows[0].Cells[6].Value.ToString();
            string salary = dataGridViewEmployee.SelectedRows[0].Cells[7].Value.ToString();
            var userType = dataGridViewEmployee.SelectedRows[0].Cells[8].Value.ToString();
            var timeSchedule = dataGridViewEmployee.SelectedRows[0].Cells[9].Value.ToString();
            txtUserId.Text = userId;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            if (gender.Trim() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtPhonenumber.Text = phoneNumber;
            txtEmail.Text = email;
            cbSalary.SelectedItem = salary;
            cbTimeShedule.SelectedItem = timeSchedule;
            txtJoinDate.Text = joinDate;
        }
    }
}
