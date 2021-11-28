
namespace Presentation.Forms.Admin
{
    partial class Managechef
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddChef = new System.Windows.Forms.Button();
            this.btnViewchef = new System.Windows.Forms.Button();
            this.panelChefMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelChefMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddChef);
            this.panel1.Controls.Add(this.btnViewchef);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnAddChef
            // 
            this.btnAddChef.Location = new System.Drawing.Point(325, 22);
            this.btnAddChef.Name = "btnAddChef";
            this.btnAddChef.Size = new System.Drawing.Size(75, 23);
            this.btnAddChef.TabIndex = 1;
            this.btnAddChef.Text = "Add Chef";
            this.btnAddChef.UseVisualStyleBackColor = true;
            this.btnAddChef.Click += new System.EventHandler(this.btnAddChef_Click);
            // 
            // btnViewchef
            // 
            this.btnViewchef.Location = new System.Drawing.Point(431, 22);
            this.btnViewchef.Name = "btnViewchef";
            this.btnViewchef.Size = new System.Drawing.Size(75, 23);
            this.btnViewchef.TabIndex = 0;
            this.btnViewchef.Text = "View chef";
            this.btnViewchef.UseVisualStyleBackColor = true;
            // 
            // panelChefMain
            // 
            this.panelChefMain.Controls.Add(this.label1);
            this.panelChefMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChefMain.Location = new System.Drawing.Point(0, 0);
            this.panelChefMain.Name = "panelChefMain";
            this.panelChefMain.Size = new System.Drawing.Size(800, 393);
            this.panelChefMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To Chef";
            // 
            // Managechef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChefMain);
            this.Controls.Add(this.panel1);
            this.Name = "Managechef";
            this.Text = "ManageShafe";
            this.panel1.ResumeLayout(false);
            this.panelChefMain.ResumeLayout(false);
            this.panelChefMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewchef;
        private System.Windows.Forms.Button btnAddChef;
        private System.Windows.Forms.Panel panelChefMain;
        private System.Windows.Forms.Label label1;
    }
}