namespace LibraryManagementSystem
{
    partial class Form1
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.boxStudents = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudentGender = new System.Windows.Forms.ComboBox();
            this.txtStudentLastname = new System.Windows.Forms.TextBox();
            this.txtStudentBirthdate = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnRefreshS = new System.Windows.Forms.Button();
            this.btnRemoveS = new System.Windows.Forms.Button();
            this.btnAddS = new System.Windows.Forms.Button();
            this.btnSearchS = new System.Windows.Forms.Button();
            this.txtSearchS = new System.Windows.Forms.TextBox();
            this.boxBooks = new System.Windows.Forms.GroupBox();
            this.btnRefreshB = new System.Windows.Forms.Button();
            this.btnSearchB = new System.Windows.Forms.Button();
            this.txtSearchB = new System.Windows.Forms.TextBox();
            this.btnRemoveB = new System.Windows.Forms.Button();
            this.boxSelect = new System.Windows.Forms.GroupBox();
            this.rdbBooks = new System.Windows.Forms.RadioButton();
            this.rdbStudents = new System.Windows.Forms.RadioButton();
            this.cmbBooksGenres = new System.Windows.Forms.ComboBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthorLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.boxStudents.SuspendLayout();
            this.boxBooks.SuspendLayout();
            this.boxSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(16, 58);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(562, 294);
            this.dgvStudents.TabIndex = 0;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(16, 58);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(460, 294);
            this.dgvBooks.TabIndex = 1;
            // 
            // boxStudents
            // 
            this.boxStudents.Controls.Add(this.label4);
            this.boxStudents.Controls.Add(this.label2);
            this.boxStudents.Controls.Add(this.label3);
            this.boxStudents.Controls.Add(this.label1);
            this.boxStudents.Controls.Add(this.cmbStudentGender);
            this.boxStudents.Controls.Add(this.txtStudentLastname);
            this.boxStudents.Controls.Add(this.txtStudentBirthdate);
            this.boxStudents.Controls.Add(this.txtStudentName);
            this.boxStudents.Controls.Add(this.btnRefreshS);
            this.boxStudents.Controls.Add(this.btnRemoveS);
            this.boxStudents.Controls.Add(this.btnAddS);
            this.boxStudents.Controls.Add(this.btnSearchS);
            this.boxStudents.Controls.Add(this.txtSearchS);
            this.boxStudents.Controls.Add(this.dgvStudents);
            this.boxStudents.Location = new System.Drawing.Point(12, 56);
            this.boxStudents.Name = "boxStudents";
            this.boxStudents.Size = new System.Drawing.Size(594, 556);
            this.boxStudents.TabIndex = 2;
            this.boxStudents.TabStop = false;
            this.boxStudents.Text = "Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Birthdate (YYYY-MM-DD):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // cmbStudentGender
            // 
            this.cmbStudentGender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbStudentGender.FormattingEnabled = true;
            this.cmbStudentGender.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbStudentGender.Location = new System.Drawing.Point(178, 410);
            this.cmbStudentGender.Name = "cmbStudentGender";
            this.cmbStudentGender.Size = new System.Drawing.Size(72, 21);
            this.cmbStudentGender.TabIndex = 8;
            // 
            // txtStudentLastname
            // 
            this.txtStudentLastname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStudentLastname.Location = new System.Drawing.Point(178, 371);
            this.txtStudentLastname.Name = "txtStudentLastname";
            this.txtStudentLastname.Size = new System.Drawing.Size(156, 20);
            this.txtStudentLastname.TabIndex = 7;
            // 
            // txtStudentBirthdate
            // 
            this.txtStudentBirthdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStudentBirthdate.Location = new System.Drawing.Point(16, 410);
            this.txtStudentBirthdate.Name = "txtStudentBirthdate";
            this.txtStudentBirthdate.Size = new System.Drawing.Size(156, 20);
            this.txtStudentBirthdate.TabIndex = 7;
            // 
            // txtStudentName
            // 
            this.txtStudentName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStudentName.Location = new System.Drawing.Point(16, 371);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(156, 20);
            this.txtStudentName.TabIndex = 7;
            // 
            // btnRefreshS
            // 
            this.btnRefreshS.Location = new System.Drawing.Point(502, 32);
            this.btnRefreshS.Name = "btnRefreshS";
            this.btnRefreshS.Size = new System.Drawing.Size(76, 21);
            this.btnRefreshS.TabIndex = 5;
            this.btnRefreshS.Text = "Refresh";
            this.btnRefreshS.UseVisualStyleBackColor = true;
            this.btnRefreshS.Click += new System.EventHandler(this.btnClearS_Click);
            // 
            // btnRemoveS
            // 
            this.btnRemoveS.Location = new System.Drawing.Point(421, 367);
            this.btnRemoveS.Name = "btnRemoveS";
            this.btnRemoveS.Size = new System.Drawing.Size(157, 26);
            this.btnRemoveS.TabIndex = 6;
            this.btnRemoveS.Text = "Remove Selected";
            this.btnRemoveS.UseVisualStyleBackColor = true;
            this.btnRemoveS.Click += new System.EventHandler(this.btnRemoveS_Click);
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(16, 436);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(156, 26);
            this.btnAddS.TabIndex = 6;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // btnSearchS
            // 
            this.btnSearchS.Location = new System.Drawing.Point(399, 32);
            this.btnSearchS.Name = "btnSearchS";
            this.btnSearchS.Size = new System.Drawing.Size(97, 20);
            this.btnSearchS.TabIndex = 3;
            this.btnSearchS.Text = "Search";
            this.btnSearchS.UseVisualStyleBackColor = true;
            this.btnSearchS.Click += new System.EventHandler(this.btnSearchS_Click);
            // 
            // txtSearchS
            // 
            this.txtSearchS.Location = new System.Drawing.Point(16, 32);
            this.txtSearchS.Name = "txtSearchS";
            this.txtSearchS.Size = new System.Drawing.Size(377, 20);
            this.txtSearchS.TabIndex = 2;
            // 
            // boxBooks
            // 
            this.boxBooks.Controls.Add(this.btnRefreshB);
            this.boxBooks.Controls.Add(this.label8);
            this.boxBooks.Controls.Add(this.label6);
            this.boxBooks.Controls.Add(this.btnSearchB);
            this.boxBooks.Controls.Add(this.txtSearchB);
            this.boxBooks.Controls.Add(this.dgvBooks);
            this.boxBooks.Controls.Add(this.label7);
            this.boxBooks.Controls.Add(this.label5);
            this.boxBooks.Controls.Add(this.cmbBooksGenres);
            this.boxBooks.Controls.Add(this.btnRemoveB);
            this.boxBooks.Controls.Add(this.btnAddB);
            this.boxBooks.Controls.Add(this.txtAuthorLastname);
            this.boxBooks.Controls.Add(this.txtAuthorName);
            this.boxBooks.Controls.Add(this.txtBookName);
            this.boxBooks.Location = new System.Drawing.Point(12, 56);
            this.boxBooks.Name = "boxBooks";
            this.boxBooks.Size = new System.Drawing.Size(492, 556);
            this.boxBooks.TabIndex = 3;
            this.boxBooks.TabStop = false;
            this.boxBooks.Text = "Books";
            this.boxBooks.Visible = false;
            // 
            // btnRefreshB
            // 
            this.btnRefreshB.Location = new System.Drawing.Point(400, 31);
            this.btnRefreshB.Name = "btnRefreshB";
            this.btnRefreshB.Size = new System.Drawing.Size(76, 21);
            this.btnRefreshB.TabIndex = 5;
            this.btnRefreshB.Text = "Refresh";
            this.btnRefreshB.UseVisualStyleBackColor = true;
            this.btnRefreshB.Click += new System.EventHandler(this.btnClearB_Click);
            // 
            // btnSearchB
            // 
            this.btnSearchB.Location = new System.Drawing.Point(297, 32);
            this.btnSearchB.Name = "btnSearchB";
            this.btnSearchB.Size = new System.Drawing.Size(97, 20);
            this.btnSearchB.TabIndex = 4;
            this.btnSearchB.Text = "Search";
            this.btnSearchB.UseVisualStyleBackColor = true;
            this.btnSearchB.Click += new System.EventHandler(this.btnSearchB_Click);
            // 
            // txtSearchB
            // 
            this.txtSearchB.Location = new System.Drawing.Point(16, 32);
            this.txtSearchB.Name = "txtSearchB";
            this.txtSearchB.Size = new System.Drawing.Size(275, 20);
            this.txtSearchB.TabIndex = 2;
            // 
            // btnRemoveB
            // 
            this.btnRemoveB.Location = new System.Drawing.Point(319, 367);
            this.btnRemoveB.Name = "btnRemoveB";
            this.btnRemoveB.Size = new System.Drawing.Size(157, 26);
            this.btnRemoveB.TabIndex = 6;
            this.btnRemoveB.Text = "Remove Selected";
            this.btnRemoveB.UseVisualStyleBackColor = true;
            this.btnRemoveB.Click += new System.EventHandler(this.btnRemoveB_Click);
            // 
            // boxSelect
            // 
            this.boxSelect.Controls.Add(this.rdbBooks);
            this.boxSelect.Controls.Add(this.rdbStudents);
            this.boxSelect.Location = new System.Drawing.Point(12, 9);
            this.boxSelect.Name = "boxSelect";
            this.boxSelect.Size = new System.Drawing.Size(172, 41);
            this.boxSelect.TabIndex = 5;
            this.boxSelect.TabStop = false;
            this.boxSelect.Text = "Select";
            // 
            // rdbBooks
            // 
            this.rdbBooks.AutoSize = true;
            this.rdbBooks.Location = new System.Drawing.Point(100, 18);
            this.rdbBooks.Name = "rdbBooks";
            this.rdbBooks.Size = new System.Drawing.Size(55, 17);
            this.rdbBooks.TabIndex = 6;
            this.rdbBooks.TabStop = true;
            this.rdbBooks.Text = "Books";
            this.rdbBooks.UseVisualStyleBackColor = true;
            this.rdbBooks.CheckedChanged += new System.EventHandler(this.rdbBooks_CheckedChanged);
            // 
            // rdbStudents
            // 
            this.rdbStudents.AutoSize = true;
            this.rdbStudents.Checked = true;
            this.rdbStudents.Location = new System.Drawing.Point(16, 18);
            this.rdbStudents.Name = "rdbStudents";
            this.rdbStudents.Size = new System.Drawing.Size(67, 17);
            this.rdbStudents.TabIndex = 5;
            this.rdbStudents.TabStop = true;
            this.rdbStudents.Text = "Students";
            this.rdbStudents.UseVisualStyleBackColor = true;
            this.rdbStudents.CheckedChanged += new System.EventHandler(this.rdbStudents_CheckedChanged);
            // 
            // cmbBooksGenres
            // 
            this.cmbBooksGenres.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbBooksGenres.FormattingEnabled = true;
            this.cmbBooksGenres.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbBooksGenres.Location = new System.Drawing.Point(178, 371);
            this.cmbBooksGenres.Name = "cmbBooksGenres";
            this.cmbBooksGenres.Size = new System.Drawing.Size(102, 21);
            this.cmbBooksGenres.TabIndex = 8;
            // 
            // txtBookName
            // 
            this.txtBookName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBookName.Location = new System.Drawing.Point(16, 371);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(156, 20);
            this.txtBookName.TabIndex = 7;
            // 
            // txtAuthorLastname
            // 
            this.txtAuthorLastname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAuthorLastname.Location = new System.Drawing.Point(178, 411);
            this.txtAuthorLastname.Name = "txtAuthorLastname";
            this.txtAuthorLastname.Size = new System.Drawing.Size(156, 20);
            this.txtAuthorLastname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Book:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Author\'s Lastname:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAuthorName.Location = new System.Drawing.Point(16, 411);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(156, 20);
            this.txtAuthorName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Author\'s Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Genre:";
            // 
            // btnAddB
            // 
            this.btnAddB.Location = new System.Drawing.Point(16, 437);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(156, 26);
            this.btnAddB.TabIndex = 6;
            this.btnAddB.Text = "Add";
            this.btnAddB.UseVisualStyleBackColor = true;
            this.btnAddB.Click += new System.EventHandler(this.btnAddB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 624);
            this.Controls.Add(this.boxSelect);
            this.Controls.Add(this.boxBooks);
            this.Controls.Add(this.boxStudents);
            this.Name = "Form1";
            this.Text = "Library Managment System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.boxStudents.ResumeLayout(false);
            this.boxStudents.PerformLayout();
            this.boxBooks.ResumeLayout(false);
            this.boxBooks.PerformLayout();
            this.boxSelect.ResumeLayout(false);
            this.boxSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox boxStudents;
        private System.Windows.Forms.TextBox txtSearchS;
        private System.Windows.Forms.GroupBox boxBooks;
        private System.Windows.Forms.TextBox txtSearchB;
        private System.Windows.Forms.Button btnSearchS;
        private System.Windows.Forms.Button btnSearchB;
        private System.Windows.Forms.GroupBox boxSelect;
        private System.Windows.Forms.RadioButton rdbBooks;
        private System.Windows.Forms.RadioButton rdbStudents;
        private System.Windows.Forms.Button btnRefreshB;
        private System.Windows.Forms.Button btnRefreshS;
        private System.Windows.Forms.ComboBox cmbStudentGender;
        private System.Windows.Forms.TextBox txtStudentLastname;
        private System.Windows.Forms.TextBox txtStudentBirthdate;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnRemoveS;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.Button btnRemoveB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBooksGenres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddB;
        private System.Windows.Forms.TextBox txtAuthorLastname;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
    }
}

