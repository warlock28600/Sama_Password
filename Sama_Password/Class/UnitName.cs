
using System.Data.SqlClient;
using System.Data;


namespace Sama_Password
{
    class UnitName
    {

        Project_Connection newconnection = new Project_Connection();
        
        

        public DataTable UnitNameListAll()
        {
            newconnection.sqlconn();
            {
                SqlCommand sqlComm = new SqlCommand("Main_Unit");
                sqlComm.Connection = Project_Connection.conn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                               
                DataTable t = new DataTable();
                 da.Fill(t);
                return t;
            }
        }
    }
}
