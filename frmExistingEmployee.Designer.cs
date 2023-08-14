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
            lblEmployeeID = new Label();
            txtbxEmployeeID = new TextBox();
            btnClear = new Button();
            btnSearch = new Button();
            lblExistingEmployee = new Label();

            button1 = new Button();

            SuspendLayout();
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Location = new Point(216, 185);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(93, 20);
            lblEmployeeID.TabIndex = 3;
            lblEmployeeID.Text = "EmployeeID:";
            // 
            // txtbxEmployeeID
            // 
            txtbxEmployeeID.Location = new Point(326, 181);
            txtbxEmployeeID.Margin = new Padding(3, 4, 3, 4);
            txtbxEmployeeID.Name = "txtbxEmployeeID";
            txtbxEmployeeID.Size = new Size(338, 27);
            txtbxEmployeeID.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(326, 277);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 47);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(550, 280);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 44);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;

            btnSearch.Click += btnSearch_Click;

            // 
            // lblExistingEmployee
            // 
            lblExistingEmployee.AutoSize = true;
            lblExistingEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblExistingEmployee.Location = new Point(338, 31);
            lblExistingEmployee.Name = "lblExistingEmployee";
            lblExistingEmployee.Size = new Size(311, 46);
            lblExistingEmployee.TabIndex = 6;
            lblExistingEmployee.Text = "Existing Employee";

            // 
            // button1
            // 
            button1.Location = new Point(12, 540);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 47);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;

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


            Controls.Add(lblExistingEmployee);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(lblEmployeeID);
            Controls.Add(txtbxEmployeeID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmExistingEmployee";
            Text = "frmExistingEmployee";
            ResumeLayout(false);
            PerformLayout();
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