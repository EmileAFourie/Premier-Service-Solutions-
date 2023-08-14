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
            btnDecline = new Button();
            btnAnswerCall = new Button();
            lblIncomingCall = new Label();
            lblCallCentre = new Label();
            txtbxIncomingCall = new TextBox();
            txtbxCallerID = new TextBox();
            lblCallerID = new Label();
            btnClear = new Button();
            SuspendLayout();
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
            lblIncomingCall.AutoSize = true;
            lblIncomingCall.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncomingCall.Location = new Point(130, 205);
            lblIncomingCall.Name = "lblIncomingCall";
            lblIncomingCall.Size = new Size(167, 35);
            lblIncomingCall.TabIndex = 7;
            lblIncomingCall.Text = "Incoming Call";
            // 
            // lblCallCentre
            // 
            lblCallCentre.AutoSize = true;
            lblCallCentre.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCallCentre.Location = new Point(365, 27);
            lblCallCentre.Name = "lblCallCentre";
            lblCallCentre.Size = new Size(193, 46);
            lblCallCentre.TabIndex = 6;
            lblCallCentre.Text = "Call Center";
            // 
            // txtbxIncomingCall
            // 
            txtbxIncomingCall.Location = new Point(304, 212);
            txtbxIncomingCall.Margin = new Padding(3, 4, 3, 4);
            txtbxIncomingCall.Name = "txtbxIncomingCall";
            txtbxIncomingCall.Size = new Size(458, 27);
            txtbxIncomingCall.TabIndex = 12;
            // 
            // txtbxCallerID
            // 
            txtbxCallerID.Location = new Point(304, 271);
            txtbxCallerID.Margin = new Padding(3, 4, 3, 4);
            txtbxCallerID.Name = "txtbxCallerID";
            txtbxCallerID.Size = new Size(458, 27);
            txtbxCallerID.TabIndex = 14;
            // 
            // lblCallerID
            // 
            lblCallerID.AutoSize = true;
            lblCallerID.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCallerID.Location = new Point(130, 264);
            lblCallerID.Name = "lblCallerID";
            lblCallerID.Size = new Size(109, 35);
            lblCallerID.TabIndex = 13;
            lblCallerID.Text = "Caller ID";
            lblCallerID.Click += label1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 556);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 20;
            btnClear.Text = "Back";
            btnClear.UseVisualStyleBackColor = true;
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
    }
}