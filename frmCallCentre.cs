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
    public partial class frmCallCentre : Form
    {
        public frmCallCentre()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The call has been declined. It will be redirected to another employee.", "Call Handling", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnswerCall_Click(object sender, EventArgs e)
        {
            frmCustomerType customerTypeForm = new frmCustomerType();

            // Get the value from txtbxIncomingCall
            string callerNumber = txtbxIncomingCall.Text;

            DateTime currentDatetime = DateTime.Now;

            string formattedDatetime = currentDatetime.ToString("yyyy-MM-dd HH:mm:ss");

            // Pass both date/time and caller number to frmCustomerType
            customerTypeForm.SetValues(formattedDatetime, callerNumber);

            customerTypeForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmNavigation back = new frmNavigation();
            back.Show();
            this.Hide();
        }
    }
}
