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
    public partial class AddOrder : Form
    {
        DataAccess dataAccess = new DataAccess();
        public AddOrder()
        {
            InitializeComponent();
            btnPrint.Enabled = false;

        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            var foodId = cbItemName.SelectedValue.ToString();
            Food food = dataAccess.GetFoodById(Int32.Parse(foodId));
            string foodName = food.foodName;
            var quantity = txtQuantity.Text;
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
            int price = food.Price;
            
            rtbOrders.AppendText("\n"+foodName + "           " + foodSize + "    " + quantity+ "   " + price + "\n");
        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foodType = cbItemType.SelectedItem;
            dataAccess.GetFoodCombo(cbItemName, foodType.ToString());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = true;
            
        }
    }
}
