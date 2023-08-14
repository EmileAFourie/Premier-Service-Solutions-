namespace Premier_Service_Solutions
{
    partial class frmExistingEmployeeDetails
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblExistingEmployee = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtbxEmployeeID = new System.Windows.Forms.TextBox();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAssignedTickets = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateReport.Location = new System.Drawing.Point(577, 415);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(111, 23);
            this.btnGenerateReport.TabIndex = 25;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(12, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(76, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Age:";
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(129, 265);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(354, 23);
            this.txtbxAge.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(54, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Position:";
            // 
            // txtbxPosition
            // 
            this.txtbxPosition.Location = new System.Drawing.Point(129, 225);
            this.txtbxPosition.Name = "txtbxPosition";
            this.txtbxPosition.Size = new System.Drawing.Size(354, 23);
            this.txtbxPosition.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email:";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(129, 180);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(354, 23);
            this.txtbxEmail.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(65, 142);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(129, 139);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(354, 23);
            this.txtbxName.TabIndex = 16;
            // 
            // lblExistingEmployee
            // 
            this.lblExistingEmployee.AutoSize = true;
            this.lblExistingEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExistingEmployee.Location = new System.Drawing.Point(236, 34);
            this.lblExistingEmployee.Name = "lblExistingEmployee";
            this.lblExistingEmployee.Size = new System.Drawing.Size(347, 37);
            this.lblExistingEmployee.TabIndex = 15;
            this.lblExistingEmployee.Text = "Existing Employee Details";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeID.Location = new System.Drawing.Point(33, 105);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(77, 15);
            this.lblEmployeeID.TabIndex = 14;
            this.lblEmployeeID.Text = "EmployeeID:";
            // 
            // txtbxEmployeeID
            // 
            this.txtbxEmployeeID.Location = new System.Drawing.Point(129, 102);
            this.txtbxEmployeeID.Name = "txtbxEmployeeID";
            this.txtbxEmployeeID.Size = new System.Drawing.Size(354, 23);
            this.txtbxEmployeeID.TabIndex = 13;
            // 
            // lblPerformance
            // 
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPerformance.Location = new System.Drawing.Point(28, 307);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(83, 15);
            this.lblPerformance.TabIndex = 27;
            this.lblPerformance.Text = "Performance:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 23);
            this.textBox1.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(262, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblAssignedTickets
            // 
            this.lblAssignedTickets.AutoSize = true;
            this.lblAssignedTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssignedTickets.Location = new System.Drawing.Point(589, 87);
            this.lblAssignedTickets.Name = "lblAssignedTickets";
            this.lblAssignedTickets.Size = new System.Drawing.Size(99, 15);
            this.lblAssignedTickets.TabIndex = 29;
            this.lblAssignedTickets.Text = "Assigned Tickets";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(519, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 293);
            this.dataGridView1.TabIndex = 30;
            // 
            // frmExistingEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAssignedTickets);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPerformance);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblExistingEmployee);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtbxEmployeeID);
            this.Name = "frmExistingEmployeeDetails";
            this.Text = "Existing Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerateReport;
        private Button btnDelete;
        private Label label6;
        private TextBox txtbxAge;
        private Label label5;
        private TextBox txtbxPosition;
        private Label label4;
        private TextBox txtbxEmail;
        private Label lblName;
        private TextBox txtbxName;
        private Label lblExistingEmployee;
        private Label lblEmployeeID;
        private TextBox txtbxEmployeeID;
        private Label lblPerformance;
        private TextBox textBox1;
        private Button btnUpdate;
        private Label lblAssignedTickets;
        private DataGridView dataGridView1;
    }
}