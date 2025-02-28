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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SystemTabs = new System.Windows.Forms.TabControl();
            this.CourseSelect = new System.Windows.Forms.TabPage();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.QueryButton = new System.Windows.Forms.Button();
            this.LNameLB = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.TextBox();
            this.IDLB = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.SIDLB = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.TextBox();
            this.DeptLB = new System.Windows.Forms.Label();
            this.Dept = new System.Windows.Forms.TextBox();
            this.SemLB = new System.Windows.Forms.Label();
            this.Sem = new System.Windows.Forms.TextBox();
            this.CourseSearchGrid = new System.Windows.Forms.DataGridView();
            this.TimeBlock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CartAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.InfoLB = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.TabPage();
            this.CARTInfo = new System.Windows.Forms.Label();
            this.CartDataGrid = new System.Windows.Forms.DataGridView();
            this.TimeBlockCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartEnroll = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EnrollPage = new System.Windows.Forms.TabPage();
            this.ENRInfo = new System.Windows.Forms.Label();
            this.EnrollDataGrid = new System.Windows.Forms.DataGridView();
            this.TimeBlockEnroll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollUnenroll = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CourseFac = new System.Windows.Forms.TextBox();
            this.CourseFacLB = new System.Windows.Forms.Label();
            this.CourseUniLB = new System.Windows.Forms.Label();
            this.CourseUni = new System.Windows.Forms.TextBox();
            this.TimeIDLB = new System.Windows.Forms.Label();
            this.TimeID = new System.Windows.Forms.TextBox();
            this.YearLB = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.MajorLB = new System.Windows.Forms.Label();
            this.Major = new System.Windows.Forms.TextBox();
            this.GenderLB = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.TextBox();
            this.InstUniLB = new System.Windows.Forms.Label();
            this.InstUni = new System.Windows.Forms.TextBox();
            this.InstFacLB = new System.Windows.Forms.Label();
            this.InstLB = new System.Windows.Forms.Label();
            this.InstFac = new System.Windows.Forms.TextBox();
            this.Inst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.GradeLB = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.TextBox();
            this.SystemTabs.SuspendLayout();
            this.CourseSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseSearchGrid)).BeginInit();
            this.Cart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
            this.EnrollPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemTabs
            // 
            this.SystemTabs.Controls.Add(this.CourseSelect);
            this.SystemTabs.Controls.Add(this.Cart);
            this.SystemTabs.Controls.Add(this.EnrollPage);
            this.SystemTabs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemTabs.ItemSize = new System.Drawing.Size(160, 30);
            this.SystemTabs.Location = new System.Drawing.Point(0, 1);
            this.SystemTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SystemTabs.Name = "SystemTabs";
            this.SystemTabs.SelectedIndex = 0;
            this.SystemTabs.Size = new System.Drawing.Size(1180, 566);
            this.SystemTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.SystemTabs.TabIndex = 0;
            // 
            // CourseSelect
            // 
            this.CourseSelect.BackColor = System.Drawing.Color.DarkSalmon;
            this.CourseSelect.Controls.Add(this.GradeLB);
            this.CourseSelect.Controls.Add(this.Grade);
            this.CourseSelect.Controls.Add(this.InstUniLB);
            this.CourseSelect.Controls.Add(this.InstUni);
            this.CourseSelect.Controls.Add(this.InstFacLB);
            this.CourseSelect.Controls.Add(this.InstLB);
            this.CourseSelect.Controls.Add(this.InstFac);
            this.CourseSelect.Controls.Add(this.Inst);
            this.CourseSelect.Controls.Add(this.label4);
            this.CourseSelect.Controls.Add(this.textBox4);
            this.CourseSelect.Controls.Add(this.MajorLB);
            this.CourseSelect.Controls.Add(this.Major);
            this.CourseSelect.Controls.Add(this.GenderLB);
            this.CourseSelect.Controls.Add(this.Gender);
            this.CourseSelect.Controls.Add(this.YearLB);
            this.CourseSelect.Controls.Add(this.Year);
            this.CourseSelect.Controls.Add(this.TimeIDLB);
            this.CourseSelect.Controls.Add(this.TimeID);
            this.CourseSelect.Controls.Add(this.CourseUniLB);
            this.CourseSelect.Controls.Add(this.CourseUni);
            this.CourseSelect.Controls.Add(this.VerifyButton);
            this.CourseSelect.Controls.Add(this.QueryButton);
            this.CourseSelect.Controls.Add(this.LNameLB);
            this.CourseSelect.Controls.Add(this.LName);
            this.CourseSelect.Controls.Add(this.CourseFacLB);
            this.CourseSelect.Controls.Add(this.IDLB);
            this.CourseSelect.Controls.Add(this.CourseFac);
            this.CourseSelect.Controls.Add(this.ID);
            this.CourseSelect.Controls.Add(this.SIDLB);
            this.CourseSelect.Controls.Add(this.SID);
            this.CourseSelect.Controls.Add(this.DeptLB);
            this.CourseSelect.Controls.Add(this.Dept);
            this.CourseSelect.Controls.Add(this.SemLB);
            this.CourseSelect.Controls.Add(this.Sem);
            this.CourseSelect.Controls.Add(this.CourseSearchGrid);
            this.CourseSelect.Controls.Add(this.InfoLB);
            this.CourseSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseSelect.Location = new System.Drawing.Point(4, 34);
            this.CourseSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseSelect.Name = "CourseSelect";
            this.CourseSelect.Size = new System.Drawing.Size(1172, 528);
            this.CourseSelect.TabIndex = 0;
            this.CourseSelect.Text = " Select Course    ";
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.Teal;
            this.VerifyButton.FlatAppearance.BorderSize = 0;
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.ForeColor = System.Drawing.Color.MintCream;
            this.VerifyButton.Location = new System.Drawing.Point(550, 133);
            this.VerifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(151, 39);
            this.VerifyButton.TabIndex = 14;
            this.VerifyButton.Text = "Verify ID";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Visible = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // QueryButton
            // 
            this.QueryButton.BackColor = System.Drawing.Color.GreenYellow;
            this.QueryButton.FlatAppearance.BorderSize = 0;
            this.QueryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton.ForeColor = System.Drawing.Color.Teal;
            this.QueryButton.Location = new System.Drawing.Point(550, 192);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(0);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(151, 38);
            this.QueryButton.TabIndex = 13;
            this.QueryButton.Text = "Query";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // LNameLB
            // 
            this.LNameLB.AutoSize = true;
            this.LNameLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LNameLB.Location = new System.Drawing.Point(418, 99);
            this.LNameLB.Name = "LNameLB";
            this.LNameLB.Size = new System.Drawing.Size(117, 28);
            this.LNameLB.TabIndex = 12;
            this.LNameLB.Text = "Last Name:";
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(550, 93);
            this.LName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            this.LName.Size = new System.Drawing.Size(149, 34);
            this.LName.TabIndex = 11;
            // 
            // IDLB
            // 
            this.IDLB.AutoSize = true;
            this.IDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.IDLB.Location = new System.Drawing.Point(859, 13);
            this.IDLB.Name = "IDLB";
            this.IDLB.Size = new System.Drawing.Size(108, 28);
            this.IDLB.TabIndex = 10;
            this.IDLB.Text = "Course ID:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(981, 7);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(149, 34);
            this.ID.TabIndex = 9;
            // 
            // SIDLB
            // 
            this.SIDLB.AutoSize = true;
            this.SIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.SIDLB.Location = new System.Drawing.Point(17, 217);
            this.SIDLB.Name = "SIDLB";
            this.SIDLB.Size = new System.Drawing.Size(118, 28);
            this.SIDLB.TabIndex = 8;
            this.SIDLB.Text = "Student ID:";
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(149, 214);
            this.SID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Size = new System.Drawing.Size(149, 34);
            this.SID.TabIndex = 7;
            // 
            // DeptLB
            // 
            this.DeptLB.AutoSize = true;
            this.DeptLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeptLB.Location = new System.Drawing.Point(832, 73);
            this.DeptLB.Name = "DeptLB";
            this.DeptLB.Size = new System.Drawing.Size(132, 28);
            this.DeptLB.TabIndex = 4;
            this.DeptLB.Text = "Department:";
            // 
            // Dept
            // 
            this.Dept.Location = new System.Drawing.Point(979, 69);
            this.Dept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(149, 34);
            this.Dept.TabIndex = 3;
            // 
            // SemLB
            // 
            this.SemLB.AutoSize = true;
            this.SemLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemLB.Location = new System.Drawing.Point(860, 309);
            this.SemLB.Name = "SemLB";
            this.SemLB.Size = new System.Drawing.Size(105, 28);
            this.SemLB.TabIndex = 2;
            this.SemLB.Text = "Semester:";
            // 
            // Sem
            // 
            this.Sem.Location = new System.Drawing.Point(979, 306);
            this.Sem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sem.Name = "Sem";
            this.Sem.ReadOnly = true;
            this.Sem.Size = new System.Drawing.Size(149, 34);
            this.Sem.TabIndex = 1;
            // 
            // CourseSearchGrid
            // 
            this.CourseSearchGrid.AllowUserToAddRows = false;
            this.CourseSearchGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseSearchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.CourseSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeBlock,
            this.Col_CID,
            this.Col_Title,
            this.Col_SecID,
            this.Col_Sem,
            this.Col_CartAdd});
            this.CourseSearchGrid.Location = new System.Drawing.Point(57, 358);
            this.CourseSearchGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseSearchGrid.Name = "CourseSearchGrid";
            this.CourseSearchGrid.RowHeadersWidth = 51;
            this.CourseSearchGrid.RowTemplate.Height = 24;
            this.CourseSearchGrid.Size = new System.Drawing.Size(1045, 159);
            this.CourseSearchGrid.TabIndex = 0;
            this.CourseSearchGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseSearchGrid_CellContentClick);
            // 
            // TimeBlock
            // 
            this.TimeBlock.HeaderText = "Time Block";
            this.TimeBlock.MinimumWidth = 6;
            this.TimeBlock.Name = "TimeBlock";
            this.TimeBlock.Width = 75;
            // 
            // Col_CID
            // 
            this.Col_CID.HeaderText = "Course ID";
            this.Col_CID.MinimumWidth = 6;
            this.Col_CID.Name = "Col_CID";
            this.Col_CID.ReadOnly = true;
            this.Col_CID.Width = 125;
            // 
            // Col_Title
            // 
            this.Col_Title.HeaderText = "Course Title";
            this.Col_Title.MinimumWidth = 6;
            this.Col_Title.Name = "Col_Title";
            this.Col_Title.ReadOnly = true;
            this.Col_Title.Width = 225;
            // 
            // Col_SecID
            // 
            this.Col_SecID.HeaderText = "Section ID";
            this.Col_SecID.MinimumWidth = 6;
            this.Col_SecID.Name = "Col_SecID";
            this.Col_SecID.ReadOnly = true;
            this.Col_SecID.Width = 75;
            // 
            // Col_Sem
            // 
            this.Col_Sem.HeaderText = "Semester";
            this.Col_Sem.MinimumWidth = 6;
            this.Col_Sem.Name = "Col_Sem";
            this.Col_Sem.ReadOnly = true;
            this.Col_Sem.Width = 125;
            // 
            // Col_CartAdd
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Col_CartAdd.DefaultCellStyle = dataGridViewCellStyle18;
            this.Col_CartAdd.HeaderText = "Add To Cart";
            this.Col_CartAdd.MinimumWidth = 6;
            this.Col_CartAdd.Name = "Col_CartAdd";
            this.Col_CartAdd.ReadOnly = true;
            this.Col_CartAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_CartAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col_CartAdd.Text = "Add";
            this.Col_CartAdd.UseColumnTextForButtonValue = true;
            this.Col_CartAdd.Width = 125;
            // 
            // InfoLB
            // 
            this.InfoLB.AutoSize = true;
            this.InfoLB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.InfoLB.Location = new System.Drawing.Point(409, 20);
            this.InfoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLB.Name = "InfoLB";
            this.InfoLB.Size = new System.Drawing.Size(322, 56);
            this.InfoLB.TabIndex = 15;
            this.InfoLB.Text = "Enter the relevant info based \r\nupon the search fields you enter.";
            // 
            // Cart
            // 
            this.Cart.BackColor = System.Drawing.Color.DarkSalmon;
            this.Cart.Controls.Add(this.CARTInfo);
            this.Cart.Controls.Add(this.CartDataGrid);
            this.Cart.Location = new System.Drawing.Point(4, 34);
            this.Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cart.Name = "Cart";
            this.Cart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cart.Size = new System.Drawing.Size(1172, 528);
            this.Cart.TabIndex = 1;
            this.Cart.Text = "User Cart";
            // 
            // CARTInfo
            // 
            this.CARTInfo.AutoSize = true;
            this.CARTInfo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CARTInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CARTInfo.Location = new System.Drawing.Point(244, 12);
            this.CARTInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CARTInfo.Name = "CARTInfo";
            this.CARTInfo.Size = new System.Drawing.Size(513, 56);
            this.CARTInfo.TabIndex = 17;
            this.CARTInfo.Text = "This page contains information on all of the courses \r\nyou\'ve added to your cart " +
    "this semester.\r\n";
            // 
            // CartDataGrid
            // 
            this.CartDataGrid.AllowUserToAddRows = false;
            this.CartDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.CartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeBlockCart,
            this.CartCID,
            this.CartTitle,
            this.CartSID,
            this.CartSem,
            this.CartEnroll,
            this.CartDelete});
            this.CartDataGrid.Location = new System.Drawing.Point(77, 172);
            this.CartDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CartDataGrid.Name = "CartDataGrid";
            this.CartDataGrid.RowHeadersWidth = 51;
            this.CartDataGrid.RowTemplate.Height = 24;
            this.CartDataGrid.Size = new System.Drawing.Size(1024, 318);
            this.CartDataGrid.TabIndex = 16;
            this.CartDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGrid_CellContentClick);
            // 
            // TimeBlockCart
            // 
            this.TimeBlockCart.HeaderText = "Time Block";
            this.TimeBlockCart.MinimumWidth = 6;
            this.TimeBlockCart.Name = "TimeBlockCart";
            this.TimeBlockCart.Width = 75;
            // 
            // CartCID
            // 
            this.CartCID.HeaderText = "Course ID";
            this.CartCID.MinimumWidth = 6;
            this.CartCID.Name = "CartCID";
            this.CartCID.ReadOnly = true;
            this.CartCID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CartCID.Width = 125;
            // 
            // CartTitle
            // 
            this.CartTitle.HeaderText = "Course Title";
            this.CartTitle.MinimumWidth = 6;
            this.CartTitle.Name = "CartTitle";
            this.CartTitle.ReadOnly = true;
            this.CartTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CartTitle.Width = 215;
            // 
            // CartSID
            // 
            this.CartSID.HeaderText = "Section ID";
            this.CartSID.MinimumWidth = 6;
            this.CartSID.Name = "CartSID";
            this.CartSID.ReadOnly = true;
            this.CartSID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CartSID.Width = 75;
            // 
            // CartSem
            // 
            this.CartSem.HeaderText = "Semester";
            this.CartSem.MinimumWidth = 6;
            this.CartSem.Name = "CartSem";
            this.CartSem.ReadOnly = true;
            this.CartSem.Width = 90;
            // 
            // CartEnroll
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Info;
            this.CartEnroll.DefaultCellStyle = dataGridViewCellStyle20;
            this.CartEnroll.HeaderText = "Enroll";
            this.CartEnroll.MinimumWidth = 6;
            this.CartEnroll.Name = "CartEnroll";
            this.CartEnroll.ReadOnly = true;
            this.CartEnroll.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CartEnroll.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CartEnroll.Text = "Enroll";
            this.CartEnroll.UseColumnTextForButtonValue = true;
            this.CartEnroll.Width = 80;
            // 
            // CartDelete
            // 
            this.CartDelete.HeaderText = "Delete";
            this.CartDelete.MinimumWidth = 6;
            this.CartDelete.Name = "CartDelete";
            this.CartDelete.ReadOnly = true;
            this.CartDelete.Text = "Delete";
            this.CartDelete.UseColumnTextForButtonValue = true;
            this.CartDelete.Width = 80;
            // 
            // EnrollPage
            // 
            this.EnrollPage.BackColor = System.Drawing.Color.DarkSalmon;
            this.EnrollPage.Controls.Add(this.ENRInfo);
            this.EnrollPage.Controls.Add(this.EnrollDataGrid);
            this.EnrollPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnrollPage.Location = new System.Drawing.Point(4, 34);
            this.EnrollPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnrollPage.Name = "EnrollPage";
            this.EnrollPage.Size = new System.Drawing.Size(1172, 528);
            this.EnrollPage.TabIndex = 2;
            this.EnrollPage.Text = "Enrollment Page";
            // 
            // ENRInfo
            // 
            this.ENRInfo.AutoSize = true;
            this.ENRInfo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ENRInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ENRInfo.Location = new System.Drawing.Point(113, 11);
            this.ENRInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ENRInfo.Name = "ENRInfo";
            this.ENRInfo.Size = new System.Drawing.Size(818, 28);
            this.ENRInfo.TabIndex = 2;
            this.ENRInfo.Text = "This page contains information on all of the courses you\'ve enrolled in this seme" +
    "ster.";
            // 
            // EnrollDataGrid
            // 
            this.EnrollDataGrid.AllowUserToAddRows = false;
            this.EnrollDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EnrollDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.EnrollDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeBlockEnroll,
            this.EnrollCID,
            this.EnrollTitle,
            this.EnrollSID,
            this.EnrollSem,
            this.EnrollUnenroll});
            this.EnrollDataGrid.Location = new System.Drawing.Point(0, 231);
            this.EnrollDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnrollDataGrid.Name = "EnrollDataGrid";
            this.EnrollDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.EnrollDataGrid.RowTemplate.Height = 24;
            this.EnrollDataGrid.Size = new System.Drawing.Size(1175, 286);
            this.EnrollDataGrid.TabIndex = 1;
            this.EnrollDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnrollDataGrid_CellContentClick);
            // 
            // TimeBlockEnroll
            // 
            this.TimeBlockEnroll.HeaderText = "Time Block";
            this.TimeBlockEnroll.MinimumWidth = 6;
            this.TimeBlockEnroll.Name = "TimeBlockEnroll";
            this.TimeBlockEnroll.Width = 125;
            // 
            // EnrollCID
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollCID.DefaultCellStyle = dataGridViewCellStyle22;
            this.EnrollCID.HeaderText = "Course ID";
            this.EnrollCID.MinimumWidth = 6;
            this.EnrollCID.Name = "EnrollCID";
            this.EnrollCID.Width = 125;
            // 
            // EnrollTitle
            // 
            this.EnrollTitle.HeaderText = "Course Title";
            this.EnrollTitle.MinimumWidth = 6;
            this.EnrollTitle.Name = "EnrollTitle";
            this.EnrollTitle.Width = 215;
            // 
            // EnrollSID
            // 
            this.EnrollSID.HeaderText = "Section ID";
            this.EnrollSID.MinimumWidth = 6;
            this.EnrollSID.Name = "EnrollSID";
            this.EnrollSID.Width = 125;
            // 
            // EnrollSem
            // 
            this.EnrollSem.HeaderText = "Semester";
            this.EnrollSem.MinimumWidth = 6;
            this.EnrollSem.Name = "EnrollSem";
            this.EnrollSem.Width = 135;
            // 
            // EnrollUnenroll
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Info;
            this.EnrollUnenroll.DefaultCellStyle = dataGridViewCellStyle23;
            this.EnrollUnenroll.HeaderText = "Unenroll";
            this.EnrollUnenroll.MinimumWidth = 6;
            this.EnrollUnenroll.Name = "EnrollUnenroll";
            this.EnrollUnenroll.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EnrollUnenroll.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EnrollUnenroll.Text = "Unenroll";
            this.EnrollUnenroll.UseColumnTextForButtonValue = true;
            this.EnrollUnenroll.Width = 125;
            // 
            // CourseFac
            // 
            this.CourseFac.Location = new System.Drawing.Point(979, 107);
            this.CourseFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseFac.Name = "CourseFac";
            this.CourseFac.Size = new System.Drawing.Size(149, 34);
            this.CourseFac.TabIndex = 9;
            // 
            // CourseFacLB
            // 
            this.CourseFacLB.AutoSize = true;
            this.CourseFacLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseFacLB.Location = new System.Drawing.Point(857, 113);
            this.CourseFacLB.Name = "CourseFacLB";
            this.CourseFacLB.Size = new System.Drawing.Size(84, 28);
            this.CourseFacLB.TabIndex = 10;
            this.CourseFacLB.Text = "Faculty:";
            // 
            // CourseUniLB
            // 
            this.CourseUniLB.AutoSize = true;
            this.CourseUniLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseUniLB.Location = new System.Drawing.Point(857, 151);
            this.CourseUniLB.Name = "CourseUniLB";
            this.CourseUniLB.Size = new System.Drawing.Size(49, 28);
            this.CourseUniLB.TabIndex = 17;
            this.CourseUniLB.Text = "Uni:";
            // 
            // CourseUni
            // 
            this.CourseUni.Location = new System.Drawing.Point(979, 145);
            this.CourseUni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseUni.Name = "CourseUni";
            this.CourseUni.Size = new System.Drawing.Size(149, 34);
            this.CourseUni.TabIndex = 16;
            // 
            // TimeIDLB
            // 
            this.TimeIDLB.AutoSize = true;
            this.TimeIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIDLB.Location = new System.Drawing.Point(860, 208);
            this.TimeIDLB.Name = "TimeIDLB";
            this.TimeIDLB.Size = new System.Drawing.Size(91, 28);
            this.TimeIDLB.TabIndex = 19;
            this.TimeIDLB.Text = "Time ID:";
            // 
            // TimeID
            // 
            this.TimeID.Location = new System.Drawing.Point(979, 205);
            this.TimeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeID.Name = "TimeID";
            this.TimeID.ReadOnly = true;
            this.TimeID.Size = new System.Drawing.Size(149, 34);
            this.TimeID.TabIndex = 18;
            // 
            // YearLB
            // 
            this.YearLB.AutoSize = true;
            this.YearLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLB.Location = new System.Drawing.Point(860, 271);
            this.YearLB.Name = "YearLB";
            this.YearLB.Size = new System.Drawing.Size(58, 28);
            this.YearLB.TabIndex = 21;
            this.YearLB.Text = "Year:";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(979, 268);
            this.Year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Size = new System.Drawing.Size(149, 34);
            this.Year.TabIndex = 20;
            // 
            // MajorLB
            // 
            this.MajorLB.AutoSize = true;
            this.MajorLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorLB.Location = new System.Drawing.Point(30, 274);
            this.MajorLB.Name = "MajorLB";
            this.MajorLB.Size = new System.Drawing.Size(74, 28);
            this.MajorLB.TabIndex = 25;
            this.MajorLB.Text = "Major:";
            // 
            // Major
            // 
            this.Major.Location = new System.Drawing.Point(149, 271);
            this.Major.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            this.Major.Size = new System.Drawing.Size(149, 34);
            this.Major.TabIndex = 24;
            // 
            // GenderLB
            // 
            this.GenderLB.AutoSize = true;
            this.GenderLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLB.Location = new System.Drawing.Point(30, 312);
            this.GenderLB.Name = "GenderLB";
            this.GenderLB.Size = new System.Drawing.Size(86, 28);
            this.GenderLB.TabIndex = 23;
            this.GenderLB.Text = "Gender:";
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(149, 309);
            this.Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Size = new System.Drawing.Size(149, 34);
            this.Gender.TabIndex = 22;
            // 
            // InstUniLB
            // 
            this.InstUniLB.AutoSize = true;
            this.InstUniLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.InstUniLB.Location = new System.Drawing.Point(27, 155);
            this.InstUniLB.Name = "InstUniLB";
            this.InstUniLB.Size = new System.Drawing.Size(49, 28);
            this.InstUniLB.TabIndex = 33;
            this.InstUniLB.Text = "Uni:";
            // 
            // InstUni
            // 
            this.InstUni.Location = new System.Drawing.Point(149, 149);
            this.InstUni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstUni.Name = "InstUni";
            this.InstUni.Size = new System.Drawing.Size(149, 34);
            this.InstUni.TabIndex = 32;
            // 
            // InstFacLB
            // 
            this.InstFacLB.AutoSize = true;
            this.InstFacLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.InstFacLB.Location = new System.Drawing.Point(27, 117);
            this.InstFacLB.Name = "InstFacLB";
            this.InstFacLB.Size = new System.Drawing.Size(84, 28);
            this.InstFacLB.TabIndex = 30;
            this.InstFacLB.Text = "Faculty:";
            // 
            // InstLB
            // 
            this.InstLB.AutoSize = true;
            this.InstLB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.InstLB.Location = new System.Drawing.Point(-1, 17);
            this.InstLB.Name = "InstLB";
            this.InstLB.Size = new System.Drawing.Size(137, 28);
            this.InstLB.TabIndex = 31;
            this.InstLB.Text = "Instructor ID:";
            // 
            // InstFac
            // 
            this.InstFac.Location = new System.Drawing.Point(149, 111);
            this.InstFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstFac.Name = "InstFac";
            this.InstFac.Size = new System.Drawing.Size(149, 34);
            this.InstFac.TabIndex = 28;
            // 
            // Inst
            // 
            this.Inst.Location = new System.Drawing.Point(151, 11);
            this.Inst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Inst.Name = "Inst";
            this.Inst.Size = new System.Drawing.Size(149, 34);
            this.Inst.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(2, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Department:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 73);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 34);
            this.textBox4.TabIndex = 26;
            // 
            // GradeLB
            // 
            this.GradeLB.AutoSize = true;
            this.GradeLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GradeLB.Location = new System.Drawing.Point(418, 296);
            this.GradeLB.Name = "GradeLB";
            this.GradeLB.Size = new System.Drawing.Size(73, 28);
            this.GradeLB.TabIndex = 35;
            this.GradeLB.Text = "Grade:";
            // 
            // Grade
            // 
            this.Grade.Location = new System.Drawing.Point(550, 290);
            this.Grade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Size = new System.Drawing.Size(149, 34);
            this.Grade.TabIndex = 34;
            // 
            // Registration_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.SystemTabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Registration System";
            this.SystemTabs.ResumeLayout(false);
            this.CourseSelect.ResumeLayout(false);
            this.CourseSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseSearchGrid)).EndInit();
            this.Cart.ResumeLayout(false);
            this.Cart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).EndInit();
            this.EnrollPage.ResumeLayout(false);
            this.EnrollPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage CourseSelect;
        private System.Windows.Forms.TabPage Cart;
        private System.Windows.Forms.DataGridView CourseSearchGrid;
        private System.Windows.Forms.TabPage EnrollPage;
        private System.Windows.Forms.Label SemLB;
        private System.Windows.Forms.TextBox Sem;
        private System.Windows.Forms.Label DeptLB;
        private System.Windows.Forms.TextBox Dept;
        private System.Windows.Forms.Label SIDLB;
        private System.Windows.Forms.TabControl SystemTabs;
        private System.Windows.Forms.Label LNameLB;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.Label IDLB;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.Label InfoLB;
        private System.Windows.Forms.DataGridView CartDataGrid;
        private System.Windows.Forms.DataGridView EnrollDataGrid;
        private System.Windows.Forms.Label ENRInfo;
        private System.Windows.Forms.Label CARTInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlockEnroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollSem;
        private System.Windows.Forms.DataGridViewButtonColumn EnrollUnenroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Sem;
        private System.Windows.Forms.DataGridViewButtonColumn Col_CartAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlockCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartSem;
        private System.Windows.Forms.DataGridViewButtonColumn CartEnroll;
        private System.Windows.Forms.DataGridViewButtonColumn CartDelete;
        private System.Windows.Forms.TextBox SID;
        private System.Windows.Forms.Label CourseFacLB;
        private System.Windows.Forms.TextBox CourseFac;
        private System.Windows.Forms.Label CourseUniLB;
        private System.Windows.Forms.TextBox CourseUni;
        private System.Windows.Forms.Label MajorLB;
        private System.Windows.Forms.TextBox Major;
        private System.Windows.Forms.Label GenderLB;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.Label YearLB;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label TimeIDLB;
        private System.Windows.Forms.TextBox TimeID;
        private System.Windows.Forms.Label InstUniLB;
        private System.Windows.Forms.TextBox InstUni;
        private System.Windows.Forms.Label InstFacLB;
        private System.Windows.Forms.Label InstLB;
        private System.Windows.Forms.TextBox InstFac;
        private System.Windows.Forms.TextBox Inst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label GradeLB;
        private System.Windows.Forms.TextBox Grade;
    }
}
