﻿namespace Premier_Service_Solutions
{
    partial class frmContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContracts));
            this.lblContracts = new System.Windows.Forms.Label();
            this.btnViewContractPerformance = new System.Windows.Forms.Button();
            this.btnEditContracts = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContracts
            // 
            this.lblContracts.AutoSize = true;
            this.lblContracts.BackColor = System.Drawing.Color.Transparent;
            this.lblContracts.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContracts.ForeColor = System.Drawing.Color.Transparent;
            this.lblContracts.Location = new System.Drawing.Point(323, 32);
            this.lblContracts.Name = "lblContracts";
            this.lblContracts.Size = new System.Drawing.Size(140, 37);
            this.lblContracts.TabIndex = 0;
            this.lblContracts.Text = "Contracts";
            // 
            // btnViewContractPerformance
            // 
            this.btnViewContractPerformance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewContractPerformance.Location = new System.Drawing.Point(293, 225);
            this.btnViewContractPerformance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewContractPerformance.Name = "btnViewContractPerformance";
            this.btnViewContractPerformance.Size = new System.Drawing.Size(206, 67);
            this.btnViewContractPerformance.TabIndex = 1;
            this.btnViewContractPerformance.Text = "View Contract Performance";
            this.btnViewContractPerformance.UseVisualStyleBackColor = true;
            this.btnViewContractPerformance.Click += new System.EventHandler(this.btnViewContractPerformance_Click);
            // 
            // btnEditContracts
            // 
            this.btnEditContracts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditContracts.Location = new System.Drawing.Point(293, 125);
            this.btnEditContracts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditContracts.Name = "btnEditContracts";
            this.btnEditContracts.Size = new System.Drawing.Size(206, 67);
            this.btnEditContracts.TabIndex = 2;
            this.btnEditContracts.Text = "Edit Contracts";
            this.btnEditContracts.UseVisualStyleBackColor = true;
            this.btnEditContracts.Click += new System.EventHandler(this.btnEditContracts_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 553);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Back";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 22);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEditContracts);
            this.Controls.Add(this.btnViewContractPerformance);
            this.Controls.Add(this.lblContracts);
            this.Name = "frmContracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contracts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblContracts;
        private Button btnViewContractPerformance;
        private Button btnEditContracts;
        private Button btnClear;
        private Button btnBack;
    }
}