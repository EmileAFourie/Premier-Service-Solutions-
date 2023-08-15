using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Premier_Service_Solutions
{
    internal class DataHandler
    {
        private string connect = @"Data source=.;Initial Catalog=PremierServiceSolutions;Integrated Security=SSPI";
        private SqlConnection conn;
        private SqlCommand cmd;

        public void ClientIWriteToDB(string Firstname, string Surname, string Address, string CellNo, string Email, int ContractID)
        {
            string insertI = @"INSERT INTO IndividualClient (Firstname,Surname,Address,CellNo,Email,ContractID) VALUES ( @Firstname, @Surname, @Address, @CellNo, @Email, @ContractID)";

            using (conn = new SqlConnection(connect))
            {
                conn.Open();

                using (cmd = new SqlCommand(insertI, conn))
                {
                   
                    cmd.Parameters.AddWithValue("@Firstname", Firstname);
                    cmd.Parameters.AddWithValue("@Surname", Surname);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@CellNo", CellNo);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@ContractID", ContractID);
                    

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
            string insertB = @"INSERT INTO BusinessClient VALUES (@CompanyID, @CompanyName, @CompanyAddress, @CompanyPhone)";

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

        public void LogTicket(string TypeOfErr, string Description, DateTime Dateopened, string Priority, string Status, int ClientID)
        {
            string insert = @"INSERT INTO [dbo].[Ticket] (TypeOfError, Description, DateOpened, Priority, Status, ClientID) 
                    VALUES (@TypeOfError, @Description, @DateOpened, @Priority, @Status, @ClientID)";

            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@TypeOfError", TypeOfErr);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@DateOpened", Dateopened);
                    cmd.Parameters.AddWithValue("@Priority", Priority);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ticket has been logged");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ticket not logged: " + ex.Message);
                    }
                }
            }
        }

    }
}
