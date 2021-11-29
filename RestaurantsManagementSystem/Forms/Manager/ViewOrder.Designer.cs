
namespace Presentation.Forms.Manager
{
    partial class ViewOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrder));
            this.panelorderdata = new System.Windows.Forms.Panel();
            this.panelordertable = new System.Windows.Forms.Panel();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.rtborderview = new System.Windows.Forms.RichTextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panelorderdata.SuspendLayout();
            this.panelordertable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelorderdata
            // 
            this.panelorderdata.Controls.Add(this.rtborderview);
            this.panelorderdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelorderdata.Location = new System.Drawing.Point(0, 271);
            this.panelorderdata.Name = "panelorderdata";
            this.panelorderdata.Size = new System.Drawing.Size(922, 216);
            this.panelorderdata.TabIndex = 0;
            // 
            // panelordertable
            // 
            this.panelordertable.Controls.Add(this.dataGridViewOrder);
            this.panelordertable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelordertable.Location = new System.Drawing.Point(0, 0);
            this.panelordertable.Name = "panelordertable";
            this.panelordertable.Size = new System.Drawing.Size(922, 233);
            this.panelordertable.TabIndex = 1;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 25;
            this.dataGridViewOrder.Size = new System.Drawing.Size(922, 233);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // rtborderview
            // 
            this.rtborderview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtborderview.Location = new System.Drawing.Point(0, 0);
            this.rtborderview.Name = "rtborderview";
            this.rtborderview.Size = new System.Drawing.Size(922, 216);
            this.rtborderview.TabIndex = 0;
            this.rtborderview.Text = "";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(618, 242);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 487);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelordertable);
            this.Controls.Add(this.panelorderdata);
            this.Name = "ViewOrder";
            this.Text = "ViewOrder";
            this.panelorderdata.ResumeLayout(false);
            this.panelordertable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelorderdata;
        private System.Windows.Forms.Panel panelordertable;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.RichTextBox rtborderview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrint;
    }
}