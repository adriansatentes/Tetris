using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Tetris
{
    class SqlConnection
    {
        SqlConnection conn;
        public SqlConnection GetCon()
        {
            conn = new SqlConnection();
            return conn;
        }
    }
}
