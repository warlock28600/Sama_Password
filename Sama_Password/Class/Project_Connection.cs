using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sama_Password
{
    using Microsoft.Win32;
    public class Project_Connection
    {
        public static SqlConnection conn = null;

        public void sqlconn()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=sama_pass;Integrated Security=True");
            conn.Open();
        }
    }
}
