using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Premier_Service_Solutions
{
    internal class DataHandler
    {
        private string connect = @"Data source=(local);Initial Catalog=PremierServiceSolutions;Integrated Security=SSPI";
        private SqlConnection conn;
        private SqlCommand cmd;

        public void ClientIWriteToDB(int ClientID, string Firstname, string LastName, string Address, string CellNo, string Email, int ContractID, int CompanyID)
        {
            string insertI = @"INSERT INTO [dbo].[IndividualClient] VALUES (@ClientID, @Firstname, @LastName, @Address, @CellNo, @Email, @ContractID, @CompanyID)";

            using (conn = new SqlConnection(connect))
            {
                conn.Open();

                using (cmd = new SqlCommand(insertI, conn))
                {
                    cmd.Parameters.AddWithValue("@ClientID", ClientID);
                    cmd.Parameters.AddWithValue("@Firstname", Firstname);
                    cmd.Parameters.AddWithValue("@Surname", LastName);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@CellNo", CellNo);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@ContractID", ContractID);
                    cmd.Parameters.AddWithValue("@CompanyID", CompanyID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Individual Client details saved successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Details not saved: " + ex.Message);
                    }
                }
            }
        }

        public void ClientBWriteToDB(int CompanyID, string CompanyName, string CompanyAddress, string CompanyPhone)
        {
            string insertB = @"INSERT INTO [dbo].[BusinessClient] VALUES (@CompanyID, @CompanyName, @CompanyAddress, @CompanyPhone)";

            using (conn = new SqlConnection(connect))
            {
                conn.Open();

                using (cmd = new SqlCommand(insertB, conn))
                {
                    cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
                    cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                    cmd.Parameters.AddWithValue("@CompanyAddress", CompanyAddress);
                    cmd.Parameters.AddWithValue("@CompanyPhone", CompanyPhone);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Business Client details saved successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Details not saved: " + ex.Message);
                    }
                }
            }
        }
    }
}
