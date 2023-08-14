using System;
using System.Windows.Forms;

namespace Premier_Service_Solutions
{
    public partial class frmPremierServiceSolutionsLogin : Form
    {
        public frmPremierServiceSolutionsLogin()
        {
            InitializeComponent();
            txtbxPassword.PasswordChar = '*';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxUsername.Clear();
            txtbxPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtbxUsername.Text;
            string password = txtbxPassword.Text;

            // Default credentials
            const string defaultUsername = "default";
            const string defaultPassword = "123";

            if (username == defaultUsername && password == defaultPassword)
            {
                // If credentials are valid, open the next form
                frmNavigation nextForm = new frmNavigation();
                nextForm.Show();
                this.Hide();  // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }       

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            txtbxPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnBypass_Click(object sender, EventArgs e)
        {
            frmNavigation Navigation = new frmNavigation();
            Navigation.Show();

            this.Hide(); // Hide the login form
        }
    }
}
