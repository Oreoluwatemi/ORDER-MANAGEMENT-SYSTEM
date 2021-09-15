using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ManagementDataDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                @"Data Source=(localdb)\MySpace;Initial Catalog=ProjectDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
