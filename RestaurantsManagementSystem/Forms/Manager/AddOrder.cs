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
            txtTotalPrice.Enabled = false;
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
            int total = Int32.Parse(txtTotalPrice.Text) + price * Int32.Parse(quantity);
            txtTotalPrice.Text = total.ToString();
            
            rtbOrders.AppendText("\n"+foodName + "           " + foodSize + "    " + quantity+ "   " + price + "\n");
        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var foodType = cbItemType.SelectedItem;
            dataAccess.GetFoodCombo(cbItemName, foodType.ToString());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbOrders.AppendText("\n Total Price" + txtTotalPrice.Text);
            bool isInstert = dataAccess.InsertOrrder(rtbOrders.Text, Int32.Parse(txtTotalPrice.Text));
            if (isInstert)
            {
                MessageBox.Show("Order Confirmed");
                btnPrint.Enabled = true;
            }
            else
            {
                MessageBox.Show("Order Failed");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Resturant maangement Sytem", new Font("Times New Roman", 24, FontStyle.Bold), Brushes.DarkGray, new Point(50,25));
            e.Graphics.DrawString(rtbOrders.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.DarkGray, new Point(50, 100));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
