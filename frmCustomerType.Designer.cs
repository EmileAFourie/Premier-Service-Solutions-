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
            txtbxTimestamp = new TextBox();
            btnNewCustomer = new Button();
            btnOldCustomer = new Button();
            lblTimestamp = new Label();
            lblCallCentre = new Label();
            btn = new Button();
            txtbxCallDuration = new TextBox();
            lblCallDuration = new Label();
            textBox1 = new TextBox();
            lblCallerNumber = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtbxTimestamp
            // 
            txtbxTimestamp.Location = new Point(289, 223);
            txtbxTimestamp.Margin = new Padding(3, 4, 3, 4);
            txtbxTimestamp.Name = "txtbxTimestamp";
            txtbxTimestamp.Size = new Size(458, 27);
            txtbxTimestamp.TabIndex = 19;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Location = new Point(289, 395);
            btnNewCustomer.Margin = new Padding(3, 4, 3, 4);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(216, 44);
            btnNewCustomer.TabIndex = 18;
            btnNewCustomer.Text = "New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnOldCustomer
            // 
            btnOldCustomer.Location = new Point(531, 395);
            btnOldCustomer.Margin = new Padding(3, 4, 3, 4);
            btnOldCustomer.Name = "btnOldCustomer";
            btnOldCustomer.Size = new Size(216, 44);
            btnOldCustomer.TabIndex = 17;
            btnOldCustomer.Text = "Old Customer";
            btnOldCustomer.UseVisualStyleBackColor = true;
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimestamp.Location = new Point(115, 216);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(143, 35);
            lblTimestamp.TabIndex = 16;
            lblTimestamp.Text = "Timestamp:";
            // 
            // lblCallCentre
            // 
            lblCallCentre.AutoSize = true;
            lblCallCentre.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCallCentre.Location = new Point(350, 37);
            lblCallCentre.Name = "lblCallCentre";
            lblCallCentre.Size = new Size(193, 46);
            lblCallCentre.TabIndex = 15;
            lblCallCentre.Text = "Call Center";
            // 
            // btn
            // 
            btn.Location = new Point(14, 16);
            btn.Margin = new Padding(3, 4, 3, 4);
            btn.Name = "btn";
            btn.Size = new Size(57, 43);
            btn.TabIndex = 20;
            btn.Text = "<";
            btn.UseVisualStyleBackColor = true;
            // 
            // txtbxCallDuration
            // 
            txtbxCallDuration.Location = new Point(793, 557);
            txtbxCallDuration.Margin = new Padding(3, 4, 3, 4);
            txtbxCallDuration.Name = "txtbxCallDuration";
            txtbxCallDuration.Size = new Size(107, 27);
            txtbxCallDuration.TabIndex = 22;
            txtbxCallDuration.TextChanged += textBox1_TextChanged;
            // 
            // lblCallDuration
            // 
            lblCallDuration.AutoSize = true;
            lblCallDuration.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCallDuration.Location = new Point(619, 551);
            lblCallDuration.Name = "lblCallDuration";
            lblCallDuration.Size = new Size(159, 35);
            lblCallDuration.TabIndex = 21;
            lblCallDuration.Text = "Call Duration";
            lblCallDuration.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 277);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(458, 27);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // lblCallerNumber
            // 
            lblCallerNumber.AutoSize = true;
            lblCallerNumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCallerNumber.Location = new Point(115, 271);
            lblCallerNumber.Name = "lblCallerNumber";
            lblCallerNumber.Size = new Size(181, 35);
            lblCallerNumber.TabIndex = 23;
            lblCallerNumber.Text = "Caller Number:";
            lblCallerNumber.Click += label1_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(14, 551);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(155, 33);
            btnClear.TabIndex = 25;
            btnClear.Text = "Back";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // frmCustomerType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnClear);
            Controls.Add(textBox1);
            Controls.Add(lblCallerNumber);
            Controls.Add(txtbxCallDuration);
            Controls.Add(lblCallDuration);
            Controls.Add(btn);
            Controls.Add(txtbxTimestamp);
            Controls.Add(btnNewCustomer);
            Controls.Add(btnOldCustomer);
            Controls.Add(lblTimestamp);
            Controls.Add(lblCallCentre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCustomerType";
            Text = "frmCustomerType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxTimestamp;
        private Button btnNewCustomer;
        private Button btnOldCustomer;
        private Label lblTimestamp;
        private Label lblCallCentre;
        private Button btn;
        private TextBox txtbxCallDuration;
        private Label lblCallDuration;
        private TextBox textBox1;
        private Label lblCallerNumber;
        private Button btnClear;
    }
}