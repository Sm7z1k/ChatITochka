using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChatITochka
{
    internal class ConnectionToSQL
    {
        public SqlConnection Connection { get => connection; } 

        static string connectionString = "Data Source=DESKTOP-7KACT8E\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection = new SqlConnection(connectionString);
    }
}
