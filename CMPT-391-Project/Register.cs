using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dbHelper = new DatabaseHelper();
        }

        public string SIDText = "";
        public string LNameText = "";
        public string Verified = "N";

        public List<string> cartSecIDs = new List<string>();
        public List<string> enrollSecIDs = new List<string>();


        private void QueryButton_Click(object sender, EventArgs e)
        {
            // Clear table
            CourseSearchGrid.Rows.Clear();

            // Shows courses in the database, based upon the entered fields
            var DeptText = Dept.Text;
            var IDText = ID.Text;
            var SemText = Sem.Text;

            // Read in Data
            dbHelper.FillSearch(SemText,DeptText,IDText);
            while (dbHelper.myDataReader.Read()) 
            {
                CourseSearchGrid.Rows.Add(dbHelper.myDataReader["CID"].ToString(), dbHelper.myDataReader["Title"], dbHelper.myDataReader["SecID"].ToString(),
                dbHelper.myDataReader["Semester"].ToString());
            }
            dbHelper.myDataReader.Close();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            // Checks if the student exists in the database and can therefore add the courses to their cart.
            // First we reset the data entered.

            SIDText = "";
            LNameText = "";
            Verified = "Y";     // Need to change  to N if verify is to be an added feature.

            SIDText = SID.Text;
            LNameText = LName.Text;

            // Cannot access student if either field is blank.
            if (SIDText.Length == 0 || LNameText.Length == 0)
            {
                MessageBox.Show("ID or name is not entered.");
            }
            else
            {
                // Perform queries to verify that the student exists, based on the ID and last name (validity checks).

                try
                {

                    //Verified = "Y";   // Need to change if verify is to be an added feature.
                    MessageBox.Show($@"{Environment.NewLine}Student ID: {SIDText}{Environment.NewLine}Last Name: {LNameText}", "Successfully verified!");
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }


            }
        }

        private void CourseSearchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // To test area of selection
            //MessageBox.Show(String.Format("Row: {0}, Column: {1}",
            //        CourseSearchGrid.CurrentCell.RowIndex,
            //        CourseSearchGrid.CurrentCell.ColumnIndex), "Current Cell");

            // Check what column was clicked to add a course to the cart.
            if (CourseSearchGrid.Columns[e.ColumnIndex].Name == "Col_CartAdd" && e.RowIndex >= 0)
            {

                if (Verified == "N")
                {
                    MessageBox.Show("Student is not logged in.", "Error.");
                }
                else
                {
                    if (MessageBox.Show("Are you sure want to add this course to your cart ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Adds the course to the cart
                        try
                        {

                            var addedCID = CourseSearchGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                            var addedTitle = CourseSearchGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                            var addedSecID = CourseSearchGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                            var addedSem = CourseSearchGrid.Rows[e.RowIndex].Cells[3].Value.ToString();


                            if (cartSecIDs.Contains(addedSecID) == false)
                            {
                                CartDataGrid.Rows.Add(addedCID, addedTitle,
                                addedSecID, addedSem, EnrollUnenroll);

                                cartSecIDs.Add(addedSecID);
                            }
                            else
                            {
                                MessageBox.Show("That course is already in your cart.", "Not Added");
                            }
                            
                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString(), "Error");
                        }
                    }
                }
            }

        }

        private void CartDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check what column was clicked, to enroll in a course or delete a course from the cart
            if (CartDataGrid.Columns[e.ColumnIndex].Name== "CartEnroll" && e.RowIndex >= 0)
            {


                if (Verified == "N")
                {
                    MessageBox.Show("Student is not logged in.", "Error.");
                }
                else
                {
                    // Confirmation to enroll in the course
                    if (MessageBox.Show("Are you sure want to enroll in this course ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Enrolls the course into the students' page
                        try
                        {

                            var addedCID = CartDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                            var addedTitle = CartDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                            var addedSecID = CartDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                            var addedSem = CartDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                            if (enrollSecIDs.Contains(addedSecID) == false)
                            {

                                EnrollDataGrid.Rows.Add(addedCID, addedTitle,
                                addedSecID, addedSem, EnrollUnenroll);

                                CartDataGrid.Rows.RemoveAt(e.RowIndex);

                                enrollSecIDs.Add(addedSecID);
                            }
                            else
                            {
                                MessageBox.Show("You are already enrolled in that course.", "Not Added");
                            }

                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString(), "Error");
                        }
                    }
                }
            }

            if (CartDataGrid.Columns[e.ColumnIndex].Name == "CartDelete" && e.RowIndex >= 0)
            {
                if (Verified == "N")
                {
                    MessageBox.Show("Student is not logged in.", "Error.");
                }
                else
                {
                    // Confirmation to remove the course from the cart
                    if (MessageBox.Show("Are you sure want to remove this course from your cart ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Removes the course from the cart
                        try
                        {

                            var removedCID = CartDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                            var removedSecID = CartDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                            var removedSem = CartDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                            MessageBox.Show($@"Removed the following course from your cart: {Environment.NewLine
                                }Course ID: {removedCID}{Environment.NewLine
                                }Section ID: {removedSecID}{Environment.NewLine
                                }Semester: {removedSem}{Environment.NewLine}", 
                                "Successfully removed!");

                            CartDataGrid.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString(), "Error");
                        }
                    }
                }
            }
        }

        private void EnrollDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check what column was clicked to unenroll from a course.
            if (CourseSearchGrid.Columns[e.ColumnIndex].Name == "Col_CartAdd" && e.RowIndex >= 0)
            {

                if (Verified == "N")
                {
                    MessageBox.Show("Student is not logged in.", "Error.");
                }
                else
                {
                    // Confirmation to unenroll from the course
                    if (MessageBox.Show("Are you sure want to unenroll in this course ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Removes the course from the enrolled.
                        try
                        { 

                            var removedCID = EnrollDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                            var removedSecID = EnrollDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                            var removedSem = EnrollDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                            MessageBox.Show($@"Unenrolled from the following course: {Environment.NewLine
                                }Course ID: {removedCID}{Environment.NewLine
                                }Section ID: {removedSecID}{Environment.NewLine
                                }Semester: {removedSem}{Environment.NewLine}", 
                                "Successfully unenrolled!");

                            EnrollDataGrid.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString(), "Error");
                        }
                    }
                }
            }
        }
    }
}
