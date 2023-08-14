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
            btnSearchTicket = new Button();
            SuspendLayout();
            // 
            // lblNavigationHeader
            // 
            lblNavigationHeader.AutoSize = true;
            lblNavigationHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNavigationHeader.Location = new Point(337, 33);
            lblNavigationHeader.Name = "lblNavigationHeader";
            lblNavigationHeader.Size = new Size(283, 46);
            lblNavigationHeader.TabIndex = 0;
            lblNavigationHeader.Text = "Navigation Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(375, 107);
            label1.Name = "label1";
            label1.Size = new Size(170, 35);
            label1.TabIndex = 1;
            label1.Text = "Departments";
            // 
            // btnCallCentre
            // 
            btnCallCentre.Location = new Point(339, 193);
            btnCallCentre.Margin = new Padding(3, 4, 3, 4);
            btnCallCentre.Name = "btnCallCentre";
            btnCallCentre.Size = new Size(216, 44);
            btnCallCentre.TabIndex = 2;
            btnCallCentre.Text = "Call Centre";
            btnCallCentre.UseVisualStyleBackColor = true;
            btnCallCentre.Click += btnCallCentre_Click;
            // 
            // btnServiceDepartment
            // 
            btnServiceDepartment.Location = new Point(339, 264);
            btnServiceDepartment.Margin = new Padding(3, 4, 3, 4);
            btnServiceDepartment.Name = "btnServiceDepartment";
            btnServiceDepartment.Size = new Size(216, 44);
            btnServiceDepartment.TabIndex = 3;
            btnServiceDepartment.Text = "Service Department";
            btnServiceDepartment.UseVisualStyleBackColor = true;
            btnServiceDepartment.Click += btnServiceDepartment_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(339, 395);
            btnEmployees.Margin = new Padding(3, 4, 3, 4);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(216, 44);
            btnEmployees.TabIndex = 4;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnContracts
            // 
            btnContracts.Location = new Point(337, 471);
            btnContracts.Margin = new Padding(3, 4, 3, 4);
            btnContracts.Name = "btnContracts";
            btnContracts.Size = new Size(216, 44);
            btnContracts.TabIndex = 5;
            btnContracts.Text = "Contracts";
            btnContracts.UseVisualStyleBackColor = true;
            btnContracts.Click += btnContracts_Click;
            // 
            // btnSearchTicket
            // 
            btnSearchTicket.Location = new Point(12, 556);
            btnSearchTicket.Margin = new Padding(3, 4, 3, 4);
            btnSearchTicket.Name = "btnSearchTicket";
            btnSearchTicket.Size = new Size(103, 31);
            btnSearchTicket.TabIndex = 10;
            btnSearchTicket.Text = "Back";
            btnSearchTicket.UseVisualStyleBackColor = true;
            // 
            // frmNavigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSearchTicket);
            Controls.Add(btnContracts);
            Controls.Add(btnEmployees);
            Controls.Add(btnServiceDepartment);
            Controls.Add(btnCallCentre);
            Controls.Add(label1);
            Controls.Add(lblNavigationHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNavigation";
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
        private Button btnSearchTicket;
    }
}