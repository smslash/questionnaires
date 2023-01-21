using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EXAM.Implementation
{
    public class GetConnection
    {
        public SqlConnection getConn
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ToString());
            }
        }
    }
}