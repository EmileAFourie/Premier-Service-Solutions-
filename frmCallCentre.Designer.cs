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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.Location = new System.Drawing.Point(478, 288);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Size = new System.Drawing.Size(189, 33);
            this.btnAnswerCall.TabIndex = 10;
            this.btnAnswerCall.Text = "Answer Call";
            this.btnAnswerCall.UseVisualStyleBackColor = true;
            this.btnAnswerCall.Click += new System.EventHandler(this.btnAnswerCall_Click);
            // 
            // lblIncomingCall
            // 
            this.lblIncomingCall.AutoSize = true;
            this.lblIncomingCall.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncomingCall.Location = new System.Drawing.Point(122, 117);
            this.lblIncomingCall.Name = "lblIncomingCall";
            this.lblIncomingCall.Size = new System.Drawing.Size(131, 28);
            this.lblIncomingCall.TabIndex = 7;
            this.lblIncomingCall.Text = "Incoming Call";
            // 
            // lblCallCentre
            // 
            this.lblCallCentre.AutoSize = true;
            this.lblCallCentre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCallCentre.Location = new System.Drawing.Point(365, 27);
            this.lblCallCentre.Name = "lblCallCentre";
            this.lblCallCentre.Size = new System.Drawing.Size(157, 37);
            this.lblCallCentre.TabIndex = 6;
            this.lblCallCentre.Text = "Call Center";
            // 
            // txtbxIncomingCall
            // 
            this.txtbxIncomingCall.Location = new System.Drawing.Point(296, 124);
            this.txtbxIncomingCall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxIncomingCall.Name = "txtbxIncomingCall";
            this.txtbxIncomingCall.Size = new System.Drawing.Size(371, 23);
            this.txtbxIncomingCall.TabIndex = 12;
            this.txtbxIncomingCall.Text = "+27 76 323 7618";
            // 
            // txtbxCallerID
            // 
            this.txtbxCallerID.Location = new System.Drawing.Point(296, 183);
            this.txtbxCallerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxCallerID.Name = "txtbxCallerID";
            this.txtbxCallerID.Size = new System.Drawing.Size(371, 23);
            this.txtbxCallerID.TabIndex = 14;
            this.txtbxCallerID.Text = "Emile Ayden Fourie";
            // 
            // lblCallerID
            // 
            this.lblCallerID.AutoSize = true;
            this.lblCallerID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCallerID.Location = new System.Drawing.Point(122, 176);
            this.lblCallerID.Name = "lblCallerID";
            this.lblCallerID.Size = new System.Drawing.Size(85, 28);
            this.lblCallerID.TabIndex = 13;
            this.lblCallerID.Text = "Caller ID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 556);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Back";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 22);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCallCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtbxCallerID);
            this.Controls.Add(this.lblCallerID);
            this.Controls.Add(this.txtbxIncomingCall);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAnswerCall);
            this.Controls.Add(this.lblIncomingCall);
            this.Controls.Add(this.lblCallCentre);
            this.Name = "frmCallCentre";
            this.Text = "Call Centre";
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
        private Button btnClear;
        private Button btnBack;
    }
}