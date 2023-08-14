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
            lblEmployeeCenter = new Label();
            btnNewEmployee = new Button();
            btnExistingEmployee = new Button();
            btnClear = new Button();

            SuspendLayout();
            // 
            // lblEmployeeCenter
            // 
            lblEmployeeCenter.AutoSize = true;
            lblEmployeeCenter.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeeCenter.Location = new Point(357, 33);
            lblEmployeeCenter.Name = "lblEmployeeCenter";
            lblEmployeeCenter.Size = new Size(289, 46);
            lblEmployeeCenter.TabIndex = 0;
            lblEmployeeCenter.Text = "Employee Centre";
            // 
            // btnNewEmployee
            // 
            btnNewEmployee.Location = new Point(285, 232);
            btnNewEmployee.Margin = new Padding(3, 4, 3, 4);
            btnNewEmployee.Name = "btnNewEmployee";
            btnNewEmployee.Size = new Size(158, 89);
            btnNewEmployee.TabIndex = 1;
            btnNewEmployee.Text = "New Employee";
            btnNewEmployee.UseVisualStyleBackColor = true;
            btnNewEmployee.Click += btnNewEmployee_Click;
            // 
            // btnExistingEmployee
            // 
            btnExistingEmployee.Location = new Point(499, 232);
            btnExistingEmployee.Margin = new Padding(3, 4, 3, 4);
            btnExistingEmployee.Name = "btnExistingEmployee";
            btnExistingEmployee.Size = new Size(158, 89);
            btnExistingEmployee.TabIndex = 2;
            btnExistingEmployee.Text = "Existing Employee";
            btnExistingEmployee.UseVisualStyleBackColor = true;

            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 550);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 37);
            btnClear.TabIndex = 5;
            btnClear.Text = "Back";
            btnClear.UseVisualStyleBackColor = true;

            btnExistingEmployee.Click += btnExistingEmployee_Click;
            // 
            // frmEmployeeCenter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);

            Controls.Add(btnClear);

            Controls.Add(btnExistingEmployee);
            Controls.Add(btnNewEmployee);
            Controls.Add(lblEmployeeCenter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEmployeeCenter";
            Text = "frmEmployeeCenter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployeeCenter;
        private Button btnNewEmployee;
        private Button btnExistingEmployee;
        private Button btnClear;
    }
}