namespace Premier_Service_Solutions
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
            this.lblContracts = new System.Windows.Forms.Label();
            this.btnViewContractPerformance = new System.Windows.Forms.Button();
            this.btnEditContracts = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContracts
            // 
            this.lblContracts.AutoSize = true;
            this.lblContracts.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContracts.Location = new System.Drawing.Point(334, 27);
            this.lblContracts.Name = "lblContracts";
            this.lblContracts.Size = new System.Drawing.Size(140, 37);
            this.lblContracts.TabIndex = 0;
            this.lblContracts.Text = "Contracts";
            // 
            // btnViewContractPerformance
            // 
            this.btnViewContractPerformance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewContractPerformance.Location = new System.Drawing.Point(299, 233);
            this.btnViewContractPerformance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewContractPerformance.Name = "btnViewContractPerformance";
            this.btnViewContractPerformance.Size = new System.Drawing.Size(206, 67);
            this.btnViewContractPerformance.TabIndex = 1;
            this.btnViewContractPerformance.Text = "View Contract Performance";
            this.btnViewContractPerformance.UseVisualStyleBackColor = true;
            this.btnViewContractPerformance.Click += new System.EventHandler(this.btnViewContractPerformance_Click_1);
            // 
            // btnEditContracts
            // 
            this.btnEditContracts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditContracts.Location = new System.Drawing.Point(299, 133);
            this.btnEditContracts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditContracts.Name = "btnEditContracts";
            this.btnEditContracts.Size = new System.Drawing.Size(206, 67);
            this.btnEditContracts.TabIndex = 2;
            this.btnEditContracts.Text = "Edit Contracts";
            this.btnEditContracts.UseVisualStyleBackColor = true;
            this.btnEditContracts.Click += new System.EventHandler(this.btnEditContracts_Click_1);
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
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.White;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(12, 13);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(32, 34);
            this.btn.TabIndex = 21;
            this.btn.Text = "<";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 22);
            btnBack.TabIndex = 17;
            btnBack.Text = "<<<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnEditContracts);
            this.Controls.Add(this.btnViewContractPerformance);
            this.Controls.Add(this.lblContracts);
            this.Name = "frmContracts";
            this.Text = "Contracts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblContracts;
        private Button btnViewContractPerformance;
        private Button btnEditContracts;
        private Button btnClear;
        private Button btn;
    }
}