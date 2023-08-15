using System;
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

        public void ClientIWriteToDB(int ClientID, string Firstname, string Surname, string Address, string CellNo, string Email, int ContractID, int CompanyID)
        {
            string insert = "Insert INTO [dbo].[IndividualClient] Values  ";

        }

        public void ClientBWriteToDB(int CompanyID, string CompanyName, string CompanyAddress, string CompanyPhone)
        {
            string insert = "Insert INTO [dbo].[CompanyClient] Values   ";
        }

    }
}
