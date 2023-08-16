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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 111);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(320, 351);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(534, 111);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(320, 351);
            this.dataGridView2.TabIndex = 2;
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
            btnAssignTicket.Location = new Point(393, 195);
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
            this.btnEscalateTicket.Location = new System.Drawing.Point(393, 317);
            this.btnEscalateTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEscalateTicket.Name = "btnEscalateTicket";
            this.btnEscalateTicket.Size = new System.Drawing.Size(104, 45);
            this.btnEscalateTicket.TabIndex = 6;
            this.btnEscalateTicket.Text = "Escalate Ticket";
            this.btnEscalateTicket.UseVisualStyleBackColor = true;
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(594, 503);
            this.btnUnassign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(86, 31);
            this.btnUnassign.TabIndex = 7;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.UseVisualStyleBackColor = true;
            // 
            // btnResolveJob
            // 
            this.btnResolveJob.Location = new System.Drawing.Point(704, 503);
            this.btnResolveJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResolveJob.Name = "btnResolveJob";
            this.btnResolveJob.Size = new System.Drawing.Size(89, 32);
            this.btnResolveJob.TabIndex = 8;
            this.btnResolveJob.Text = "Resolve Job";
            this.btnResolveJob.UseVisualStyleBackColor = true;
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
            this.button1.Location = new System.Drawing.Point(31, 556);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
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
            comboBox1.Location = new Point(380, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 137);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 18;
            label1.Text = "Avalible Employees";
            // 
            // frmServiceDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 584);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnBack);
            Controls.Add(txtbxSearchTicket);
            Controls.Add(btnSearchTicket);
            Controls.Add(btnResolveJob);
            Controls.Add(btnUnassign);
            Controls.Add(btnEscalateTicket);
            Controls.Add(btnAssignTicket);
            Controls.Add(lblAssignedTickets);
            Controls.Add(lblUnassignedTickets);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(lblServiceDepartment);
            Name = "frmServiceDepartment";
            Text = "Service Department";
            Load += frmServiceDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
    }
}