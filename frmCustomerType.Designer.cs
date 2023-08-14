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

            this.btnNewCustomer.Location = new System.Drawing.Point(253, 296);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(189, 33);
            this.btnNewCustomer.TabIndex = 18;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnOldCustomer
            // 
            this.btnOldCustomer.Location = new System.Drawing.Point(465, 296);
            this.btnOldCustomer.Name = "btnOldCustomer";
            this.btnOldCustomer.Size = new System.Drawing.Size(189, 33);
            this.btnOldCustomer.TabIndex = 17;
            this.btnOldCustomer.Text = "Old Customer";
            this.btnOldCustomer.UseVisualStyleBackColor = true;
            this.btnOldCustomer.Click += new System.EventHandler(this.btnOldCustomer_Click);

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

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCallerNumber);
            this.Controls.Add(this.txtbxCallDuration);
            this.Controls.Add(this.lblCallDuration);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtbxTimestamp);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnOldCustomer);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblCallCentre);
            this.Name = "frmCustomerType";
            this.Text = "Customer Type";
            this.ResumeLayout(false);
            this.PerformLayout();


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