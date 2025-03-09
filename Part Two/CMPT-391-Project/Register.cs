using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT_391_Project
{
    public partial class Registration_System : Form
    {
        public DatabaseHelper dbHelper;
        public Registration_System()
        {
            InitializeComponent();
            CourseSelect.Size = new Size(885, 500);
            dbHelper = new DatabaseHelper();
            // QueryButton_Click(null, EventArgs.Empty);
            SelectEnrollment.Select();
            SelectDistinct.Select();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {

            // Entered fields to narrow the search results for the aggregates
            // There are 16 fields overall (4 - instructors, 3 - students, 4 - courses, 3 - dates, 1 - grade)

            var CountType = GetSelectedRadioButton(SelectCountType);
            if (CountType.Equals("Distinct Occurrences")){
                CountType = "Distinct";
            }           
            var CountBy = GetSelectedRadioButton(SelectCount);
            
            var InstIDText = InstID.Text; 
            var InstRankText = InstRank.Text;
            var InstFacText = InstFac.Text;
            var InstUniText = InstUni.Text;

            var SIDText = SID.Text;
            var MajText = Major.Text;
            var GendText = Gender.Text;

            var CIDText = CourseID.Text;
            var DeptText = CourseDept.Text;
            var FacText = CourseFac.Text;
            var UniText = CourseUni.Text;

            var DateText = DateID.Text;
            var YearText = Year.Text;
            var SemText = Sem.Text;

            var GradeText = Grade.Text;

            
            /*if (InstIDText.Length == 0 && InstRankText.Length == 0 && InstFacText.Length == 0 && InstUniText.Length == 0
                && SIDText.Length == 0 && MajText.Length == 0 && GendText.Length == 0 && CIDText.Length == 0
                && DeptText.Length == 0 && FacText.Length == 0 && UniText.Length == 0 && DateText.Length == 0
                && YearText.Length == 0 && SemText.Length == 0 && GradeText.Length == 0)
            {
                // Nothing to query for, asks the user to enter one field
                MessageBox.Show("No attributes have been selected, please select at least one field.", "Error.");

            } 
            else 
            { */
                // Enters the attributes to search by
                dbHelper.WarehouseSearch(CountType, CountBy, InstIDText, InstRankText, InstFacText, InstUniText, SIDText,
            MajText, GendText, CIDText, DeptText, FacText, UniText, DateText, YearText, SemText, GradeText);

                while (dbHelper.myDataReader.Read())
                {
                    Occurence.Text = dbHelper.myDataReader["Occurrences"].ToString();
                }
                dbHelper.myDataReader.Close();
            //}
        }

        private string GetSelectedRadioButton(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // Returns the text of the selected radio button
                }
            }
            return null; // No selection
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";  // Restrict to XML files
            openFileDialog.Title = "Select an XML file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                dbHelper.UploadXML(selectedFilePath);
            }
        }
    }
}
