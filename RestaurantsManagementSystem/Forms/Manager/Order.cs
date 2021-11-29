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
    public partial class Order : Form
    {
        public Order()
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
            panelOrderMain.Controls.Add(childForm);
            panelOrderMain.Tag = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddOrder());
            btnAddNewOrder.Enabled = false;
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewOrder());
        }
    }
}
