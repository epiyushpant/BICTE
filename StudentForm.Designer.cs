namespace StudentManagementSystem
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.nudYearPassed = new System.Windows.Forms.NumericUpDown();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvQualifications = new System.Windows.Forms.DataGridView();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPassed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSaveExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearPassed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifications)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOB :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact No. :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 5;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(83, 45);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(157, 45);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(83, 74);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(83, 110);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(83, 143);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 20);
            this.txtContact.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Faculty :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Course :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Year Passed :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Marks / Percentage :";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "Architecture",
            "Computer and Information Technology",
            "Electrical engineering",
            "Environmental science",
            "Finance",
            "Bachelor of Hotel Management",
            "Bachelors In Information Technology (Bit)",
            "BSc in Computer Science",
            "Computer Engineering",
            "BA in Social Work",
            "Bachelor of Business Administration",
            "Bachelor of Education",
            "Bachelor of Science",
            "Bachelor Of Computer Application (Bca)",
            "Bachelor of Electronics and Communication Engineering",
            "Bachelor of Law",
            "Social work"});
            this.cmbFaculty.Location = new System.Drawing.Point(616, 6);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(121, 21);
            this.cmbFaculty.TabIndex = 15;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(616, 38);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(121, 20);
            this.txtCourse.TabIndex = 16;
            // 
            // nudYearPassed
            // 
            this.nudYearPassed.Location = new System.Drawing.Point(617, 74);
            this.nudYearPassed.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudYearPassed.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYearPassed.Name = "nudYearPassed";
            this.nudYearPassed.Size = new System.Drawing.Size(120, 20);
            this.nudYearPassed.TabIndex = 17;
            this.nudYearPassed.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(617, 110);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(120, 20);
            this.txtMarks.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(662, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvQualifications
            // 
            this.dgvQualifications.AllowUserToAddRows = false;
            this.dgvQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Faculty,
            this.Course,
            this.YearPassed,
            this.Marks,
            this.editBtn,
            this.deleteBtn});
            this.dgvQualifications.Location = new System.Drawing.Point(95, 169);
            this.dgvQualifications.Name = "dgvQualifications";
            this.dgvQualifications.Size = new System.Drawing.Size(642, 134);
            this.dgvQualifications.TabIndex = 20;
            this.dgvQualifications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQualifications_CellContentClick);
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Faculty";
            this.Faculty.Name = "Faculty";
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            // 
            // YearPassed
            // 
            this.YearPassed.HeaderText = "Year Passed";
            this.YearPassed.Name = "YearPassed";
            // 
            // Marks
            // 
            this.Marks.HeaderText = "Marks";
            this.Marks.Name = "Marks";
            // 
            // editBtn
            // 
            this.editBtn.HeaderText = "Edit";
            this.editBtn.Name = "editBtn";
            // 
            // deleteBtn
            // 
            this.deleteBtn.HeaderText = "Delete";
            this.deleteBtn.Name = "deleteBtn";
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(641, 322);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(96, 23);
            this.btnSaveExcel.TabIndex = 21;
            this.btnSaveExcel.Text = "Save to Excel";
            this.btnSaveExcel.UseVisualStyleBackColor = true;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveExcel);
            this.Controls.Add(this.dgvQualifications);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.nudYearPassed);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYearPassed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.NumericUpDown nudYearPassed;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvQualifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPassed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marks;
        private System.Windows.Forms.DataGridViewButtonColumn editBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.Button btnSaveExcel;
    }
}