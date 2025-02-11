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
            dbHelper = new DatabaseHelper();
            QueryButton_Click(null, EventArgs.Empty);
            FillStudentEnrollment();
        }

        public string SIDText = "";
        public string LNameText = "";
        public string Verified = "Y";

        public List<string> cartSecIDs = new List<string>();
        public List<string> enrollSecIDs = new List<string>();
        public List<int> prereqsMet = new List<int> ();


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
                CourseSearchGrid.Rows.Add(dbHelper.myDataReader["TimeBlock"].ToString(), dbHelper.myDataReader["CID"].ToString(), dbHelper.myDataReader["Title"], dbHelper.myDataReader["SecID"].ToString(),
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
            Verified = "Y";     // Need to change to N if verify is to be an added feature.

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

                            var addedCID = CourseSearchGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                            var addedTitle = CourseSearchGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                            var addedSecID = CourseSearchGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                            var addedSem = CourseSearchGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                            var addedTimeBlock = CourseSearchGrid.Rows[e.RowIndex].Cells[0].Value.ToString();


                            if (cartSecIDs.Contains(addedSecID) == false)
                            {
                                // Call database to add class to cart
                                try
                                {
                                    dbHelper.AddToCart(Int32.Parse(SID.Text), Int32.Parse(addedSecID));

                                    CartDataGrid.Rows.Add(addedTimeBlock,addedCID, addedTitle,
                                    addedSecID, addedSem, EnrollUnenroll);

                                    cartSecIDs.Add(addedSecID);

                                    dbHelper.CheckPrereq(Int32.Parse(SID.Text), addedCID, Sem.Text);
                                    while (dbHelper.myDataReader.Read())
                                    {
                                        if (Int32.Parse(dbHelper.myDataReader["PrereqMet"].ToString()) == 1)
                                        {
                                            prereqsMet.Add(1);

                                        }
                                        else
                                        {
                                            CartDataGrid.Rows[cartSecIDs.Count - 1].HeaderCell.Style.BackColor = Color.Red;
                                            CartDataGrid.Rows[cartSecIDs.Count - 1].HeaderCell.ToolTipText = "The Prerequisites for this class are not met";
                                            CartDataGrid.EnableHeadersVisualStyles = false;
                                            prereqsMet.Add(0);
                                        }
                                    }
                                    dbHelper.myDataReader.Close();

                                }
                                catch (SqlException ex) { MessageBox.Show("Error adding course to cart.");} //+ ex.ToString()); }
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
                    if (prereqsMet[e.RowIndex] == 0)
                    {
                        MessageBox.Show("Course Prerequisites are not met.", "Error");
                    }
                    else
                    {
                        // Confirmation to enroll in the course
                        if (MessageBox.Show("Are you sure want to enroll in this course ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Enrolls the course into the students' page
                            try
                            {
                                var addedCID = CartDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                                var addedTitle = CartDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                                var addedSecID = CartDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                                var addedSem = CartDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                                var addedTimeBlock = CartDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                                if (enrollSecIDs.Contains(addedSecID) == false  )
                                {
                                    try
                                    {
                                        dbHelper.CheckTimeConflict(Int32.Parse(SID.Text), Int32.Parse(addedSecID), addedTimeBlock, addedSem);
                                        while (dbHelper.myDataReader.Read())
                                        {
                                            if (dbHelper.myDataReader["ConflictSecID"].ToString() == "0")
                                            {
                                                try {
                                                    dbHelper.myDataReader.Close();
                                                    dbHelper.Enroll(Int32.Parse(addedSecID),addedSem,Int32.Parse(SID.Text));
                                                    int result;
                                                    while (dbHelper.myDataReader.Read())
                                                    {
                                                        if (Int32.Parse(dbHelper.myDataReader["Result"].ToString()) == 1) {
                                                            EnrollDataGrid.Rows.Add(addedTimeBlock, addedCID, addedTitle,
                                                            addedSecID, addedSem, EnrollUnenroll);

                                                            CartDataGrid.Rows.RemoveAt(e.RowIndex);

                                                            cartSecIDs.Remove(addedSecID);
                                                            enrollSecIDs.Add(addedSecID);

                                                            prereqsMet.RemoveAt(e.RowIndex);

                                                            MessageBox.Show($@"You have enrolled in: {Environment.NewLine}Course ID: {addedCID}{Environment.NewLine}Section ID: {addedSecID}{Environment.NewLine}Semester: {addedSem}{Environment.NewLine}","Enrollment Complete");
                                                        }
                                                        else {
                                                            MessageBox.Show("Enrollment failed, section " + addedSecID + " is full.", "Enrollment Failed");
                                                        }
                                                        dbHelper.myDataReader.Close();
                                                        break;
                                                    }
                                                    
                                                }
                                                catch (SqlException ex) { 
                                                    MessageBox.Show(ex.ToString());
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Can't enroll in " + addedSecID + ", conflicts with section " + dbHelper.myDataReader["ConflictSecID"].ToString() + ".", "Time Conflict");
                                                dbHelper.myDataReader.Close();
                                            }
                                            break;
                                        }
                                        
                                    }
                                    catch(SqlException ex) {
                                        MessageBox.Show(ex.ToString()); }
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
                            var removedCID = CartDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                            var removedSecID = CartDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                            var removedSem = CartDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                            var removedTimeBlock = CartDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                            dbHelper.DeleteFromCart(Int32.Parse(SID.Text), Int32.Parse(removedSecID));

                            MessageBox.Show($@"Removed the following course from your cart: {Environment.NewLine
                                }Course ID: {removedCID}{Environment.NewLine
                                }Section ID: {removedSecID}{Environment.NewLine
                                }Semester: {removedSem}{Environment.NewLine}", 
                                "Successfully removed!");

                            prereqsMet.RemoveAt(e.RowIndex);

                            CartDataGrid.Rows.RemoveAt(e.RowIndex);

                            cartSecIDs.Remove(removedSecID);

                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString(), "Error removing course from cart.");
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

                            var removedCID = EnrollDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                            var removedSecID = EnrollDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                            var removedSem = EnrollDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                            var removedTimeBlock = EnrollDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                            dbHelper.Unenroll(Int32.Parse(removedSecID), Int32.Parse(SID.Text));

                            MessageBox.Show($@"Unenrolled from the following course: {Environment.NewLine
                                }Course ID: {removedCID}{Environment.NewLine
                                }Section ID: {removedSecID}{Environment.NewLine
                                }Semester: {removedSem}{Environment.NewLine}", 
                                "Successfully unenrolled!");

                            EnrollDataGrid.Rows.RemoveAt(e.RowIndex);

                            enrollSecIDs.Remove(removedSecID);
                          
                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString(), "Error");
                        }
                    }
                }
            }
        }

        public void FillStudentEnrollment() {
            try
            {
                dbHelper.FillStudentEnrollment(Sem.Text, Int32.Parse(SID.Text));
                while (dbHelper.myDataReader.Read())
                {
                    EnrollDataGrid.Rows.Add(dbHelper.myDataReader["TimeBlock"].ToString(), dbHelper.myDataReader["CID"].ToString(), dbHelper.myDataReader["Title"], dbHelper.myDataReader["SecID"].ToString(),
                    dbHelper.myDataReader["Semester"].ToString());
                }
                dbHelper.myDataReader.Close();

            }
            catch(SqlException ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
