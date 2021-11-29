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
    public partial class ViewFood : Form
    {

        DataAccess dataAccess = new DataAccess();
        public ViewFood()
        {
            InitializeComponent();
            dataAccess.GetAllFood(dataGridViewFood);

        }

        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridViewFood_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dataGridViewFood.SelectedRows[0].Cells[0].Value.ToString();
            var foodName = dataGridViewFood.SelectedRows[0].Cells[1].Value.ToString();
            var Size = dataGridViewFood.SelectedRows[0].Cells[2].Value.ToString();
            string Price = dataGridViewFood.SelectedRows[0].Cells[3].Value.ToString();
            var foodType = dataGridViewFood.SelectedRows[0].Cells[4].Value.ToString();
            var description = dataGridViewFood.SelectedRows[0].Cells[5].Value.ToString();

            txtFoodId.Text = id;
            txtFoodName.Text = foodName;
            if (Size.Trim() == "Small")
            {
                rbSmall.Checked = true;
            }
            else if (Size.Trim() == "Medium")
            {
                rbMedium.Checked = true;
            }
            else
            {
                rbBig.Checked = true;
            }
             txtPrice.Text = Price;
            cbFoodType.Text = foodType;
            txtDescription.Text = description;
            
            
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {

            int foodId = Int32.Parse(txtFoodId.Text);
            string foodname = txtFoodName.Text;
            string foodSize;
            if (rbSmall.Checked)
            {
                foodSize = "Small";

            }
            else if (rbMedium.Checked)
            {
                foodSize = "Small";
            }
            else
            {
                foodSize = "Big";
            }
            int price = Int32.Parse(txtPrice.Text);
            string foodType = cbFoodType.Text;
            string description = txtDescription.Text;
            bool isFoodUpdate = dataAccess.UpdateFood(foodId, foodname, foodSize, price, foodType, description);
            if (isFoodUpdate)
            {
                MessageBox.Show("Upadte Successfully");
                dataAccess.GetAllFood(dataGridViewFood);

            }

            else
            {
                MessageBox.Show("Unsuccessfull & Try again");
            }

        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtFoodId.Text);
            bool isDeletefoodId = dataAccess.DeleteFood(id);
            if (isDeletefoodId)
            {
                MessageBox.Show("Delete Successfully");
                

            }

            else
            {
                MessageBox.Show(" Delete Unsuccessfull & Try again");
            }
        }
    }
}
