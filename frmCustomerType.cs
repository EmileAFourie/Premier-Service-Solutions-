using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premier_Service_Solutions
{
    public partial class frmCustomerType : Form
    {
        public frmCustomerType()
        {
            InitializeComponent();
        }

        public void SetDateTime(string dateTime)
        {
            txtbxTimestamp.Text = dateTime; 
        }

        public void SetValues(string dateTime, string callerNumber)
        {
            txtbxTimestamp.Text = dateTime;
            txtbxCallerNumber.Text = callerNumber;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmClientDetails NewClientDetails = new frmClientDetails();
            NewClientDetails.Show();
            this.Hide();
        }

        private void btnOldCustomer_Click(object sender, EventArgs e)
        {
            frmExistingClientSearch Search = new frmExistingClientSearch();
            Search.Show();
            this.Hide();
        }

        private void frmCustomerType_Load(object sender, EventArgs e)
        {

        }
    }
}
