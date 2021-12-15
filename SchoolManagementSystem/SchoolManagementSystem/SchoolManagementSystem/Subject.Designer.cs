
namespace SchoolManagementSystem
{
    partial class Subject
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
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.cb_grade = new System.Windows.Forms.ComboBox();
            this.cb_gradetype = new System.Windows.Forms.ComboBox();
            this.btn_addsubject = new System.Windows.Forms.Button();
            this.cb_subjects = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_countsubjects = new System.Windows.Forms.ComboBox();
            this.btn_resetsubject = new System.Windows.Forms.Button();
            this.lbl_subjects = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.BackColor = System.Drawing.Color.Transparent;
            this.lbl_class.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(78, 44);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(42, 16);
            this.lbl_class.TabIndex = 1;
            this.lbl_class.Text = "Class";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subject.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(421, 44);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(59, 16);
            this.lbl_subject.TabIndex = 2;
            this.lbl_subject.Text = "Subject";
            // 
            // cb_grade
            // 
            this.cb_grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_grade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_grade.FormattingEnabled = true;
            this.cb_grade.Items.AddRange(new object[] {
            "I grade",
            "II grade",
            "III grade",
            "IV grade",
            "V grade",
            "VI grade",
            "VII grade",
            "VIII grade",
            "IX grade",
            "X grade",
            "XI grade"});
            this.cb_grade.Location = new System.Drawing.Point(91, 79);
            this.cb_grade.Name = "cb_grade";
            this.cb_grade.Size = new System.Drawing.Size(102, 24);
            this.cb_grade.TabIndex = 3;
            this.cb_grade.Text = "Grade";
            // 
            // cb_gradetype
            // 
            this.cb_gradetype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_gradetype.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gradetype.FormattingEnabled = true;
            this.cb_gradetype.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cb_gradetype.Location = new System.Drawing.Point(199, 80);
            this.cb_gradetype.Name = "cb_gradetype";
            this.cb_gradetype.Size = new System.Drawing.Size(40, 24);
            this.cb_gradetype.TabIndex = 4;
            this.cb_gradetype.Text = "A";
            // 
            // btn_addsubject
            // 
            this.btn_addsubject.BackColor = System.Drawing.Color.Transparent;
            this.btn_addsubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_addsubject.FlatAppearance.BorderSize = 0;
            this.btn_addsubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_addsubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addsubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addsubject.Location = new System.Drawing.Point(574, 158);
            this.btn_addsubject.Name = "btn_addsubject";
            this.btn_addsubject.Size = new System.Drawing.Size(151, 36);
            this.btn_addsubject.TabIndex = 6;
            this.btn_addsubject.UseVisualStyleBackColor = false;
            this.btn_addsubject.Click += new System.EventHandler(this.btn_addsubject_Click);
            // 
            // cb_subjects
            // 
            this.cb_subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_subjects.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_subjects.FormattingEnabled = true;
            this.cb_subjects.Items.AddRange(new object[] {
            "English",
            "History",
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "Geography",
            "Music",
            "Geometry",
            "French",
            "Art",
            "GYM"});
            this.cb_subjects.Location = new System.Drawing.Point(425, 76);
            this.cb_subjects.Name = "cb_subjects";
            this.cb_subjects.Size = new System.Drawing.Size(124, 24);
            this.cb_subjects.TabIndex = 22;
            this.cb_subjects.Text = "English";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(680, 73);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(45, 31);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_countsubjects
            // 
            this.cb_countsubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_countsubjects.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_countsubjects.FormattingEnabled = true;
            this.cb_countsubjects.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7"});
            this.cb_countsubjects.Location = new System.Drawing.Point(245, 79);
            this.cb_countsubjects.Name = "cb_countsubjects";
            this.cb_countsubjects.Size = new System.Drawing.Size(133, 24);
            this.cb_countsubjects.TabIndex = 24;
            this.cb_countsubjects.Text = "Subject count";
            // 
            // btn_resetsubject
            // 
            this.btn_resetsubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_resetsubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_resetsubject.FlatAppearance.BorderSize = 0;
            this.btn_resetsubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_resetsubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_resetsubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetsubject.ForeColor = System.Drawing.Color.White;
            this.btn_resetsubject.Location = new System.Drawing.Point(555, 73);
            this.btn_resetsubject.Name = "btn_resetsubject";
            this.btn_resetsubject.Size = new System.Drawing.Size(119, 31);
            this.btn_resetsubject.TabIndex = 25;
            this.btn_resetsubject.Text = "Reset subject";
            this.btn_resetsubject.UseVisualStyleBackColor = false;
            this.btn_resetsubject.Click += new System.EventHandler(this.btn_resetsubject_Click);
            // 
            // lbl_subjects
            // 
            this.lbl_subjects.AutoSize = true;
            this.lbl_subjects.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subjects.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subjects.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_subjects.Location = new System.Drawing.Point(78, 326);
            this.lbl_subjects.Name = "lbl_subjects";
            this.lbl_subjects.Size = new System.Drawing.Size(81, 14);
            this.lbl_subjects.TabIndex = 26;
            this.lbl_subjects.Text = "SUBJECTS:";
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.addsubjectbck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.lbl_subjects);
            this.Controls.Add(this.btn_resetsubject);
            this.Controls.Add(this.cb_countsubjects);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_subjects);
            this.Controls.Add(this.btn_addsubject);
            this.Controls.Add(this.cb_gradetype);
            this.Controls.Add(this.cb_grade);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_class);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Subject";
            this.Text = "Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.ComboBox cb_grade;
        private System.Windows.Forms.ComboBox cb_gradetype;
        private System.Windows.Forms.Button btn_addsubject;
        private System.Windows.Forms.ComboBox cb_subjects;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_countsubjects;
        private System.Windows.Forms.Button btn_resetsubject;
        private System.Windows.Forms.Label lbl_subjects;
    }
}