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
    public partial class ViewOrder : Form
    {
        DataAccess dataaccess = new DataAccess();
        public ViewOrder()
        {
            InitializeComponent();
            dataaccess.GetAllOrder(dataGridViewOrder);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var details = dataGridViewOrder.SelectedRows[0].Cells[1].Value.ToString();
            rtborderview.Text = details;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Resturant maangement Sytem", new Font("Times New Roman", 24, FontStyle.Bold), Brushes.DarkGray, new Point(50, 25));
            e.Graphics.DrawString(rtborderview.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.DarkGray, new Point(50, 100));

        }
    }
}
