namespace Premier_Service_Solutions
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            lblClient = new Label();
            txtbxClient = new TextBox();
            txtbxContract = new TextBox();
            lblContract = new Label();
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
            lblTicketManagement = new Label();
            btnEndCall = new Button();
            txtbxCallDuration = new TextBox();
            lblCallDuration = new Label();
            lblPreviousTickets = new Label();
            lblPreviousCalls = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            grpbxNewTicket.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(555, 104);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(323, 177);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(555, 333);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(323, 180);
            dataGridView2.TabIndex = 1;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClient.Location = new Point(96, 96);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(53, 20);
            lblClient.TabIndex = 2;
            lblClient.Text = "Client:";
            // 
            // txtbxClient
            // 
            txtbxClient.Location = new Point(166, 92);
            txtbxClient.Margin = new Padding(3, 4, 3, 4);
            txtbxClient.Name = "txtbxClient";
            txtbxClient.Size = new Size(332, 27);
            txtbxClient.TabIndex = 3;
            // 
            // txtbxContract
            // 
            txtbxContract.Location = new Point(166, 152);
            txtbxContract.Margin = new Padding(3, 4, 3, 4);
            txtbxContract.Name = "txtbxContract";
            txtbxContract.Size = new Size(332, 27);
            txtbxContract.TabIndex = 5;
            // 
            // lblContract
            // 
            lblContract.AutoSize = true;
            lblContract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContract.Location = new Point(96, 156);
            lblContract.Name = "lblContract";
            lblContract.Size = new Size(73, 20);
            lblContract.TabIndex = 4;
            lblContract.Text = "Contract:";
            // 
            // grpbxNewTicket
            // 
            grpbxNewTicket.Controls.Add(button1);
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
            grpbxNewTicket.Location = new Point(14, 205);
            grpbxNewTicket.Margin = new Padding(3, 4, 3, 4);
            grpbxNewTicket.Name = "grpbxNewTicket";
            grpbxNewTicket.Padding = new Padding(3, 4, 3, 4);
            grpbxNewTicket.Size = new Size(503, 379);
            grpbxNewTicket.TabIndex = 6;
            grpbxNewTicket.TabStop = false;
            grpbxNewTicket.Text = "New Ticket";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(152, 299);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 43);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(309, 299);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(119, 43);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtbxAssignedTo
            // 
            txtbxAssignedTo.Location = new Point(101, 243);
            txtbxAssignedTo.Margin = new Padding(3, 4, 3, 4);
            txtbxAssignedTo.Name = "txtbxAssignedTo";
            txtbxAssignedTo.Size = new Size(383, 27);
            txtbxAssignedTo.TabIndex = 19;
            // 
            // txtbxPriority
            // 
            txtbxPriority.Location = new Point(101, 204);
            txtbxPriority.Margin = new Padding(3, 4, 3, 4);
            txtbxPriority.Name = "txtbxPriority";
            txtbxPriority.Size = new Size(383, 27);
            txtbxPriority.TabIndex = 17;
            // 
            // lblAssignedTo
            // 
            lblAssignedTo.AutoSize = true;
            lblAssignedTo.Location = new Point(13, 247);
            lblAssignedTo.Name = "lblAssignedTo";
            lblAssignedTo.Size = new Size(90, 20);
            lblAssignedTo.TabIndex = 18;
            lblAssignedTo.Text = "Assigned to:";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(13, 208);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(59, 20);
            lblPriority.TabIndex = 16;
            lblPriority.Text = "Priority:";
            // 
            // txtbxDescription
            // 
            txtbxDescription.Location = new Point(101, 165);
            txtbxDescription.Margin = new Padding(3, 4, 3, 4);
            txtbxDescription.Name = "txtbxDescription";
            txtbxDescription.Size = new Size(383, 27);
            txtbxDescription.TabIndex = 15;
            // 
            // txtbxTypeOfError
            // 
            txtbxTypeOfError.Location = new Point(101, 127);
            txtbxTypeOfError.Margin = new Padding(3, 4, 3, 4);
            txtbxTypeOfError.Name = "txtbxTypeOfError";
            txtbxTypeOfError.Size = new Size(383, 27);
            txtbxTypeOfError.TabIndex = 13;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(13, 169);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // lblTypeOfError
            // 
            lblTypeOfError.AutoSize = true;
            lblTypeOfError.Location = new Point(13, 131);
            lblTypeOfError.Name = "lblTypeOfError";
            lblTypeOfError.Size = new Size(91, 20);
            lblTypeOfError.TabIndex = 12;
            lblTypeOfError.Text = "TypeOfError:";
            // 
            // txtbxClientID
            // 
            txtbxClientID.Location = new Point(101, 84);
            txtbxClientID.Margin = new Padding(3, 4, 3, 4);
            txtbxClientID.Name = "txtbxClientID";
            txtbxClientID.Size = new Size(383, 27);
            txtbxClientID.TabIndex = 11;
            // 
            // txtbxTicketID
            // 
            txtbxTicketID.Location = new Point(101, 45);
            txtbxTicketID.Margin = new Padding(3, 4, 3, 4);
            txtbxTicketID.Name = "txtbxTicketID";
            txtbxTicketID.Size = new Size(383, 27);
            txtbxTicketID.TabIndex = 9;
            // 
            // lblClientIDNewTicket
            // 
            lblClientIDNewTicket.AutoSize = true;
            lblClientIDNewTicket.Location = new Point(13, 88);
            lblClientIDNewTicket.Name = "lblClientIDNewTicket";
            lblClientIDNewTicket.Size = new Size(65, 20);
            lblClientIDNewTicket.TabIndex = 10;
            lblClientIDNewTicket.Text = "ClientID:";
            // 
            // lblTicketID
            // 
            lblTicketID.AutoSize = true;
            lblTicketID.Location = new Point(13, 49);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(66, 20);
            lblTicketID.TabIndex = 8;
            lblTicketID.Text = "TicketID:";
            // 
            // lblTicketManagement
            // 
            lblTicketManagement.AutoSize = true;
            lblTicketManagement.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketManagement.Location = new Point(322, 12);
            lblTicketManagement.Name = "lblTicketManagement";
            lblTicketManagement.Size = new Size(318, 46);
            lblTicketManagement.TabIndex = 7;
            lblTicketManagement.Text = "Ticket Management";
            // 
            // btnEndCall
            // 
            btnEndCall.Location = new Point(760, 541);
            btnEndCall.Margin = new Padding(3, 4, 3, 4);
            btnEndCall.Name = "btnEndCall";
            btnEndCall.Size = new Size(119, 43);
            btnEndCall.TabIndex = 23;
            btnEndCall.Text = "End Call";
            btnEndCall.UseVisualStyleBackColor = true;
            // 
            // txtbxCallDuration
            // 
            txtbxCallDuration.Location = new Point(654, 549);
            txtbxCallDuration.Margin = new Padding(3, 4, 3, 4);
            txtbxCallDuration.Name = "txtbxCallDuration";
            txtbxCallDuration.Size = new Size(94, 27);
            txtbxCallDuration.TabIndex = 25;
            // 
            // lblCallDuration
            // 
            lblCallDuration.AutoSize = true;
            lblCallDuration.Location = new Point(557, 553);
            lblCallDuration.Name = "lblCallDuration";
            lblCallDuration.Size = new Size(99, 20);
            lblCallDuration.TabIndex = 24;
            lblCallDuration.Text = "Call Duration:";
            lblCallDuration.Click += label1_Click;
            // 
            // lblPreviousTickets
            // 
            lblPreviousTickets.AutoSize = true;
            lblPreviousTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreviousTickets.Location = new Point(664, 80);
            lblPreviousTickets.Name = "lblPreviousTickets";
            lblPreviousTickets.Size = new Size(126, 20);
            lblPreviousTickets.TabIndex = 26;
            lblPreviousTickets.Text = "Previous Tickets:";
            // 
            // lblPreviousCalls
            // 
            lblPreviousCalls.AutoSize = true;
            lblPreviousCalls.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreviousCalls.Location = new Point(664, 309);
            lblPreviousCalls.Name = "lblPreviousCalls";
            lblPreviousCalls.Size = new Size(109, 20);
            lblPreviousCalls.TabIndex = 27;
            lblPreviousCalls.Text = "Previous Calls:";
            // 
            // button1
            // 
            button1.Location = new Point(13, 299);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 43);
            button1.TabIndex = 23;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmTicketManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTicketManagement";
            Text = "frmTicketManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            grpbxNewTicket.ResumeLayout(false);
            grpbxNewTicket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
    }
}