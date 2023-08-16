namespace Premier_Service_Solutions
{
    partial class frmEditbasic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditbasic));
            this.pictureBoxBasic = new System.Windows.Forms.PictureBox();
            this.dgvBasic = new System.Windows.Forms.DataGridView();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxDescription = new System.Windows.Forms.TextBox();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.txtbxAvailability = new System.Windows.Forms.TextBox();
            this.txtbxPriority = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBasic
            // 
            this.pictureBoxBasic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBasic.Image")));
            this.pictureBoxBasic.Location = new System.Drawing.Point(144, 12);
            this.pictureBoxBasic.Name = "pictureBoxBasic";
            this.pictureBoxBasic.Size = new System.Drawing.Size(472, 106);
            this.pictureBoxBasic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBasic.TabIndex = 0;
            this.pictureBoxBasic.TabStop = false;
            // 
            // dgvBasic
            // 
            this.dgvBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasic.Location = new System.Drawing.Point(144, 124);
            this.dgvBasic.Name = "dgvBasic";
            this.dgvBasic.RowTemplate.Height = 25;
            this.dgvBasic.Size = new System.Drawing.Size(472, 122);
            this.dgvBasic.TabIndex = 1;
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(198, 254);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(75, 23);
            this.btnEnable.TabIndex = 2;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(346, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(486, 254);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 23);
            this.btnDisable.TabIndex = 4;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(263, 296);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(280, 23);
            this.txtbxName.TabIndex = 6;
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Location = new System.Drawing.Point(263, 325);
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(280, 23);
            this.txtbxDescription.TabIndex = 7;
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(263, 354);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(280, 23);
            this.txtbxPrice.TabIndex = 8;
            // 
            // txtbxAvailability
            // 
            this.txtbxAvailability.Location = new System.Drawing.Point(263, 383);
            this.txtbxAvailability.Name = "txtbxAvailability";
            this.txtbxAvailability.Size = new System.Drawing.Size(280, 23);
            this.txtbxAvailability.TabIndex = 9;
            // 
            // txtbxPriority
            // 
            this.txtbxPriority.Location = new System.Drawing.Point(263, 412);
            this.txtbxPriority.Name = "txtbxPriority";
            this.txtbxPriority.Size = new System.Drawing.Size(280, 23);
            this.txtbxPriority.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(187, 299);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Location = new System.Drawing.Point(187, 328);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 15);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(187, 357);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvailability.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAvailability.Location = new System.Drawing.Point(187, 386);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(67, 15);
            this.lblAvailability.TabIndex = 15;
            this.lblAvailability.Text = "Availability";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.BackColor = System.Drawing.Color.Transparent;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPriority.Location = new System.Drawing.Point(187, 415);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(48, 15);
            this.lblPriority.TabIndex = 16;
            this.lblPriority.Text = "Priority";
            // 
            // frmEditbasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtbxPriority);
            this.Controls.Add(this.txtbxAvailability);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.txtbxDescription);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.dgvBasic);
            this.Controls.Add(this.pictureBoxBasic);
            this.Name = "frmEditbasic";
            this.Text = "Edit basic";
            this.Load += new System.EventHandler(this.frmEditbasic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxBasic;
        private DataGridView dgvBasic;
        private Button btnEnable;
        private Button btnUpdate;
        private Button btnDisable;
        private Button btnDelete;
        private TextBox txtbxName;
        private TextBox txtbxDescription;
        private TextBox txtbxPrice;
        private TextBox txtbxAvailability;
        private TextBox txtbxPriority;
        private Button btnBack;
        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblAvailability;
        private Label lblPriority;
    }
}