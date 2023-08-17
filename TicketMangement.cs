using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Premier_Service_Solutions
{
    public class TicketManagement
    {
        private string connectionString = Global.connectionString;



        public void LogTicket(string typeOfError, string description, DateTime dateOpened, string priority, string status, int clientID)
        {
            string query = @"INSERT INTO Ticket (TypeOfError, Description, DateOpened, Priority, Status, ClientID) 
                         VALUES (@TypeOfError, @Description, @DateOpened, @Priority, @Status, @ClientID)";



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TypeOfError", typeOfError);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@DateOpened", dateOpened);
                    cmd.Parameters.AddWithValue("@Priority", priority);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ClientID", clientID);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public DataTable GetTickets(int clientID)
        {
            string query = "Select * from Ticket Where ClientID = @ClientID";
            DataTable dt = new DataTable();



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@ClientID", clientID);
                da.Fill(dt);
            }



            return dt;
        }



        public string UpdateTicket(int ticketID, string typeOfError, string description, string priority)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"UPDATE Ticket 
                             SET TypeOfError = @TypeOfError, Description = @Description, Priority = @Priority 
                             WHERE TicketID = @TicketID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TypeOfError", typeOfError);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Priority", priority);
                    cmd.Parameters.AddWithValue("@TicketID", ticketID);
                    cmd.ExecuteNonQuery();
                }

                return "Ticket updated";
            }
        }



        public void DeleteTicket(int ticketID)
        {
            string query = "DELETE FROM Ticket WHERE TicketID = @TicketID";



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TicketID", ticketID);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public string GetCurrentFormattedDatetime()
        {
            DateTime currentDatetime = DateTime.Now;
            return currentDatetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
