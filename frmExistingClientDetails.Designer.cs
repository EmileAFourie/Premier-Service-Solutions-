namespace Premier_Service_Solutions
{
    partial class frmExistingClientDetails
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
            lblPreviousCalls = new Label();
            lblPreviousTickets = new Label();
            txtbxCallDuration = new TextBox();
            lblCallDuration = new Label();
            btnEndCall = new Button();
            lblTicketManagement = new Label();
            grpbxNewTicket = new GroupBox();
            btnClear = new Button();
            btnSubmit = new Button();
            txtbxAssignedTo = new TextBox();
            txtbxPriority = new TextBox();
            lblAssignedTo = new Label();
            lblPriority = new Label();
            txtbxDescription = new TextBox();
            txtbxTypeOfError = new TextBox();
            lblDescription = new Label();
            lblTypeOfError = new Label();
            txtbxClientID = new TextBox();
            txtbxTicketID = new TextBox();
            lblClientIDNewTicket = new Label();
            lblTicketID = new Label();
            txtbxContract = new TextBox();
            lblContract = new Label();
            txtbxClient = new TextBox();
            lblClient = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            grpbxNewTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblPreviousCalls
            // 
            lblPreviousCalls.AutoSize = true;
            lblPreviousCalls.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreviousCalls.Location = new Point(591, 234);
            lblPreviousCalls.Name = "lblPreviousCalls";
            lblPreviousCalls.Size = new Size(85, 15);
            lblPreviousCalls.TabIndex = 40;
            lblPreviousCalls.Text = "Previous Calls:";
            // 
            // lblPreviousTickets
            // 
            lblPreviousTickets.AutoSize = true;
            lblPreviousTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreviousTickets.Location = new Point(591, 62);
            lblPreviousTickets.Name = "lblPreviousTickets";
            lblPreviousTickets.Size = new Size(101, 15);
            lblPreviousTickets.TabIndex = 39;
            lblPreviousTickets.Text = "Previous Tickets:";
            // 
            // txtbxCallDuration
            // 
            txtbxCallDuration.Location = new Point(582, 414);
            txtbxCallDuration.Name = "txtbxCallDuration";
            txtbxCallDuration.Size = new Size(83, 23);
            txtbxCallDuration.TabIndex = 38;
            // 
            // lblCallDuration
            // 
            lblCallDuration.AutoSize = true;
            lblCallDuration.Location = new Point(497, 417);
            lblCallDuration.Name = "lblCallDuration";
            lblCallDuration.Size = new Size(79, 15);
            lblCallDuration.TabIndex = 37;
            lblCallDuration.Text = "Call Duration:";
            // 
            // btnEndCall
            // 
            btnEndCall.Location = new Point(675, 408);
            btnEndCall.Name = "btnEndCall";
            btnEndCall.Size = new Size(104, 32);
            btnEndCall.TabIndex = 36;
            btnEndCall.Text = "End Call";
            btnEndCall.UseVisualStyleBackColor = true;
            // 
            // lblTicketManagement
            // 
            lblTicketManagement.AutoSize = true;
            lblTicketManagement.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketManagement.Location = new Point(292, 0);
            lblTicketManagement.Name = "lblTicketManagement";
            lblTicketManagement.Size = new Size(251, 37);
            lblTicketManagement.TabIndex = 35;
            lblTicketManagement.Text = "Ticket Management";
            // 
            // grpbxNewTicket
            // 
            grpbxNewTicket.Controls.Add(btnClear);
            grpbxNewTicket.Controls.Add(btnSubmit);
            grpbxNewTicket.Controls.Add(txtbxAssignedTo);
            grpbxNewTicket.Controls.Add(txtbxPriority);
            grpbxNewTicket.Controls.Add(lblAssignedTo);
            grpbxNewTicket.Controls.Add(lblPriority);
            grpbxNewTicket.Controls.Add(txtbxDescription);
            grpbxNewTicket.Controls.Add(txtbxTypeOfError);
            grpbxNewTicket.Controls.Add(lblDescription);
            grpbxNewTicket.Controls.Add(lblTypeOfError);
            grpbxNewTicket.Controls.Add(txtbxClientID);
            grpbxNewTicket.Controls.Add(txtbxTicketID);
            grpbxNewTicket.Controls.Add(lblClientIDNewTicket);
            grpbxNewTicket.Controls.Add(lblTicketID);
            grpbxNewTicket.Location = new Point(22, 156);
            grpbxNewTicket.Name = "grpbxNewTicket";
            grpbxNewTicket.Size = new Size(440, 284);
            grpbxNewTicket.TabIndex = 34;
            grpbxNewTicket.TabStop = false;
            grpbxNewTicket.Text = "New Ticket";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(133, 224);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 32);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(270, 224);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(104, 32);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtbxAssignedTo
            // 
            txtbxAssignedTo.Location = new Point(88, 182);
            txtbxAssignedTo.Name = "txtbxAssignedTo";
            txtbxAssignedTo.Size = new Size(336, 23);
            txtbxAssignedTo.TabIndex = 19;
            // 
            // txtbxPriority
            // 
            txtbxPriority.Location = new Point(88, 153);
            txtbxPriority.Name = "txtbxPriority";
            txtbxPriority.Size = new Size(336, 23);
            txtbxPriority.TabIndex = 17;
            // 
            // lblAssignedTo
            // 
            lblAssignedTo.AutoSize = true;
            lblAssignedTo.Location = new Point(11, 185);
            lblAssignedTo.Name = "lblAssignedTo";
            lblAssignedTo.Size = new Size(72, 15);
            lblAssignedTo.TabIndex = 18;
            lblAssignedTo.Text = "Assigned to:";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(11, 156);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(48, 15);
            lblPriority.TabIndex = 16;
            lblPriority.Text = "Priority:";
            // 
            // txtbxDescription
            // 
            txtbxDescription.Location = new Point(88, 124);
            txtbxDescription.Name = "txtbxDescription";
            txtbxDescription.Size = new Size(336, 23);
            txtbxDescription.TabIndex = 15;
            // 
            // txtbxTypeOfError
            // 
            txtbxTypeOfError.Location = new Point(88, 95);
            txtbxTypeOfError.Name = "txtbxTypeOfError";
            txtbxTypeOfError.Size = new Size(336, 23);
            txtbxTypeOfError.TabIndex = 13;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(11, 127);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // lblTypeOfError
            // 
            lblTypeOfError.AutoSize = true;
            lblTypeOfError.Location = new Point(11, 98);
            lblTypeOfError.Name = "lblTypeOfError";
            lblTypeOfError.Size = new Size(72, 15);
            lblTypeOfError.TabIndex = 12;
            lblTypeOfError.Text = "TypeOfError:";
            // 
            // txtbxClientID
            // 
            txtbxClientID.Location = new Point(88, 63);
            txtbxClientID.Name = "txtbxClientID";
            txtbxClientID.Size = new Size(336, 23);
            txtbxClientID.TabIndex = 11;
            // 
            // txtbxTicketID
            // 
            txtbxTicketID.Location = new Point(88, 34);
            txtbxTicketID.Name = "txtbxTicketID";
            txtbxTicketID.Size = new Size(336, 23);
            txtbxTicketID.TabIndex = 9;
            // 
            // lblClientIDNewTicket
            // 
            lblClientIDNewTicket.AutoSize = true;
            lblClientIDNewTicket.Location = new Point(11, 66);
            lblClientIDNewTicket.Name = "lblClientIDNewTicket";
            lblClientIDNewTicket.Size = new Size(52, 15);
            lblClientIDNewTicket.TabIndex = 10;
            lblClientIDNewTicket.Text = "ClientID:";
            // 
            // lblTicketID
            // 
            lblTicketID.AutoSize = true;
            lblTicketID.Location = new Point(11, 37);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(52, 15);
            lblTicketID.TabIndex = 8;
            lblTicketID.Text = "TicketID:";
            // 
            // txtbxContract
            // 
            txtbxContract.Location = new Point(155, 116);
            txtbxContract.Name = "txtbxContract";
            txtbxContract.Size = new Size(291, 23);
            txtbxContract.TabIndex = 33;
            // 
            // lblContract
            // 
            lblContract.AutoSize = true;
            lblContract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContract.Location = new Point(94, 119);
            lblContract.Name = "lblContract";
            lblContract.Size = new Size(58, 15);
            lblContract.TabIndex = 32;
            lblContract.Text = "Contract:";
            // 
            // txtbxClient
            // 
            txtbxClient.Location = new Point(155, 87);
            txtbxClient.Name = "txtbxClient";
            txtbxClient.Size = new Size(291, 23);
            txtbxClient.TabIndex = 31;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClient.Location = new Point(94, 90);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(42, 15);
            lblClient.TabIndex = 30;
            lblClient.Text = "Client:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(496, 252);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(283, 135);
            dataGridView2.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(496, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(283, 133);
            dataGridView1.TabIndex = 28;
            // 
            // frmExistingClientDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPreviousCalls);
            Controls.Add(lblPreviousTickets);
            Controls.Add(txtbxCallDuration);
            Controls.Add(lblCallDuration);
            Controls.Add(btnEndCall);
            Controls.Add(lblTicketManagement);
            Controls.Add(grpbxNewTicket);
            Controls.Add(txtbxContract);
            Controls.Add(lblContract);
            Controls.Add(txtbxClient);
            Controls.Add(lblClient);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "frmExistingClientDetails";
            Text = "Existing Client Details";
            grpbxNewTicket.ResumeLayout(false);
            grpbxNewTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPreviousCalls;
        private Label lblPreviousTickets;
        private TextBox txtbxCallDuration;
        private Label lblCallDuration;
        private Button btnEndCall;
        private Label lblTicketManagement;
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
        private TextBox txtbxContract;
        private Label lblContract;
        private TextBox txtbxClient;
        private Label lblClient;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}