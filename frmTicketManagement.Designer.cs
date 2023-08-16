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
            this.dgvPreviousTickets = new System.Windows.Forms.DataGridView();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtbxClient = new System.Windows.Forms.TextBox();
            this.txtbxContract = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.grpbxNewTicket = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtbxPriority = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtbxDescription = new System.Windows.Forms.TextBox();
            this.txtbxTypeOfError = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTypeOfError = new System.Windows.Forms.Label();
            this.txtbxClientID = new System.Windows.Forms.TextBox();
            this.lblClientIDNewTicket = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTicketManagement = new System.Windows.Forms.Label();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.txtbxCallDuration = new System.Windows.Forms.TextBox();
            this.lblCallDuration = new System.Windows.Forms.Label();
            this.lblPreviousTickets = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousTickets)).BeginInit();
            this.grpbxNewTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPreviousTickets
            // 
            this.dgvPreviousTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviousTickets.Location = new System.Drawing.Point(29, 86);
            this.dgvPreviousTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPreviousTickets.Name = "dgvPreviousTickets";
            this.dgvPreviousTickets.RowHeadersWidth = 51;
            this.dgvPreviousTickets.RowTemplate.Height = 25;
            this.dgvPreviousTickets.Size = new System.Drawing.Size(862, 225);
            this.dgvPreviousTickets.TabIndex = 0;
            this.dgvPreviousTickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreviousTickets_CellClick);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClient.Location = new System.Drawing.Point(651, 372);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(42, 15);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client:";
            // 
            // txtbxClient
            // 
            this.txtbxClient.Location = new System.Drawing.Point(727, 364);
            this.txtbxClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxClient.Name = "txtbxClient";
            this.txtbxClient.Size = new System.Drawing.Size(164, 23);
            this.txtbxClient.TabIndex = 3;
            // 
            // txtbxContract
            // 
            this.txtbxContract.Location = new System.Drawing.Point(727, 414);
            this.txtbxContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxContract.Name = "txtbxContract";
            this.txtbxContract.Size = new System.Drawing.Size(164, 23);
            this.txtbxContract.TabIndex = 5;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContract.Location = new System.Drawing.Point(651, 422);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(58, 15);
            this.lblContract.TabIndex = 4;
            this.lblContract.Text = "Contract:";
            // 
            // grpbxNewTicket
            // 
            this.grpbxNewTicket.Controls.Add(this.btnUpdate);
            this.grpbxNewTicket.Controls.Add(this.btnClear);
            this.grpbxNewTicket.Controls.Add(this.btnSubmit);
            this.grpbxNewTicket.Controls.Add(this.txtbxPriority);
            this.grpbxNewTicket.Controls.Add(this.lblPriority);
            this.grpbxNewTicket.Controls.Add(this.txtbxDescription);
            this.grpbxNewTicket.Controls.Add(this.txtbxTypeOfError);
            this.grpbxNewTicket.Controls.Add(this.lblDescription);
            this.grpbxNewTicket.Controls.Add(this.lblTypeOfError);
            this.grpbxNewTicket.Controls.Add(this.txtbxClientID);
            this.grpbxNewTicket.Controls.Add(this.lblClientIDNewTicket);
            this.grpbxNewTicket.Location = new System.Drawing.Point(29, 348);
            this.grpbxNewTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbxNewTicket.Name = "grpbxNewTicket";
            this.grpbxNewTicket.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbxNewTicket.Size = new System.Drawing.Size(616, 264);
            this.grpbxNewTicket.TabIndex = 6;
            this.grpbxNewTicket.TabStop = false;
            this.grpbxNewTicket.Text = "Ticket";
            this.grpbxNewTicket.Enter += new System.EventHandler(this.grpbxNewTicket_Enter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(500, 146);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 32);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(500, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 43);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(500, 184);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 43);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtbxPriority
            // 
            this.txtbxPriority.Location = new System.Drawing.Point(129, 230);
            this.txtbxPriority.Name = "txtbxPriority";
            this.txtbxPriority.Size = new System.Drawing.Size(383, 27);
            this.txtbxPriority.TabIndex = 17;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(35, 233);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(59, 20);
            this.lblPriority.TabIndex = 16;
            this.lblPriority.Text = "Priority:";
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Location = new System.Drawing.Point(129, 184);
            this.txtbxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(336, 23);
            this.txtbxDescription.TabIndex = 15;
            // 
            // txtbxTypeOfError
            // 
            this.txtbxTypeOfError.Location = new System.Drawing.Point(129, 137);
            this.txtbxTypeOfError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxTypeOfError.Name = "txtbxTypeOfError";
            this.txtbxTypeOfError.Size = new System.Drawing.Size(336, 23);
            this.txtbxTypeOfError.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(33, 184);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblTypeOfError
            // 
            this.lblTypeOfError.AutoSize = true;
            this.lblTypeOfError.Location = new System.Drawing.Point(33, 140);
            this.lblTypeOfError.Name = "lblTypeOfError";
            this.lblTypeOfError.Size = new System.Drawing.Size(91, 20);
            this.lblTypeOfError.TabIndex = 12;
            this.lblTypeOfError.Text = "TypeOfError:";
            // 
            // txtbxClientID
            // 
            this.txtbxClientID.Location = new System.Drawing.Point(129, 96);
            this.txtbxClientID.Name = "txtbxClientID";
            this.txtbxClientID.Size = new System.Drawing.Size(383, 27);
            this.txtbxClientID.TabIndex = 11;
            // 
            // lblClientIDNewTicket
            // 
            this.lblClientIDNewTicket.AutoSize = true;
            this.lblClientIDNewTicket.Location = new System.Drawing.Point(52, 99);
            this.lblClientIDNewTicket.Name = "lblClientIDNewTicket";
            this.lblClientIDNewTicket.Size = new System.Drawing.Size(65, 20);
            this.lblClientIDNewTicket.TabIndex = 10;
            this.lblClientIDNewTicket.Text = "ClientID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(406, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 32);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTicketManagement
            // 
            this.lblTicketManagement.AutoSize = true;
            this.lblTicketManagement.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketManagement.Location = new System.Drawing.Point(322, 12);
            this.lblTicketManagement.Name = "lblTicketManagement";
            this.lblTicketManagement.Size = new System.Drawing.Size(318, 46);
            this.lblTicketManagement.TabIndex = 7;
            this.lblTicketManagement.Text = "Ticket Management";
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(826, 539);
            this.btnEndCall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(65, 43);
            this.btnEndCall.TabIndex = 23;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // txtbxCallDuration
            // 
            this.txtbxCallDuration.Location = new System.Drawing.Point(727, 545);
            this.txtbxCallDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxCallDuration.Name = "txtbxCallDuration";
            this.txtbxCallDuration.Size = new System.Drawing.Size(94, 23);
            this.txtbxCallDuration.TabIndex = 25;
            // 
            // lblCallDuration
            // 
            this.lblCallDuration.AutoSize = true;
            this.lblCallDuration.Location = new System.Drawing.Point(651, 553);
            this.lblCallDuration.Name = "lblCallDuration";
            this.lblCallDuration.Size = new System.Drawing.Size(79, 15);
            this.lblCallDuration.TabIndex = 24;
            this.lblCallDuration.Text = "Call Duration:";
            // 
            // lblPreviousTickets
            // 
            this.lblPreviousTickets.AutoSize = true;
            this.lblPreviousTickets.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreviousTickets.Location = new System.Drawing.Point(29, 54);
            this.lblPreviousTickets.Name = "lblPreviousTickets";
            this.lblPreviousTickets.Size = new System.Drawing.Size(84, 28);
            this.lblPreviousTickets.TabIndex = 26;
            this.lblPreviousTickets.Text = "Tickets:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 22);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmTicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 643);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPreviousTickets);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtbxCallDuration);
            this.Controls.Add(this.lblCallDuration);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblTicketManagement);
            this.Controls.Add(this.grpbxNewTicket);
            this.Controls.Add(this.txtbxContract);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.txtbxClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dgvPreviousTickets);
            this.Name = "frmTicketManagement";
            this.Text = "Ticket Management";
            this.Load += new System.EventHandler(this.frmTicketManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousTickets)).EndInit();
            this.grpbxNewTicket.ResumeLayout(false);
            this.grpbxNewTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPreviousTickets;
        private DataGridView dgvPreviousCalls;
        private Label lblClient;
        private TextBox txtbxClient;
        private TextBox txtbxContract;
        private Label lblContract;
        private GroupBox grpbxNewTicket;
        private Button btnClear;
        private Button btnSubmit;
        private TextBox txtbxPriority;
        private Label lblPriority;
        private TextBox txtbxDescription;
        private TextBox txtbxTypeOfError;
        private Label lblDescription;
        private Label lblTypeOfError;
        private TextBox txtbxClientID;
        private Label lblClientIDNewTicket;
        private Label lblTicketManagement;
        private Button btnEndCall;
        private TextBox txtbxCallDuration;
        private Label lblCallDuration;
        private Label lblPreviousTickets;
        private Label lblPreviousCalls;
        private Button btnDelete;
        private Button button2;
        private Button btnUpdate;
        private Button btnBack;
    }
}