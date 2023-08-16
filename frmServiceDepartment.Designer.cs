namespace Premier_Service_Solutions
{
    partial class frmServiceDepartment
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
            lblServiceDepartment = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            lblUnassignedTickets = new Label();
            lblAssignedTickets = new Label();
            btnAssignTicket = new Button();
            btnEscalateTicket = new Button();
            btnUnassign = new Button();
            btnResolveJob = new Button();
            btnSearchTicket = new Button();
            txtbxSearchTicket = new TextBox();
            button1 = new Button();
            btnBack = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            lblUnassigned = new Label();
            lblAssigned = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblServiceDepartment
            // 
            lblServiceDepartment.AutoSize = true;
            lblServiceDepartment.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblServiceDepartment.Location = new Point(296, 27);
            lblServiceDepartment.Name = "lblServiceDepartment";
            lblServiceDepartment.Size = new Size(274, 37);
            lblServiceDepartment.TabIndex = 0;
            lblServiceDepartment.Text = "Service Department";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 111);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(320, 351);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 33);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(320, 351);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // lblUnassignedTickets
            // 
            lblUnassignedTickets.AutoSize = true;
            lblUnassignedTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnassignedTickets.Location = new Point(114, 87);
            lblUnassignedTickets.Name = "lblUnassignedTickets";
            lblUnassignedTickets.Size = new Size(113, 15);
            lblUnassignedTickets.TabIndex = 3;
            lblUnassignedTickets.Text = "Unassigned Tickets";
            // 
            // lblAssignedTickets
            // 
            lblAssignedTickets.AutoSize = true;
            lblAssignedTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssignedTickets.Location = new Point(646, 87);
            lblAssignedTickets.Name = "lblAssignedTickets";
            lblAssignedTickets.Size = new Size(99, 15);
            lblAssignedTickets.TabIndex = 4;
            lblAssignedTickets.Text = "Assigned Tickets";
            // 
            // btnAssignTicket
            // 
            btnAssignTicket.Location = new Point(345, 119);
            btnAssignTicket.Margin = new Padding(3, 4, 3, 4);
            btnAssignTicket.Name = "btnAssignTicket";
            btnAssignTicket.Size = new Size(104, 48);
            btnAssignTicket.TabIndex = 5;
            btnAssignTicket.Text = "Assign Ticket";
            btnAssignTicket.UseVisualStyleBackColor = true;
            btnAssignTicket.Click += btnAssignTicket_Click;
            // 
            // btnEscalateTicket
            // 
            btnEscalateTicket.Location = new Point(345, 184);
            btnEscalateTicket.Margin = new Padding(3, 4, 3, 4);
            btnEscalateTicket.Name = "btnEscalateTicket";
            btnEscalateTicket.Size = new Size(104, 45);
            btnEscalateTicket.TabIndex = 6;
            btnEscalateTicket.Text = "Escalate Ticket";
            btnEscalateTicket.UseVisualStyleBackColor = true;
            // 
            // btnUnassign
            // 
            btnUnassign.Location = new Point(594, 503);
            btnUnassign.Margin = new Padding(3, 4, 3, 4);
            btnUnassign.Name = "btnUnassign";
            btnUnassign.Size = new Size(86, 31);
            btnUnassign.TabIndex = 7;
            btnUnassign.Text = "Unassign";
            btnUnassign.UseVisualStyleBackColor = true;
            // 
            // btnResolveJob
            // 
            btnResolveJob.Location = new Point(704, 503);
            btnResolveJob.Margin = new Padding(3, 4, 3, 4);
            btnResolveJob.Name = "btnResolveJob";
            btnResolveJob.Size = new Size(89, 32);
            btnResolveJob.TabIndex = 8;
            btnResolveJob.Text = "Resolve Job";
            btnResolveJob.UseVisualStyleBackColor = true;
            // 
            // btnSearchTicket
            // 
            btnSearchTicket.Location = new Point(248, 504);
            btnSearchTicket.Margin = new Padding(3, 4, 3, 4);
            btnSearchTicket.Name = "btnSearchTicket";
            btnSearchTicket.Size = new Size(103, 31);
            btnSearchTicket.TabIndex = 9;
            btnSearchTicket.Text = "Search Ticket";
            btnSearchTicket.UseVisualStyleBackColor = true;
            btnSearchTicket.Click += btnSearchTicket_Click_1;
            // 
            // txtbxSearchTicket
            // 
            txtbxSearchTicket.Location = new Point(31, 504);
            txtbxSearchTicket.Margin = new Padding(3, 4, 3, 4);
            txtbxSearchTicket.Name = "txtbxSearchTicket";
            txtbxSearchTicket.Size = new Size(189, 23);
            txtbxSearchTicket.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(31, 556);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 22);
            btnBack.TabIndex = 16;
            btnBack.Text = "<<<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(345, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 23);
            comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 59);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 18;
            label1.Text = "Avalible Employees";
            // 
            // lblUnassigned
            // 
            lblUnassigned.AutoSize = true;
            lblUnassigned.Location = new Point(31, 466);
            lblUnassigned.Name = "lblUnassigned";
            lblUnassigned.Size = new Size(38, 15);
            lblUnassigned.TabIndex = 19;
            lblUnassigned.Text = "label2";
            // 
            // lblAssigned
            // 
            lblAssigned.AutoSize = true;
            lblAssigned.Location = new Point(13, 388);
            lblAssigned.Name = "lblAssigned";
            lblAssigned.Size = new Size(38, 15);
            lblAssigned.TabIndex = 20;
            lblAssigned.Text = "label2";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAssignTicket);
            panel1.Controls.Add(btnEscalateTicket);
            panel1.Location = new Point(20, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 419);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblAssigned);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(523, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 419);
            panel2.TabIndex = 22;
            // 
            // frmServiceDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 584);
            Controls.Add(lblUnassigned);
            Controls.Add(btnBack);
            Controls.Add(txtbxSearchTicket);
            Controls.Add(btnSearchTicket);
            Controls.Add(btnResolveJob);
            Controls.Add(btnUnassign);
            Controls.Add(lblAssignedTickets);
            Controls.Add(lblUnassignedTickets);
            Controls.Add(dataGridView1);
            Controls.Add(lblServiceDepartment);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmServiceDepartment";
            Text = "Service Department";
            Load += frmServiceDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServiceDepartment;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label lblUnassignedTickets;
        private Label lblAssignedTickets;
        private Button btnAssignTicket;
        private Button btnEscalateTicket;
        private Button btnUnassign;
        private Button btnResolveJob;
        private Button btnSearchTicket;
        private TextBox txtbxSearchTicket;
        private Button button1;
        private Button btnBack;
        private ComboBox comboBox1;
        private Label label1;
        private Label lblUnassigned;
        private Label lblAssigned;
        private Panel panel1;
        private Panel panel2;
    }
}