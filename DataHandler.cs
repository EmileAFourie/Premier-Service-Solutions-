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

        public void ClientWriteToDB()
        {
            string insert = "INsert INTO tblClient ";

        }

    }
}
