using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data.DataHandler
{
    public class Connections
    {
        private static readonly string connectionString;

        static Connections()
        {
            //connectionString = "Data Source=localhost;Initial Catalog=Movies; Integrated Security=True";
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
        public static string ConnectionString()
        {
            return connectionString;
        }
    }
}

