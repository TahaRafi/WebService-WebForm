using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Test
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {

        [WebMethod]
        public int InsertStudent(int Sid,string StudentFirstName,string StudentLastName)
        {
            int retRecord=0;
            using(SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("SID", SqlDbType.Int).Value = Sid;
                    cmd.Parameters.Add("FirstName", SqlDbType.VarChar, 255).Value = StudentFirstName;
                    cmd.Parameters.Add("LastName", SqlDbType.VarChar, 255).Value = StudentLastName;
                    if(con.State!=ConnectionState.Open)
                    {
                        con.Open();

                    }
                    try
                    {
                        retRecord = cmd.ExecuteNonQuery();
                    }
                    catch(Exception e)
                    {

                    }
                }
            }
            return retRecord;
        }



        [WebMethod]
        public int InsertAssessments(int AID, int SID,string AssessType,string Date,int MaxMark)
        {
            int retRecord = 0;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertAssessment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("AID1", SqlDbType.Int).Value = AID;
                    cmd.Parameters.Add("SID1", SqlDbType.Int).Value = SID;
                    cmd.Parameters.Add("AssesSType1", SqlDbType.VarChar, 255).Value =AssessType;
                    
                    cmd.Parameters.Add("Date1", SqlDbType.VarChar, 255).Value = Date;
                    
                    cmd.Parameters.Add("MaxMark1", SqlDbType.Int).Value = MaxMark;
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();

                    }
                    retRecord = cmd.ExecuteNonQuery();
                }
            }
            return retRecord;
        }




        [WebMethod]
        public int InsertGrade(int SID,int Marks,string Grade)
        {
            int retRecord = 0;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertGrading", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("SID", SqlDbType.Int).Value = SID;
                    cmd.Parameters.Add("Marks", SqlDbType.Int).Value = Marks;
                    cmd.Parameters.Add("Grade", SqlDbType.VarChar, 255).Value = Grade;
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();

                    }
                    retRecord = cmd.ExecuteNonQuery();
                }
            }
            return retRecord;
        }

    }
}
