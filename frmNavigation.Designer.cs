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
            this.lblNavigationHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCallCentre = new System.Windows.Forms.Button();
            this.btnServiceDepartment = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNavigationHeader
            // 
            this.lblNavigationHeader.AutoSize = true;
            this.lblNavigationHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavigationHeader.Location = new System.Drawing.Point(295, 25);
            this.lblNavigationHeader.Name = "lblNavigationHeader";
            this.lblNavigationHeader.Size = new System.Drawing.Size(230, 37);
            this.lblNavigationHeader.TabIndex = 0;
            this.lblNavigationHeader.Text = "Navigation Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departments";
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.Location = new System.Drawing.Point(297, 145);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(189, 33);
            this.btnCallCentre.TabIndex = 2;
            this.btnCallCentre.Text = "Call Centre";
            this.btnCallCentre.UseVisualStyleBackColor = true;
            this.btnCallCentre.Click += new System.EventHandler(this.btnCallCentre_Click_1);
            // 
            // btnServiceDepartment
            // 
            this.btnServiceDepartment.Location = new System.Drawing.Point(297, 198);
            this.btnServiceDepartment.Name = "btnServiceDepartment";
            this.btnServiceDepartment.Size = new System.Drawing.Size(189, 33);
            this.btnServiceDepartment.TabIndex = 3;
            this.btnServiceDepartment.Text = "Service Department";
            this.btnServiceDepartment.UseVisualStyleBackColor = true;
            this.btnServiceDepartment.Click += new System.EventHandler(this.btnServiceDepartment_Click_1);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(297, 296);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(189, 33);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click_1);
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(295, 353);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(189, 33);
            this.btnContracts.TabIndex = 5;
            this.btnContracts.Text = "Contracts";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click_1);
            // 
            // frmNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnServiceDepartment);
            this.Controls.Add(this.btnCallCentre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNavigationHeader);
            this.Name = "frmNavigation";
            this.Text = "Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

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