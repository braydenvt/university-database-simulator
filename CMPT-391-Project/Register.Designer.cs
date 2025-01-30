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
            this.SystemTabs = new System.Windows.Forms.TabControl();
            this.CourseSelect = new System.Windows.Forms.TabPage();
            this.SIDLB = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.TextBox();
            this.Field2LB = new System.Windows.Forms.Label();
            this.Field2 = new System.Windows.Forms.TextBox();
            this.Field1LB = new System.Windows.Forms.Label();
            this.Field1 = new System.Windows.Forms.TextBox();
            this.CourseSearchGrid = new System.Windows.Forms.DataGridView();
            this.Col_CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3_Spots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cart = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SystemTabs.SuspendLayout();
            this.CourseSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseSearchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemTabs
            // 
            this.SystemTabs.Controls.Add(this.CourseSelect);
            this.SystemTabs.Controls.Add(this.Cart);
            this.SystemTabs.Controls.Add(this.tabPage3);
            this.SystemTabs.Location = new System.Drawing.Point(0, 1);
            this.SystemTabs.Name = "SystemTabs";
            this.SystemTabs.SelectedIndex = 0;
            this.SystemTabs.Size = new System.Drawing.Size(1055, 541);
            this.SystemTabs.TabIndex = 0;
            // 
            // CourseSelect
            // 
            this.CourseSelect.Controls.Add(this.SIDLB);
            this.CourseSelect.Controls.Add(this.SID);
            this.CourseSelect.Controls.Add(this.Field2LB);
            this.CourseSelect.Controls.Add(this.Field2);
            this.CourseSelect.Controls.Add(this.Field1LB);
            this.CourseSelect.Controls.Add(this.Field1);
            this.CourseSelect.Controls.Add(this.CourseSearchGrid);
            this.CourseSelect.Location = new System.Drawing.Point(4, 25);
            this.CourseSelect.Name = "CourseSelect";
            this.CourseSelect.Padding = new System.Windows.Forms.Padding(3);
            this.CourseSelect.Size = new System.Drawing.Size(1047, 512);
            this.CourseSelect.TabIndex = 0;
            this.CourseSelect.Text = "Course Selection";
            this.CourseSelect.UseVisualStyleBackColor = true;
            // 
            // SIDLB
            // 
            this.SIDLB.AutoSize = true;
            this.SIDLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SIDLB.Location = new System.Drawing.Point(69, 220);
            this.SIDLB.Name = "SIDLB";
            this.SIDLB.Size = new System.Drawing.Size(118, 28);
            this.SIDLB.TabIndex = 8;
            this.SIDLB.Text = "Student ID:";
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(254, 227);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(149, 22);
            this.SID.TabIndex = 7;
            // 
            // Field2LB
            // 
            this.Field2LB.AutoSize = true;
            this.Field2LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Field2LB.Location = new System.Drawing.Point(400, 125);
            this.Field2LB.Name = "Field2LB";
            this.Field2LB.Size = new System.Drawing.Size(130, 28);
            this.Field2LB.TabIndex = 4;
            this.Field2LB.Text = "Course Title:";
            // 
            // Field2
            // 
            this.Field2.Location = new System.Drawing.Point(553, 132);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(149, 22);
            this.Field2.TabIndex = 3;
            // 
            // Field1LB
            // 
            this.Field1LB.AutoSize = true;
            this.Field1LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field1LB.Location = new System.Drawing.Point(57, 118);
            this.Field1LB.Name = "Field1LB";
            this.Field1LB.Size = new System.Drawing.Size(105, 28);
            this.Field1LB.TabIndex = 2;
            this.Field1LB.Text = "Semester:";
            // 
            // Field1
            // 
            this.Field1.Location = new System.Drawing.Point(180, 125);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(149, 22);
            this.Field1.TabIndex = 1;
            // 
            // CourseSearchGrid
            // 
            this.CourseSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_CID,
            this.Col_Title,
            this.Col_SecID,
            this.Col3_Spots});
            this.CourseSearchGrid.Location = new System.Drawing.Point(62, 286);
            this.CourseSearchGrid.Name = "CourseSearchGrid";
            this.CourseSearchGrid.RowHeadersWidth = 51;
            this.CourseSearchGrid.RowTemplate.Height = 24;
            this.CourseSearchGrid.Size = new System.Drawing.Size(950, 201);
            this.CourseSearchGrid.TabIndex = 0;
            // 
            // Col_CID
            // 
            this.Col_CID.HeaderText = "Course ID";
            this.Col_CID.MinimumWidth = 6;
            this.Col_CID.Name = "Col_CID";
            this.Col_CID.Width = 125;
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
            // Col3_Spots
            // 
            this.Col3_Spots.HeaderText = "Spots Remaining";
            this.Col3_Spots.MinimumWidth = 6;
            this.Col3_Spots.Name = "Col3_Spots";
            this.Col3_Spots.Width = 125;
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(4, 25);
            this.Cart.Name = "Cart";
            this.Cart.Padding = new System.Windows.Forms.Padding(3);
            this.Cart.Size = new System.Drawing.Size(1047, 512);
            this.Cart.TabIndex = 1;
            this.Cart.Text = "User Cart";
            this.Cart.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1047, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Registration_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SystemTabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Registration System";
            this.SystemTabs.ResumeLayout(false);
            this.CourseSelect.ResumeLayout(false);
            this.CourseSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseSearchGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SystemTabs;
        private System.Windows.Forms.TabPage CourseSelect;
        private System.Windows.Forms.TabPage Cart;
        private System.Windows.Forms.DataGridView CourseSearchGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Field1LB;
        private System.Windows.Forms.TextBox Field1;
        private System.Windows.Forms.Label Field2LB;
        private System.Windows.Forms.TextBox Field2;
        private System.Windows.Forms.Label SIDLB;
        private System.Windows.Forms.TextBox SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3_Spots;
    }
}