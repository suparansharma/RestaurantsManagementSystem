
namespace Presentation.Forms.Manager
{
    partial class ManageFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelFoodManageButtomArea = new System.Windows.Forms.Panel();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFoodManageButtomArea.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Manage";
            // 
            // panelFoodManageButtomArea
            // 
            this.panelFoodManageButtomArea.Controls.Add(this.btnViewFood);
            this.panelFoodManageButtomArea.Controls.Add(this.btnAddFood);
            this.panelFoodManageButtomArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFoodManageButtomArea.Location = new System.Drawing.Point(0, 371);
            this.panelFoodManageButtomArea.Name = "panelFoodManageButtomArea";
            this.panelFoodManageButtomArea.Size = new System.Drawing.Size(800, 79);
            this.panelFoodManageButtomArea.TabIndex = 1;
            // 
            // btnViewFood
            // 
            this.btnViewFood.Location = new System.Drawing.Point(391, 27);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(75, 23);
            this.btnViewFood.TabIndex = 1;
            this.btnViewFood.Text = "View Food";
            this.btnViewFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(286, 27);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 371);
            this.panel1.TabIndex = 2;
            // 
            // ManageFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFoodManageButtomArea);
            this.Name = "ManageFood";
            this.Text = "ManageFood";
            this.panelFoodManageButtomArea.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFoodManageButtomArea;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel1;
    }
}