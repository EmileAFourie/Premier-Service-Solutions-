﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    internal class DataHandler
    {
        string connect = @"Data source= (local);Initial Catalog=PremierServiceSolutions;Integrated Security=SSPI";


        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        //========================================================================================================================
        //Clients
        //=====================================================================================================================

        public void ClientIWriteToDB(int ClientID, string Firstname, string Surname, string Address, string CellNo, string Email, int ContractID, int CompanyID)
        {
            string insertI = @"Insert INTO [dbo].[IndividualClient] Values ('"+ClientID+ "','" + Firstname + "','" + Surname + "'," +
                "'" + Address + "','" + CellNo + "','" + Email + "','" + ContractID + "','" + CompanyID + "') ";

            conn = new SqlConnection(connect);
            conn.Open();

            cmd = new SqlCommand(insertI, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Individual Client details saved successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void ClientBWriteToDB(int CompanyID, string CompanyName, string CompanyAddress, string CompanyPhone)
        {
            string insertB = @"Insert INTO [dbo].[IndividualClient] Values ('" + CompanyID + "','" + CompanyName + "','" + CompanyAddress + "'," +
             "'" + CompanyPhone + "') ";

            conn = new SqlConnection(connect);
            conn.Open();

            cmd = new SqlCommand(insertB, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Individual Client details saved successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        //=========================================================================================================================================
        // Tickects
        //======================================================================================================================================================
        
        public void LogTickect(int TicketID, string TypeOfErr, string Description, DateTime Dateopened, DateTime DateClosed, string Priority, string Status, int ClientID)
        {
            string insert = @"Insert INTO [dbo].[Ticket] Values ('"+ TicketID + "','" + TypeOfErr + "','" + Description + "'," +
                "'" + Dateopened + "','" + DateClosed + "','" + Priority + "','" + Status + "','" + ClientID + "',) ";

            conn = new SqlConnection(connect);
            conn.Open();
            
            cmd = new SqlCommand(insert, conn);
            
            
            // Put status as unassigned by default


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket has been logged");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ticket not logged" + ex);
            }
            finally
            {
                conn.Close();
            }
        }


        //============================================================================
        //Employee
        //============================================================================

        
        //============================================================================
        //Contracts
        //============================================================================


    }

}
