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
using Microsoft.VisualBasic;

namespace Premier_Service_Solutions
{
    public partial class frmEditSaver : Form
    {
        public frmEditSaver()
        {
            InitializeComponent();
        }

        SqlCommand cmd;

        private void btnEnable_Click(object sender, EventArgs e)
        {
            string connect = @"Data source = (local) ; Initial Catalog=PremierServiceSolutions; Integrated Security= SSPI";
            SqlConnection con = new SqlConnection(connect);
            string query = @"UPDATE Contract SET Avalibilty = true ";

            con.Open();
            cmd = new SqlCommand(query, con);


            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception err )
            {
                MessageBox.Show(err.Message);
                throw;
            }

            // Reload the datagrid
            dgvSaver.DataSource = null;

            string reload = @"Select * from Contract Where Contract = 2";
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSaver.DataSource = dt;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAvailableContracts frmAvailableContracts = new frmAvailableContracts();
            this.Close();
            frmAvailableContracts.Show();

        }

        private void frmEditSaver_Load(object sender, EventArgs e)
        {
            string connect = @"Data source = (local) ; Initial Catalog=PremierServiceSolutions; Integrated Security= SSPI";
            SqlConnection con = new SqlConnection(connect);
            string query = @"Select * from Contract Where ContractID = 2";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSaver.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name =  
        }
    }
}
