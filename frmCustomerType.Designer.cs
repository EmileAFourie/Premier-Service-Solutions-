﻿namespace Premier_Service_Solutions
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
            this.txtbxTimestamp = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnOldCustomer = new System.Windows.Forms.Button();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblCallCentre = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtbxCallDuration = new System.Windows.Forms.TextBox();
            this.lblCallDuration = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCallerNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxTimestamp
            // 
            this.txtbxTimestamp.Location = new System.Drawing.Point(253, 167);
            this.txtbxTimestamp.Name = "txtbxTimestamp";
            this.txtbxTimestamp.Size = new System.Drawing.Size(401, 23);
            this.txtbxTimestamp.TabIndex = 19;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(253, 296);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(189, 33);
            this.btnNewCustomer.TabIndex = 18;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnOldCustomer
            // 
            this.btnOldCustomer.Location = new System.Drawing.Point(465, 296);
            this.btnOldCustomer.Name = "btnOldCustomer";
            this.btnOldCustomer.Size = new System.Drawing.Size(189, 33);
            this.btnOldCustomer.TabIndex = 17;
            this.btnOldCustomer.Text = "Old Customer";
            this.btnOldCustomer.UseVisualStyleBackColor = true;
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimestamp.Location = new System.Drawing.Point(101, 162);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(112, 28);
            this.lblTimestamp.TabIndex = 16;
            this.lblTimestamp.Text = "Timestamp:";
            // 
            // lblCallCentre
            // 
            this.lblCallCentre.AutoSize = true;
            this.lblCallCentre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCallCentre.Location = new System.Drawing.Point(306, 28);
            this.lblCallCentre.Name = "lblCallCentre";
            this.lblCallCentre.Size = new System.Drawing.Size(157, 37);
            this.lblCallCentre.TabIndex = 15;
            this.lblCallCentre.Text = "Call Center";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(50, 32);
            this.btn.TabIndex = 20;
            this.btn.Text = "<";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // txtbxCallDuration
            // 
            this.txtbxCallDuration.Location = new System.Drawing.Point(694, 418);
            this.txtbxCallDuration.Name = "txtbxCallDuration";
            this.txtbxCallDuration.Size = new System.Drawing.Size(94, 23);
            this.txtbxCallDuration.TabIndex = 22;
            this.txtbxCallDuration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCallDuration
            // 
            this.lblCallDuration.AutoSize = true;
            this.lblCallDuration.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCallDuration.Location = new System.Drawing.Point(542, 413);
            this.lblCallDuration.Name = "lblCallDuration";
            this.lblCallDuration.Size = new System.Drawing.Size(126, 28);
            this.lblCallDuration.TabIndex = 21;
            this.lblCallDuration.Text = "Call Duration";
            this.lblCallDuration.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 23);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblCallerNumber
            // 
            this.lblCallerNumber.AutoSize = true;
            this.lblCallerNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCallerNumber.Location = new System.Drawing.Point(101, 203);
            this.lblCallerNumber.Name = "lblCallerNumber";
            this.lblCallerNumber.Size = new System.Drawing.Size(142, 28);
            this.lblCallerNumber.TabIndex = 23;
            this.lblCallerNumber.Text = "Caller Number:";
            this.lblCallerNumber.Click += new System.EventHandler(this.label1_Click_1);
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
            this.Text = "frmCustomerType";
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
    }
}