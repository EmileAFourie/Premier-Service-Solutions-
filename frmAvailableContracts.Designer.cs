namespace Premier_Service_Solutions
{
    partial class frmAvailableContracts
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
            lblSaver = new Label();
            lblBasic = new Label();
            lblExtra = new Label();
            lblAvailableContracts = new Label();
            btnEditSaver = new Button();
            btnEditBasic = new Button();
            btnEditExtra = new Button();
            pictureBoxExtra = new PictureBox();
            pictureBoxBasic = new PictureBox();
            pictureBoxSaver = new PictureBox();
            dgvSaver = new DataGridView();
            dgvBasic = new DataGridView();
            dgvExtra = new DataGridView();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBasic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBasic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtra).BeginInit();
            SuspendLayout();
            // 
            // lblSaver
            // 
            lblSaver.AutoSize = true;
            lblSaver.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaver.Location = new Point(138, 66);
            lblSaver.Name = "lblSaver";
            lblSaver.Size = new Size(64, 28);
            lblSaver.TabIndex = 0;
            lblSaver.Text = "Saver";
            // 
            // lblBasic
            // 
            lblBasic.AutoSize = true;
            lblBasic.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblBasic.Location = new Point(365, 66);
            lblBasic.Name = "lblBasic";
            lblBasic.Size = new Size(61, 28);
            lblBasic.TabIndex = 1;
            lblBasic.Text = "Basic";
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblExtra.Location = new Point(604, 66);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(61, 28);
            lblExtra.TabIndex = 2;
            lblExtra.Text = "Extra";
            // 
            // lblAvailableContracts
            // 
            lblAvailableContracts.AutoSize = true;
            lblAvailableContracts.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailableContracts.Location = new Point(267, 19);
            lblAvailableContracts.Name = "lblAvailableContracts";
            lblAvailableContracts.Size = new Size(266, 37);
            lblAvailableContracts.TabIndex = 3;
            lblAvailableContracts.Text = "Available Contracts";
            // 
            // btnEditSaver
            // 
            btnEditSaver.Location = new Point(129, 415);
            btnEditSaver.Name = "btnEditSaver";
            btnEditSaver.Size = new Size(75, 23);
            btnEditSaver.TabIndex = 4;
            btnEditSaver.Text = "Edit";
            btnEditSaver.UseVisualStyleBackColor = true;
            btnEditSaver.Click += btnEditSaver_Click;
            // 
            // btnEditBasic
            // 
            btnEditBasic.Location = new Point(351, 415);
            btnEditBasic.Name = "btnEditBasic";
            btnEditBasic.Size = new Size(75, 23);
            btnEditBasic.TabIndex = 5;
            btnEditBasic.Text = "Edit";
            btnEditBasic.UseVisualStyleBackColor = true;
            // 
            // btnEditExtra
            // 
            btnEditExtra.Location = new Point(604, 415);
            btnEditExtra.Name = "btnEditExtra";
            btnEditExtra.Size = new Size(75, 23);
            btnEditExtra.TabIndex = 6;
            btnEditExtra.Text = "Edit";
            btnEditExtra.UseVisualStyleBackColor = true;
            // 
            // pictureBoxExtra
            // 
            pictureBoxExtra.Location = new Point(529, 97);
            pictureBoxExtra.Name = "pictureBoxExtra";
            pictureBoxExtra.Size = new Size(225, 113);
            pictureBoxExtra.TabIndex = 7;
            pictureBoxExtra.TabStop = false;
            // 
            // pictureBoxBasic
            // 
            pictureBoxBasic.Location = new Point(298, 97);
            pictureBoxBasic.Name = "pictureBoxBasic";
            pictureBoxBasic.Size = new Size(225, 113);
            pictureBoxBasic.TabIndex = 8;
            pictureBoxBasic.TabStop = false;
            // 
            // pictureBoxSaver
            // 
            pictureBoxSaver.Location = new Point(67, 97);
            pictureBoxSaver.Name = "pictureBoxSaver";
            pictureBoxSaver.Size = new Size(225, 113);
            pictureBoxSaver.TabIndex = 9;
            pictureBoxSaver.TabStop = false;
            // 
            // dgvSaver
            // 
            dgvSaver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaver.Location = new Point(67, 216);
            dgvSaver.Name = "dgvSaver";
            dgvSaver.RowHeadersWidth = 51;
            dgvSaver.RowTemplate.Height = 25;
            dgvSaver.Size = new Size(225, 170);
            dgvSaver.TabIndex = 10;
            // 
            // dgvBasic
            // 
            dgvBasic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBasic.Location = new Point(298, 216);
            dgvBasic.Name = "dgvBasic";
            dgvBasic.RowHeadersWidth = 51;
            dgvBasic.RowTemplate.Height = 25;
            dgvBasic.Size = new Size(225, 170);
            dgvBasic.TabIndex = 11;
            // 
            // dgvExtra
            // 
            dgvExtra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtra.Location = new Point(529, 216);
            dgvExtra.Name = "dgvExtra";
            dgvExtra.RowHeadersWidth = 51;
            dgvExtra.RowTemplate.Height = 25;
            dgvExtra.Size = new Size(225, 170);
            dgvExtra.TabIndex = 12;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(10, 475);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 20;
            btnClear.Text = "Back";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // frmAvailableContracts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(btnClear);
            Controls.Add(dgvExtra);
            Controls.Add(dgvBasic);
            Controls.Add(dgvSaver);
            Controls.Add(pictureBoxSaver);
            Controls.Add(pictureBoxBasic);
            Controls.Add(pictureBoxExtra);
            Controls.Add(btnEditExtra);
            Controls.Add(btnEditBasic);
            Controls.Add(btnEditSaver);
            Controls.Add(lblAvailableContracts);
            Controls.Add(lblExtra);
            Controls.Add(lblBasic);
            Controls.Add(lblSaver);
            Name = "frmAvailableContracts";
            Text = "AvailableContracts";
            ((System.ComponentModel.ISupportInitialize)pictureBoxExtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBasic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaver).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaver).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBasic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaver;
        private Label lblBasic;
        private Label lblExtra;
        private Label lblAvailableContracts;
        private Button btnEditSaver;
        private Button btnEditBasic;
        private Button btnEditExtra;
        private PictureBox pictureBoxExtra;
        private PictureBox pictureBoxBasic;
        private PictureBox pictureBoxSaver;
        private DataGridView dgvSaver;
        private DataGridView dgvBasic;
        private DataGridView dgvExtra;
        private Button btnClear;
    }
}