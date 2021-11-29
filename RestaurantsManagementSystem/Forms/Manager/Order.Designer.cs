
namespace Presentation.Forms.Manager
{
    partial class Order
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
            this.panelOrderBotoom = new System.Windows.Forms.Panel();
            this.panelOrderMain = new System.Windows.Forms.Panel();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOrderBotoom.SuspendLayout();
            this.panelOrderMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrderBotoom
            // 
            this.panelOrderBotoom.Controls.Add(this.btnViewOrder);
            this.panelOrderBotoom.Controls.Add(this.btnAddNewOrder);
            this.panelOrderBotoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrderBotoom.Location = new System.Drawing.Point(0, 392);
            this.panelOrderBotoom.Name = "panelOrderBotoom";
            this.panelOrderBotoom.Size = new System.Drawing.Size(800, 58);
            this.panelOrderBotoom.TabIndex = 0;
            // 
            // panelOrderMain
            // 
            this.panelOrderMain.Controls.Add(this.label1);
            this.panelOrderMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelOrderMain.Location = new System.Drawing.Point(0, 0);
            this.panelOrderMain.Name = "panelOrderMain";
            this.panelOrderMain.Size = new System.Drawing.Size(800, 392);
            this.panelOrderMain.TabIndex = 1;
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Location = new System.Drawing.Point(181, 7);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewOrder.TabIndex = 0;
            this.btnAddNewOrder.Text = "Add Order";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(296, 7);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnViewOrder.TabIndex = 1;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(350, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOrderMain);
            this.Controls.Add(this.panelOrderBotoom);
            this.Name = "Order";
            this.Text = "Order";
            this.panelOrderBotoom.ResumeLayout(false);
            this.panelOrderMain.ResumeLayout(false);
            this.panelOrderMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrderBotoom;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.Panel panelOrderMain;
        private System.Windows.Forms.Label label1;
    }
}