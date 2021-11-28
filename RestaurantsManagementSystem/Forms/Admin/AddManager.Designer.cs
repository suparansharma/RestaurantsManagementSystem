
namespace Presentation.Forms.Admin
{
    partial class AddManager
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
            this.panelAddManageruser = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddManagerIdpass = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddManagerInformation = new System.Windows.Forms.Panel();
            this.panelAddManageruser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddManageruser
            // 
            this.panelAddManageruser.Controls.Add(this.txtPassword);
            this.panelAddManageruser.Controls.Add(this.label2);
            this.panelAddManageruser.Controls.Add(this.btnAddManagerIdpass);
            this.panelAddManageruser.Controls.Add(this.txtUserId);
            this.panelAddManageruser.Controls.Add(this.label1);
            this.panelAddManageruser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddManageruser.Location = new System.Drawing.Point(0, 0);
            this.panelAddManageruser.Name = "panelAddManageruser";
            this.panelAddManageruser.Size = new System.Drawing.Size(924, 100);
            this.panelAddManageruser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnAddManagerIdpass
            // 
            this.btnAddManagerIdpass.Location = new System.Drawing.Point(563, 52);
            this.btnAddManagerIdpass.Name = "btnAddManagerIdpass";
            this.btnAddManagerIdpass.Size = new System.Drawing.Size(75, 23);
            this.btnAddManagerIdpass.TabIndex = 2;
            this.btnAddManagerIdpass.Text = "Next";
            this.btnAddManagerIdpass.UseVisualStyleBackColor = true;
            this.btnAddManagerIdpass.Click += new System.EventHandler(this.btnAddManagerIdpass_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(124, 10);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(150, 23);
            this.txtUserId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id";
            // 
            // panelAddManagerInformation
            // 
            this.panelAddManagerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddManagerInformation.Location = new System.Drawing.Point(0, 100);
            this.panelAddManagerInformation.Name = "panelAddManagerInformation";
            this.panelAddManagerInformation.Size = new System.Drawing.Size(924, 350);
            this.panelAddManagerInformation.TabIndex = 1;
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.panelAddManagerInformation);
            this.Controls.Add(this.panelAddManageruser);
            this.Name = "AddManager";
            this.Text = "AddManager";
            this.panelAddManageruser.ResumeLayout(false);
            this.panelAddManageruser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddManageruser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddManagerIdpass;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAddManagerInformation;
    }
}