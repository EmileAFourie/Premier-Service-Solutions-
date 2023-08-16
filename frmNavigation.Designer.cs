namespace Premier_Service_Solutions
{
    partial class frmNavigation
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
            lblNavigationHeader = new Label();
            label1 = new Label();
            btnCallCentre = new Button();
            btnServiceDepartment = new Button();
            btnEmployees = new Button();
            btnContracts = new Button();
            SuspendLayout();
            // 
            // lblNavigationHeader
            // 
            lblNavigationHeader.AutoSize = true;
            lblNavigationHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNavigationHeader.Location = new Point(295, 25);
            lblNavigationHeader.Name = "lblNavigationHeader";
            lblNavigationHeader.Size = new Size(230, 37);
            lblNavigationHeader.TabIndex = 0;
            lblNavigationHeader.Text = "Navigation Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 80);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 1;
            label1.Text = "Departments";
            // 
            // btnCallCentre
            // 
            btnCallCentre.Location = new Point(297, 145);
            btnCallCentre.Name = "btnCallCentre";
            btnCallCentre.Size = new Size(189, 33);
            btnCallCentre.TabIndex = 2;
            btnCallCentre.Text = "Call Centre";
            btnCallCentre.UseVisualStyleBackColor = true;
            btnCallCentre.Click += btnCallCentre_Click_1;
            // 
            // btnServiceDepartment
            // 
            btnServiceDepartment.Location = new Point(297, 198);
            btnServiceDepartment.Name = "btnServiceDepartment";
            btnServiceDepartment.Size = new Size(189, 33);
            btnServiceDepartment.TabIndex = 3;
            btnServiceDepartment.Text = "Service Department";
            btnServiceDepartment.UseVisualStyleBackColor = true;
            btnServiceDepartment.Click += btnServiceDepartment_Click_1;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(297, 296);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(189, 33);
            btnEmployees.TabIndex = 4;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click_1;
            // 
            // btnContracts
            // 
            btnContracts.Location = new Point(295, 353);
            btnContracts.Name = "btnContracts";
            btnContracts.Size = new Size(189, 33);
            btnContracts.TabIndex = 5;
            btnContracts.Text = "Contracts";
            btnContracts.UseVisualStyleBackColor = true;
            btnContracts.Click += btnContracts_Click_1;
            // 
            // frmNavigation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContracts);
            Controls.Add(btnEmployees);
            Controls.Add(btnServiceDepartment);
            Controls.Add(btnCallCentre);
            Controls.Add(label1);
            Controls.Add(lblNavigationHeader);
            Name = "frmNavigation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Navigation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNavigationHeader;
        private Label label1;
        private Button btnCallCentre;
        private Button btnServiceDepartment;
        private Button btnEmployees;
        private Button btnContracts;
    }
}