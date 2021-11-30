
namespace Presentation.Forms.Admin
{
    partial class Admin
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
            this.panelAdminTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelAdminLeft = new System.Windows.Forms.Panel();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnManageFood = new System.Windows.Forms.Button();
            this.panelManageEmployee = new System.Windows.Forms.Panel();
            this.btnChef = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelAdminMain = new System.Windows.Forms.Panel();
            this.panelAdminTop.SuspendLayout();
            this.panelAdminLeft.SuspendLayout();
            this.panelManageEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdminTop
            // 
            this.panelAdminTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelAdminTop.Controls.Add(this.btnLogout);
            this.panelAdminTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminTop.Location = new System.Drawing.Point(0, 0);
            this.panelAdminTop.Name = "panelAdminTop";
            this.panelAdminTop.Size = new System.Drawing.Size(931, 75);
            this.panelAdminTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(791, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelAdminLeft
            // 
            this.panelAdminLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelAdminLeft.Controls.Add(this.btnManageOrder);
            this.panelAdminLeft.Controls.Add(this.btnManageFood);
            this.panelAdminLeft.Controls.Add(this.panelManageEmployee);
            this.panelAdminLeft.Controls.Add(this.btnManageEmployee);
            this.panelAdminLeft.Controls.Add(this.btnDashboard);
            this.panelAdminLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminLeft.Location = new System.Drawing.Point(0, 75);
            this.panelAdminLeft.Name = "panelAdminLeft";
            this.panelAdminLeft.Size = new System.Drawing.Size(200, 422);
            this.panelAdminLeft.TabIndex = 1;
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.BackColor = System.Drawing.Color.Aqua;
            this.btnManageOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageOrder.Location = new System.Drawing.Point(0, 155);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(200, 36);
            this.btnManageOrder.TabIndex = 4;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageOrder.UseVisualStyleBackColor = false;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnManageFood
            // 
            this.btnManageFood.BackColor = System.Drawing.Color.Aqua;
            this.btnManageFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageFood.Location = new System.Drawing.Point(0, 119);
            this.btnManageFood.Name = "btnManageFood";
            this.btnManageFood.Size = new System.Drawing.Size(200, 36);
            this.btnManageFood.TabIndex = 3;
            this.btnManageFood.Text = "Manage Food";
            this.btnManageFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageFood.UseVisualStyleBackColor = false;
            this.btnManageFood.Click += new System.EventHandler(this.btnManageFood_Click);
            // 
            // panelManageEmployee
            // 
            this.panelManageEmployee.Controls.Add(this.btnChef);
            this.panelManageEmployee.Controls.Add(this.btnManager);
            this.panelManageEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageEmployee.Location = new System.Drawing.Point(0, 72);
            this.panelManageEmployee.Name = "panelManageEmployee";
            this.panelManageEmployee.Size = new System.Drawing.Size(200, 47);
            this.panelManageEmployee.TabIndex = 2;
            // 
            // btnChef
            // 
            this.btnChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChef.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChef.Location = new System.Drawing.Point(0, 23);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(200, 23);
            this.btnChef.TabIndex = 1;
            this.btnChef.Text = "Chef";
            this.btnChef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChef.UseVisualStyleBackColor = false;
            this.btnChef.Click += new System.EventHandler(this.btnChef_Click);
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManager.Location = new System.Drawing.Point(0, 0);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(200, 23);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "Manager";
            this.btnManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.BackColor = System.Drawing.Color.Aqua;
            this.btnManageEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployee.Location = new System.Drawing.Point(0, 36);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(200, 36);
            this.btnManageEmployee.TabIndex = 1;
            this.btnManageEmployee.Text = "Manage Employee";
            this.btnManageEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployee.UseVisualStyleBackColor = false;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 36);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panelAdminMain
            // 
            this.panelAdminMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminMain.Location = new System.Drawing.Point(200, 75);
            this.panelAdminMain.Name = "panelAdminMain";
            this.panelAdminMain.Size = new System.Drawing.Size(731, 422);
            this.panelAdminMain.TabIndex = 2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 497);
            this.Controls.Add(this.panelAdminMain);
            this.Controls.Add(this.panelAdminLeft);
            this.Controls.Add(this.panelAdminTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panelAdminTop.ResumeLayout(false);
            this.panelAdminLeft.ResumeLayout(false);
            this.panelManageEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelAdminLeft;
        private System.Windows.Forms.Button btnManageFood;
        private System.Windows.Forms.Panel panelManageEmployee;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnManageEmployee;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelAdminMain;
        private System.Windows.Forms.Button btnManageOrder;
    }
}