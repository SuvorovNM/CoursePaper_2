using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Program
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"COMPUTER";

            string database = "LibraryDB";
            string username = @"Admin";//COMPUTER\
            string password = "SuvorovNM_2251";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
