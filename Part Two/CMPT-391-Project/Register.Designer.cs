namespace CMPT_391_Project
{
    partial class Registration_System
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CourseSelect = new System.Windows.Forms.TabPage();
            this.SelectCount = new System.Windows.Forms.GroupBox();
            this.SelectInstructor = new System.Windows.Forms.RadioButton();
            this.SelectDate = new System.Windows.Forms.RadioButton();
            this.SelectEnrollment = new System.Windows.Forms.RadioButton();
            this.SelectStudent = new System.Windows.Forms.RadioButton();
            this.SelectCourse = new System.Windows.Forms.RadioButton();
            this.Occurence = new System.Windows.Forms.TextBox();
            this.OccurenceLB = new System.Windows.Forms.Label();
            this.GradeLB = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.TextBox();
            this.InstUni = new System.Windows.Forms.TextBox();
            this.InstFac = new System.Windows.Forms.TextBox();
            this.InstID = new System.Windows.Forms.TextBox();
            this.InstRank = new System.Windows.Forms.TextBox();
            this.Major = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.DateID = new System.Windows.Forms.TextBox();
            this.CourseUni = new System.Windows.Forms.TextBox();
            this.CourseFac = new System.Windows.Forms.TextBox();
            this.CourseID = new System.Windows.Forms.TextBox();
            this.SID = new System.Windows.Forms.TextBox();
            this.CourseDept = new System.Windows.Forms.TextBox();
            this.Sem = new System.Windows.Forms.TextBox();
            this.InstUniLB = new System.Windows.Forms.Label();
            this.InstFacLB = new System.Windows.Forms.Label();
            this.InstIDLB = new System.Windows.Forms.Label();
            this.InstRankLB = new System.Windows.Forms.Label();
            this.MajorLB = new System.Windows.Forms.Label();
            this.GenderLB = new System.Windows.Forms.Label();
            this.YearLB = new System.Windows.Forms.Label();
            this.DateIDLB = new System.Windows.Forms.Label();
            this.CourseUniLB = new System.Windows.Forms.Label();
            this.QueryButton = new System.Windows.Forms.Button();
            this.CourseFacLB = new System.Windows.Forms.Label();
            this.CourseIDLB = new System.Windows.Forms.Label();
            this.SIDLB = new System.Windows.Forms.Label();
            this.CourseDeptLB = new System.Windows.Forms.Label();
            this.SemLB = new System.Windows.Forms.Label();
            this.InfoLB = new System.Windows.Forms.Label();
            this.SystemTabs = new System.Windows.Forms.TabControl();
            this.SelectCountType = new System.Windows.Forms.GroupBox();
            this.SelectDistinct = new System.Windows.Forms.RadioButton();
            this.SelectAll = new System.Windows.Forms.RadioButton();
            this.CourseSelect.SuspendLayout();
            this.SelectCount.SuspendLayout();
            this.SystemTabs.SuspendLayout();
            this.SelectCountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseSelect
            // 
            this.CourseSelect.BackColor = System.Drawing.Color.DarkSalmon;
            this.CourseSelect.Controls.Add(this.SelectCountType);
            this.CourseSelect.Controls.Add(this.SelectCount);
            this.CourseSelect.Controls.Add(this.Occurence);
            this.CourseSelect.Controls.Add(this.OccurenceLB);
            this.CourseSelect.Controls.Add(this.GradeLB);
            this.CourseSelect.Controls.Add(this.Grade);
            this.CourseSelect.Controls.Add(this.InstUni);
            this.CourseSelect.Controls.Add(this.InstFac);
            this.CourseSelect.Controls.Add(this.InstID);
            this.CourseSelect.Controls.Add(this.InstRank);
            this.CourseSelect.Controls.Add(this.Major);
            this.CourseSelect.Controls.Add(this.Gender);
            this.CourseSelect.Controls.Add(this.Year);
            this.CourseSelect.Controls.Add(this.DateID);
            this.CourseSelect.Controls.Add(this.CourseUni);
            this.CourseSelect.Controls.Add(this.CourseFac);
            this.CourseSelect.Controls.Add(this.CourseID);
            this.CourseSelect.Controls.Add(this.SID);
            this.CourseSelect.Controls.Add(this.CourseDept);
            this.CourseSelect.Controls.Add(this.Sem);
            this.CourseSelect.Controls.Add(this.InstUniLB);
            this.CourseSelect.Controls.Add(this.InstFacLB);
            this.CourseSelect.Controls.Add(this.InstIDLB);
            this.CourseSelect.Controls.Add(this.InstRankLB);
            this.CourseSelect.Controls.Add(this.MajorLB);
            this.CourseSelect.Controls.Add(this.GenderLB);
            this.CourseSelect.Controls.Add(this.YearLB);
            this.CourseSelect.Controls.Add(this.DateIDLB);
            this.CourseSelect.Controls.Add(this.CourseUniLB);
            this.CourseSelect.Controls.Add(this.QueryButton);
            this.CourseSelect.Controls.Add(this.CourseFacLB);
            this.CourseSelect.Controls.Add(this.CourseIDLB);
            this.CourseSelect.Controls.Add(this.SIDLB);
            this.CourseSelect.Controls.Add(this.CourseDeptLB);
            this.CourseSelect.Controls.Add(this.SemLB);
            this.CourseSelect.Controls.Add(this.InfoLB);
            this.CourseSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseSelect.Location = new System.Drawing.Point(4, 34);
            this.CourseSelect.Margin = new System.Windows.Forms.Padding(2);
            this.CourseSelect.Name = "CourseSelect";
            this.CourseSelect.Size = new System.Drawing.Size(913, 542);
            this.CourseSelect.TabIndex = 0;
            this.CourseSelect.Text = "Data Warehouse Entry";
            this.CourseSelect.Click += new System.EventHandler(this.CourseSelect_Click);
            // 
            // SelectCount
            // 
            this.SelectCount.Controls.Add(this.SelectInstructor);
            this.SelectCount.Controls.Add(this.SelectDate);
            this.SelectCount.Controls.Add(this.SelectEnrollment);
            this.SelectCount.Controls.Add(this.SelectStudent);
            this.SelectCount.Controls.Add(this.SelectCourse);
            this.SelectCount.Location = new System.Drawing.Point(284, 215);
            this.SelectCount.Name = "SelectCount";
            this.SelectCount.Size = new System.Drawing.Size(339, 103);
            this.SelectCount.TabIndex = 43;
            this.SelectCount.TabStop = false;
            this.SelectCount.Text = "Count By";
            this.SelectCount.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SelectInstructor
            // 
            this.SelectInstructor.AutoSize = true;
            this.SelectInstructor.Location = new System.Drawing.Point(176, 28);
            this.SelectInstructor.Name = "SelectInstructor";
            this.SelectInstructor.Size = new System.Drawing.Size(102, 25);
            this.SelectInstructor.TabIndex = 39;
            this.SelectInstructor.TabStop = true;
            this.SelectInstructor.Text = "Instructor";
            this.SelectInstructor.UseVisualStyleBackColor = true;
            this.SelectInstructor.CheckedChanged += new System.EventHandler(this.SelectInstructor_CheckedChanged);
            // 
            // SelectDate
            // 
            this.SelectDate.AutoSize = true;
            this.SelectDate.Location = new System.Drawing.Point(243, 59);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(64, 25);
            this.SelectDate.TabIndex = 42;
            this.SelectDate.TabStop = true;
            this.SelectDate.Text = "Date";
            this.SelectDate.UseVisualStyleBackColor = true;
            // 
            // SelectEnrollment
            // 
            this.SelectEnrollment.AutoSize = true;
            this.SelectEnrollment.Location = new System.Drawing.Point(57, 28);
            this.SelectEnrollment.Name = "SelectEnrollment";
            this.SelectEnrollment.Size = new System.Drawing.Size(113, 25);
            this.SelectEnrollment.TabIndex = 38;
            this.SelectEnrollment.TabStop = true;
            this.SelectEnrollment.Text = "Enrollment";
            this.SelectEnrollment.UseVisualStyleBackColor = true;
            this.SelectEnrollment.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SelectStudent
            // 
            this.SelectStudent.AutoSize = true;
            this.SelectStudent.Location = new System.Drawing.Point(136, 59);
            this.SelectStudent.Name = "SelectStudent";
            this.SelectStudent.Size = new System.Drawing.Size(88, 25);
            this.SelectStudent.TabIndex = 41;
            this.SelectStudent.TabStop = true;
            this.SelectStudent.Text = "Student";
            this.SelectStudent.UseVisualStyleBackColor = true;
            // 
            // SelectCourse
            // 
            this.SelectCourse.AutoSize = true;
            this.SelectCourse.Location = new System.Drawing.Point(35, 59);
            this.SelectCourse.Name = "SelectCourse";
            this.SelectCourse.Size = new System.Drawing.Size(80, 25);
            this.SelectCourse.TabIndex = 40;
            this.SelectCourse.TabStop = true;
            this.SelectCourse.Text = "Course";
            this.SelectCourse.UseVisualStyleBackColor = true;
            // 
            // Occurence
            // 
            this.Occurence.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Occurence.Location = new System.Drawing.Point(480, 468);
            this.Occurence.Margin = new System.Windows.Forms.Padding(2);
            this.Occurence.Name = "Occurence";
            this.Occurence.ReadOnly = true;
            this.Occurence.Size = new System.Drawing.Size(143, 39);
            this.Occurence.TabIndex = 37;
            // 
            // OccurenceLB
            // 
            this.OccurenceLB.AutoSize = true;
            this.OccurenceLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.OccurenceLB.Location = new System.Drawing.Point(192, 468);
            this.OccurenceLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OccurenceLB.Name = "OccurenceLB";
            this.OccurenceLB.Size = new System.Drawing.Size(294, 32);
            this.OccurenceLB.TabIndex = 36;
            this.OccurenceLB.Text = "Number of Occurrences:";
            // 
            // GradeLB
            // 
            this.GradeLB.AutoSize = true;
            this.GradeLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GradeLB.Location = new System.Drawing.Point(337, 353);
            this.GradeLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GradeLB.Name = "GradeLB";
            this.GradeLB.Size = new System.Drawing.Size(59, 21);
            this.GradeLB.TabIndex = 35;
            this.GradeLB.Text = "Grade:";
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(442, 350);
            this.Grade.Margin = new System.Windows.Forms.Padding(2);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(113, 29);
            this.Grade.TabIndex = 34;
            this.Grade.TextChanged += new System.EventHandler(this.Grade_TextChanged);
            // 
            // InstUni
            // 
            this.InstUni.Location = new System.Drawing.Point(128, 182);
            this.InstUni.Margin = new System.Windows.Forms.Padding(2);
            this.InstUni.Name = "InstUni";
            this.InstUni.Size = new System.Drawing.Size(113, 29);
            this.InstUni.TabIndex = 32;
            // 
            // InstFac
            // 
            this.InstFac.Location = new System.Drawing.Point(128, 149);
            this.InstFac.Margin = new System.Windows.Forms.Padding(2);
            this.InstFac.Name = "InstFac";
            this.InstFac.Size = new System.Drawing.Size(113, 29);
            this.InstFac.TabIndex = 28;
            // 
            // InstID
            // 
            this.InstID.Location = new System.Drawing.Point(128, 83);
            this.InstID.Margin = new System.Windows.Forms.Padding(2);
            this.InstID.Name = "InstID";
            this.InstID.Size = new System.Drawing.Size(113, 29);
            this.InstID.TabIndex = 29;
            // 
            // InstRank
            // 
            this.InstRank.Location = new System.Drawing.Point(128, 116);
            this.InstRank.Margin = new System.Windows.Forms.Padding(2);
            this.InstRank.Name = "InstRank";
            this.InstRank.Size = new System.Drawing.Size(113, 29);
            this.InstRank.TabIndex = 26;
            // 
            // Major
            // 
            this.Major.Location = new System.Drawing.Point(128, 294);
            this.Major.Margin = new System.Windows.Forms.Padding(2);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(113, 29);
            this.Major.TabIndex = 24;
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(128, 330);
            this.Gender.Margin = new System.Windows.Forms.Padding(2);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(113, 29);
            this.Gender.TabIndex = 22;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(769, 297);
            this.Year.Margin = new System.Windows.Forms.Padding(2);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(113, 29);
            this.Year.TabIndex = 20;
            // 
            // DateID
            // 
            this.DateID.Location = new System.Drawing.Point(769, 260);
            this.DateID.Margin = new System.Windows.Forms.Padding(2);
            this.DateID.Name = "DateID";
            this.DateID.Size = new System.Drawing.Size(113, 29);
            this.DateID.TabIndex = 18;
            // 
            // CourseUni
            // 
            this.CourseUni.Location = new System.Drawing.Point(769, 178);
            this.CourseUni.Margin = new System.Windows.Forms.Padding(2);
            this.CourseUni.Name = "CourseUni";
            this.CourseUni.Size = new System.Drawing.Size(113, 29);
            this.CourseUni.TabIndex = 16;
            // 
            // CourseFac
            // 
            this.CourseFac.Location = new System.Drawing.Point(769, 144);
            this.CourseFac.Margin = new System.Windows.Forms.Padding(2);
            this.CourseFac.Name = "CourseFac";
            this.CourseFac.Size = new System.Drawing.Size(113, 29);
            this.CourseFac.TabIndex = 9;
            // 
            // CourseID
            // 
            this.CourseID.Location = new System.Drawing.Point(769, 78);
            this.CourseID.Margin = new System.Windows.Forms.Padding(2);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(113, 29);
            this.CourseID.TabIndex = 9;
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(128, 258);
            this.SID.Margin = new System.Windows.Forms.Padding(2);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(113, 29);
            this.SID.TabIndex = 7;
            // 
            // CourseDept
            // 
            this.CourseDept.Location = new System.Drawing.Point(769, 111);
            this.CourseDept.Margin = new System.Windows.Forms.Padding(2);
            this.CourseDept.Name = "CourseDept";
            this.CourseDept.Size = new System.Drawing.Size(113, 29);
            this.CourseDept.TabIndex = 3;
            // 
            // Sem
            // 
            this.Sem.Location = new System.Drawing.Point(769, 333);
            this.Sem.Margin = new System.Windows.Forms.Padding(2);
            this.Sem.Name = "Sem";
            this.Sem.Size = new System.Drawing.Size(113, 29);
            this.Sem.TabIndex = 1;
            // 
            // InstUniLB
            // 
            this.InstUniLB.AutoSize = true;
            this.InstUniLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.InstUniLB.Location = new System.Drawing.Point(41, 186);
            this.InstUniLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstUniLB.Name = "InstUniLB";
            this.InstUniLB.Size = new System.Drawing.Size(41, 21);
            this.InstUniLB.TabIndex = 33;
            this.InstUniLB.Text = "Uni:";
            this.InstUniLB.Click += new System.EventHandler(this.InstUniLB_Click);
            // 
            // InstFacLB
            // 
            this.InstFacLB.AutoSize = true;
            this.InstFacLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.InstFacLB.Location = new System.Drawing.Point(41, 152);
            this.InstFacLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstFacLB.Name = "InstFacLB";
            this.InstFacLB.Size = new System.Drawing.Size(69, 21);
            this.InstFacLB.TabIndex = 30;
            this.InstFacLB.Text = "Faculty:";
            this.InstFacLB.Click += new System.EventHandler(this.InstFacLB_Click);
            // 
            // InstIDLB
            // 
            this.InstIDLB.AutoSize = true;
            this.InstIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.InstIDLB.Location = new System.Drawing.Point(15, 86);
            this.InstIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstIDLB.Name = "InstIDLB";
            this.InstIDLB.Size = new System.Drawing.Size(109, 21);
            this.InstIDLB.TabIndex = 31;
            this.InstIDLB.Text = "Instructor ID:";
            // 
            // InstRankLB
            // 
            this.InstRankLB.AutoSize = true;
            this.InstRankLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.InstRankLB.Location = new System.Drawing.Point(41, 119);
            this.InstRankLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstRankLB.Name = "InstRankLB";
            this.InstRankLB.Size = new System.Drawing.Size(53, 21);
            this.InstRankLB.TabIndex = 27;
            this.InstRankLB.Text = "Rank:";
            // 
            // MajorLB
            // 
            this.MajorLB.AutoSize = true;
            this.MajorLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorLB.Location = new System.Drawing.Point(41, 297);
            this.MajorLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MajorLB.Name = "MajorLB";
            this.MajorLB.Size = new System.Drawing.Size(60, 21);
            this.MajorLB.TabIndex = 25;
            this.MajorLB.Text = "Major:";
            // 
            // GenderLB
            // 
            this.GenderLB.AutoSize = true;
            this.GenderLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLB.Location = new System.Drawing.Point(40, 336);
            this.GenderLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLB.Name = "GenderLB";
            this.GenderLB.Size = new System.Drawing.Size(70, 21);
            this.GenderLB.TabIndex = 23;
            this.GenderLB.Text = "Gender:";
            // 
            // YearLB
            // 
            this.YearLB.AutoSize = true;
            this.YearLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLB.Location = new System.Drawing.Point(676, 302);
            this.YearLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearLB.Name = "YearLB";
            this.YearLB.Size = new System.Drawing.Size(48, 21);
            this.YearLB.TabIndex = 21;
            this.YearLB.Text = "Year:";
            // 
            // DateIDLB
            // 
            this.DateIDLB.AutoSize = true;
            this.DateIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateIDLB.Location = new System.Drawing.Point(676, 266);
            this.DateIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateIDLB.Name = "DateIDLB";
            this.DateIDLB.Size = new System.Drawing.Size(71, 21);
            this.DateIDLB.TabIndex = 19;
            this.DateIDLB.Text = "Date ID:";
            // 
            // CourseUniLB
            // 
            this.CourseUniLB.AutoSize = true;
            this.CourseUniLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseUniLB.Location = new System.Drawing.Point(659, 186);
            this.CourseUniLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseUniLB.Name = "CourseUniLB";
            this.CourseUniLB.Size = new System.Drawing.Size(41, 21);
            this.CourseUniLB.TabIndex = 17;
            this.CourseUniLB.Text = "Uni:";
            // 
            // QueryButton
            // 
            this.QueryButton.BackColor = System.Drawing.Color.GreenYellow;
            this.QueryButton.FlatAppearance.BorderSize = 0;
            this.QueryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton.ForeColor = System.Drawing.Color.Teal;
            this.QueryButton.Location = new System.Drawing.Point(442, 393);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(0);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(113, 31);
            this.QueryButton.TabIndex = 13;
            this.QueryButton.Text = "Query";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // CourseFacLB
            // 
            this.CourseFacLB.AutoSize = true;
            this.CourseFacLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseFacLB.Location = new System.Drawing.Point(659, 152);
            this.CourseFacLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseFacLB.Name = "CourseFacLB";
            this.CourseFacLB.Size = new System.Drawing.Size(69, 21);
            this.CourseFacLB.TabIndex = 10;
            this.CourseFacLB.Text = "Faculty:";
            // 
            // CourseIDLB
            // 
            this.CourseIDLB.AutoSize = true;
            this.CourseIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.CourseIDLB.Location = new System.Drawing.Point(659, 81);
            this.CourseIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseIDLB.Name = "CourseIDLB";
            this.CourseIDLB.Size = new System.Drawing.Size(87, 21);
            this.CourseIDLB.TabIndex = 10;
            this.CourseIDLB.Text = "Course ID:";
            // 
            // SIDLB
            // 
            this.SIDLB.AutoSize = true;
            this.SIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.SIDLB.Location = new System.Drawing.Point(29, 260);
            this.SIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SIDLB.Name = "SIDLB";
            this.SIDLB.Size = new System.Drawing.Size(95, 21);
            this.SIDLB.TabIndex = 8;
            this.SIDLB.Text = "Student ID:";
            // 
            // CourseDeptLB
            // 
            this.CourseDeptLB.AutoSize = true;
            this.CourseDeptLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseDeptLB.Location = new System.Drawing.Point(659, 114);
            this.CourseDeptLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseDeptLB.Name = "CourseDeptLB";
            this.CourseDeptLB.Size = new System.Drawing.Size(106, 21);
            this.CourseDeptLB.TabIndex = 4;
            this.CourseDeptLB.Text = "Department:";
            // 
            // SemLB
            // 
            this.SemLB.AutoSize = true;
            this.SemLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemLB.Location = new System.Drawing.Point(676, 338);
            this.SemLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SemLB.Name = "SemLB";
            this.SemLB.Size = new System.Drawing.Size(85, 21);
            this.SemLB.TabIndex = 2;
            this.SemLB.Text = "Semester:";
            // 
            // InfoLB
            // 
            this.InfoLB.AutoSize = true;
            this.InfoLB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.InfoLB.Location = new System.Drawing.Point(300, 9);
            this.InfoLB.Name = "InfoLB";
            this.InfoLB.Size = new System.Drawing.Size(317, 84);
            this.InfoLB.TabIndex = 15;
            this.InfoLB.Text = "Enter the relevant info based \r\nupon the search fields you wish to enter.\r\nUnderl" +
    "ined attributes are guaranteed\r\nto be unique.";
            // 
            // SystemTabs
            // 
            this.SystemTabs.Controls.Add(this.CourseSelect);
            this.SystemTabs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemTabs.ItemSize = new System.Drawing.Size(160, 30);
            this.SystemTabs.Location = new System.Drawing.Point(0, 1);
            this.SystemTabs.Margin = new System.Windows.Forms.Padding(2);
            this.SystemTabs.Name = "SystemTabs";
            this.SystemTabs.SelectedIndex = 0;
            this.SystemTabs.Size = new System.Drawing.Size(921, 580);
            this.SystemTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.SystemTabs.TabIndex = 0;
            // 
            // SelectCountType
            // 
            this.SelectCountType.Controls.Add(this.SelectAll);
            this.SelectCountType.Controls.Add(this.SelectDistinct);
            this.SelectCountType.Location = new System.Drawing.Point(284, 109);
            this.SelectCountType.Name = "SelectCountType";
            this.SelectCountType.Size = new System.Drawing.Size(339, 69);
            this.SelectCountType.TabIndex = 44;
            this.SelectCountType.TabStop = false;
            this.SelectCountType.Text = "Count";
            this.SelectCountType.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // SelectDistinct
            // 
            this.SelectDistinct.AutoSize = true;
            this.SelectDistinct.Location = new System.Drawing.Point(6, 30);
            this.SelectDistinct.Name = "SelectDistinct";
            this.SelectDistinct.Size = new System.Drawing.Size(184, 25);
            this.SelectDistinct.TabIndex = 0;
            this.SelectDistinct.TabStop = true;
            this.SelectDistinct.Text = "Distinct Occurrences";
            this.SelectDistinct.UseVisualStyleBackColor = true;
            this.SelectDistinct.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // SelectAll
            // 
            this.SelectAll.AutoSize = true;
            this.SelectAll.Location = new System.Drawing.Point(193, 30);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(146, 25);
            this.SelectAll.TabIndex = 1;
            this.SelectAll.TabStop = true;
            this.SelectAll.Text = "All Occurrences";
            this.SelectAll.UseVisualStyleBackColor = true;
            // 
            // Registration_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 584);
            this.Controls.Add(this.SystemTabs);
            this.Name = "Registration_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Registration System";
            this.CourseSelect.ResumeLayout(false);
            this.CourseSelect.PerformLayout();
            this.SelectCount.ResumeLayout(false);
            this.SelectCount.PerformLayout();
            this.SystemTabs.ResumeLayout(false);
            this.SelectCountType.ResumeLayout(false);
            this.SelectCountType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CourseSelect;
        private System.Windows.Forms.Label GradeLB;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.TextBox InstUni;
        private System.Windows.Forms.TextBox InstFac;
        private System.Windows.Forms.TextBox InstID;
        private System.Windows.Forms.TextBox InstRank;
        private System.Windows.Forms.TextBox Major;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox DateID;
        private System.Windows.Forms.TextBox CourseUni;
        private System.Windows.Forms.TextBox CourseFac;
        private System.Windows.Forms.TextBox CourseID;
        private System.Windows.Forms.TextBox SID;
        private System.Windows.Forms.TextBox CourseDept;
        private System.Windows.Forms.TextBox Sem;
        private System.Windows.Forms.Label InstUniLB;
        private System.Windows.Forms.Label InstFacLB;
        private System.Windows.Forms.Label InstIDLB;
        private System.Windows.Forms.Label InstRankLB;
        private System.Windows.Forms.Label MajorLB;
        private System.Windows.Forms.Label GenderLB;
        private System.Windows.Forms.Label YearLB;
        private System.Windows.Forms.Label DateIDLB;
        private System.Windows.Forms.Label CourseUniLB;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.Label CourseFacLB;
        private System.Windows.Forms.Label CourseIDLB;
        private System.Windows.Forms.Label SIDLB;
        private System.Windows.Forms.Label CourseDeptLB;
        private System.Windows.Forms.Label SemLB;
        private System.Windows.Forms.Label InfoLB;
        private System.Windows.Forms.TabControl SystemTabs;
        private System.Windows.Forms.TextBox Occurence;
        private System.Windows.Forms.Label OccurenceLB;
        private System.Windows.Forms.RadioButton SelectEnrollment;
        private System.Windows.Forms.GroupBox SelectCount;
        private System.Windows.Forms.RadioButton SelectDate;
        private System.Windows.Forms.RadioButton SelectStudent;
        private System.Windows.Forms.RadioButton SelectCourse;
        private System.Windows.Forms.RadioButton SelectInstructor;
        private System.Windows.Forms.GroupBox SelectCountType;
        private System.Windows.Forms.RadioButton SelectAll;
        private System.Windows.Forms.RadioButton SelectDistinct;
    }
}
