namespace Premier_Service_Solutions
{
    partial class frmEditSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSaver));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.dgvSaver = new System.Windows.Forms.DataGridView();
            this.pictureBoxBasic = new System.Windows.Forms.PictureBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxPriority = new System.Windows.Forms.TextBox();
            this.txtbxAvailability = new System.Windows.Forms.TextBox();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.txtbxDescription = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(12, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDisable
            // 
            this.btnDisable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisable.Location = new System.Drawing.Point(486, 257);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 23);
            this.btnDisable.TabIndex = 16;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(346, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEnable
            // 
            this.btnEnable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnable.Location = new System.Drawing.Point(198, 257);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(75, 23);
            this.btnEnable.TabIndex = 14;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            // 
            // dgvSaver
            // 
            this.dgvSaver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaver.Location = new System.Drawing.Point(146, 117);
            this.dgvSaver.Name = "dgvSaver";
            this.dgvSaver.RowTemplate.Height = 25;
            this.dgvSaver.Size = new System.Drawing.Size(472, 122);
            this.dgvSaver.TabIndex = 13;
            // 
            // pictureBoxBasic
            // 
            this.pictureBoxBasic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBasic.Image")));
            this.pictureBoxBasic.Location = new System.Drawing.Point(146, 2);
            this.pictureBoxBasic.Name = "pictureBoxBasic";
            this.pictureBoxBasic.Size = new System.Drawing.Size(472, 109);
            this.pictureBoxBasic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBasic.TabIndex = 12;
            this.pictureBoxBasic.TabStop = false;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.BackColor = System.Drawing.Color.Transparent;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPriority.Location = new System.Drawing.Point(190, 415);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(48, 15);
            this.lblPriority.TabIndex = 33;
            this.lblPriority.Text = "Priority";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvailability.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAvailability.Location = new System.Drawing.Point(190, 386);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(67, 15);
            this.lblAvailability.TabIndex = 32;
            this.lblAvailability.Text = "Availability";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(190, 357);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Location = new System.Drawing.Point(190, 328);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 15);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "Description ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(190, 299);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // txtbxPriority
            // 
            this.txtbxPriority.Location = new System.Drawing.Point(266, 412);
            this.txtbxPriority.Name = "txtbxPriority";
            this.txtbxPriority.Size = new System.Drawing.Size(280, 23);
            this.txtbxPriority.TabIndex = 28;
            // 
            // txtbxAvailability
            // 
            this.txtbxAvailability.Location = new System.Drawing.Point(266, 383);
            this.txtbxAvailability.Name = "txtbxAvailability";
            this.txtbxAvailability.Size = new System.Drawing.Size(280, 23);
            this.txtbxAvailability.TabIndex = 27;
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(266, 354);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(280, 23);
            this.txtbxPrice.TabIndex = 26;
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Location = new System.Drawing.Point(266, 325);
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(280, 23);
            this.txtbxDescription.TabIndex = 25;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(266, 296);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(280, 23);
            this.txtbxName.TabIndex = 24;
            // 
            // frmEditSaver
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
            this.Controls.Add(this.txtbxPriority);
            this.Controls.Add(this.txtbxAvailability);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.txtbxDescription);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.dgvSaver);
            this.Controls.Add(this.pictureBoxBasic);
            this.Name = "frmEditSaver";
            this.Text = "Edit Saver";
            this.Load += new System.EventHandler(this.frmEditSaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Button btnDelete;
        private Button btnDisable;
        private Button btnUpdate;
        private Button btnEnable;
        private DataGridView dgvSaver;
        private PictureBox pictureBoxBasic;
        private Label lblPriority;
        private Label lblAvailability;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblName;
        private TextBox txtbxPriority;
        private TextBox txtbxAvailability;
        private TextBox txtbxPrice;
        private TextBox txtbxDescription;
        private TextBox txtbxName;
    }
}