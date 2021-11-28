
namespace Presentation.Forms.Admin
{
    partial class ManageManager
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
            this.panelManagerBottom = new System.Windows.Forms.Panel();
            this.btnViewManager = new System.Windows.Forms.Button();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelManagerMain = new System.Windows.Forms.Panel();
            this.panelManagerBottom.SuspendLayout();
            this.panelManagerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManagerBottom
            // 
            this.panelManagerBottom.Controls.Add(this.btnViewManager);
            this.panelManagerBottom.Controls.Add(this.btnAddManager);
            this.panelManagerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelManagerBottom.Location = new System.Drawing.Point(0, 392);
            this.panelManagerBottom.Name = "panelManagerBottom";
            this.panelManagerBottom.Size = new System.Drawing.Size(888, 58);
            this.panelManagerBottom.TabIndex = 0;
            // 
            // btnViewManager
            // 
            this.btnViewManager.Location = new System.Drawing.Point(153, 14);
            this.btnViewManager.Name = "btnViewManager";
            this.btnViewManager.Size = new System.Drawing.Size(98, 23);
            this.btnViewManager.TabIndex = 1;
            this.btnViewManager.Text = "View Manager";
            this.btnViewManager.UseVisualStyleBackColor = true;
            // 
            // btnAddManager
            // 
            this.btnAddManager.Location = new System.Drawing.Point(23, 14);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(98, 23);
            this.btnAddManager.TabIndex = 0;
            this.btnAddManager.Text = "Add Manager";
            this.btnAddManager.UseVisualStyleBackColor = true;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Manager";
            // 
            // panelManagerMain
            // 
            this.panelManagerMain.Controls.Add(this.label1);
            this.panelManagerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagerMain.Location = new System.Drawing.Point(0, 0);
            this.panelManagerMain.Name = "panelManagerMain";
            this.panelManagerMain.Size = new System.Drawing.Size(888, 392);
            this.panelManagerMain.TabIndex = 2;
            // 
            // ManageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.panelManagerMain);
            this.Controls.Add(this.panelManagerBottom);
            this.Name = "ManageManager";
            this.Text = "ManageManager";
            this.panelManagerBottom.ResumeLayout(false);
            this.panelManagerMain.ResumeLayout(false);
            this.panelManagerMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManagerBottom;
        private System.Windows.Forms.Button btnViewManager;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelManagerMain;
    }
}