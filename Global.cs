﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    static class Global
    {
        //public const string connectionString = @"Data Source=.\SQLEXPRESS01; Initial Catalog=PremierServiceSolutions; Integrated Security=true;"; //Emile

        //public const string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=PremierServiceSolutions; Integrated Security=true;";//Leandro

        public const string connectionString = @"Data Source=.\SQLEXPRESS03; Initial Catalog=PremierServiceSolutions; Integrated Security=true;";//Kyle

        // Static property for ClientID
        public static int ClientID { get; set; }

    }
}
