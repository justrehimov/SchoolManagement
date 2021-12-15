
namespace SchoolManagementSystem
{
    partial class Student
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
            this.pnl_student_table = new System.Windows.Forms.Panel();
            this.pnl_student_controls = new System.Windows.Forms.Panel();
            this.btn_deletstudent = new System.Windows.Forms.Button();
            this.btn_editStudent = new System.Windows.Forms.Button();
            this.btn_view_student = new System.Windows.Forms.Button();
            this.btn_search_student = new System.Windows.Forms.Button();
            this.tb_search_student = new System.Windows.Forms.TextBox();
            this.btn_addStudent = new System.Windows.Forms.Button();
            this.pnl_student_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_student_table
            // 
            this.pnl_student_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_student_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_student_table.Location = new System.Drawing.Point(0, 64);
            this.pnl_student_table.Name = "pnl_student_table";
            this.pnl_student_table.Size = new System.Drawing.Size(804, 497);
            this.pnl_student_table.TabIndex = 1;
            // 
            // pnl_student_controls
            // 
            this.pnl_student_controls.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pnl_tch_cntrlback;
            this.pnl_student_controls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_student_controls.Controls.Add(this.btn_deletstudent);
            this.pnl_student_controls.Controls.Add(this.btn_editStudent);
            this.pnl_student_controls.Controls.Add(this.btn_view_student);
            this.pnl_student_controls.Controls.Add(this.btn_search_student);
            this.pnl_student_controls.Controls.Add(this.tb_search_student);
            this.pnl_student_controls.Controls.Add(this.btn_addStudent);
            this.pnl_student_controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_student_controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_student_controls.Name = "pnl_student_controls";
            this.pnl_student_controls.Size = new System.Drawing.Size(804, 64);
            this.pnl_student_controls.TabIndex = 0;
            // 
            // btn_deletstudent
            // 
            this.btn_deletstudent.BackColor = System.Drawing.Color.Transparent;
            this.btn_deletstudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_deletstudent.FlatAppearance.BorderSize = 0;
            this.btn_deletstudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_deletstudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_deletstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletstudent.Location = new System.Drawing.Point(252, 12);
            this.btn_deletstudent.Name = "btn_deletstudent";
            this.btn_deletstudent.Size = new System.Drawing.Size(113, 40);
            this.btn_deletstudent.TabIndex = 8;
            this.btn_deletstudent.UseVisualStyleBackColor = false;
            this.btn_deletstudent.Click += new System.EventHandler(this.btn_deletstudent_Click);
            // 
            // btn_editStudent
            // 
            this.btn_editStudent.BackColor = System.Drawing.Color.Transparent;
            this.btn_editStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_editStudent.FlatAppearance.BorderSize = 0;
            this.btn_editStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_editStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_editStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editStudent.Location = new System.Drawing.Point(126, 12);
            this.btn_editStudent.Name = "btn_editStudent";
            this.btn_editStudent.Size = new System.Drawing.Size(100, 40);
            this.btn_editStudent.TabIndex = 7;
            this.btn_editStudent.UseVisualStyleBackColor = false;
            this.btn_editStudent.Click += new System.EventHandler(this.btn_editStudent_Click);
            // 
            // btn_view_student
            // 
            this.btn_view_student.BackColor = System.Drawing.Color.Transparent;
            this.btn_view_student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_view_student.FlatAppearance.BorderSize = 0;
            this.btn_view_student.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_view_student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_view_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_student.Location = new System.Drawing.Point(390, 12);
            this.btn_view_student.Name = "btn_view_student";
            this.btn_view_student.Size = new System.Drawing.Size(101, 40);
            this.btn_view_student.TabIndex = 6;
            this.btn_view_student.UseVisualStyleBackColor = false;
            this.btn_view_student.Click += new System.EventHandler(this.btn_view_student_Click);
            // 
            // btn_search_student
            // 
            this.btn_search_student.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_student.Enabled = false;
            this.btn_search_student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_search_student.FlatAppearance.BorderSize = 0;
            this.btn_search_student.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_search_student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_search_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_student.Location = new System.Drawing.Point(738, 13);
            this.btn_search_student.Name = "btn_search_student";
            this.btn_search_student.Size = new System.Drawing.Size(54, 40);
            this.btn_search_student.TabIndex = 5;
            this.btn_search_student.UseVisualStyleBackColor = false;
            this.btn_search_student.Click += new System.EventHandler(this.btn_search_student_Click);
            // 
            // tb_search_student
            // 
            this.tb_search_student.BackColor = System.Drawing.Color.White;
            this.tb_search_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search_student.Enabled = false;
            this.tb_search_student.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_student.ForeColor = System.Drawing.Color.Gray;
            this.tb_search_student.Location = new System.Drawing.Point(517, 24);
            this.tb_search_student.Multiline = true;
            this.tb_search_student.Name = "tb_search_student";
            this.tb_search_student.ReadOnly = true;
            this.tb_search_student.Size = new System.Drawing.Size(214, 25);
            this.tb_search_student.TabIndex = 4;
            this.tb_search_student.Text = "Enter name";
            this.tb_search_student.Click += new System.EventHandler(this.tb_search_student_Click);
            // 
            // btn_addStudent
            // 
            this.btn_addStudent.BackColor = System.Drawing.Color.Transparent;
            this.btn_addStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_addStudent.FlatAppearance.BorderSize = 0;
            this.btn_addStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_addStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addStudent.Location = new System.Drawing.Point(10, 12);
            this.btn_addStudent.Name = "btn_addStudent";
            this.btn_addStudent.Size = new System.Drawing.Size(92, 40);
            this.btn_addStudent.TabIndex = 1;
            this.btn_addStudent.UseVisualStyleBackColor = false;
            this.btn_addStudent.Click += new System.EventHandler(this.btn_addStudent_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.pnl_student_table);
            this.Controls.Add(this.pnl_student_controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student";
            this.Text = "Student";
            this.pnl_student_controls.ResumeLayout(false);
            this.pnl_student_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_student_controls;
        private System.Windows.Forms.Panel pnl_student_table;
        private System.Windows.Forms.Button btn_addStudent;
        private System.Windows.Forms.Button btn_search_student;
        private System.Windows.Forms.TextBox tb_search_student;
        private System.Windows.Forms.Button btn_view_student;
        private System.Windows.Forms.Button btn_editStudent;
        private System.Windows.Forms.Button btn_deletstudent;
    }
}