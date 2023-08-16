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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketManagement));
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousTickets)).BeginInit();
            this.grpbxNewTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPreviousTickets
            // 
            this.dgvPreviousTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviousTickets.Location = new System.Drawing.Point(29, 65);
            this.dgvPreviousTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPreviousTickets.Name = "dgvPreviousTickets";
            this.dgvPreviousTickets.RowHeadersWidth = 51;
            this.dgvPreviousTickets.RowTemplate.Height = 25;
            this.dgvPreviousTickets.Size = new System.Drawing.Size(862, 225);
            this.dgvPreviousTickets.TabIndex = 0;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClient.Location = new System.Drawing.Point(690, 367);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(42, 15);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client:";
            // 
            // txtbxClient
            // 
            this.txtbxClient.Location = new System.Drawing.Point(749, 364);
            this.txtbxClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxClient.Name = "txtbxClient";
            this.txtbxClient.Size = new System.Drawing.Size(142, 23);
            this.txtbxClient.TabIndex = 3;
            // 
            // txtbxContract
            // 
            this.txtbxContract.Location = new System.Drawing.Point(749, 414);
            this.txtbxContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxContract.Name = "txtbxContract";
            this.txtbxContract.Size = new System.Drawing.Size(142, 23);
            this.txtbxContract.TabIndex = 5;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.BackColor = System.Drawing.Color.Transparent;
            this.lblContract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContract.Location = new System.Drawing.Point(674, 422);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(58, 15);
            this.lblContract.TabIndex = 4;
            this.lblContract.Text = "Contract:";
            // 
            // grpbxNewTicket
            // 
            this.grpbxNewTicket.BackColor = System.Drawing.Color.Transparent;
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
            this.grpbxNewTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpbxNewTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbxNewTicket.Location = new System.Drawing.Point(29, 348);
            this.grpbxNewTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbxNewTicket.Name = "grpbxNewTicket";
            this.grpbxNewTicket.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpbxNewTicket.Size = new System.Drawing.Size(608, 264);
            this.grpbxNewTicket.TabIndex = 6;
            this.grpbxNewTicket.TabStop = false;
            this.grpbxNewTicket.Text = "Ticket";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(293, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 32);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(121, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 32);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(461, 214);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 32);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtbxPriority
            // 
            this.txtbxPriority.Location = new System.Drawing.Point(125, 169);
            this.txtbxPriority.Name = "txtbxPriority";
            this.txtbxPriority.Size = new System.Drawing.Size(440, 23);
            this.txtbxPriority.TabIndex = 17;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPriority.Location = new System.Drawing.Point(31, 172);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(51, 15);
            this.lblPriority.TabIndex = 16;
            this.lblPriority.Text = "Priority:";
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Location = new System.Drawing.Point(125, 123);
            this.txtbxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(440, 23);
            this.txtbxDescription.TabIndex = 15;
            // 
            // txtbxTypeOfError
            // 
            this.txtbxTypeOfError.Location = new System.Drawing.Point(125, 76);
            this.txtbxTypeOfError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxTypeOfError.Name = "txtbxTypeOfError";
            this.txtbxTypeOfError.Size = new System.Drawing.Size(440, 23);
            this.txtbxTypeOfError.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Location = new System.Drawing.Point(29, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 15);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblTypeOfError
            // 
            this.lblTypeOfError.AutoSize = true;
            this.lblTypeOfError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTypeOfError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTypeOfError.Location = new System.Drawing.Point(29, 79);
            this.lblTypeOfError.Name = "lblTypeOfError";
            this.lblTypeOfError.Size = new System.Drawing.Size(78, 15);
            this.lblTypeOfError.TabIndex = 12;
            this.lblTypeOfError.Text = "TypeOfError:";
            // 
            // txtbxClientID
            // 
            this.txtbxClientID.Location = new System.Drawing.Point(125, 35);
            this.txtbxClientID.Name = "txtbxClientID";
            this.txtbxClientID.Size = new System.Drawing.Size(440, 23);
            this.txtbxClientID.TabIndex = 11;
            // 
            // lblClientIDNewTicket
            // 
            this.lblClientIDNewTicket.AutoSize = true;
            this.lblClientIDNewTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientIDNewTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClientIDNewTicket.Location = new System.Drawing.Point(48, 38);
            this.lblClientIDNewTicket.Name = "lblClientIDNewTicket";
            this.lblClientIDNewTicket.Size = new System.Drawing.Size(55, 15);
            this.lblClientIDNewTicket.TabIndex = 10;
            this.lblClientIDNewTicket.Text = "ClientID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(414, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 32);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTicketManagement
            // 
            this.lblTicketManagement.AutoSize = true;
            this.lblTicketManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketManagement.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTicketManagement.Location = new System.Drawing.Point(347, 24);
            this.lblTicketManagement.Name = "lblTicketManagement";
            this.lblTicketManagement.Size = new System.Drawing.Size(273, 37);
            this.lblTicketManagement.TabIndex = 7;
            this.lblTicketManagement.Text = "Ticket Management";
            // 
            // btnEndCall
            // 
            this.btnEndCall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndCall.Location = new System.Drawing.Point(848, 587);
            this.btnEndCall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(65, 43);
            this.btnEndCall.TabIndex = 23;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.UseVisualStyleBackColor = true;
            // 
            // txtbxCallDuration
            // 
            this.txtbxCallDuration.Location = new System.Drawing.Point(733, 598);
            this.txtbxCallDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxCallDuration.Name = "txtbxCallDuration";
            this.txtbxCallDuration.Size = new System.Drawing.Size(107, 23);
            this.txtbxCallDuration.TabIndex = 25;
            // 
            // lblCallDuration
            // 
            this.lblCallDuration.AutoSize = true;
            this.lblCallDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblCallDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCallDuration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCallDuration.Location = new System.Drawing.Point(643, 606);
            this.lblCallDuration.Name = "lblCallDuration";
            this.lblCallDuration.Size = new System.Drawing.Size(84, 15);
            this.lblCallDuration.TabIndex = 24;
            this.lblCallDuration.Text = "Date Opened:";
            // 
            // lblPreviousTickets
            // 
            this.lblPreviousTickets.AutoSize = true;
            this.lblPreviousTickets.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviousTickets.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreviousTickets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPreviousTickets.Location = new System.Drawing.Point(29, 33);
            this.lblPreviousTickets.Name = "lblPreviousTickets";
            this.lblPreviousTickets.Size = new System.Drawing.Size(84, 28);
            this.lblPreviousTickets.TabIndex = 26;
            this.lblPreviousTickets.Text = "Tickets:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 22);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(58, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 22);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(841, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(72, 29);
            this.btnLogOut.TabIndex = 29;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmTicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 643);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnHome);
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
        private Button btnHome;
        private Button btnLogOut;
    }
}