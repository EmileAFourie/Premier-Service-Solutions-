﻿namespace Premier_Service_Solutions
{
    partial class frmTicketManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtbxClient = new System.Windows.Forms.TextBox();
            this.txtbxContract = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.grpbxNewTicket = new System.Windows.Forms.GroupBox();
            this.lblTicketManagement = new System.Windows.Forms.Label();
            this.txtbxClientID = new System.Windows.Forms.TextBox();
            this.lblClientIDNewTicket = new System.Windows.Forms.Label();
            this.txtbxTicketID = new System.Windows.Forms.TextBox();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.txtbxDescription = new System.Windows.Forms.TextBox();
            this.txtbxTypeOfError = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTypeOfError = new System.Windows.Forms.Label();
            this.txtbxAssignedTo = new System.Windows.Forms.TextBox();
            this.txtbxPriority = new System.Windows.Forms.TextBox();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.txtbxCallDuration = new System.Windows.Forms.TextBox();
            this.lblCallDuration = new System.Windows.Forms.Label();
            this.lblPreviousTickets = new System.Windows.Forms.Label();
            this.lblPreviousCalls = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grpbxNewTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(486, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(283, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(486, 250);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(283, 135);
            this.dataGridView2.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClient.Location = new System.Drawing.Point(84, 72);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(42, 15);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client:";
            // 
            // txtbxClient
            // 
            this.txtbxClient.Location = new System.Drawing.Point(145, 69);
            this.txtbxClient.Name = "txtbxClient";
            this.txtbxClient.Size = new System.Drawing.Size(291, 23);
            this.txtbxClient.TabIndex = 3;
            // 
            // txtbxContract
            // 
            this.txtbxContract.Location = new System.Drawing.Point(145, 114);
            this.txtbxContract.Name = "txtbxContract";
            this.txtbxContract.Size = new System.Drawing.Size(291, 23);
            this.txtbxContract.TabIndex = 5;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContract.Location = new System.Drawing.Point(84, 117);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(58, 15);
            this.lblContract.TabIndex = 4;
            this.lblContract.Text = "Contract:";
            // 
            // grpbxNewTicket
            // 
            this.grpbxNewTicket.Controls.Add(this.btnClear);
            this.grpbxNewTicket.Controls.Add(this.btnSubmit);
            this.grpbxNewTicket.Controls.Add(this.txtbxAssignedTo);
            this.grpbxNewTicket.Controls.Add(this.txtbxPriority);
            this.grpbxNewTicket.Controls.Add(this.lblAssignedTo);
            this.grpbxNewTicket.Controls.Add(this.lblPriority);
            this.grpbxNewTicket.Controls.Add(this.txtbxDescription);
            this.grpbxNewTicket.Controls.Add(this.txtbxTypeOfError);
            this.grpbxNewTicket.Controls.Add(this.lblDescription);
            this.grpbxNewTicket.Controls.Add(this.lblTypeOfError);
            this.grpbxNewTicket.Controls.Add(this.txtbxClientID);
            this.grpbxNewTicket.Controls.Add(this.txtbxTicketID);
            this.grpbxNewTicket.Controls.Add(this.lblClientIDNewTicket);
            this.grpbxNewTicket.Controls.Add(this.lblTicketID);
            this.grpbxNewTicket.Location = new System.Drawing.Point(12, 154);
            this.grpbxNewTicket.Name = "grpbxNewTicket";
            this.grpbxNewTicket.Size = new System.Drawing.Size(440, 284);
            this.grpbxNewTicket.TabIndex = 6;
            this.grpbxNewTicket.TabStop = false;
            this.grpbxNewTicket.Text = "New Ticket";
            // 
            // lblTicketManagement
            // 
            this.lblTicketManagement.AutoSize = true;
            this.lblTicketManagement.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketManagement.Location = new System.Drawing.Point(282, 9);
            this.lblTicketManagement.Name = "lblTicketManagement";
            this.lblTicketManagement.Size = new System.Drawing.Size(251, 37);
            this.lblTicketManagement.TabIndex = 7;
            this.lblTicketManagement.Text = "Ticket Management";
            // 
            // txtbxClientID
            // 
            this.txtbxClientID.Location = new System.Drawing.Point(88, 63);
            this.txtbxClientID.Name = "txtbxClientID";
            this.txtbxClientID.Size = new System.Drawing.Size(336, 23);
            this.txtbxClientID.TabIndex = 11;
            // 
            // lblClientIDNewTicket
            // 
            this.lblClientIDNewTicket.AutoSize = true;
            this.lblClientIDNewTicket.Location = new System.Drawing.Point(11, 66);
            this.lblClientIDNewTicket.Name = "lblClientIDNewTicket";
            this.lblClientIDNewTicket.Size = new System.Drawing.Size(52, 15);
            this.lblClientIDNewTicket.TabIndex = 10;
            this.lblClientIDNewTicket.Text = "ClientID:";
            // 
            // txtbxTicketID
            // 
            this.txtbxTicketID.Location = new System.Drawing.Point(88, 34);
            this.txtbxTicketID.Name = "txtbxTicketID";
            this.txtbxTicketID.Size = new System.Drawing.Size(336, 23);
            this.txtbxTicketID.TabIndex = 9;
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Location = new System.Drawing.Point(11, 37);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(52, 15);
            this.lblTicketID.TabIndex = 8;
            this.lblTicketID.Text = "TicketID:";
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Location = new System.Drawing.Point(88, 124);
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(336, 23);
            this.txtbxDescription.TabIndex = 15;
            // 
            // txtbxTypeOfError
            // 
            this.txtbxTypeOfError.Location = new System.Drawing.Point(88, 95);
            this.txtbxTypeOfError.Name = "txtbxTypeOfError";
            this.txtbxTypeOfError.Size = new System.Drawing.Size(336, 23);
            this.txtbxTypeOfError.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 127);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblTypeOfError
            // 
            this.lblTypeOfError.AutoSize = true;
            this.lblTypeOfError.Location = new System.Drawing.Point(11, 98);
            this.lblTypeOfError.Name = "lblTypeOfError";
            this.lblTypeOfError.Size = new System.Drawing.Size(72, 15);
            this.lblTypeOfError.TabIndex = 12;
            this.lblTypeOfError.Text = "TypeOfError:";
            // 
            // txtbxAssignedTo
            // 
            this.txtbxAssignedTo.Location = new System.Drawing.Point(88, 182);
            this.txtbxAssignedTo.Name = "txtbxAssignedTo";
            this.txtbxAssignedTo.Size = new System.Drawing.Size(336, 23);
            this.txtbxAssignedTo.TabIndex = 19;
            // 
            // txtbxPriority
            // 
            this.txtbxPriority.Location = new System.Drawing.Point(88, 153);
            this.txtbxPriority.Name = "txtbxPriority";
            this.txtbxPriority.Size = new System.Drawing.Size(336, 23);
            this.txtbxPriority.TabIndex = 17;
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Location = new System.Drawing.Point(11, 185);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(72, 15);
            this.lblAssignedTo.TabIndex = 18;
            this.lblAssignedTo.Text = "Assigned to:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(11, 156);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(48, 15);
            this.lblPriority.TabIndex = 16;
            this.lblPriority.Text = "Priority:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(270, 224);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 32);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(133, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 32);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(665, 406);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(104, 32);
            this.btnEndCall.TabIndex = 23;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.UseVisualStyleBackColor = true;
            // 
            // txtbxCallDuration
            // 
            this.txtbxCallDuration.Location = new System.Drawing.Point(572, 412);
            this.txtbxCallDuration.Name = "txtbxCallDuration";
            this.txtbxCallDuration.Size = new System.Drawing.Size(83, 23);
            this.txtbxCallDuration.TabIndex = 25;
            // 
            // lblCallDuration
            // 
            this.lblCallDuration.AutoSize = true;
            this.lblCallDuration.Location = new System.Drawing.Point(487, 415);
            this.lblCallDuration.Name = "lblCallDuration";
            this.lblCallDuration.Size = new System.Drawing.Size(79, 15);
            this.lblCallDuration.TabIndex = 24;
            this.lblCallDuration.Text = "Call Duration:";
            this.lblCallDuration.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPreviousTickets
            // 
            this.lblPreviousTickets.AutoSize = true;
            this.lblPreviousTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreviousTickets.Location = new System.Drawing.Point(581, 60);
            this.lblPreviousTickets.Name = "lblPreviousTickets";
            this.lblPreviousTickets.Size = new System.Drawing.Size(101, 15);
            this.lblPreviousTickets.TabIndex = 26;
            this.lblPreviousTickets.Text = "Previous Tickets:";
            // 
            // lblPreviousCalls
            // 
            this.lblPreviousCalls.AutoSize = true;
            this.lblPreviousCalls.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreviousCalls.Location = new System.Drawing.Point(581, 232);
            this.lblPreviousCalls.Name = "lblPreviousCalls";
            this.lblPreviousCalls.Size = new System.Drawing.Size(85, 15);
            this.lblPreviousCalls.TabIndex = 27;
            this.lblPreviousCalls.Text = "Previous Calls:";
            // 
            // frmTicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPreviousCalls);
            this.Controls.Add(this.lblPreviousTickets);
            this.Controls.Add(this.txtbxCallDuration);
            this.Controls.Add(this.lblCallDuration);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblTicketManagement);
            this.Controls.Add(this.grpbxNewTicket);
            this.Controls.Add(this.txtbxContract);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.txtbxClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTicketManagement";
            this.Text = "frmTicketManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grpbxNewTicket.ResumeLayout(false);
            this.grpbxNewTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label lblClient;
        private TextBox txtbxClient;
        private TextBox txtbxContract;
        private Label lblContract;
        private GroupBox grpbxNewTicket;
        private Button btnClear;
        private Button btnSubmit;
        private TextBox txtbxAssignedTo;
        private TextBox txtbxPriority;
        private Label lblAssignedTo;
        private Label lblPriority;
        private TextBox txtbxDescription;
        private TextBox txtbxTypeOfError;
        private Label lblDescription;
        private Label lblTypeOfError;
        private TextBox txtbxClientID;
        private TextBox txtbxTicketID;
        private Label lblClientIDNewTicket;
        private Label lblTicketID;
        private Label lblTicketManagement;
        private Button btnEndCall;
        private TextBox txtbxCallDuration;
        private Label lblCallDuration;
        private Label lblPreviousTickets;
        private Label lblPreviousCalls;
    }
}