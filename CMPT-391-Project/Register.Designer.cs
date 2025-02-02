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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SystemTabs = new System.Windows.Forms.TabControl();
            this.CourseSelect = new System.Windows.Forms.TabPage();
            this.InfoLB = new System.Windows.Forms.Label();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.QueryButton = new System.Windows.Forms.Button();
            this.PassLB = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.IDLB = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.SIDLB = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.TextBox();
            this.DeptLB = new System.Windows.Forms.Label();
            this.Dept = new System.Windows.Forms.TextBox();
            this.SemLB = new System.Windows.Forms.Label();
            this.Sem = new System.Windows.Forms.TextBox();
            this.CourseSearchGrid = new System.Windows.Forms.DataGridView();
            this.Cart = new System.Windows.Forms.TabPage();
            this.RefreshLB = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.EnrollPage = new System.Windows.Forms.TabPage();
            this.CartDataGrid = new System.Windows.Forms.DataGridView();
            this.Col_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CartAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EnrollDataGrid = new System.Windows.Forms.DataGridView();
            this.EnrollDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollUnenroll = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartEnroll = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SystemTabs.SuspendLayout();
            this.CourseSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseSearchGrid)).BeginInit();
            this.Cart.SuspendLayout();
            this.EnrollPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
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
            this.SystemTabs.Margin = new System.Windows.Forms.Padding(2);
            this.SystemTabs.Name = "SystemTabs";
            this.SystemTabs.SelectedIndex = 0;
            this.SystemTabs.Size = new System.Drawing.Size(791, 440);
            this.SystemTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.SystemTabs.TabIndex = 0;
            // 
            // CourseSelect
            // 
            this.CourseSelect.BackColor = System.Drawing.Color.DarkSalmon;
            this.CourseSelect.Controls.Add(this.InfoLB);
            this.CourseSelect.Controls.Add(this.VerifyButton);
            this.CourseSelect.Controls.Add(this.QueryButton);
            this.CourseSelect.Controls.Add(this.PassLB);
            this.CourseSelect.Controls.Add(this.Pass);
            this.CourseSelect.Controls.Add(this.IDLB);
            this.CourseSelect.Controls.Add(this.ID);
            this.CourseSelect.Controls.Add(this.SIDLB);
            this.CourseSelect.Controls.Add(this.SID);
            this.CourseSelect.Controls.Add(this.DeptLB);
            this.CourseSelect.Controls.Add(this.Dept);
            this.CourseSelect.Controls.Add(this.SemLB);
            this.CourseSelect.Controls.Add(this.Sem);
            this.CourseSelect.Controls.Add(this.CourseSearchGrid);
            this.CourseSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CourseSelect.Location = new System.Drawing.Point(4, 34);
            this.CourseSelect.Margin = new System.Windows.Forms.Padding(2);
            this.CourseSelect.Name = "CourseSelect";
            this.CourseSelect.Size = new System.Drawing.Size(783, 402);
            this.CourseSelect.TabIndex = 0;
            this.CourseSelect.Text = "Course Selection";
            // 
            // InfoLB
            // 
            this.InfoLB.AutoSize = true;
            this.InfoLB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.InfoLB.Location = new System.Drawing.Point(265, 9);
            this.InfoLB.Name = "InfoLB";
            this.InfoLB.Size = new System.Drawing.Size(505, 84);
            this.InfoLB.TabIndex = 15;
            this.InfoLB.Text = "Enter your student id and password to be able to select available \r\ncourses, base" +
    "d upon the search fields you enter.\r\n\r\n\r\n";
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.Teal;
            this.VerifyButton.FlatAppearance.BorderSize = 0;
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.ForeColor = System.Drawing.Color.MintCream;
            this.VerifyButton.Location = new System.Drawing.Point(622, 150);
            this.VerifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(113, 32);
            this.VerifyButton.TabIndex = 14;
            this.VerifyButton.Text = "Verify ID";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // QueryButton
            // 
            this.QueryButton.BackColor = System.Drawing.Color.GreenYellow;
            this.QueryButton.FlatAppearance.BorderSize = 0;
            this.QueryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton.ForeColor = System.Drawing.Color.Teal;
            this.QueryButton.Location = new System.Drawing.Point(122, 150);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(0);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(113, 31);
            this.QueryButton.TabIndex = 13;
            this.QueryButton.Text = "Query";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // PassLB
            // 
            this.PassLB.AutoSize = true;
            this.PassLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PassLB.Location = new System.Drawing.Point(359, 156);
            this.PassLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassLB.Name = "PassLB";
            this.PassLB.Size = new System.Drawing.Size(86, 21);
            this.PassLB.TabIndex = 12;
            this.PassLB.Text = "Password:";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(458, 153);
            this.Pass.Margin = new System.Windows.Forms.Padding(2);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(113, 29);
            this.Pass.TabIndex = 11;
            // 
            // IDLB
            // 
            this.IDLB.AutoSize = true;
            this.IDLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.IDLB.Location = new System.Drawing.Point(31, 67);
            this.IDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLB.Name = "IDLB";
            this.IDLB.Size = new System.Drawing.Size(87, 21);
            this.IDLB.TabIndex = 10;
            this.IDLB.Text = "Course ID:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(122, 62);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(113, 29);
            this.ID.TabIndex = 9;
            // 
            // SIDLB
            // 
            this.SIDLB.AutoSize = true;
            this.SIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SIDLB.Location = new System.Drawing.Point(359, 114);
            this.SIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SIDLB.Name = "SIDLB";
            this.SIDLB.Size = new System.Drawing.Size(95, 21);
            this.SIDLB.TabIndex = 8;
            this.SIDLB.Text = "Student ID:";
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(458, 111);
            this.SID.Margin = new System.Windows.Forms.Padding(2);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(113, 29);
            this.SID.TabIndex = 7;
            // 
            // DeptLB
            // 
            this.DeptLB.AutoSize = true;
            this.DeptLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeptLB.Location = new System.Drawing.Point(12, 13);
            this.DeptLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeptLB.Name = "DeptLB";
            this.DeptLB.Size = new System.Drawing.Size(106, 21);
            this.DeptLB.TabIndex = 4;
            this.DeptLB.Text = "Department:";
            // 
            // Dept
            // 
            this.Dept.Location = new System.Drawing.Point(122, 13);
            this.Dept.Margin = new System.Windows.Forms.Padding(2);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(113, 29);
            this.Dept.TabIndex = 3;
            // 
            // SemLB
            // 
            this.SemLB.AutoSize = true;
            this.SemLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemLB.Location = new System.Drawing.Point(33, 119);
            this.SemLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SemLB.Name = "SemLB";
            this.SemLB.Size = new System.Drawing.Size(85, 21);
            this.SemLB.TabIndex = 2;
            this.SemLB.Text = "Semester:";
            // 
            // Sem
            // 
            this.Sem.Location = new System.Drawing.Point(122, 116);
            this.Sem.Margin = new System.Windows.Forms.Padding(2);
            this.Sem.Name = "Sem";
            this.Sem.Size = new System.Drawing.Size(113, 29);
            this.Sem.TabIndex = 1;
            // 
            // CourseSearchGrid
            // 
            this.CourseSearchGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseSearchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CourseSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Dept,
            this.Col_CID,
            this.Col_Title,
            this.Col_SecID,
            this.Col_Sem,
            this.Col_CartAdd});
            this.CourseSearchGrid.Location = new System.Drawing.Point(2, 189);
            this.CourseSearchGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CourseSearchGrid.Name = "CourseSearchGrid";
            this.CourseSearchGrid.RowHeadersWidth = 51;
            this.CourseSearchGrid.RowTemplate.Height = 24;
            this.CourseSearchGrid.Size = new System.Drawing.Size(779, 211);
            this.CourseSearchGrid.TabIndex = 0;
            this.CourseSearchGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseSearchGrid_CellContentClick);
            // 
            // Cart
            // 
            this.Cart.BackColor = System.Drawing.Color.DarkSalmon;
            this.Cart.Controls.Add(this.CartDataGrid);
            this.Cart.Controls.Add(this.RefreshLB);
            this.Cart.Controls.Add(this.RefreshButton);
            this.Cart.Location = new System.Drawing.Point(4, 34);
            this.Cart.Margin = new System.Windows.Forms.Padding(2);
            this.Cart.Name = "Cart";
            this.Cart.Padding = new System.Windows.Forms.Padding(2);
            this.Cart.Size = new System.Drawing.Size(783, 402);
            this.Cart.TabIndex = 1;
            this.Cart.Text = "User Cart";
            // 
            // RefreshLB
            // 
            this.RefreshLB.AutoSize = true;
            this.RefreshLB.Location = new System.Drawing.Point(280, 29);
            this.RefreshLB.Name = "RefreshLB";
            this.RefreshLB.Size = new System.Drawing.Size(262, 42);
            this.RefreshLB.TabIndex = 15;
            this.RefreshLB.Text = "Click the refresh button to update \r\nthe course availability\r\n";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.GreenYellow;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.Teal;
            this.RefreshButton.Location = new System.Drawing.Point(583, 40);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(113, 31);
            this.RefreshButton.TabIndex = 14;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // EnrollPage
            // 
            this.EnrollPage.BackColor = System.Drawing.Color.DarkSalmon;
            this.EnrollPage.Controls.Add(this.EnrollDataGrid);
            this.EnrollPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnrollPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollPage.Location = new System.Drawing.Point(4, 34);
            this.EnrollPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnrollPage.Name = "EnrollPage";
            this.EnrollPage.Size = new System.Drawing.Size(783, 402);
            this.EnrollPage.TabIndex = 2;
            this.EnrollPage.Text = "Enrollment Page";
            // 
            // CartDataGrid
            // 
            this.CartDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartDept,
            this.CartCID,
            this.CartTitle,
            this.CartSID,
            this.CartSem,
            this.CartEnroll,
            this.CartDelete});
            this.CartDataGrid.Location = new System.Drawing.Point(2, 189);
            this.CartDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CartDataGrid.Name = "CartDataGrid";
            this.CartDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CartDataGrid.RowTemplate.Height = 24;
            this.CartDataGrid.Size = new System.Drawing.Size(779, 211);
            this.CartDataGrid.TabIndex = 16;
            this.CartDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGrid_CellContentClick);
            // 
            // Col_Dept
            // 
            this.Col_Dept.HeaderText = "Course Department";
            this.Col_Dept.Name = "Col_Dept";
            this.Col_Dept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Dept.Width = 110;
            // 
            // Col_CID
            // 
            this.Col_CID.HeaderText = "Course ID";
            this.Col_CID.MinimumWidth = 6;
            this.Col_CID.Name = "Col_CID";
            this.Col_CID.Width = 115;
            // 
            // Col_Title
            // 
            this.Col_Title.HeaderText = "Course Title";
            this.Col_Title.MinimumWidth = 6;
            this.Col_Title.Name = "Col_Title";
            this.Col_Title.Width = 125;
            // 
            // Col_SecID
            // 
            this.Col_SecID.HeaderText = "Section ID";
            this.Col_SecID.MinimumWidth = 6;
            this.Col_SecID.Name = "Col_SecID";
            this.Col_SecID.Width = 125;
            // 
            // Col_Sem
            // 
            this.Col_Sem.HeaderText = "Semester";
            this.Col_Sem.Name = "Col_Sem";
            this.Col_Sem.Width = 125;
            // 
            // Col_CartAdd
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            this.Col_CartAdd.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col_CartAdd.HeaderText = "Add To Cart";
            this.Col_CartAdd.MinimumWidth = 6;
            this.Col_CartAdd.Name = "Col_CartAdd";
            this.Col_CartAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_CartAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col_CartAdd.Text = "Add";
            this.Col_CartAdd.UseColumnTextForButtonValue = true;
            this.Col_CartAdd.Width = 125;
            // 
            // EnrollDataGrid
            // 
            this.EnrollDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EnrollDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.EnrollDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnrollDept,
            this.EnrollCID,
            this.EnrollTitle,
            this.EnrollSID,
            this.EnrollSem,
            this.EnrollUnenroll});
            this.EnrollDataGrid.Location = new System.Drawing.Point(2, 191);
            this.EnrollDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.EnrollDataGrid.Name = "EnrollDataGrid";
            this.EnrollDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.EnrollDataGrid.RowTemplate.Height = 24;
            this.EnrollDataGrid.Size = new System.Drawing.Size(779, 211);
            this.EnrollDataGrid.TabIndex = 1;
            this.EnrollDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnrollDataGrid_CellContentClick);
            // 
            // EnrollDept
            // 
            this.EnrollDept.HeaderText = "Course Depa";
            this.EnrollDept.Name = "EnrollDept";
            this.EnrollDept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EnrollDept.Width = 110;
            // 
            // EnrollCID
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollCID.DefaultCellStyle = dataGridViewCellStyle7;
            this.EnrollCID.HeaderText = "Course ID";
            this.EnrollCID.MinimumWidth = 6;
            this.EnrollCID.Name = "EnrollCID";
            this.EnrollCID.Width = 115;
            // 
            // EnrollTitle
            // 
            this.EnrollTitle.HeaderText = "Course Title";
            this.EnrollTitle.MinimumWidth = 6;
            this.EnrollTitle.Name = "EnrollTitle";
            this.EnrollTitle.Width = 125;
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
            this.EnrollSem.Name = "EnrollSem";
            this.EnrollSem.Width = 125;
            // 
            // EnrollUnenroll
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            this.EnrollUnenroll.DefaultCellStyle = dataGridViewCellStyle8;
            this.EnrollUnenroll.HeaderText = "Unenroll";
            this.EnrollUnenroll.MinimumWidth = 6;
            this.EnrollUnenroll.Name = "EnrollUnenroll";
            this.EnrollUnenroll.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EnrollUnenroll.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EnrollUnenroll.Text = "Unenroll";
            this.EnrollUnenroll.UseColumnTextForButtonValue = true;
            this.EnrollUnenroll.Width = 125;
            // 
            // CartDept
            // 
            this.CartDept.HeaderText = "Course Department";
            this.CartDept.Name = "CartDept";
            this.CartDept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CartDept.Width = 110;
            // 
            // CartCID
            // 
            this.CartCID.HeaderText = "Course ID";
            this.CartCID.MinimumWidth = 6;
            this.CartCID.Name = "CartCID";
            // 
            // CartTitle
            // 
            this.CartTitle.HeaderText = "Course Title";
            this.CartTitle.MinimumWidth = 6;
            this.CartTitle.Name = "CartTitle";
            this.CartTitle.Width = 125;
            // 
            // CartSID
            // 
            this.CartSID.HeaderText = "Section ID";
            this.CartSID.MinimumWidth = 6;
            this.CartSID.Name = "CartSID";
            // 
            // CartSem
            // 
            this.CartSem.HeaderText = "Semester";
            this.CartSem.Name = "CartSem";
            // 
            // CartEnroll
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this.CartEnroll.DefaultCellStyle = dataGridViewCellStyle4;
            this.CartEnroll.HeaderText = "Enroll";
            this.CartEnroll.MinimumWidth = 6;
            this.CartEnroll.Name = "CartEnroll";
            this.CartEnroll.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CartEnroll.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CartEnroll.Text = "Enroll";
            this.CartEnroll.UseColumnTextForButtonValue = true;
            this.CartEnroll.Width = 80;
            // 
            // CartDelete
            // 
            this.CartDelete.HeaderText = "Delete";
            this.CartDelete.Name = "CartDelete";
            this.CartDelete.Text = "Delete";
            this.CartDelete.UseColumnTextForButtonValue = true;
            // 
            // Registration_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SystemTabs);
            this.Name = "Registration_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Registration System";
            this.SystemTabs.ResumeLayout(false);
            this.CourseSelect.ResumeLayout(false);
            this.CourseSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseSearchGrid)).EndInit();
            this.Cart.ResumeLayout(false);
            this.Cart.PerformLayout();
            this.EnrollPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).EndInit();
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
        private System.Windows.Forms.TextBox SID;
        private System.Windows.Forms.TabControl SystemTabs;
        private System.Windows.Forms.Label PassLB;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label IDLB;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label RefreshLB;
        private System.Windows.Forms.Label InfoLB;
        private System.Windows.Forms.DataGridView CartDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Sem;
        private System.Windows.Forms.DataGridViewButtonColumn Col_CartAdd;
        private System.Windows.Forms.DataGridView EnrollDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartSem;
        private System.Windows.Forms.DataGridViewButtonColumn CartEnroll;
        private System.Windows.Forms.DataGridViewButtonColumn CartDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollSem;
        private System.Windows.Forms.DataGridViewButtonColumn EnrollUnenroll;
    }
}