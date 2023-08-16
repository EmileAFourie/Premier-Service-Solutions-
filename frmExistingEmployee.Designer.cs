namespace Premier_Service_Solutions
{
    partial class frmExistingEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExistingEmployee));
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtbxEmployeeID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblExistingEmployee = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmployeeID.Location = new System.Drawing.Point(141, 160);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(77, 15);
            this.lblEmployeeID.TabIndex = 3;
            this.lblEmployeeID.Text = "EmployeeID:";
            // 
            // txtbxEmployeeID
            // 
            this.txtbxEmployeeID.Location = new System.Drawing.Point(251, 156);
            this.txtbxEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxEmployeeID.Name = "txtbxEmployeeID";
            this.txtbxEmployeeID.Size = new System.Drawing.Size(338, 23);
            this.txtbxEmployeeID.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(251, 252);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 47);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(475, 255);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 44);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblExistingEmployee
            // 
            this.lblExistingEmployee.AutoSize = true;
            this.lblExistingEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblExistingEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExistingEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExistingEmployee.Location = new System.Drawing.Point(282, 38);
            this.lblExistingEmployee.Name = "lblExistingEmployee";
            this.lblExistingEmployee.Size = new System.Drawing.Size(251, 37);
            this.lblExistingEmployee.TabIndex = 6;
            this.lblExistingEmployee.Text = "Existing Employee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmExistingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExistingEmployee);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtbxEmployeeID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExistingEmployee";
            this.Text = "frmExistingEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmployeeID;
        private TextBox txtbxEmployeeID;
        private Button btnClear;
        private Button btnSearch;
        private Label lblExistingEmployee;
        private Button button1;
    }
}