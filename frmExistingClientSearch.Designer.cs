namespace Premier_Service_Solutions
{
    partial class frmExistingClientSearch
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
            this.lblExistingClientDetails = new System.Windows.Forms.Label();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.txtbxCellNumber = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExistingClientDetails
            // 
            this.lblExistingClientDetails.AutoSize = true;
            this.lblExistingClientDetails.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExistingClientDetails.Location = new System.Drawing.Point(291, 24);
            this.lblExistingClientDetails.Name = "lblExistingClientDetails";
            this.lblExistingClientDetails.Size = new System.Drawing.Size(220, 28);
            this.lblExistingClientDetails.TabIndex = 0;
            this.lblExistingClientDetails.Text = "Existing Client Details";
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoSize = true;
            this.lblCellNumber.Location = new System.Drawing.Point(248, 124);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(71, 15);
            this.lblCellNumber.TabIndex = 1;
            this.lblCellNumber.Text = "CellNumber";
            // 
            // txtbxCellNumber
            // 
            this.txtbxCellNumber.Location = new System.Drawing.Point(339, 121);
            this.txtbxCellNumber.Name = "txtbxCellNumber";
            this.txtbxCellNumber.Size = new System.Drawing.Size(251, 23);
            this.txtbxCellNumber.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(455, 250);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmExistingClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtbxCellNumber);
            this.Controls.Add(this.lblCellNumber);
            this.Controls.Add(this.lblExistingClientDetails);
            this.Name = "frmExistingClientSearch";
            this.Text = "Existing Client Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblExistingClientDetails;
        private Label lblCellNumber;
        private TextBox txtbxCellNumber;
        private Button btnClear;
        private Button btnSearch;
    }
}