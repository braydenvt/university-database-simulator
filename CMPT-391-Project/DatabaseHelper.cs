using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;

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
                "Server = DESKTOP-2A78GKN; Database = 391Project; Trusted_Connection = yes;", // Brayden - 0
                "Server = DAXS-COMP-RIG; Database = 391Project; Trusted_Connection = yes;", // Daxton - 1
                "Server = ; Database = 391Project; Trusted_Connection = yes;",
                "Server = ; Database = 391Project; Trusted_Connection = yes;",
                "Server = LAPTOP-ORGILO7V; Database = 391Project; Trusted_Connection = yes;", //cole 4
                "Server = ; Database = 391Project; Trusted_Connection = yes;"
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

        public void FillSearch(String semester, String dept, String CID) {
            if (dept.Length == 0) { dept = null; }
            if (CID.Length == 0) { CID = null; }
            using (SqlCommand command = new SqlCommand("FillSearch", myConnection)) {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                
                // Semester (Required)
                command.Parameters.Add(new SqlParameter("@Semester",System.Data.SqlDbType.NVarChar,15){Value = semester});
                // Dept ID (Optional)
                command.Parameters.Add(new SqlParameter("@DepartmentID", System.Data.SqlDbType.NVarChar, 4));
                command.Parameters["@DepartmentID"].Value = (object)dept ?? DBNull.Value;
                // Course ID (Optional)
                command.Parameters.Add(new SqlParameter("@CID", System.Data.SqlDbType.NVarChar, 8));
                command.Parameters["@CID"].Value = (object)CID ?? DBNull.Value;

                myDataReader = command.ExecuteReader();
            }
        }

        public void AddToCart(int SID, int SecID) {
            using (SqlCommand command = new SqlCommand("addToCart", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Student Id (Required)
                command.Parameters.Add(new SqlParameter("@SID", System.Data.SqlDbType.Int) { Value = SID });
                // Course ID (Required)
                command.Parameters.Add(new SqlParameter("@SecID", System.Data.SqlDbType.Int) { Value = SecID });

                myDataReader = command.ExecuteReader();
                myDataReader.Close();
            }
        }

        public void DeleteFromCart(int SID, int SecID) {
            using (SqlCommand command = new SqlCommand("deleteFromCart", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Student Id (Required)
                command.Parameters.Add(new SqlParameter("@SID", System.Data.SqlDbType.Int) { Value = SID });
                // Section ID (Required)
                command.Parameters.Add(new SqlParameter("@SecID", System.Data.SqlDbType.Int) { Value = SecID });

                myDataReader = command.ExecuteReader();
                myDataReader.Close();
            }
        }

        public void CheckPrereq(int SID, string CID, string Semester) {
            using (SqlCommand command = new SqlCommand("checkPrereq", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Student Id (Required)
                command.Parameters.Add(new SqlParameter("@SID", System.Data.SqlDbType.Int) { Value = SID });
                // Course ID (Required)
                command.Parameters.Add(new SqlParameter("@CID", System.Data.SqlDbType.NVarChar,8) { Value = CID });
                // Semester (Required)
                command.Parameters.Add(new SqlParameter("@Semester", System.Data.SqlDbType.NVarChar, 15) { Value = Semester });

                myDataReader = command.ExecuteReader();
            }
        }

        public void FillStudentEnrollment(string Semester, int SID) {
            using (SqlCommand command = new SqlCommand("FillStudentEnrollment", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                
                // Semester (Required)
                command.Parameters.Add(new SqlParameter("@Semester", System.Data.SqlDbType.NVarChar, 15) { Value = Semester });
                // Student Id (Required)
                command.Parameters.Add(new SqlParameter("@SID", System.Data.SqlDbType.Int) { Value = SID });
               
                myDataReader = command.ExecuteReader();
            }
        }

        public void CheckTimeConflict(int SID, int SecID, string TimeBlock, string Semester) {
            using (SqlCommand command = new SqlCommand("checkTimeConflict", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Student Id (Required)
                command.Parameters.Add(new SqlParameter("@SID", System.Data.SqlDbType.Int) { Value = SID });
                // Section ID (Required)
                command.Parameters.Add(new SqlParameter("@SecID", System.Data.SqlDbType.Int) { Value = SecID });
                //  TimeBlock (Required)
                command.Parameters.Add(new SqlParameter("@TimeBlock", System.Data.SqlDbType.NVarChar, 15) { Value = TimeBlock });
                // Semester ID (Required)
                command.Parameters.Add(new SqlParameter("@Semester", System.Data.SqlDbType.NVarChar, 15) { Value = Semester });

                myDataReader = command.ExecuteReader();
            }
        }

        public void Enroll(int SecID, string Semester, int SID) {
            using (SqlCommand command = new SqlCommand("EnrolFromCart", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Section ID (Required)
                command.Parameters.Add(new SqlParameter("@SecID", System.Data.SqlDbType.Int) { Value = SecID });
                // Semester ID (Required)
                command.Parameters.Add(new SqlParameter("@CurrentSemester", System.Data.SqlDbType.NVarChar, 15) { Value = Semester });
                // Student Id (Required)
                command.Parameters.Add(new SqlParameter("@SID", System.Data.SqlDbType.Int) { Value = SID });

                myDataReader = command.ExecuteReader();
            }
        }

        public void Unenroll(int SecID, int SID) {
            using (SqlCommand command = new SqlCommand("Unenroll", myConnection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Student Id (Required)
                command.Parameters.Add(new SqlParameter("@SID", System.Data.SqlDbType.Int) { Value = SID });
                // Section ID (Required)
                command.Parameters.Add(new SqlParameter("@SecID", System.Data.SqlDbType.Int) { Value = SecID });

                myDataReader = command.ExecuteReader();
                myDataReader.Close();
            }
        }

    }
}
