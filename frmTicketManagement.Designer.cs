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

            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtbxClient = new System.Windows.Forms.TextBox();
            this.txtbxContract = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.grpbxNewTicket = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtbxAssignedTo = new System.Windows.Forms.TextBox();
            this.txtbxPriority = new System.Windows.Forms.TextBox();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtbxDescription = new System.Windows.Forms.TextBox();
            this.txtbxTypeOfError = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTypeOfError = new System.Windows.Forms.Label();
            this.txtbxClientID = new System.Windows.Forms.TextBox();
            this.txtbxTicketID = new System.Windows.Forms.TextBox();
            this.lblClientIDNewTicket = new System.Windows.Forms.Label();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.lblTicketManagement = new System.Windows.Forms.Label();
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

            this.btnClear.Location = new System.Drawing.Point(133, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 32);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(270, 224);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 32);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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

            this.lblTypeOfError.AutoSize = true;
            this.lblTypeOfError.Location = new System.Drawing.Point(11, 98);
            this.lblTypeOfError.Name = "lblTypeOfError";
            this.lblTypeOfError.Size = new System.Drawing.Size(72, 15);
            this.lblTypeOfError.TabIndex = 12;
            this.lblTypeOfError.Text = "TypeOfError:";
            // 
            // txtbxClientID
            // 
            this.txtbxClientID.Location = new System.Drawing.Point(88, 63);
            this.txtbxClientID.Name = "txtbxClientID";
            this.txtbxClientID.Size = new System.Drawing.Size(336, 23);
            this.txtbxClientID.TabIndex = 11;
            // 
            // txtbxTicketID
            // 
            this.txtbxTicketID.Location = new System.Drawing.Point(88, 34);
            this.txtbxTicketID.Name = "txtbxTicketID";
            this.txtbxTicketID.Size = new System.Drawing.Size(336, 23);
            this.txtbxTicketID.TabIndex = 9;
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
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Location = new System.Drawing.Point(11, 37);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(52, 15);
            this.lblTicketID.TabIndex = 8;
            this.lblTicketID.Text = "TicketID:";
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
            this.Text = "Ticket Management";
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
        private Button button1;
    }
}