using Presentation.Forms.Manager;
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

namespace Presentation.Forms.Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            panelManageEmployee.Visible = false;
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            ControlSubMenu(panelManageEmployee);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void ControlSubMenu(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }

        }


        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelAdminMain.Controls.Add(childForm);
            panelAdminMain.Tag = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageManager());
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Managechef());
        }

        private void btnManageFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageFood());
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order());
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
