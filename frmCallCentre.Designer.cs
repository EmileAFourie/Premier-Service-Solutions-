namespace Premier_Service_Solutions
{
    partial class frmCallCentre
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
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.lblIncomingCall = new System.Windows.Forms.Label();
            this.lblCallCentre = new System.Windows.Forms.Label();
            this.txtbxIncomingCall = new System.Windows.Forms.TextBox();
            this.txtbxCallerID = new System.Windows.Forms.TextBox();
            this.lblCallerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(266, 288);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(189, 33);
            this.btnDecline.TabIndex = 11;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.Location = new System.Drawing.Point(478, 288);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Size = new System.Drawing.Size(189, 33);
            this.btnAnswerCall.TabIndex = 10;
            this.btnAnswerCall.Text = "Answer Call";
            this.btnAnswerCall.UseVisualStyleBackColor = true;
            // 
            // lblIncomingCall
            // 
            this.lblIncomingCall.AutoSize = true;
            this.lblIncomingCall.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncomingCall.Location = new System.Drawing.Point(114, 154);
            this.lblIncomingCall.Name = "lblIncomingCall";
            this.lblIncomingCall.Size = new System.Drawing.Size(131, 28);
            this.lblIncomingCall.TabIndex = 7;
            this.lblIncomingCall.Text = "Incoming Call";
            // 
            // lblCallCentre
            // 
            this.lblCallCentre.AutoSize = true;
            this.lblCallCentre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCallCentre.Location = new System.Drawing.Point(319, 20);
            this.lblCallCentre.Name = "lblCallCentre";
            this.lblCallCentre.Size = new System.Drawing.Size(157, 37);
            this.lblCallCentre.TabIndex = 6;
            this.lblCallCentre.Text = "Call Center";
            // 
            // txtbxIncomingCall
            // 
            this.txtbxIncomingCall.Location = new System.Drawing.Point(266, 159);
            this.txtbxIncomingCall.Name = "txtbxIncomingCall";
            this.txtbxIncomingCall.Size = new System.Drawing.Size(401, 23);
            this.txtbxIncomingCall.TabIndex = 12;
            // 
            // txtbxCallerID
            // 
            this.txtbxCallerID.Location = new System.Drawing.Point(266, 203);
            this.txtbxCallerID.Name = "txtbxCallerID";
            this.txtbxCallerID.Size = new System.Drawing.Size(401, 23);
            this.txtbxCallerID.TabIndex = 14;
            // 
            // lblCallerID
            // 
            this.lblCallerID.AutoSize = true;
            this.lblCallerID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCallerID.Location = new System.Drawing.Point(114, 198);
            this.lblCallerID.Name = "lblCallerID";
            this.lblCallerID.Size = new System.Drawing.Size(85, 28);
            this.lblCallerID.TabIndex = 13;
            this.lblCallerID.Text = "Caller ID";
            this.lblCallerID.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCallCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxCallerID);
            this.Controls.Add(this.lblCallerID);
            this.Controls.Add(this.txtbxIncomingCall);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAnswerCall);
            this.Controls.Add(this.lblIncomingCall);
            this.Controls.Add(this.lblCallCentre);
            this.Name = "frmCallCentre";
            this.Text = "CallCentre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDecline;
        private Button btnAnswerCall;
        private Label lblIncomingCall;
        private Label lblCallCentre;
        private TextBox txtbxIncomingCall;
        private TextBox txtbxCallerID;
        private Label lblCallerID;
    }
}