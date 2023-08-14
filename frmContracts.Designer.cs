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
            lblContracts = new Label();
            btnViewContractPerformance = new Button();
            btnEditContracts = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblContracts
            // 
            lblContracts.AutoSize = true;
            lblContracts.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblContracts.Location = new Point(384, 33);
            lblContracts.Name = "lblContracts";
            lblContracts.Size = new Size(172, 46);
            lblContracts.TabIndex = 0;
            lblContracts.Text = "Contracts";
            // 
            // btnViewContractPerformance
            // 
            btnViewContractPerformance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewContractPerformance.Location = new Point(355, 309);
            btnViewContractPerformance.Margin = new Padding(3, 4, 3, 4);
            btnViewContractPerformance.Name = "btnViewContractPerformance";
            btnViewContractPerformance.Size = new Size(206, 67);
            btnViewContractPerformance.TabIndex = 1;
            btnViewContractPerformance.Text = "View Contract Performance";
            btnViewContractPerformance.UseVisualStyleBackColor = true;
            btnViewContractPerformance.Click += btnViewContractPerformance_Click;
            // 
            // btnEditContracts
            // 
            btnEditContracts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditContracts.Location = new Point(355, 209);
            btnEditContracts.Margin = new Padding(3, 4, 3, 4);
            btnEditContracts.Name = "btnEditContracts";
            btnEditContracts.Size = new Size(206, 67);
            btnEditContracts.TabIndex = 2;
            btnEditContracts.Text = "Edit Contracts";
            btnEditContracts.UseVisualStyleBackColor = true;
            btnEditContracts.Click += btnEditContracts_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 553);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Back";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // frmContracts
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}