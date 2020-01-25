
using System.Data.SqlClient;
using System.Data;


namespace Sama_Password
{
    class MainSession_Inset
    {
        Project_Connection newconnection = new Project_Connection();
       public int status;
       public int Place;
       public string startdate;
       public string enddate;
       public string starttime;
       public string endtime;
       public string ficilityname;
       public string MainPerson;
       public string explane;
       public int isUserTeachig;
       public int isSecondTeaching;
       public int isProblemSolving;
       public int isServerChanging;
       public int isSqlInstall;
       public int isSystemInstall;
       public int isAmoozesh;
       public int isMali;
       public int isEvaluation;
       public int isTalented;
       public int isShahed;
       public int isDoormitory;
       public int isNutrition;
       public int isTeacherSalary;
       public int isProposal;
        public void mainSession()
        {
            newconnection.sqlconn();
            {
                SqlCommand sqlComm = new SqlCommand("MainSessinData");
                sqlComm.Connection = Project_Connection.conn;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.Add("@status", SqlDbType.Int).Value = status;
                sqlComm.Parameters.Add("@place", SqlDbType.Int).Value = Place;
                sqlComm.Parameters.Add("@Startdate", SqlDbType.NVarChar, 20).Value = startdate;
                sqlComm.Parameters.Add("@enddate", SqlDbType.NVarChar, 20).Value = enddate;
                sqlComm.Parameters.Add("@starttime", SqlDbType.NVarChar, 10).Value = starttime;
                sqlComm.Parameters.Add("@endtime", SqlDbType.NVarChar, 10).Value = endtime;
                sqlComm.Parameters.Add("@ficilityname", SqlDbType.NVarChar, 30).Value = ficilityname;
                sqlComm.Parameters.Add("@MainPerson", SqlDbType.NVarChar, 30).Value = MainPerson;
                sqlComm.Parameters.Add("@explane", SqlDbType.NVarChar, 100).Value = explane;
                sqlComm.Parameters.Add("@isUserTeachig", SqlDbType.Int).Value = isUserTeachig;
                sqlComm.Parameters.Add("@isSecondTeaching", SqlDbType.Int).Value = isSecondTeaching;
                sqlComm.Parameters.Add("@isProblemSolving", SqlDbType.Int).Value = isProblemSolving;
                sqlComm.Parameters.Add("@isServerChanging", SqlDbType.Int).Value = isServerChanging;
                sqlComm.Parameters.Add("@isSqlInstall", SqlDbType.Int).Value = isSqlInstall;
                sqlComm.Parameters.Add("@isSystemInstall", SqlDbType.Int).Value = isSystemInstall;
                sqlComm.Parameters.Add("@isAmoozesh", SqlDbType.Int).Value = isAmoozesh;
                sqlComm.Parameters.Add("@isMali", SqlDbType.Int).Value = isMali;
                sqlComm.Parameters.Add("@isEvaluation", SqlDbType.Int).Value = isEvaluation;
                sqlComm.Parameters.Add("@isTalented", SqlDbType.Int).Value = isTalented;
                sqlComm.Parameters.Add("@isShahed", SqlDbType.Int).Value = isShahed;
                sqlComm.Parameters.Add("@isDoormitory", SqlDbType.Int).Value = isDoormitory;
                sqlComm.Parameters.Add("@isNutrition", SqlDbType.Int).Value = isNutrition;
                sqlComm.Parameters.Add("@isTeacherSalary", SqlDbType.Int).Value = isTeacherSalary;
                sqlComm.Parameters.Add("@isProposal", SqlDbType.Int).Value = isProposal;
                sqlComm.ExecuteNonQuery();

            }
        }


    }
}
