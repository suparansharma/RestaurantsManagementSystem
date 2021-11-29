
namespace Presentation.Forms.Manager
{
    partial class ViewFood
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
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFoodType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFood.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowTemplate.Height = 25;
            this.dataGridViewFood.Size = new System.Drawing.Size(929, 209);
            this.dataGridViewFood.TabIndex = 0;
            this.dataGridViewFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFood_CellContentClick);
            this.dataGridViewFood.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFood_CellMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Food Name";
            // 
            // cbFoodType
            // 
            this.cbFoodType.FormattingEnabled = true;
            this.cbFoodType.Items.AddRange(new object[] {
            "Burger",
            "Pizza",
            "Coffee"});
            this.cbFoodType.Location = new System.Drawing.Point(94, 266);
            this.cbFoodType.Name = "cbFoodType";
            this.cbFoodType.Size = new System.Drawing.Size(150, 23);
            this.cbFoodType.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBig);
            this.groupBox2.Controls.Add(this.rbMedium);
            this.groupBox2.Controls.Add(this.rbSmall);
            this.groupBox2.Location = new System.Drawing.Point(88, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 39);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(165, 14);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(42, 19);
            this.rbBig.TabIndex = 2;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Big";
            this.rbBig.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(87, 14);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(70, 19);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(11, 12);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(54, 19);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Size";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(459, 212);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 23);
            this.txtPrice.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Food Type";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(95, 295);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(150, 23);
            this.txtFoodName.TabIndex = 37;
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(419, 398);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFood.TabIndex = 47;
            this.btnUpdateFood.Text = "Update";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(456, 259);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 73);
            this.txtDescription.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Description";
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(512, 398);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 48;
            this.btnDeleteFood.Text = "Delete Food";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Food Id";
            // 
            // txtFoodId
            // 
            this.txtFoodId.Location = new System.Drawing.Point(95, 232);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(150, 23);
            this.txtFoodId.TabIndex = 50;
            // 
            // ViewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.txtFoodId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnUpdateFood);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFoodType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.dataGridViewFood);
            this.Name = "ViewFood";
            this.Text = "ViewFood";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFoodType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodId;
    }
}