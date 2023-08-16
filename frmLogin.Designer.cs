namespace Premier_Service_Solutions
{
    partial class frmPremierServiceSolutionsLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPremierServiceSolutionsLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtbxUsername = new TextBox();
            txtbxPassword = new TextBox();
            btnClear = new Button();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            btnBypass = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(617, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(207, 206);
            label1.Name = "label1";
            label1.Size = new Size(409, 25);
            label1.TabIndex = 1;
            label1.Text = "Please provide your username and password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = SystemColors.ButtonHighlight;
            lblUsername.Location = new Point(150, 264);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Location = new Point(150, 310);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtbxUsername
            // 
            txtbxUsername.Location = new Point(247, 262);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(369, 23);
            txtbxUsername.TabIndex = 4;
            // 
            // txtbxPassword
            // 
            txtbxPassword.Location = new Point(247, 307);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.Size = new Size(369, 23);
            txtbxPassword.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(398, 369);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(541, 369);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkShowPassword.ForeColor = SystemColors.ButtonShadow;
            chkShowPassword.Location = new Point(624, 312);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(112, 19);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged_1;
            // 
            // btnBypass
            // 
            btnBypass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBypass.Location = new Point(689, 415);
            btnBypass.Name = "btnBypass";
            btnBypass.Size = new Size(75, 23);
            btnBypass.TabIndex = 9;
            btnBypass.Text = "Bypass";
            btnBypass.UseVisualStyleBackColor = true;
            btnBypass.Click += btnBypass_Click;
            // 
            // frmPremierServiceSolutionsLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBypass);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnClear);
            Controls.Add(txtbxPassword);
            Controls.Add(txtbxUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmPremierServiceSolutionsLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Premiere Service Solutions Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtbxUsername;
        private TextBox txtbxPassword;
        private Button btnClear;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private Button btnBypass;
    }
}