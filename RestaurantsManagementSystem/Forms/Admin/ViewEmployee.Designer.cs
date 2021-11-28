
namespace Presentation.Forms.Admin
{
    partial class ViewEmployee
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
            this.panelviewemployee = new System.Windows.Forms.Panel();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.panelviewemployeedata = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEployee = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJoinDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelviewemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.panelviewemployeedata.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelviewemployee
            // 
            this.panelviewemployee.Controls.Add(this.dataGridViewEmployee);
            this.panelviewemployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelviewemployee.Location = new System.Drawing.Point(0, 0);
            this.panelviewemployee.Name = "panelviewemployee";
            this.panelviewemployee.Size = new System.Drawing.Size(962, 216);
            this.panelviewemployee.TabIndex = 0;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowTemplate.Height = 25;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(962, 216);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewEmployee_MouseDoubleClick);
            // 
            // panelviewemployeedata
            // 
            this.panelviewemployeedata.Controls.Add(this.btnDeleteEmployee);
            this.panelviewemployeedata.Controls.Add(this.btnUpdateEployee);
            this.panelviewemployeedata.Controls.Add(this.txtUserId);
            this.panelviewemployeedata.Controls.Add(this.label2);
            this.panelviewemployeedata.Controls.Add(this.txtJoinDate);
            this.panelviewemployeedata.Controls.Add(this.label1);
            this.panelviewemployeedata.Controls.Add(this.cbTimeShedule);
            this.panelviewemployeedata.Controls.Add(this.label9);
            this.panelviewemployeedata.Controls.Add(this.cbSalary);
            this.panelviewemployeedata.Controls.Add(this.label8);
            this.panelviewemployeedata.Controls.Add(this.txtEmail);
            this.panelviewemployeedata.Controls.Add(this.label7);
            this.panelviewemployeedata.Controls.Add(this.txtPhonenumber);
            this.panelviewemployeedata.Controls.Add(this.label6);
            this.panelviewemployeedata.Controls.Add(this.groupBox1);
            this.panelviewemployeedata.Controls.Add(this.label5);
            this.panelviewemployeedata.Controls.Add(this.txtLastName);
            this.panelviewemployeedata.Controls.Add(this.label4);
            this.panelviewemployeedata.Controls.Add(this.txtFirstName);
            this.panelviewemployeedata.Controls.Add(this.label3);
            this.panelviewemployeedata.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelviewemployeedata.Location = new System.Drawing.Point(0, 216);
            this.panelviewemployeedata.Name = "panelviewemployeedata";
            this.panelviewemployeedata.Size = new System.Drawing.Size(962, 216);
            this.panelviewemployeedata.TabIndex = 1;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(734, 179);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 31;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEployee
            // 
            this.btnUpdateEployee.Location = new System.Drawing.Point(734, 128);
            this.btnUpdateEployee.Name = "btnUpdateEployee";
            this.btnUpdateEployee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEployee.TabIndex = 30;
            this.btnUpdateEployee.Text = "Update";
            this.btnUpdateEployee.UseVisualStyleBackColor = true;
            this.btnUpdateEployee.Click += new System.EventHandler(this.btnUpdateEployee_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(110, 23);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(150, 23);
            this.txtUserId.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Uer Id";
            // 
            // txtJoinDate
            // 
            this.txtJoinDate.Location = new System.Drawing.Point(419, 100);
            this.txtJoinDate.Name = "txtJoinDate";
            this.txtJoinDate.Size = new System.Drawing.Size(150, 23);
            this.txtJoinDate.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Join Date";
            // 
            // cbTimeShedule
            // 
            this.cbTimeShedule.FormattingEnabled = true;
            this.cbTimeShedule.Items.AddRange(new object[] {
            "10 am - 3 pm",
            "3pm - 10 am"});
            this.cbTimeShedule.Location = new System.Drawing.Point(419, 61);
            this.cbTimeShedule.Name = "cbTimeShedule";
            this.cbTimeShedule.Size = new System.Drawing.Size(150, 23);
            this.cbTimeShedule.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 24;
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
            this.cbSalary.Location = new System.Drawing.Point(419, 20);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(150, 23);
            this.cbSalary.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Salary";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 23);
            this.txtEmail.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(104, 149);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(150, 23);
            this.txtPhonenumber.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(110, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 39);
            this.groupBox1.TabIndex = 17;
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
            this.label5.Location = new System.Drawing.Point(40, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gender";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(110, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 23);
            this.txtLastName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 23);
            this.txtFirstName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 464);
            this.Controls.Add(this.panelviewemployeedata);
            this.Controls.Add(this.panelviewemployee);
            this.Name = "ViewEmployee";
            this.Text = "ViewEmployee";
            this.panelviewemployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.panelviewemployeedata.ResumeLayout(false);
            this.panelviewemployeedata.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelviewemployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Panel panelviewemployeedata;
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
        private System.Windows.Forms.ComboBox cbTimeShedule;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJoinDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEployee;
    }
}