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
    public partial class Managechef : Form
    {
        public Managechef()
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
            panelChefMain.Controls.Add(childForm);
            panelChefMain.Tag = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddChef_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddChef());
            btnAddChef.Enabled = false;
        }

        private void btnViewchef_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewEmployee((int)User.UserTypeEnum.Chef));

        }
    }
}
