
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
            this.cbTimeShedule = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSalary = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnEmployeeInformation = new System.Windows.Forms.Button();
            this.panelAddManageruser.SuspendLayout();
            this.panelAddManagerInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panelAddManagerInformation.Controls.Add(this.btnEmployeeInformation);
            this.panelAddManagerInformation.Controls.Add(this.cbTimeShedule);
            this.panelAddManagerInformation.Controls.Add(this.label9);
            this.panelAddManagerInformation.Controls.Add(this.cbSalary);
            this.panelAddManagerInformation.Controls.Add(this.label8);
            this.panelAddManagerInformation.Controls.Add(this.txtEmail);
            this.panelAddManagerInformation.Controls.Add(this.label7);
            this.panelAddManagerInformation.Controls.Add(this.txtPhonenumber);
            this.panelAddManagerInformation.Controls.Add(this.label6);
            this.panelAddManagerInformation.Controls.Add(this.groupBox1);
            this.panelAddManagerInformation.Controls.Add(this.label5);
            this.panelAddManagerInformation.Controls.Add(this.txtLastName);
            this.panelAddManagerInformation.Controls.Add(this.label4);
            this.panelAddManagerInformation.Controls.Add(this.txtFirstName);
            this.panelAddManagerInformation.Controls.Add(this.label3);
            this.panelAddManagerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddManagerInformation.Location = new System.Drawing.Point(0, 100);
            this.panelAddManagerInformation.Name = "panelAddManagerInformation";
            this.panelAddManagerInformation.Size = new System.Drawing.Size(924, 350);
            this.panelAddManagerInformation.TabIndex = 1;
            // 
            // cbTimeShedule
            // 
            this.cbTimeShedule.FormattingEnabled = true;
            this.cbTimeShedule.Items.AddRange(new object[] {
            "10 am - 3 pm",
            "3pm - 10 am"});
            this.cbTimeShedule.Location = new System.Drawing.Point(107, 217);
            this.cbTimeShedule.Name = "cbTimeShedule";
            this.cbTimeShedule.Size = new System.Drawing.Size(150, 23);
            this.cbTimeShedule.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Time Shedule";
            // 
            // cbSalary
            // 
            this.cbSalary.FormattingEnabled = true;
            this.cbSalary.Items.AddRange(new object[] {
            "10000",
            "12000",
            "15000",
            "20000",
            "25000"});
            this.cbSalary.Location = new System.Drawing.Point(107, 176);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(150, 23);
            this.cbSalary.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Salary";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(107, 111);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(150, 23);
            this.txtPhonenumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(113, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 39);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(78, 14);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 19);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(11, 12);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(113, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 23);
            this.txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 23);
            this.txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // btnEmployeeInformation
            // 
            this.btnEmployeeInformation.Location = new System.Drawing.Point(343, 235);
            this.btnEmployeeInformation.Name = "btnEmployeeInformation";
            this.btnEmployeeInformation.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeInformation.TabIndex = 16;
            this.btnEmployeeInformation.Text = "Add";
            this.btnEmployeeInformation.UseVisualStyleBackColor = true;
            this.btnEmployeeInformation.Click += new System.EventHandler(this.btnEmployeeInformation_Click);
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
            this.panelAddManagerInformation.ResumeLayout(false);
            this.panelAddManagerInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbTimeShedule;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnEmployeeInformation;
    }
}