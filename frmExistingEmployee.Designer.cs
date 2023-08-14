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
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtbxEmployeeID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblExistingEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(189, 139);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(73, 15);
            this.lblEmployeeID.TabIndex = 3;
            this.lblEmployeeID.Text = "EmployeeID:";
            // 
            // txtbxEmployeeID
            // 
            this.txtbxEmployeeID.Location = new System.Drawing.Point(285, 136);
            this.txtbxEmployeeID.Name = "txtbxEmployeeID";
            this.txtbxEmployeeID.Size = new System.Drawing.Size(296, 23);
            this.txtbxEmployeeID.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(285, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(481, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 33);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblExistingEmployee
            // 
            this.lblExistingEmployee.AutoSize = true;
            this.lblExistingEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExistingEmployee.Location = new System.Drawing.Point(296, 23);
            this.lblExistingEmployee.Name = "lblExistingEmployee";
            this.lblExistingEmployee.Size = new System.Drawing.Size(251, 37);
            this.lblExistingEmployee.TabIndex = 6;
            this.lblExistingEmployee.Text = "Existing Employee";
            // 
            // frmExistingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExistingEmployee);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtbxEmployeeID);
            this.Name = "frmExistingEmployee";
            this.Text = "Existing Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmployeeID;
        private TextBox txtbxEmployeeID;
        private Button btnClear;
        private Button btnSearch;
        private Label lblExistingEmployee;
    }
}