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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExistingClientSearch));
            this.lblExistingClientDetails = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtbxClientID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExistingClientDetails
            // 
            this.lblExistingClientDetails.AutoSize = true;
            this.lblExistingClientDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblExistingClientDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExistingClientDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExistingClientDetails.Location = new System.Drawing.Point(257, 25);
            this.lblExistingClientDetails.Name = "lblExistingClientDetails";
            this.lblExistingClientDetails.Size = new System.Drawing.Size(296, 37);
            this.lblExistingClientDetails.TabIndex = 0;
            this.lblExistingClientDetails.Text = "Existing Client Details";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.BackColor = System.Drawing.Color.Transparent;
            this.lblClientID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClientID.Location = new System.Drawing.Point(200, 146);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(55, 15);
            this.lblClientID.TabIndex = 1;
            this.lblClientID.Text = "Client ID";
            // 
            // txtbxClientID
            // 
            this.txtbxClientID.Location = new System.Drawing.Point(291, 143);
            this.txtbxClientID.Name = "txtbxClientID";
            this.txtbxClientID.Size = new System.Drawing.Size(251, 23);
            this.txtbxClientID.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(247, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(411, 222);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 22);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmExistingClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtbxClientID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblExistingClientDetails);
            this.Name = "frmExistingClientSearch";
            this.Text = "Existing Client Search";
            this.Load += new System.EventHandler(this.frmExistingClientSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblExistingClientDetails;
        private Label lblClientID;
        private TextBox txtbxClientID;
        private Button btnClear;
        private Button btnSearch;
        private Button btnBack;
    }
}