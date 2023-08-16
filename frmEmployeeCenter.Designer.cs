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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeCenter));
            this.lblEmployeeCenter = new System.Windows.Forms.Label();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnExistingEmployee = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeCenter
            // 
            this.lblEmployeeCenter.AutoSize = true;
            this.lblEmployeeCenter.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeCenter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeCenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmployeeCenter.Location = new System.Drawing.Point(257, 33);
            this.lblEmployeeCenter.Name = "lblEmployeeCenter";
            this.lblEmployeeCenter.Size = new System.Drawing.Size(235, 37);
            this.lblEmployeeCenter.TabIndex = 0;
            this.lblEmployeeCenter.Text = "Employee Centre";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewEmployee.Location = new System.Drawing.Point(185, 184);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(158, 89);
            this.btnNewEmployee.TabIndex = 1;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnExistingEmployee
            // 
            this.btnExistingEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExistingEmployee.Location = new System.Drawing.Point(399, 184);
            this.btnExistingEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExistingEmployee.Name = "btnExistingEmployee";
            this.btnExistingEmployee.Size = new System.Drawing.Size(158, 89);
            this.btnExistingEmployee.TabIndex = 2;
            this.btnExistingEmployee.Text = "Existing Employee";
            this.btnExistingEmployee.UseVisualStyleBackColor = true;
            this.btnExistingEmployee.Click += new System.EventHandler(this.btnExistingEmployee_Click);
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
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 22);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEmployeeCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExistingEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.lblEmployeeCenter);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployeeCenter";
            this.Text = "frmEmployeeCenter";
            this.Load += new System.EventHandler(this.frmEmployeeCenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmployeeCenter;
        private Button btnNewEmployee;
        private Button btnExistingEmployee;
        private Button btnClear;
        private Button btnBack;
    }
}