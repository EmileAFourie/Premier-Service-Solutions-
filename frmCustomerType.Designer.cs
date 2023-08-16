namespace Premier_Service_Solutions
{
    partial class frmCustomerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerType));
            this.txtbxTimestamp = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnOldCustomer = new System.Windows.Forms.Button();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblCallCentre = new System.Windows.Forms.Label();
            this.txtbxCallDuration = new System.Windows.Forms.TextBox();
            this.lblCallDuration = new System.Windows.Forms.Label();
            this.txtbxCallerNumber = new System.Windows.Forms.TextBox();
            this.lblCallerNumber = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxTimestamp
            // 
            this.txtbxTimestamp.Location = new System.Drawing.Point(289, 144);
            this.txtbxTimestamp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxTimestamp.Name = "txtbxTimestamp";
            this.txtbxTimestamp.Size = new System.Drawing.Size(316, 23);
            this.txtbxTimestamp.TabIndex = 19;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewCustomer.Location = new System.Drawing.Point(204, 297);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(189, 33);
            this.btnNewCustomer.TabIndex = 18;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnOldCustomer
            // 
            this.btnOldCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOldCustomer.Location = new System.Drawing.Point(416, 297);
            this.btnOldCustomer.Name = "btnOldCustomer";
            this.btnOldCustomer.Size = new System.Drawing.Size(189, 33);
            this.btnOldCustomer.TabIndex = 17;
            this.btnOldCustomer.Text = "Old Customer";
            this.btnOldCustomer.UseVisualStyleBackColor = true;
            this.btnOldCustomer.Click += new System.EventHandler(this.btnOldCustomer_Click);
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.BackColor = System.Drawing.Color.Transparent;
            this.lblTimestamp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimestamp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimestamp.Location = new System.Drawing.Point(115, 137);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(112, 28);
            this.lblTimestamp.TabIndex = 16;
            this.lblTimestamp.Text = "Timestamp:";
            // 
            // lblCallCentre
            // 
            this.lblCallCentre.AutoSize = true;
            this.lblCallCentre.BackColor = System.Drawing.Color.Transparent;
            this.lblCallCentre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCallCentre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCallCentre.Location = new System.Drawing.Point(321, 37);
            this.lblCallCentre.Name = "lblCallCentre";
            this.lblCallCentre.Size = new System.Drawing.Size(157, 37);
            this.lblCallCentre.TabIndex = 15;
            this.lblCallCentre.Text = "Call Center";
            // 
            // txtbxCallDuration
            // 
            this.txtbxCallDuration.Location = new System.Drawing.Point(793, 557);
            this.txtbxCallDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxCallDuration.Name = "txtbxCallDuration";
            this.txtbxCallDuration.Size = new System.Drawing.Size(107, 23);
            this.txtbxCallDuration.TabIndex = 22;
            // 
            // lblCallDuration
            // 
            this.lblCallDuration.AutoSize = true;
            this.lblCallDuration.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCallDuration.Location = new System.Drawing.Point(619, 551);
            this.lblCallDuration.Name = "lblCallDuration";
            this.lblCallDuration.Size = new System.Drawing.Size(126, 28);
            this.lblCallDuration.TabIndex = 21;
            this.lblCallDuration.Text = "Call Duration";
            // 
            // txtbxCallerNumber
            // 
            this.txtbxCallerNumber.Location = new System.Drawing.Point(289, 198);
            this.txtbxCallerNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxCallerNumber.Name = "txtbxCallerNumber";
            this.txtbxCallerNumber.Size = new System.Drawing.Size(316, 23);
            this.txtbxCallerNumber.TabIndex = 24;
            // 
            // lblCallerNumber
            // 
            this.lblCallerNumber.AutoSize = true;
            this.lblCallerNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCallerNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCallerNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCallerNumber.Location = new System.Drawing.Point(115, 192);
            this.lblCallerNumber.Name = "lblCallerNumber";
            this.lblCallerNumber.Size = new System.Drawing.Size(142, 28);
            this.lblCallerNumber.TabIndex = 23;
            this.lblCallerNumber.Text = "Caller Number:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 551);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 33);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Back";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxCallerNumber);
            this.Controls.Add(this.lblCallerNumber);
            this.Controls.Add(this.txtbxCallDuration);
            this.Controls.Add(this.lblCallDuration);
            this.Controls.Add(this.txtbxTimestamp);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnOldCustomer);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblCallCentre);
            this.Name = "frmCustomerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Type";
            this.Load += new System.EventHandler(this.frmCustomerType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbxTimestamp;
        private Button btnNewCustomer;
        private Button btnOldCustomer;
        private Label lblTimestamp;
        private Label lblCallCentre;
        private TextBox txtbxCallDuration;
        private Label lblCallDuration;
        private TextBox txtbxCallerNumber;
        private Label lblCallerNumber;
        private Button btnClear;
    }
}