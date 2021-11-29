using Database.Entities;
using RestaurantsManagementSystem;
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
    public partial class Manager : Form
    {
        public User user;
        public Manager(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelManagerMain.Controls.Add(childForm);
            panelManagerMain.Tag = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnManageFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageFood());

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagerProfile(user));
        }
    }
}
