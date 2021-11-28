
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
            this.panelviewemployeedata = new System.Windows.Forms.Panel();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.panelviewemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
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
            // panelviewemployeedata
            // 
            this.panelviewemployeedata.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelviewemployeedata.Location = new System.Drawing.Point(0, 216);
            this.panelviewemployeedata.Name = "panelviewemployeedata";
            this.panelviewemployeedata.Size = new System.Drawing.Size(962, 216);
            this.panelviewemployeedata.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelviewemployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Panel panelviewemployeedata;
    }
}