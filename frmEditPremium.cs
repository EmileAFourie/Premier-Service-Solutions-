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
    public partial class frmEditPremium : Form
    {
        string connect = Global.connectionString;
        public frmEditPremium()
        {
            InitializeComponent();
        }

        private void frmEditPremium_Load(object sender, EventArgs e)
        {
           // string connect = @"Data source=(local); Initial Catalog=PremierServiceSolutions; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(connect);
            string query = @"SELECT * FROM Contract WHERE ContractID = 3";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPremium.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAvailableContracts back = new frmAvailableContracts();
            this.Hide();
            back.Show();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
           // string connect = @"Data Source=(local); Initial Catalog=PremierServiceSolutions; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(connect);
            string query = @"UPDATE Contract SET Avalibilty = 1"; // Assuming 'Availability' is the correct column name

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                con.Close();
            }

            // Reload the datagrid
            dgvPremium.DataSource = null;

            string reloadQuery = @"SELECT * FROM Contract WHERE ContractID = 2"; // Assuming 'ContractID' is the correct column name
            SqlDataAdapter da = new SqlDataAdapter(reloadQuery, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPremium.DataSource = dt;

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
           // string connect = @"Data Source=(local); Initial Catalog=PremierServiceSolutions; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(connect);
            string query = @"UPDATE Contract SET Avalibilty = 0"; // Assuming 'Availability' is the correct column name

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                con.Close();
            }

            // Reload the datagrid
            dgvPremium.DataSource = null;

            string reloadQuery = @"SELECT * FROM Contract WHERE ContractID = 2"; // Assuming 'ContractID' is the correct column name
            SqlDataAdapter da = new SqlDataAdapter(reloadQuery, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPremium.DataSource = dt;
        }
    }
}
