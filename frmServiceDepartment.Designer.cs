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
            lblServiceDepartment.Size = new Size(336, 46);
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
            // 
            // lblUnassignedTickets
            // 
            lblUnassignedTickets.AutoSize = true;
            lblUnassignedTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnassignedTickets.Location = new Point(114, 87);
            lblUnassignedTickets.Name = "lblUnassignedTickets";
            lblUnassignedTickets.Size = new Size(143, 20);
            lblUnassignedTickets.TabIndex = 3;
            lblUnassignedTickets.Text = "Unassigned Tickets";
            // 
            // lblAssignedTickets
            // 
            lblAssignedTickets.AutoSize = true;
            lblAssignedTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssignedTickets.Location = new Point(646, 87);
            lblAssignedTickets.Name = "lblAssignedTickets";
            lblAssignedTickets.Size = new Size(126, 20);
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
            // 
            // btnEscalateTicket
            // 
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
            // 
            // txtbxSearchTicket
            // 
            txtbxSearchTicket.Location = new Point(31, 504);
            txtbxSearchTicket.Margin = new Padding(3, 4, 3, 4);
            txtbxSearchTicket.Name = "txtbxSearchTicket";
            txtbxSearchTicket.Size = new Size(189, 27);
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
            this.Text = "Service Department";
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
        private Button button1;
    }
}