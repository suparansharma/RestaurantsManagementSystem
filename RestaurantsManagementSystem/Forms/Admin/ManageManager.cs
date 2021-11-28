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
    public partial class ManageManager : Form
    {
        public ManageManager()
        {
            InitializeComponent();
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


        private void btnAddManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddManager());
            btnAddManager.Enabled = false;
        }

        private void btnViewManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewEmployee((int)User.UserTypeEnum.Manager));
        }
    }
}
