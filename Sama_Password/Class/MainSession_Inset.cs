
using System.Data.SqlClient;
using System.Data;



namespace Sama_Password
{
    class MainSession_Inset
    {
        Project_Connection newconnection = new Project_Connection();
        public int status
        {
            get { return status; }
            set { status = value; }

        }

       public int Place
        {
            get { return Place;}
            set { Place = value; }
        }
        

       public string startdate
        {
            get { return startdate; }
            set { startdate = value; }
        }
        
       public string enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }
       public string starttime
        {
            get { return starttime; }
            set { starttime = value; }
        }
       public string endtime
        {
            get { return endtime; }
            set { endtime = value; }
        }
       public string ficilityname
        {
            get { return ficilityname; }
            set { ficilityname = value; }
        }
       public string MainPerson
        {
            get { return MainPerson; }
            set { MainPerson = value; }
        }
       public string explane
        {
            get { return explane; }
            set { explane = value; }
        }
       public int isUserTeachig
        {
            get { return isUserTeachig; }
            set { isUserTeachig = value; }
        }
       public int isSecondTeaching
        {
            get { return isSecondTeaching; }
            set { isSecondTeaching = value; }
        }
       public int isProblemSolving
        {
            get { return isProblemSolving; }
            set { isProblemSolving = value; }
        }
       public int isServerChanging
        {
            get { return isServerChanging; }
            set { isServerChanging = value; }
        }
       public int isSqlInstall
        {
            get { return isSqlInstall; }
            set { isSqlInstall = value; }
        }
       public int isSystemInstall
        {
            get { return isSystemInstall; }
            set { isSystemInstall = value; }
        }
       public int isAmoozesh
        {
            get { return isAmoozesh; }
            set { isAmoozesh = value; }
        }
       public int isMali
        {
            get { return isMali; }
            set { isMali = value; }
        }
       public int isEvaluation
        {
            get { return isEvaluation; }
            set { isEvaluation = value; }
        }
       public int isTalented
        {
            get { return isTalented; }
            set { isTalented = value; }
        }
       public int isShahed
        {
            get { return isShahed; }
            set { isShahed = value; }
        }
       public int isDoormitory
        {
            get { return isDoormitory; }
            set { isDoormitory = value; }
        }
       public int isNutrition
        {
            get { return isNutrition; }
            set { isNutrition = value; }
        }
       public int isTeacherSalary
        {
            get { return isTeacherSalary; }
            set { isTeacherSalary = value; }
        }
       public int isProposal
        {
            get { return isProposal; }
            set { isProposal = value; }
        }
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
