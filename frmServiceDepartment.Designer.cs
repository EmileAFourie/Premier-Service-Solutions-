﻿namespace Premier_Service_Solutions
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceDepartment
            // 
            this.lblServiceDepartment.AutoSize = true;
            this.lblServiceDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceDepartment.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServiceDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServiceDepartment.Location = new System.Drawing.Point(296, 27);
            this.lblServiceDepartment.Name = "lblServiceDepartment";
            this.lblServiceDepartment.Size = new System.Drawing.Size(274, 37);
            this.lblServiceDepartment.TabIndex = 0;
            this.lblServiceDepartment.Text = "Service Department";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(320, 351);
            this.dataGridView1.TabIndex = 1;
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
            this.lblUnassignedTickets.AutoSize = true;
            this.lblUnassignedTickets.BackColor = System.Drawing.Color.Transparent;
            this.lblUnassignedTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnassignedTickets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnassignedTickets.Location = new System.Drawing.Point(114, 87);
            this.lblUnassignedTickets.Name = "lblUnassignedTickets";
            this.lblUnassignedTickets.Size = new System.Drawing.Size(113, 15);
            this.lblUnassignedTickets.TabIndex = 3;
            this.lblUnassignedTickets.Text = "Unassigned Tickets";
            // 
            // lblAssignedTickets
            // 
            this.lblAssignedTickets.AutoSize = true;
            this.lblAssignedTickets.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignedTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssignedTickets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssignedTickets.Location = new System.Drawing.Point(646, 87);
            this.lblAssignedTickets.Name = "lblAssignedTickets";
            this.lblAssignedTickets.Size = new System.Drawing.Size(99, 15);
            this.lblAssignedTickets.TabIndex = 4;
            this.lblAssignedTickets.Text = "Assigned Tickets";
            // 
            // btnAssignTicket
            // 
            this.btnAssignTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssignTicket.Location = new System.Drawing.Point(393, 195);
            this.btnAssignTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssignTicket.Name = "btnAssignTicket";
            this.btnAssignTicket.Size = new System.Drawing.Size(104, 48);
            this.btnAssignTicket.TabIndex = 5;
            this.btnAssignTicket.Text = "Assign Ticket";
            this.btnAssignTicket.UseVisualStyleBackColor = true;
            // 
            // btnEscalateTicket
            // 
            this.btnEscalateTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.btnUnassign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.btnResolveJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.btnSearchTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchTicket.Location = new System.Drawing.Point(248, 504);
            this.btnSearchTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(103, 31);
            this.btnSearchTicket.TabIndex = 9;
            this.btnSearchTicket.Text = "Search Ticket";
            this.btnSearchTicket.UseVisualStyleBackColor = true;
            // 
            // txtbxSearchTicket
            // 
            this.txtbxSearchTicket.Location = new System.Drawing.Point(31, 504);
            this.txtbxSearchTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxSearchTicket.Name = "txtbxSearchTicket";
            this.txtbxSearchTicket.Size = new System.Drawing.Size(189, 23);
            this.txtbxSearchTicket.TabIndex = 10;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 22);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(380, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 23);
            this.comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(393, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Avalible Employees";
            // 
            // frmServiceDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBack);
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
        private Button btnBack;
        private ComboBox comboBox1;
        private Label label1;
    }
}