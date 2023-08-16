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
            lblEmployeeID.BackColor = Color.Transparent;
            lblEmployeeID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeeID.ForeColor = SystemColors.ButtonHighlight;
            lblEmployeeID.Location = new Point(141, 160);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(77, 15);
            lblEmployeeID.TabIndex = 3;
            lblEmployeeID.Text = "EmployeeID:";
            // 
            // txtbxEmployeeID
            // 
            txtbxEmployeeID.Location = new Point(251, 156);
            txtbxEmployeeID.Margin = new Padding(3, 4, 3, 4);
            txtbxEmployeeID.Name = "txtbxEmployeeID";
            txtbxEmployeeID.Size = new Size(338, 23);
            txtbxEmployeeID.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(251, 252);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 47);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(475, 255);
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
            lblExistingEmployee.BackColor = Color.Transparent;
            lblExistingEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblExistingEmployee.ForeColor = SystemColors.ButtonHighlight;
            lblExistingEmployee.Location = new Point(282, 38);
            lblExistingEmployee.Name = "lblExistingEmployee";
            lblExistingEmployee.Size = new Size(251, 37);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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