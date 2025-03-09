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
            this.SelectCountType = new System.Windows.Forms.GroupBox();
            this.SelectAll = new System.Windows.Forms.RadioButton();
            this.SelectDistinct = new System.Windows.Forms.RadioButton();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Browse = new System.Windows.Forms.Button();
            this.CourseSelect.SuspendLayout();
            this.SelectCountType.SuspendLayout();
            this.SelectCount.SuspendLayout();
            this.SystemTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseSelect
            // 
            this.CourseSelect.BackColor = System.Drawing.Color.DarkSalmon;
            this.CourseSelect.Controls.Add(this.Browse);
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
            this.CourseSelect.Location = new System.Drawing.Point(8, 38);
            this.CourseSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseSelect.Name = "CourseSelect";
            this.CourseSelect.Size = new System.Drawing.Size(1826, 1069);
            this.CourseSelect.TabIndex = 0;
            this.CourseSelect.Text = "Data Warehouse Entry";
            this.CourseSelect.Click += new System.EventHandler(this.CourseSelect_Click);
            // 
            // SelectCountType
            // 
            this.SelectCountType.Controls.Add(this.SelectAll);
            this.SelectCountType.Controls.Add(this.SelectDistinct);
            this.SelectCountType.Location = new System.Drawing.Point(568, 210);
            this.SelectCountType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectCountType.Name = "SelectCountType";
            this.SelectCountType.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectCountType.Size = new System.Drawing.Size(678, 133);
            this.SelectCountType.TabIndex = 44;
            this.SelectCountType.TabStop = false;
            this.SelectCountType.Text = "Count";
            this.SelectCountType.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // SelectAll
            // 
            this.SelectAll.AutoSize = true;
            this.SelectAll.Location = new System.Drawing.Point(386, 58);
            this.SelectAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(282, 49);
            this.SelectAll.TabIndex = 1;
            this.SelectAll.TabStop = true;
            this.SelectAll.Text = "All Occurrences";
            this.SelectAll.UseVisualStyleBackColor = true;
            // 
            // SelectDistinct
            // 
            this.SelectDistinct.AutoSize = true;
            this.SelectDistinct.Location = new System.Drawing.Point(12, 58);
            this.SelectDistinct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectDistinct.Name = "SelectDistinct";
            this.SelectDistinct.Size = new System.Drawing.Size(355, 49);
            this.SelectDistinct.TabIndex = 0;
            this.SelectDistinct.TabStop = true;
            this.SelectDistinct.Text = "Distinct Occurrences";
            this.SelectDistinct.UseVisualStyleBackColor = true;
            this.SelectDistinct.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // SelectCount
            // 
            this.SelectCount.Controls.Add(this.SelectInstructor);
            this.SelectCount.Controls.Add(this.SelectDate);
            this.SelectCount.Controls.Add(this.SelectEnrollment);
            this.SelectCount.Controls.Add(this.SelectStudent);
            this.SelectCount.Controls.Add(this.SelectCourse);
            this.SelectCount.Location = new System.Drawing.Point(568, 413);
            this.SelectCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectCount.Name = "SelectCount";
            this.SelectCount.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectCount.Size = new System.Drawing.Size(678, 198);
            this.SelectCount.TabIndex = 43;
            this.SelectCount.TabStop = false;
            this.SelectCount.Text = "Count By";
            this.SelectCount.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SelectInstructor
            // 
            this.SelectInstructor.AutoSize = true;
            this.SelectInstructor.Location = new System.Drawing.Point(352, 54);
            this.SelectInstructor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectInstructor.Name = "SelectInstructor";
            this.SelectInstructor.Size = new System.Drawing.Size(198, 49);
            this.SelectInstructor.TabIndex = 39;
            this.SelectInstructor.TabStop = true;
            this.SelectInstructor.Text = "Instructor";
            this.SelectInstructor.UseVisualStyleBackColor = true;
            this.SelectInstructor.CheckedChanged += new System.EventHandler(this.SelectInstructor_CheckedChanged);
            // 
            // SelectDate
            // 
            this.SelectDate.AutoSize = true;
            this.SelectDate.Location = new System.Drawing.Point(486, 113);
            this.SelectDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(121, 49);
            this.SelectDate.TabIndex = 42;
            this.SelectDate.TabStop = true;
            this.SelectDate.Text = "Date";
            this.SelectDate.UseVisualStyleBackColor = true;
            // 
            // SelectEnrollment
            // 
            this.SelectEnrollment.AutoSize = true;
            this.SelectEnrollment.Location = new System.Drawing.Point(114, 54);
            this.SelectEnrollment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectEnrollment.Name = "SelectEnrollment";
            this.SelectEnrollment.Size = new System.Drawing.Size(215, 49);
            this.SelectEnrollment.TabIndex = 38;
            this.SelectEnrollment.TabStop = true;
            this.SelectEnrollment.Text = "Enrollment";
            this.SelectEnrollment.UseVisualStyleBackColor = true;
            this.SelectEnrollment.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SelectStudent
            // 
            this.SelectStudent.AutoSize = true;
            this.SelectStudent.Location = new System.Drawing.Point(272, 113);
            this.SelectStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectStudent.Name = "SelectStudent";
            this.SelectStudent.Size = new System.Drawing.Size(167, 49);
            this.SelectStudent.TabIndex = 41;
            this.SelectStudent.TabStop = true;
            this.SelectStudent.Text = "Student";
            this.SelectStudent.UseVisualStyleBackColor = true;
            // 
            // SelectCourse
            // 
            this.SelectCourse.AutoSize = true;
            this.SelectCourse.Location = new System.Drawing.Point(70, 113);
            this.SelectCourse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectCourse.Name = "SelectCourse";
            this.SelectCourse.Size = new System.Drawing.Size(154, 49);
            this.SelectCourse.TabIndex = 40;
            this.SelectCourse.TabStop = true;
            this.SelectCourse.Text = "Course";
            this.SelectCourse.UseVisualStyleBackColor = true;
            // 
            // Occurence
            // 
            this.Occurence.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Occurence.Location = new System.Drawing.Point(960, 900);
            this.Occurence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Occurence.Name = "Occurence";
            this.Occurence.ReadOnly = true;
            this.Occurence.Size = new System.Drawing.Size(282, 71);
            this.Occurence.TabIndex = 37;
            // 
            // OccurenceLB
            // 
            this.OccurenceLB.AutoSize = true;
            this.OccurenceLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.OccurenceLB.Location = new System.Drawing.Point(384, 900);
            this.OccurenceLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OccurenceLB.Name = "OccurenceLB";
            this.OccurenceLB.Size = new System.Drawing.Size(573, 65);
            this.OccurenceLB.TabIndex = 36;
            this.OccurenceLB.Text = "Number of Occurrences:";
            // 
            // GradeLB
            // 
            this.GradeLB.AutoSize = true;
            this.GradeLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GradeLB.Location = new System.Drawing.Point(674, 679);
            this.GradeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GradeLB.Name = "GradeLB";
            this.GradeLB.Size = new System.Drawing.Size(119, 45);
            this.GradeLB.TabIndex = 35;
            this.GradeLB.Text = "Grade:";
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(884, 673);
            this.Grade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(222, 50);
            this.Grade.TabIndex = 34;
            this.Grade.TextChanged += new System.EventHandler(this.Grade_TextChanged);
            // 
            // InstUni
            // 
            this.InstUni.Location = new System.Drawing.Point(256, 350);
            this.InstUni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstUni.Name = "InstUni";
            this.InstUni.Size = new System.Drawing.Size(222, 50);
            this.InstUni.TabIndex = 32;
            // 
            // InstFac
            // 
            this.InstFac.Location = new System.Drawing.Point(256, 287);
            this.InstFac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstFac.Name = "InstFac";
            this.InstFac.Size = new System.Drawing.Size(222, 50);
            this.InstFac.TabIndex = 28;
            // 
            // InstID
            // 
            this.InstID.Location = new System.Drawing.Point(256, 160);
            this.InstID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstID.Name = "InstID";
            this.InstID.Size = new System.Drawing.Size(222, 50);
            this.InstID.TabIndex = 29;
            // 
            // InstRank
            // 
            this.InstRank.Location = new System.Drawing.Point(256, 223);
            this.InstRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstRank.Name = "InstRank";
            this.InstRank.Size = new System.Drawing.Size(222, 50);
            this.InstRank.TabIndex = 26;
            // 
            // Major
            // 
            this.Major.Location = new System.Drawing.Point(256, 565);
            this.Major.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(222, 50);
            this.Major.TabIndex = 24;
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(256, 635);
            this.Gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(222, 50);
            this.Gender.TabIndex = 22;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(1538, 571);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(222, 50);
            this.Year.TabIndex = 20;
            // 
            // DateID
            // 
            this.DateID.Location = new System.Drawing.Point(1538, 500);
            this.DateID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateID.Name = "DateID";
            this.DateID.Size = new System.Drawing.Size(222, 50);
            this.DateID.TabIndex = 18;
            // 
            // CourseUni
            // 
            this.CourseUni.Location = new System.Drawing.Point(1538, 342);
            this.CourseUni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseUni.Name = "CourseUni";
            this.CourseUni.Size = new System.Drawing.Size(222, 50);
            this.CourseUni.TabIndex = 16;
            // 
            // CourseFac
            // 
            this.CourseFac.Location = new System.Drawing.Point(1538, 277);
            this.CourseFac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseFac.Name = "CourseFac";
            this.CourseFac.Size = new System.Drawing.Size(222, 50);
            this.CourseFac.TabIndex = 9;
            // 
            // CourseID
            // 
            this.CourseID.Location = new System.Drawing.Point(1538, 150);
            this.CourseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(222, 50);
            this.CourseID.TabIndex = 9;
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(256, 496);
            this.SID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(222, 50);
            this.SID.TabIndex = 7;
            // 
            // CourseDept
            // 
            this.CourseDept.Location = new System.Drawing.Point(1538, 213);
            this.CourseDept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseDept.Name = "CourseDept";
            this.CourseDept.Size = new System.Drawing.Size(222, 50);
            this.CourseDept.TabIndex = 3;
            // 
            // Sem
            // 
            this.Sem.Location = new System.Drawing.Point(1538, 640);
            this.Sem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sem.Name = "Sem";
            this.Sem.Size = new System.Drawing.Size(222, 50);
            this.Sem.TabIndex = 1;
            // 
            // InstUniLB
            // 
            this.InstUniLB.AutoSize = true;
            this.InstUniLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.InstUniLB.Location = new System.Drawing.Point(82, 358);
            this.InstUniLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstUniLB.Name = "InstUniLB";
            this.InstUniLB.Size = new System.Drawing.Size(80, 45);
            this.InstUniLB.TabIndex = 33;
            this.InstUniLB.Text = "Uni:";
            this.InstUniLB.Click += new System.EventHandler(this.InstUniLB_Click);
            // 
            // InstFacLB
            // 
            this.InstFacLB.AutoSize = true;
            this.InstFacLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.InstFacLB.Location = new System.Drawing.Point(82, 292);
            this.InstFacLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstFacLB.Name = "InstFacLB";
            this.InstFacLB.Size = new System.Drawing.Size(134, 45);
            this.InstFacLB.TabIndex = 30;
            this.InstFacLB.Text = "Faculty:";
            this.InstFacLB.Click += new System.EventHandler(this.InstFacLB_Click);
            // 
            // InstIDLB
            // 
            this.InstIDLB.AutoSize = true;
            this.InstIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.InstIDLB.Location = new System.Drawing.Point(30, 165);
            this.InstIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstIDLB.Name = "InstIDLB";
            this.InstIDLB.Size = new System.Drawing.Size(219, 45);
            this.InstIDLB.TabIndex = 31;
            this.InstIDLB.Text = "Instructor ID:";
            // 
            // InstRankLB
            // 
            this.InstRankLB.AutoSize = true;
            this.InstRankLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.InstRankLB.Location = new System.Drawing.Point(82, 229);
            this.InstRankLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstRankLB.Name = "InstRankLB";
            this.InstRankLB.Size = new System.Drawing.Size(105, 45);
            this.InstRankLB.TabIndex = 27;
            this.InstRankLB.Text = "Rank:";
            // 
            // MajorLB
            // 
            this.MajorLB.AutoSize = true;
            this.MajorLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorLB.Location = new System.Drawing.Point(82, 571);
            this.MajorLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MajorLB.Name = "MajorLB";
            this.MajorLB.Size = new System.Drawing.Size(120, 45);
            this.MajorLB.TabIndex = 25;
            this.MajorLB.Text = "Major:";
            // 
            // GenderLB
            // 
            this.GenderLB.AutoSize = true;
            this.GenderLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLB.Location = new System.Drawing.Point(80, 646);
            this.GenderLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLB.Name = "GenderLB";
            this.GenderLB.Size = new System.Drawing.Size(139, 45);
            this.GenderLB.TabIndex = 23;
            this.GenderLB.Text = "Gender:";
            // 
            // YearLB
            // 
            this.YearLB.AutoSize = true;
            this.YearLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLB.Location = new System.Drawing.Point(1352, 581);
            this.YearLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLB.Name = "YearLB";
            this.YearLB.Size = new System.Drawing.Size(93, 45);
            this.YearLB.TabIndex = 21;
            this.YearLB.Text = "Year:";
            // 
            // DateIDLB
            // 
            this.DateIDLB.AutoSize = true;
            this.DateIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateIDLB.Location = new System.Drawing.Point(1352, 512);
            this.DateIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateIDLB.Name = "DateIDLB";
            this.DateIDLB.Size = new System.Drawing.Size(142, 45);
            this.DateIDLB.TabIndex = 19;
            this.DateIDLB.Text = "Date ID:";
            // 
            // CourseUniLB
            // 
            this.CourseUniLB.AutoSize = true;
            this.CourseUniLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseUniLB.Location = new System.Drawing.Point(1318, 358);
            this.CourseUniLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseUniLB.Name = "CourseUniLB";
            this.CourseUniLB.Size = new System.Drawing.Size(80, 45);
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
            this.QueryButton.Location = new System.Drawing.Point(884, 756);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(0);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(226, 60);
            this.QueryButton.TabIndex = 13;
            this.QueryButton.Text = "Query";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // CourseFacLB
            // 
            this.CourseFacLB.AutoSize = true;
            this.CourseFacLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseFacLB.Location = new System.Drawing.Point(1318, 292);
            this.CourseFacLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseFacLB.Name = "CourseFacLB";
            this.CourseFacLB.Size = new System.Drawing.Size(134, 45);
            this.CourseFacLB.TabIndex = 10;
            this.CourseFacLB.Text = "Faculty:";
            // 
            // CourseIDLB
            // 
            this.CourseIDLB.AutoSize = true;
            this.CourseIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.CourseIDLB.Location = new System.Drawing.Point(1318, 156);
            this.CourseIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseIDLB.Name = "CourseIDLB";
            this.CourseIDLB.Size = new System.Drawing.Size(175, 45);
            this.CourseIDLB.TabIndex = 10;
            this.CourseIDLB.Text = "Course ID:";
            // 
            // SIDLB
            // 
            this.SIDLB.AutoSize = true;
            this.SIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.SIDLB.Location = new System.Drawing.Point(58, 500);
            this.SIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SIDLB.Name = "SIDLB";
            this.SIDLB.Size = new System.Drawing.Size(188, 45);
            this.SIDLB.TabIndex = 8;
            this.SIDLB.Text = "Student ID:";
            // 
            // CourseDeptLB
            // 
            this.CourseDeptLB.AutoSize = true;
            this.CourseDeptLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseDeptLB.Location = new System.Drawing.Point(1318, 219);
            this.CourseDeptLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseDeptLB.Name = "CourseDeptLB";
            this.CourseDeptLB.Size = new System.Drawing.Size(210, 45);
            this.CourseDeptLB.TabIndex = 4;
            this.CourseDeptLB.Text = "Department:";
            // 
            // SemLB
            // 
            this.SemLB.AutoSize = true;
            this.SemLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemLB.Location = new System.Drawing.Point(1352, 650);
            this.SemLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SemLB.Name = "SemLB";
            this.SemLB.Size = new System.Drawing.Size(167, 45);
            this.SemLB.TabIndex = 2;
            this.SemLB.Text = "Semester:";
            // 
            // InfoLB
            // 
            this.InfoLB.AutoSize = true;
            this.InfoLB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.InfoLB.Location = new System.Drawing.Point(600, 17);
            this.InfoLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.InfoLB.Name = "InfoLB";
            this.InfoLB.Size = new System.Drawing.Size(625, 180);
            this.InfoLB.TabIndex = 15;
            this.InfoLB.Text = "Enter the relevant info based \r\nupon the search fields you wish to enter.\r\nUnderl" +
    "ined attributes are guaranteed\r\nto be unique.";
            // 
            // SystemTabs
            // 
            this.SystemTabs.Controls.Add(this.CourseSelect);
            this.SystemTabs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemTabs.ItemSize = new System.Drawing.Size(160, 30);
            this.SystemTabs.Location = new System.Drawing.Point(0, 2);
            this.SystemTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SystemTabs.Name = "SystemTabs";
            this.SystemTabs.SelectedIndex = 0;
            this.SystemTabs.Size = new System.Drawing.Size(1842, 1115);
            this.SystemTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.SystemTabs.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Browse
            // 
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Location = new System.Drawing.Point(1474, 914);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(254, 68);
            this.Browse.TabIndex = 45;
            this.Browse.Text = "Upload XML";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Registration_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1123);
            this.Controls.Add(this.SystemTabs);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Registration_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Registration System";
            this.CourseSelect.ResumeLayout(false);
            this.CourseSelect.PerformLayout();
            this.SelectCountType.ResumeLayout(false);
            this.SelectCountType.PerformLayout();
            this.SelectCount.ResumeLayout(false);
            this.SelectCount.PerformLayout();
            this.SystemTabs.ResumeLayout(false);
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
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
