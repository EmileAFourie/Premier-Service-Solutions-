﻿namespace Premier_Service_Solutions
{
    partial class frmNewEmployee
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
            this.txtbxEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxEmployeeID
            // 
            this.txtbxEmployeeID.Location = new System.Drawing.Point(285, 140);
            this.txtbxEmployeeID.Name = "txtbxEmployeeID";
            this.txtbxEmployeeID.Size = new System.Drawing.Size(296, 23);
            this.txtbxEmployeeID.TabIndex = 0;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(189, 143);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(73, 15);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "EmployeeID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(297, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Centre";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(221, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(285, 177);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(296, 23);
            this.txtbxName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(285, 218);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(296, 23);
            this.txtbxEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position:";
            // 
            // txtbxPosition
            // 
            this.txtbxPosition.Location = new System.Drawing.Point(285, 263);
            this.txtbxPosition.Name = "txtbxPosition";
            this.txtbxPosition.Size = new System.Drawing.Size(296, 23);
            this.txtbxPosition.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Age:";
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(285, 303);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(296, 23);
            this.txtbxAge.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(285, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(506, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtbxEmployeeID);
            this.Name = "frmNewEmployee";
            this.Text = "frmNewEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbxEmployeeID;
        private Label lblEmployeeID;
        private Label label2;
        private Label lblName;
        private TextBox txtbxName;
        private Label label4;
        private TextBox txtbxEmail;
        private Label label5;
        private TextBox txtbxPosition;
        private Label label6;
        private TextBox txtbxAge;
        private Button btnClear;
        private Button btnSubmit;
    }
}