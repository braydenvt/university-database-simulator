using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;

namespace CMPT_391_Project
{
    public class DatabaseHelper
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myDataReader;
        private readonly List<string> connectionStrings;
        public DatabaseHelper() 
        {

            connectionStrings = new List<string>
            {
                "Server = DESKTOP-2A78GKN; Database = 391Project2; Trusted_Connection = yes;", // Brayden - 0
                "Server = DAXS-COMP-RIG; Database = 391Project2; Trusted_Connection = yes;", // Daxton - 1
                "Server = ; Database = 391Project2; Trusted_Connection = yes;",
                "Server = ; Database = 391Project2; Trusted_Connection = yes;",
                "Server = LAPTOP-ORGILO7V; Database = 391Project2; Trusted_Connection = yes;", // Cole - 4
                "Server = ; Database = 391Project2; Trusted_Connection = yes;",
                "Server = TABLET-PUDR0N7I\\MSSQLSERVER01; Database = 391Project2; Trusted_Connection = yes;" // Stu - 6
            };
        
            myConnection = new SqlConnection(connectionStrings[0]);

            try {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                Console.WriteLine("Connection complete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString(), "Error");
            }
        }

        public void query(String query_string)
        {
            myCommand.CommandText = query_string;
            myDataReader = myCommand.ExecuteReader();
        }

        public void loadXML (String filename)
        {
            using (SqlCommand command = new SqlCommand("LoadXMLData", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@FilePath", System.Data.SqlDbType.NVarChar, 255) { Value = filename });
                myDataReader =  command.ExecuteReader();
            }
        }

        public void WarehouseSearch(String CountType, String CountBy, String InstIDText, String InstRankText, String InstFacText, String InstUniText, String SIDText,
            String MajText, String GendText, String CIDText, String DeptText, String FacText, String UniText, String DateText,
            String YearText, String SemText, String GradeText)
        {
            // All parameters are optional, but at least one is required as seen in Register.cs
            if (InstIDText.Length == 0) { InstIDText = null; } 
            if (InstRankText.Length == 0) { InstRankText = null; }
            if (InstFacText.Length == 0) { InstFacText = null; } 
            if (InstUniText.Length == 0) { InstUniText = null; }

            if (SIDText.Length == 0) { SIDText = null; }
            if (MajText.Length == 0) { MajText = null; }
            if (GendText.Length == 0) { GendText = null; }

            if (CIDText.Length == 0) { CIDText = null; }
            if (DeptText.Length == 0) { DeptText = null; }
            if (FacText.Length == 0) { FacText = null; }
            if (UniText.Length == 0) { UniText = null; }

            if (DateText.Length == 0) { DateText = null; }
            if (YearText.Length == 0) { YearText = null; }
            if (SemText.Length == 0) { SemText = null; }

            if (GradeText.Length == 0) { GradeText = null; }

            using (SqlCommand command = new SqlCommand("extractData", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Logic used for the stored procedure (3/02/25 12:29 pm)

                //@CourseId INT = NULL,
                //@InstructorId INT = NULL,
                //@StudentId INT = NULL,
                //@DateId INT = NULL,
                //@Grade VARCHAR(2) = NULL,
                //@Department VARCHAR(50) = NULL,
                //@CourseFaculty VARCHAR(50) = NULL,
                //@CourseUniversity VARCHAR(50) = NULL,
                //@InstructorFaculty VARCHAR(50) = NULL,
                //@InstructorRank VARCHAR(50) = NULL,
                //@InstructorUniversity VARCHAR(50) = NULL,
                //@Major VARCHAR(50) = NULL,
                //@Gender VARCHAR(10) = NULL,
                //@Semester VARCHAR(20) = NULL,
                //@Year INT = NULL

                // Count Type, Count By (Will always be selected)
                command.Parameters.Add(new SqlParameter("@CountType", System.Data.SqlDbType.NVarChar, 10) { Value = CountType });
                command.Parameters.Add(new SqlParameter("@CountBy", System.Data.SqlDbType.NVarChar, 10) { Value = CountBy });

                command.Parameters.Add(new SqlParameter("@CourseID", System.Data.SqlDbType.Int));
                command.Parameters["@CourseID"].Value = (object)CIDText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@InstructorId", System.Data.SqlDbType.Int));
                command.Parameters["@InstructorId"].Value = (object)InstIDText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@StudentId", System.Data.SqlDbType.Int));
                command.Parameters["@StudentId"].Value = (object)SIDText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@DateId", System.Data.SqlDbType.NVarChar, 8));
                command.Parameters["@DateId"].Value = (object)DateText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@Grade", System.Data.SqlDbType.NVarChar, 2));
                command.Parameters["@Grade"].Value = (object)GradeText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@Department", System.Data.SqlDbType.NVarChar, 50));
                command.Parameters["@Department"].Value = (object)DeptText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@CourseFaculty", System.Data.SqlDbType.NVarChar, 50));
                command.Parameters["@CourseFaculty"].Value = (object)FacText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@CourseUniversity", System.Data.SqlDbType.NVarChar, 50));
                command.Parameters["@CourseUniversity"].Value = (object)UniText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@InstructorFaculty", System.Data.SqlDbType.NVarChar, 50));
                command.Parameters["@InstructorFaculty"].Value = (object)InstFacText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@InstructorRank", System.Data.SqlDbType.NVarChar, 50));
                command.Parameters["@InstructorRank"].Value = (object)InstRankText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@InstructorUniversity", System.Data.SqlDbType.NVarChar, 50));
                command.Parameters["@InstructorUniversity"].Value = (object)InstUniText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@Major", System.Data.SqlDbType.NVarChar, 50));
                command.Parameters["@Major"].Value = (object)MajText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@Gender", System.Data.SqlDbType.NVarChar, 10));
                command.Parameters["@Gender"].Value = (object)GendText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@Semester", System.Data.SqlDbType.NVarChar, 20));
                command.Parameters["@Semester"].Value = (object)SemText ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter("@Year", System.Data.SqlDbType.Int));
                command.Parameters["@Year"].Value = (object)YearText ?? DBNull.Value;

                myDataReader = command.ExecuteReader();
            }
        }
    }
}
