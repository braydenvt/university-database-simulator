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
            var SIDText = ID.Text;
            var PassText = Pass.Text;

            // Cannot access student if either field is blank.
            if (SIDText.Length == 0 || PassText.Length == 0)
            {
                MessageBox.Show("ID or password is not entered.");
            } else
            {
                // Perform queries...

            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void CartDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check what column was clicked, to enroll in a course or delete a course from the cart
            if (CartDataGrid.Columns[e.ColumnIndex].Name== "CartEnroll")
            {
                if (MessageBox.Show("Are you sure want to enroll in this course ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Enrolls the course into the students' page
                    return;
                }
            }

            if (CartDataGrid.Columns[e.ColumnIndex].Name == "CartDelete")
            {
                if (MessageBox.Show("Are you sure want to remove this course from your cart ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Removes the course from the cart
                    return;
                }
            }
        }

        private void CourseSearchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check what column was clicked to add a course to the cart.
            if (CourseSearchGrid.Columns[e.ColumnIndex].Name == "Col_CartAdd")
            {
                if (MessageBox.Show("Are you sure want to add this course to your cart ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Removes the course from the cart
                    return;
                }
            }

        }

        private void EnrollDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check what column was clicked to unenroll from a course.
            if (CourseSearchGrid.Columns[e.ColumnIndex].Name == "Col_CartAdd")
            {
                if (MessageBox.Show("Are you sure want to unenroll in this course ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Removes the course from the cart
                    return;
                }
            }
        }
    }
}
