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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceDepartment));
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblServiceDepartment
            // 
            lblServiceDepartment.AutoSize = true;
            lblServiceDepartment.BackColor = Color.Transparent;
            lblServiceDepartment.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblServiceDepartment.ForeColor = SystemColors.ButtonHighlight;
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
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(534, 111);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(320, 351);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // lblUnassignedTickets
            // 
            lblUnassignedTickets.AutoSize = true;
            lblUnassignedTickets.BackColor = Color.Transparent;
            lblUnassignedTickets.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnassignedTickets.ForeColor = SystemColors.ButtonHighlight;
            lblUnassignedTickets.Location = new Point(87, 82);
            lblUnassignedTickets.Name = "lblUnassignedTickets";
            lblUnassignedTickets.Size = new Size(181, 25);
            lblUnassignedTickets.TabIndex = 3;
            lblUnassignedTickets.Text = "Unassigned Tickets";
            // 
            // lblAssignedTickets
            // 
            lblAssignedTickets.AutoSize = true;
            lblAssignedTickets.BackColor = Color.Transparent;
            lblAssignedTickets.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssignedTickets.ForeColor = SystemColors.ButtonHighlight;
            lblAssignedTickets.Location = new Point(619, 82);
            lblAssignedTickets.Name = "lblAssignedTickets";
            lblAssignedTickets.Size = new Size(158, 25);
            lblAssignedTickets.TabIndex = 4;
            lblAssignedTickets.Text = "Assigned Tickets";
            // 
            // btnAssignTicket
            // 
            btnAssignTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnEscalateTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEscalateTicket.Location = new Point(393, 317);
            btnEscalateTicket.Margin = new Padding(3, 4, 3, 4);
            btnEscalateTicket.Name = "btnEscalateTicket";
            btnEscalateTicket.Size = new Size(104, 45);
            btnEscalateTicket.TabIndex = 6;
            btnEscalateTicket.Text = "Escalate Ticket";
            btnEscalateTicket.UseVisualStyleBackColor = true;
            // 
            // btnUnassign
            // 
            btnUnassign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnResolveJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnSearchTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchTicket.Location = new Point(248, 504);
            btnSearchTicket.Margin = new Padding(3, 4, 3, 4);
            btnSearchTicket.Name = "btnSearchTicket";
            btnSearchTicket.Size = new Size(103, 31);
            btnSearchTicket.TabIndex = 9;
            btnSearchTicket.Text = "Search Ticket";
            btnSearchTicket.UseVisualStyleBackColor = true;
            btnSearchTicket.Click += btnSearchTicket_Click;
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
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(393, 137);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 18;
            label1.Text = "Avalible Employees";
            // 
            // lblUnassigned
            // 
            lblUnassigned.AutoSize = true;
            lblUnassigned.BackColor = Color.Transparent;
            lblUnassigned.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnassigned.ForeColor = SystemColors.ButtonHighlight;
            lblUnassigned.Location = new Point(31, 466);
            lblUnassigned.Name = "lblUnassigned";
            lblUnassigned.Size = new Size(113, 15);
            lblUnassigned.TabIndex = 22;
            lblUnassigned.Text = "Unassigned Tickets";
            // 
            // lblAssigned
            // 
            lblAssigned.AutoSize = true;
            lblAssigned.BackColor = Color.Transparent;
            lblAssigned.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssigned.ForeColor = SystemColors.ButtonHighlight;
            lblAssigned.Location = new Point(534, 466);
            lblAssigned.Name = "lblAssigned";
            lblAssigned.Size = new Size(113, 15);
            lblAssigned.TabIndex = 23;
            lblAssigned.Text = "Unassigned Tickets";
            // 
            // frmServiceDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 584);
            Controls.Add(lblAssigned);
            Controls.Add(lblUnassigned);
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
        private Label lblUnassigned;
        private Label lblAssigned;
    }
}