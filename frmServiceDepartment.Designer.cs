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
            this.lblServiceDepartment = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblUnassignedTickets = new System.Windows.Forms.Label();
            this.lblAssignedTickets = new System.Windows.Forms.Label();
            this.btnAssignTicket = new System.Windows.Forms.Button();
            this.btnEscalateTicket = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.btnResolveJob = new System.Windows.Forms.Button();
            this.btnSearchTicket = new System.Windows.Forms.Button();
            this.txtbxSearchTicket = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceDepartment
            // 
            this.lblServiceDepartment.AutoSize = true;
            this.lblServiceDepartment.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServiceDepartment.Location = new System.Drawing.Point(259, 20);
            this.lblServiceDepartment.Name = "lblServiceDepartment";
            this.lblServiceDepartment.Size = new System.Drawing.Size(274, 37);
            this.lblServiceDepartment.TabIndex = 0;
            this.lblServiceDepartment.Text = "Service Department";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(280, 263);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(467, 83);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(280, 263);
            this.dataGridView2.TabIndex = 2;
            // 
            // lblUnassignedTickets
            // 
            this.lblUnassignedTickets.AutoSize = true;
            this.lblUnassignedTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnassignedTickets.Location = new System.Drawing.Point(100, 65);
            this.lblUnassignedTickets.Name = "lblUnassignedTickets";
            this.lblUnassignedTickets.Size = new System.Drawing.Size(113, 15);
            this.lblUnassignedTickets.TabIndex = 3;
            this.lblUnassignedTickets.Text = "Unassigned Tickets";
            // 
            // lblAssignedTickets
            // 
            this.lblAssignedTickets.AutoSize = true;
            this.lblAssignedTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssignedTickets.Location = new System.Drawing.Point(565, 65);
            this.lblAssignedTickets.Name = "lblAssignedTickets";
            this.lblAssignedTickets.Size = new System.Drawing.Size(99, 15);
            this.lblAssignedTickets.TabIndex = 4;
            this.lblAssignedTickets.Text = "Assigned Tickets";
            // 
            // btnAssignTicket
            // 
            this.btnAssignTicket.Location = new System.Drawing.Point(344, 146);
            this.btnAssignTicket.Name = "btnAssignTicket";
            this.btnAssignTicket.Size = new System.Drawing.Size(91, 36);
            this.btnAssignTicket.TabIndex = 5;
            this.btnAssignTicket.Text = "Assign Ticket";
            this.btnAssignTicket.UseVisualStyleBackColor = true;
            // 
            // btnEscalateTicket
            // 
            this.btnEscalateTicket.Location = new System.Drawing.Point(344, 238);
            this.btnEscalateTicket.Name = "btnEscalateTicket";
            this.btnEscalateTicket.Size = new System.Drawing.Size(91, 34);
            this.btnEscalateTicket.TabIndex = 6;
            this.btnEscalateTicket.Text = "Escalate Ticket";
            this.btnEscalateTicket.UseVisualStyleBackColor = true;
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(520, 377);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(75, 23);
            this.btnUnassign.TabIndex = 7;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.UseVisualStyleBackColor = true;
            // 
            // btnResolveJob
            // 
            this.btnResolveJob.Location = new System.Drawing.Point(616, 377);
            this.btnResolveJob.Name = "btnResolveJob";
            this.btnResolveJob.Size = new System.Drawing.Size(78, 24);
            this.btnResolveJob.TabIndex = 8;
            this.btnResolveJob.Text = "Resolve Job";
            this.btnResolveJob.UseVisualStyleBackColor = true;
            // 
            // btnSearchTicket
            // 
            this.btnSearchTicket.Location = new System.Drawing.Point(217, 378);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(90, 23);
            this.btnSearchTicket.TabIndex = 9;
            this.btnSearchTicket.Text = "Search Ticket";
            this.btnSearchTicket.UseVisualStyleBackColor = true;
            // 
            // txtbxSearchTicket
            // 
            this.txtbxSearchTicket.Location = new System.Drawing.Point(27, 378);
            this.txtbxSearchTicket.Name = "txtbxSearchTicket";
            this.txtbxSearchTicket.Size = new System.Drawing.Size(166, 23);
            this.txtbxSearchTicket.TabIndex = 10;
            // 
            // frmServiceDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxSearchTicket);
            this.Controls.Add(this.btnSearchTicket);
            this.Controls.Add(this.btnResolveJob);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnEscalateTicket);
            this.Controls.Add(this.btnAssignTicket);
            this.Controls.Add(this.lblAssignedTickets);
            this.Controls.Add(this.lblUnassignedTickets);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblServiceDepartment);
            this.Name = "frmServiceDepartment";
            this.Text = "ServiceDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}