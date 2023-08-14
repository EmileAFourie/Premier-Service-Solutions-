namespace Premier_Service_Solutions
{
    partial class frmNewEmployee
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
            txtbxEmployeeID = new TextBox();
            lblEmployeeID = new Label();
            label2 = new Label();
            lblName = new Label();
            txtbxName = new TextBox();
            label4 = new Label();
            txtbxEmail = new TextBox();
            label5 = new Label();
            txtbxPosition = new TextBox();
            label6 = new Label();
            txtbxAge = new TextBox();
            btnClear = new Button();
            btnSubmit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtbxEmployeeID
            // 
            txtbxEmployeeID.Location = new Point(326, 187);
            txtbxEmployeeID.Margin = new Padding(3, 4, 3, 4);
            txtbxEmployeeID.Name = "txtbxEmployeeID";
            txtbxEmployeeID.Size = new Size(338, 27);
            txtbxEmployeeID.TabIndex = 0;
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Location = new Point(216, 191);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(93, 20);
            lblEmployeeID.TabIndex = 1;
            lblEmployeeID.Text = "EmployeeID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(339, 24);
            label2.Name = "label2";
            label2.Size = new Size(289, 46);
            label2.TabIndex = 2;
            label2.Text = "Employee Centre";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(253, 240);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // txtbxName
            // 
            txtbxName.Location = new Point(326, 236);
            txtbxName.Margin = new Padding(3, 4, 3, 4);
            txtbxName.Name = "txtbxName";
            txtbxName.Size = new Size(338, 27);
            txtbxName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 295);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtbxEmail
            // 
            txtbxEmail.Location = new Point(326, 291);
            txtbxEmail.Margin = new Padding(3, 4, 3, 4);
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(338, 27);
            txtbxEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 355);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Position:";
            // 
            // txtbxPosition
            // 
            txtbxPosition.Location = new Point(326, 351);
            txtbxPosition.Margin = new Padding(3, 4, 3, 4);
            txtbxPosition.Name = "txtbxPosition";
            txtbxPosition.Size = new Size(338, 27);
            txtbxPosition.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 415);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 10;
            label6.Text = "Age:";
            // 
            // txtbxAge
            // 
            txtbxAge.Location = new Point(326, 404);
            txtbxAge.Margin = new Padding(3, 4, 3, 4);
            txtbxAge.Name = "txtbxAge";
            txtbxAge.Size = new Size(338, 27);
            txtbxAge.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(448, 481);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(578, 481);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 31);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(326, 481);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 13;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmNewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(txtbxAge);
            Controls.Add(label5);
            Controls.Add(txtbxPosition);
            Controls.Add(label4);
            Controls.Add(txtbxEmail);
            Controls.Add(lblName);
            Controls.Add(txtbxName);
            Controls.Add(label2);
            Controls.Add(lblEmployeeID);
            Controls.Add(txtbxEmployeeID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNewEmployee";
            Text = "frmNewEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxEmployeeID;
        private Label lblEmployeeID;
        private Label label2;
        private Label lblName;
        private TextBox txtbxName;
        private Label label4;
        private TextBox txtbxEmail;
        private Label label5;
        private TextBox txtbxPosition;
        private Label label6;
        private TextBox txtbxAge;
        private Button btnClear;
        private Button btnSubmit;
        private Button button1;
    }
}