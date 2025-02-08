using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                "Server = ; Database = 391Project; Trusted_Connection = yes;",
                "Server = ; Database = 391Project; Trusted_Connection = yes;",
                "Server = ; Database = 391Project; Trusted_Connection = yes;",
                "Server = ; Database = 391Project; Trusted_Connection = yes;",
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
                Console.WriteLine(ex.ToString());
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
    }
}
