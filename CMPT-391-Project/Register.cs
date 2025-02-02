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
        public Registration_System()
        {
            InitializeComponent();
        }

        public string SIDText = "";
        public string LNameText = "";


        private void QueryButton_Click(object sender, EventArgs e)
        {
            // Shows courses in the database, based upon the entered fields
            var DeptText = Dept.Text;
            var IDText = ID.Text;
            var SemText = Sem.Text;

            if (DeptText.Length == 0 || IDText.Length == 0 || SemText.Length == 0)
            {
                
            } else
            {

            }
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            // Checks if the student exists in the database and can therefore add the courses to their cart.
            // First we reset the data entered.

            SIDText = "";
            LNameText = "";

            SIDText = SID.Text;
            LNameText = LName.Text;

            // Cannot access student if either field is blank.
            if (SIDText.Length == 0 || LNameText.Length == 0)
            {
                MessageBox.Show("ID or name is not entered.");
            }
            else
            {
                // Perform queries to verify that the student exists.

                try
                {
                    // Try to find if the ID and last name are valid.


                    MessageBox.Show($@"Successfully verified!{Environment.NewLine}Student ID: {SIDText}{Environment.NewLine}Last Name: {LNameText}");
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }


            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void CourseSearchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // To test area of selection
            MessageBox.Show(String.Format("Row: {0}, Column: {1}",
                    CourseSearchGrid.CurrentCell.RowIndex,
                    CourseSearchGrid.CurrentCell.ColumnIndex), "Current Cell");

            // Check what column was clicked to add a course to the cart.
            if (CourseSearchGrid.Columns[e.ColumnIndex].Name == "Col_CartAdd" && e.RowIndex != -1)
            {

                if (SIDText.Length == 0 || LNameText.Length == 0)
                {
                    MessageBox.Show("ID or name is not entered.");
                }
                else
                {
                    if (MessageBox.Show("Are you sure want to add this course to your cart ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Adds the course to the cart
                        try
                        {
                            
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
            if (CartDataGrid.Columns[e.ColumnIndex].Name== "CartEnroll" && e.RowIndex != -1)
            {
                if (SIDText.Length == 0 || LNameText.Length == 0)
                {
                    MessageBox.Show("ID or name is not entered.");
                }
                else
                {
                    // Confirmation to enroll in the course
                    if (MessageBox.Show("Are you sure want to enroll in this course ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Enrolls the course into the students' page
                        try
                        {

                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString(), "Error");
                        }
                    }
                }
            }

            if (CartDataGrid.Columns[e.ColumnIndex].Name == "CartDelete" && e.RowIndex != -1)
            {
                if (SIDText.Length == 0 || LNameText.Length == 0)
                {
                    MessageBox.Show("ID or name is not entered.");
                }
                else
                {
                    // Confirmation to remove the course from the cart
                    if (MessageBox.Show("Are you sure want to remove this course from your cart ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Removes the course from the cart
                        try
                        {

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
            if (CourseSearchGrid.Columns[e.ColumnIndex].Name == "Col_CartAdd" && e.RowIndex != -1)
            {
                // Confirmation to unenroll the course from the cart
                if (MessageBox.Show("Are you sure want to unenroll in this course ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Removes the course from the cart
                    try
                    {

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
