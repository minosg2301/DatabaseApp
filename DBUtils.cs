using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MySQL
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"LAPTOP-1DNLKOHN";
            string database = "university";
            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
