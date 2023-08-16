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
            btnGenerateReport = new Button();
            btnDelete = new Button();
            lblExistingEmployee = new Label();
            lblEmployeeID = new Label();
            txtbxEmployeeID = new TextBox();
            btnUpdate = new Button();
            lblAssignedTickets = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label7 = new Label();
            txtField = new TextBox();
            label1 = new Label();
            txtCell = new TextBox();
            label6 = new Label();
            txtSurname = new TextBox();
            label5 = new Label();
            txtbxPosition = new TextBox();
            label4 = new Label();
            txtbxEmail = new TextBox();
            lblName = new Label();
            txtbxName = new TextBox();
            label2 = new Label();
            txtbxDepartment = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerateReport.Location = new Point(578, 557);
            btnGenerateReport.Margin = new Padding(3, 4, 3, 4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(127, 31);
            btnGenerateReport.TabIndex = 25;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(29, 570);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblExistingEmployee
            // 
            lblExistingEmployee.AutoSize = true;
            lblExistingEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblExistingEmployee.Location = new Point(270, 45);
            lblExistingEmployee.Name = "lblExistingEmployee";
            lblExistingEmployee.Size = new Size(347, 37);
            lblExistingEmployee.TabIndex = 15;
            lblExistingEmployee.Text = "Existing Employee Details";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeID.Location = new Point(37, 133);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(67, 13);
            lblEmployeeID.TabIndex = 14;
            lblEmployeeID.Text = "EmployeeID:";
            // 
            // txtbxEmployeeID
            // 
            txtbxEmployeeID.Enabled = false;
            txtbxEmployeeID.Location = new Point(146, 129);
            txtbxEmployeeID.Margin = new Padding(3, 4, 3, 4);
            txtbxEmployeeID.Name = "txtbxEmployeeID";
            txtbxEmployeeID.ReadOnly = true;
            txtbxEmployeeID.Size = new Size(180, 23);
            txtbxEmployeeID.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(146, 515);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblAssignedTickets
            // 
            lblAssignedTickets.AutoSize = true;
            lblAssignedTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssignedTickets.Location = new Point(592, 120);
            lblAssignedTickets.Name = "lblAssignedTickets";
            lblAssignedTickets.Size = new Size(99, 15);
            lblAssignedTickets.TabIndex = 29;
            lblAssignedTickets.Text = "Assigned Tickets";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(512, 144);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(274, 391);
            dataGridView1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 556);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 31;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(80, 471);
            label7.Name = "label7";
            label7.Size = new Size(32, 13);
            label7.TabIndex = 44;
            label7.Text = "Field:";
            // 
            // txtField
            // 
            txtField.Location = new Point(146, 463);
            txtField.Margin = new Padding(3, 4, 3, 4);
            txtField.Multiline = true;
            txtField.Name = "txtField";
            txtField.Size = new Size(181, 23);
            txtField.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 316);
            label1.Name = "label1";
            label1.Size = new Size(41, 13);
            label1.TabIndex = 42;
            label1.Text = "Phone:";
            // 
            // txtCell
            // 
            txtCell.Location = new Point(146, 313);
            txtCell.Margin = new Padding(3, 4, 3, 4);
            txtCell.Name = "txtCell";
            txtCell.Size = new Size(181, 23);
            txtCell.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 221);
            label6.Name = "label6";
            label6.Size = new Size(55, 13);
            label6.TabIndex = 40;
            label6.Text = "Surname: ";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(146, 218);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(181, 23);
            txtSurname.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(62, 370);
            label5.Name = "label5";
            label5.Size = new Size(47, 13);
            label5.TabIndex = 38;
            label5.Text = "Position:";
            // 
            // txtbxPosition
            // 
            txtbxPosition.Location = new Point(146, 370);
            txtbxPosition.Margin = new Padding(3, 4, 3, 4);
            txtbxPosition.Name = "txtbxPosition";
            txtbxPosition.Size = new Size(181, 23);
            txtbxPosition.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(76, 267);
            label4.Name = "label4";
            label4.Size = new Size(35, 13);
            label4.TabIndex = 36;
            label4.Text = "Email:";
            // 
            // txtbxEmail
            // 
            txtbxEmail.Location = new Point(146, 264);
            txtbxEmail.Margin = new Padding(3, 4, 3, 4);
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(267, 23);
            txtbxEmail.TabIndex = 35;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(48, 174);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 13);
            lblName.TabIndex = 34;
            lblName.Text = "First Name:";
            // 
            // txtbxName
            // 
            txtbxName.Location = new Point(146, 171);
            txtbxName.Margin = new Padding(3, 4, 3, 4);
            txtbxName.Name = "txtbxName";
            txtbxName.Size = new Size(181, 23);
            txtbxName.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 412);
            label2.Name = "label2";
            label2.Size = new Size(68, 13);
            label2.TabIndex = 32;
            label2.Text = "Department: ";
            // 
            // txtbxDepartment
            // 
            txtbxDepartment.Location = new Point(146, 409);
            txtbxDepartment.Margin = new Padding(3, 4, 3, 4);
            txtbxDepartment.Name = "txtbxDepartment";
            txtbxDepartment.Size = new Size(181, 23);
            txtbxDepartment.TabIndex = 31;
            // 
            // frmExistingEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 646);
            Controls.Add(label7);
            Controls.Add(txtField);
            Controls.Add(label1);
            Controls.Add(txtCell);
            Controls.Add(label6);
            Controls.Add(txtSurname);
            Controls.Add(label5);
            Controls.Add(txtbxPosition);
            Controls.Add(label4);
            Controls.Add(txtbxEmail);
            Controls.Add(lblName);
            Controls.Add(txtbxName);
            Controls.Add(label2);
            Controls.Add(txtbxDepartment);
            Controls.Add(dataGridView1);
            Controls.Add(lblAssignedTickets);
            Controls.Add(btnUpdate);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnDelete);
            Controls.Add(lblExistingEmployee);
            Controls.Add(lblEmployeeID);
            Controls.Add(txtbxEmployeeID);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmExistingEmployeeDetails";
            Text = "Existing Employee Details";
            Load += frmExistingEmployeeDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateReport;
        private Button btnDelete;
        private Label lblExistingEmployee;
        private Label lblEmployeeID;
        private TextBox txtbxEmployeeID;
        private Button btnUpdate;
        private Label lblAssignedTickets;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label7;
        private TextBox txtField;
        private Label label1;
        private TextBox txtCell;
        private Label label6;
        private TextBox txtSurname;
        private Label label5;
        private TextBox txtbxPosition;
        private Label label4;
        private TextBox txtbxEmail;
        private Label lblName;
        private TextBox txtbxName;
        private Label label2;
        private TextBox txtbxDepartment;
    }
}