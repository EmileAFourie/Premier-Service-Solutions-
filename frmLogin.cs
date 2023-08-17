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

            Employee employee = new Employee();

            string login = employee.CheckLogin(username, password);

            if (login != "fail")
            {
                frmNavigation nextForm = new frmNavigation();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect credentials entered.");
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

        public bool TestLogin(string username, string password )
        {
            Employee employee = new Employee();

            string login = employee.CheckLogin(username, password);

            if (login != "fail")
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
