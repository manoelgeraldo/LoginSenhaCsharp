using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSQLite
    {
        private readonly string connectionString;
        public ConnectionToSQLite()
        {
            connectionString = "Server=MANOEL_GERALDO\\SQLEXPRESS01; DataBase= SRCVLI; integrated security= true";
        }
        protected SqlConnection GetConnection ()
        {
            return new SqlConnection(connectionString);
        }
    }
}
