namespace Premier_Service_Solutions
{
    partial class frmEmployeeCenter
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
            this.lblEmployeeCenter = new System.Windows.Forms.Label();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnExistingEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeCenter
            // 
            this.lblEmployeeCenter.AutoSize = true;
            this.lblEmployeeCenter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeCenter.Location = new System.Drawing.Point(312, 25);
            this.lblEmployeeCenter.Name = "lblEmployeeCenter";
            this.lblEmployeeCenter.Size = new System.Drawing.Size(235, 37);
            this.lblEmployeeCenter.TabIndex = 0;
            this.lblEmployeeCenter.Text = "Employee Centre";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(249, 174);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(138, 67);
            this.btnNewEmployee.TabIndex = 1;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnExistingEmployee
            // 
            this.btnExistingEmployee.Location = new System.Drawing.Point(437, 174);
            this.btnExistingEmployee.Name = "btnExistingEmployee";
            this.btnExistingEmployee.Size = new System.Drawing.Size(138, 67);
            this.btnExistingEmployee.TabIndex = 2;
            this.btnExistingEmployee.Text = "Existing Employee";
            this.btnExistingEmployee.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExistingEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.lblEmployeeCenter);
            this.Name = "frmEmployeeCenter";
            this.Text = "frmEmployeeCenter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmployeeCenter;
        private Button btnNewEmployee;
        private Button btnExistingEmployee;
    }
}