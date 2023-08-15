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
            this.btnClear = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeCenter
            // 
            this.lblEmployeeCenter.AutoSize = true;
            this.lblEmployeeCenter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeCenter.Location = new System.Drawing.Point(283, 35);
            this.lblEmployeeCenter.Name = "lblEmployeeCenter";
            this.lblEmployeeCenter.Size = new System.Drawing.Size(235, 37);
            this.lblEmployeeCenter.TabIndex = 0;
            this.lblEmployeeCenter.Text = "Employee Centre";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(204, 195);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(158, 89);
            this.btnNewEmployee.TabIndex = 1;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            // 
            // btnExistingEmployee
            // 
            this.btnExistingEmployee.Location = new System.Drawing.Point(418, 195);
            this.btnExistingEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExistingEmployee.Name = "btnExistingEmployee";
            this.btnExistingEmployee.Size = new System.Drawing.Size(158, 89);
            this.btnExistingEmployee.TabIndex = 2;
            this.btnExistingEmployee.Text = "Existing Employee";
            this.btnExistingEmployee.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 550);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 37);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Back";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.White;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(12, 13);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(32, 34);
            this.btn.TabIndex = 21;
            this.btn.Text = "<";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // frmEmployeeCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnExistingEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.lblEmployeeCenter);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployeeCenter";
            this.Text = "Employee Center";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmployeeCenter;
        private Button btnNewEmployee;
        private Button btnExistingEmployee;
        private Button btnClear;
        private Button btn;
    }
}