
namespace Presentation.Forms.Manager
{
    partial class Manager
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
            this.panelManagerTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelManagerLeft = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnManageFood = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelManagerMain = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panelManagerTop.SuspendLayout();
            this.panelManagerLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManagerTop
            // 
            this.panelManagerTop.Controls.Add(this.btnLogout);
            this.panelManagerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManagerTop.Location = new System.Drawing.Point(0, 0);
            this.panelManagerTop.Name = "panelManagerTop";
            this.panelManagerTop.Size = new System.Drawing.Size(966, 75);
            this.panelManagerTop.TabIndex = 1;
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
            // panelManagerLeft
            // 
            this.panelManagerLeft.Controls.Add(this.btnProfile);
            this.panelManagerLeft.Controls.Add(this.btnOrder);
            this.panelManagerLeft.Controls.Add(this.btnManageFood);
            this.panelManagerLeft.Controls.Add(this.btnDashboard);
            this.panelManagerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManagerLeft.Location = new System.Drawing.Point(0, 75);
            this.panelManagerLeft.Name = "panelManagerLeft";
            this.panelManagerLeft.Size = new System.Drawing.Size(200, 445);
            this.panelManagerLeft.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.Location = new System.Drawing.Point(0, 72);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 36);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnManageFood
            // 
            this.btnManageFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageFood.Location = new System.Drawing.Point(0, 36);
            this.btnManageFood.Name = "btnManageFood";
            this.btnManageFood.Size = new System.Drawing.Size(200, 36);
            this.btnManageFood.TabIndex = 3;
            this.btnManageFood.Text = "Manage Food";
            this.btnManageFood.UseVisualStyleBackColor = true;
            this.btnManageFood.Click += new System.EventHandler(this.btnManageFood_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 36);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panelManagerMain
            // 
            this.panelManagerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagerMain.Location = new System.Drawing.Point(200, 75);
            this.panelManagerMain.Name = "panelManagerMain";
            this.panelManagerMain.Size = new System.Drawing.Size(766, 445);
            this.panelManagerMain.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Location = new System.Drawing.Point(0, 108);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 36);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 520);
            this.Controls.Add(this.panelManagerMain);
            this.Controls.Add(this.panelManagerLeft);
            this.Controls.Add(this.panelManagerTop);
            this.Name = "Manager";
            this.Text = "Manager";
            this.panelManagerTop.ResumeLayout(false);
            this.panelManagerLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelManagerLeft;
        private System.Windows.Forms.Button btnManageFood;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelManagerMain;
        private System.Windows.Forms.Panel panelManagerTop;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProfile;
    }
}