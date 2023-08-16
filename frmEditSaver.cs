using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Premier_Service_Solutions
{
    public partial class frmEditSaver : Form
    {
        public frmEditSaver()
        {
            InitializeComponent();
        }

        private void frmEditSaver_Load(object sender, EventArgs e)
        {
            string connect = @"Data source=(local); Initial Catalog=PremierServiceSolutions; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(connect);
            string query = @"SELECT * FROM Contract WHERE ContractID = 2";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBasic.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAvailableContracts back = new frmAvailableContracts();
            this.Hide();
            back.Show();
        }
    }
}
