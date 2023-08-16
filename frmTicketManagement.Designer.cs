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
            dgvPreviousTickets = new DataGridView();
            lblClient = new Label();
            txtbxClient = new TextBox();
            txtbxContract = new TextBox();
            lblContract = new Label();
            grpbxNewTicket = new GroupBox();
            btnUpdate = new Button();
            btnClear = new Button();
            btnSubmit = new Button();
            txtbxPriority = new TextBox();
            lblPriority = new Label();
            txtbxDescription = new TextBox();
            txtbxTypeOfError = new TextBox();
            lblDescription = new Label();
            lblTypeOfError = new Label();
            txtbxClientID = new TextBox();
            lblClientIDNewTicket = new Label();
            btnDelete = new Button();
            lblTicketManagement = new Label();
            btnEndCall = new Button();
            txtbxCallDuration = new TextBox();
            lblCallDuration = new Label();
            lblPreviousTickets = new Label();
            btnBack = new Button();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPreviousTickets).BeginInit();
            grpbxNewTicket.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPreviousTickets
            // 
            dgvPreviousTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreviousTickets.Location = new Point(29, 65);
            dgvPreviousTickets.Margin = new Padding(3, 4, 3, 4);
            dgvPreviousTickets.Name = "dgvPreviousTickets";
            dgvPreviousTickets.RowHeadersWidth = 51;
            dgvPreviousTickets.RowTemplate.Height = 25;
            dgvPreviousTickets.Size = new Size(862, 225);
            dgvPreviousTickets.TabIndex = 0;
            dgvPreviousTickets.CellClick += dgvPreviousTickets_CellClick;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = Color.Transparent;
            lblClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClient.ForeColor = SystemColors.ButtonHighlight;
            lblClient.Location = new Point(690, 367);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(42, 15);
            lblClient.TabIndex = 2;
            lblClient.Text = "Client:";
            // 
            // txtbxClient
            // 
            txtbxClient.Location = new Point(749, 364);
            txtbxClient.Margin = new Padding(3, 4, 3, 4);
            txtbxClient.Name = "txtbxClient";
            txtbxClient.Size = new Size(142, 23);
            txtbxClient.TabIndex = 3;
            // 
            // txtbxContract
            // 
            txtbxContract.Location = new Point(749, 414);
            txtbxContract.Margin = new Padding(3, 4, 3, 4);
            txtbxContract.Name = "txtbxContract";
            txtbxContract.Size = new Size(142, 23);
            txtbxContract.TabIndex = 5;
            // 
            // lblContract
            // 
            lblContract.AutoSize = true;
            lblContract.BackColor = Color.Transparent;
            lblContract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContract.ForeColor = SystemColors.ButtonHighlight;
            lblContract.Location = new Point(674, 422);
            lblContract.Name = "lblContract";
            lblContract.Size = new Size(58, 15);
            lblContract.TabIndex = 4;
            lblContract.Text = "Contract:";
            // 
            // grpbxNewTicket
            // 
            grpbxNewTicket.BackColor = Color.Transparent;
            grpbxNewTicket.Controls.Add(btnUpdate);
            grpbxNewTicket.Controls.Add(btnClear);
            grpbxNewTicket.Controls.Add(btnSubmit);
            grpbxNewTicket.Controls.Add(txtbxPriority);
            grpbxNewTicket.Controls.Add(lblPriority);
            grpbxNewTicket.Controls.Add(txtbxDescription);
            grpbxNewTicket.Controls.Add(txtbxTypeOfError);
            grpbxNewTicket.Controls.Add(lblDescription);
            grpbxNewTicket.Controls.Add(lblTypeOfError);
            grpbxNewTicket.Controls.Add(txtbxClientID);
            grpbxNewTicket.Controls.Add(lblClientIDNewTicket);
            grpbxNewTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpbxNewTicket.ForeColor = SystemColors.ButtonHighlight;
            grpbxNewTicket.Location = new Point(29, 348);
            grpbxNewTicket.Margin = new Padding(3, 4, 3, 4);
            grpbxNewTicket.Name = "grpbxNewTicket";
            grpbxNewTicket.Padding = new Padding(3, 4, 3, 4);
            grpbxNewTicket.Size = new Size(608, 264);
            grpbxNewTicket.TabIndex = 6;
            grpbxNewTicket.TabStop = false;
            grpbxNewTicket.Text = "Ticket";
            grpbxNewTicket.Enter += grpbxNewTicket_Enter;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(293, 214);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 32);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(121, 214);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 32);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmit.Location = new Point(461, 214);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(104, 32);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Add";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtbxPriority
            // 
            txtbxPriority.Location = new Point(125, 169);
            txtbxPriority.Name = "txtbxPriority";
            txtbxPriority.Size = new Size(440, 23);
            txtbxPriority.TabIndex = 17;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriority.ForeColor = SystemColors.ButtonHighlight;
            lblPriority.Location = new Point(31, 172);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(51, 15);
            lblPriority.TabIndex = 16;
            lblPriority.Text = "Priority:";
            // 
            // txtbxDescription
            // 
            txtbxDescription.Location = new Point(125, 123);
            txtbxDescription.Margin = new Padding(3, 4, 3, 4);
            txtbxDescription.Name = "txtbxDescription";
            txtbxDescription.Size = new Size(440, 23);
            txtbxDescription.TabIndex = 15;
            // 
            // txtbxTypeOfError
            // 
            txtbxTypeOfError.Location = new Point(125, 76);
            txtbxTypeOfError.Margin = new Padding(3, 4, 3, 4);
            txtbxTypeOfError.Name = "txtbxTypeOfError";
            txtbxTypeOfError.Size = new Size(440, 23);
            txtbxTypeOfError.TabIndex = 13;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ButtonHighlight;
            lblDescription.Location = new Point(29, 123);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(74, 15);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // lblTypeOfError
            // 
            lblTypeOfError.AutoSize = true;
            lblTypeOfError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypeOfError.ForeColor = SystemColors.ButtonHighlight;
            lblTypeOfError.Location = new Point(29, 79);
            lblTypeOfError.Name = "lblTypeOfError";
            lblTypeOfError.Size = new Size(78, 15);
            lblTypeOfError.TabIndex = 12;
            lblTypeOfError.Text = "TypeOfError:";
            // 
            // txtbxClientID
            // 
            txtbxClientID.Location = new Point(125, 35);
            txtbxClientID.Name = "txtbxClientID";
            txtbxClientID.Size = new Size(440, 23);
            txtbxClientID.TabIndex = 11;
            // 
            // lblClientIDNewTicket
            // 
            lblClientIDNewTicket.AutoSize = true;
            lblClientIDNewTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientIDNewTicket.ForeColor = SystemColors.ButtonHighlight;
            lblClientIDNewTicket.Location = new Point(48, 38);
            lblClientIDNewTicket.Name = "lblClientIDNewTicket";
            lblClientIDNewTicket.Size = new Size(55, 15);
            lblClientIDNewTicket.TabIndex = 10;
            lblClientIDNewTicket.Text = "ClientID:";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(414, 309);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 32);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTicketManagement
            // 
            lblTicketManagement.AutoSize = true;
            lblTicketManagement.BackColor = Color.Transparent;
            lblTicketManagement.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicketManagement.ForeColor = SystemColors.ButtonHighlight;
            lblTicketManagement.Location = new Point(347, 24);
            lblTicketManagement.Name = "lblTicketManagement";
            lblTicketManagement.Size = new Size(273, 37);
            lblTicketManagement.TabIndex = 7;
            lblTicketManagement.Text = "Ticket Management";
            // 
            // btnEndCall
            // 
            btnEndCall.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEndCall.Location = new Point(848, 587);
            btnEndCall.Margin = new Padding(3, 4, 3, 4);
            btnEndCall.Name = "btnEndCall";
            btnEndCall.Size = new Size(65, 43);
            btnEndCall.TabIndex = 23;
            btnEndCall.Text = "End Call";
            btnEndCall.UseVisualStyleBackColor = true;
            btnEndCall.Click += btnEndCall_Click;
            // 
            // txtbxCallDuration
            // 
            txtbxCallDuration.Location = new Point(733, 598);
            txtbxCallDuration.Margin = new Padding(3, 4, 3, 4);
            txtbxCallDuration.Name = "txtbxCallDuration";
            txtbxCallDuration.Size = new Size(107, 23);
            txtbxCallDuration.TabIndex = 25;
            // 
            // lblCallDuration
            // 
            lblCallDuration.AutoSize = true;
            lblCallDuration.BackColor = Color.Transparent;
            lblCallDuration.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCallDuration.ForeColor = SystemColors.ButtonHighlight;
            lblCallDuration.Location = new Point(643, 606);
            lblCallDuration.Name = "lblCallDuration";
            lblCallDuration.Size = new Size(84, 15);
            lblCallDuration.TabIndex = 24;
            lblCallDuration.Text = "Date Opened:";
            // 
            // lblPreviousTickets
            // 
            lblPreviousTickets.AutoSize = true;
            lblPreviousTickets.BackColor = Color.Transparent;
            lblPreviousTickets.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreviousTickets.ForeColor = SystemColors.ButtonHighlight;
            lblPreviousTickets.Location = new Point(29, 33);
            lblPreviousTickets.Name = "lblPreviousTickets";
            lblPreviousTickets.Size = new Size(84, 28);
            lblPreviousTickets.TabIndex = 26;
            lblPreviousTickets.Text = "Tickets:";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 22);
            btnBack.TabIndex = 27;
            btnBack.Text = "<<<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Location = new Point(58, 8);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(72, 22);
            btnHome.TabIndex = 28;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // frmTicketManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(925, 643);
            Controls.Add(btnHome);
            Controls.Add(btnBack);
            Controls.Add(lblPreviousTickets);
            Controls.Add(btnDelete);
            Controls.Add(txtbxCallDuration);
            Controls.Add(lblCallDuration);
            Controls.Add(btnEndCall);
            Controls.Add(lblTicketManagement);
            Controls.Add(grpbxNewTicket);
            Controls.Add(txtbxContract);
            Controls.Add(lblContract);
            Controls.Add(txtbxClient);
            Controls.Add(lblClient);
            Controls.Add(dgvPreviousTickets);
            Name = "frmTicketManagement";
            Text = "Ticket Management";
            Load += frmTicketManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPreviousTickets).EndInit();
            grpbxNewTicket.ResumeLayout(false);
            grpbxNewTicket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}