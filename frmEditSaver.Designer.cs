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
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSaver = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(201, 323);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(111, 36);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(510, 323);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(111, 36);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(12, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvSaver
            // 
            this.dgvSaver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaver.Location = new System.Drawing.Point(135, 147);
            this.dgvSaver.Name = "dgvSaver";
            this.dgvSaver.RowHeadersWidth = 51;
            this.dgvSaver.Size = new System.Drawing.Size(574, 154);
            this.dgvSaver.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(141, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 118);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEditSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSaver);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEnable);
            this.Name = "frmEditSaver";
            this.Text = "frmEditSaver";
            this.Load += new System.EventHandler(this.frmEditSaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEnable;
        private Button btnUpdate;
        private Button btnDisable;
        private Button btnDelete;
        private DataGridView dgvSaver;
        private PictureBox pictureBox1;
        private Button btnBack;
    }
}