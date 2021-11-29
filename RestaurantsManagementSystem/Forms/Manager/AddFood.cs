using Database;
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
    public partial class AddFood : Form
    {
        DataAccess dataAccess = new DataAccess();
        public AddFood()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            //panelManagerMain.Controls.Add(childForm);
            //panelManagerMain.Tag = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string foodType = cbFoodType.Text;
            string foodName = txtFoodName.Text;
            string foodSize;
            if (rbSmall.Checked)
            {
                foodSize = "Small";
            }
            else if (rbMedium.Checked)
            {
                foodSize = "Medium";
            }

            else
            {
                foodSize = "Big";
            }

            int price = Int32.Parse(txtPrice.Text);
              string description = txtDescription.Text;

            bool insertFood=dataAccess.InsertFood(foodName, foodSize, price, foodType, description);
            if (insertFood)
            {
                MessageBox.Show("Insert Successfully");
            }

            else
            {
                MessageBox.Show("Unsuccessfull & Try again");
            }




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
