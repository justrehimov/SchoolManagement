
namespace SchoolManagementSystem
{
    partial class Admin
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
            this.pnl_multiple = new System.Windows.Forms.Panel();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_subject = new System.Windows.Forms.Button();
            this.btn_worker = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.tb_home_color = new System.Windows.Forms.TextBox();
            this.tb_teacher_color = new System.Windows.Forms.TextBox();
            this.tb_student_color = new System.Windows.Forms.TextBox();
            this.tb_worker_color = new System.Windows.Forms.TextBox();
            this.tb_subject_color = new System.Windows.Forms.TextBox();
            this.tb_settings_color = new System.Windows.Forms.TextBox();
            this.pnl_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_multiple
            // 
            this.pnl_multiple.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.homebackground;
            this.pnl_multiple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_multiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_multiple.Location = new System.Drawing.Point(230, 0);
            this.pnl_multiple.Name = "pnl_multiple";
            this.pnl_multiple.Size = new System.Drawing.Size(804, 561);
            this.pnl_multiple.TabIndex = 1;
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.sidebarbackground;
            this.pnl_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_sidebar.Controls.Add(this.tb_settings_color);
            this.pnl_sidebar.Controls.Add(this.tb_subject_color);
            this.pnl_sidebar.Controls.Add(this.tb_worker_color);
            this.pnl_sidebar.Controls.Add(this.tb_student_color);
            this.pnl_sidebar.Controls.Add(this.tb_teacher_color);
            this.pnl_sidebar.Controls.Add(this.tb_home_color);
            this.pnl_sidebar.Controls.Add(this.btn_exit);
            this.pnl_sidebar.Controls.Add(this.btn_settings);
            this.pnl_sidebar.Controls.Add(this.btn_subject);
            this.pnl_sidebar.Controls.Add(this.btn_worker);
            this.pnl_sidebar.Controls.Add(this.btn_student);
            this.pnl_sidebar.Controls.Add(this.btn_teacher);
            this.pnl_sidebar.Controls.Add(this.btn_home);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(230, 561);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(0, 483);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(201, 43);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(0, 414);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(201, 43);
            this.btn_settings.TabIndex = 5;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_subject
            // 
            this.btn_subject.BackColor = System.Drawing.Color.Transparent;
            this.btn_subject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_subject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_subject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subject.Location = new System.Drawing.Point(0, 348);
            this.btn_subject.Name = "btn_subject";
            this.btn_subject.Size = new System.Drawing.Size(201, 43);
            this.btn_subject.TabIndex = 4;
            this.btn_subject.UseVisualStyleBackColor = false;
            this.btn_subject.Click += new System.EventHandler(this.btn_subject_Click);
            // 
            // btn_worker
            // 
            this.btn_worker.BackColor = System.Drawing.Color.Transparent;
            this.btn_worker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_worker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_worker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_worker.Location = new System.Drawing.Point(3, 281);
            this.btn_worker.Name = "btn_worker";
            this.btn_worker.Size = new System.Drawing.Size(201, 43);
            this.btn_worker.TabIndex = 3;
            this.btn_worker.UseVisualStyleBackColor = false;
            this.btn_worker.Click += new System.EventHandler(this.btn_worker_Click);
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.Color.Transparent;
            this.btn_student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_student.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student.Location = new System.Drawing.Point(3, 212);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(201, 43);
            this.btn_student.TabIndex = 2;
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.BackColor = System.Drawing.Color.Transparent;
            this.btn_teacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_teacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_teacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher.Location = new System.Drawing.Point(0, 145);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(201, 43);
            this.btn_teacher.TabIndex = 1;
            this.btn_teacher.UseVisualStyleBackColor = false;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(0, 77);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(201, 43);
            this.btn_home.TabIndex = 0;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // tb_home_color
            // 
            this.tb_home_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_home_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_home_color.Enabled = false;
            this.tb_home_color.Location = new System.Drawing.Point(220, 65);
            this.tb_home_color.Multiline = true;
            this.tb_home_color.Name = "tb_home_color";
            this.tb_home_color.Size = new System.Drawing.Size(10, 61);
            this.tb_home_color.TabIndex = 7;
            this.tb_home_color.Visible = false;
            // 
            // tb_teacher_color
            // 
            this.tb_teacher_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_teacher_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_teacher_color.Enabled = false;
            this.tb_teacher_color.Location = new System.Drawing.Point(220, 132);
            this.tb_teacher_color.Multiline = true;
            this.tb_teacher_color.Name = "tb_teacher_color";
            this.tb_teacher_color.Size = new System.Drawing.Size(10, 61);
            this.tb_teacher_color.TabIndex = 8;
            this.tb_teacher_color.Visible = false;
            // 
            // tb_student_color
            // 
            this.tb_student_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_student_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_student_color.Enabled = false;
            this.tb_student_color.Location = new System.Drawing.Point(220, 199);
            this.tb_student_color.Multiline = true;
            this.tb_student_color.Name = "tb_student_color";
            this.tb_student_color.Size = new System.Drawing.Size(10, 61);
            this.tb_student_color.TabIndex = 9;
            this.tb_student_color.Visible = false;
            // 
            // tb_worker_color
            // 
            this.tb_worker_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_worker_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_worker_color.Enabled = false;
            this.tb_worker_color.Location = new System.Drawing.Point(220, 266);
            this.tb_worker_color.Multiline = true;
            this.tb_worker_color.Name = "tb_worker_color";
            this.tb_worker_color.Size = new System.Drawing.Size(10, 61);
            this.tb_worker_color.TabIndex = 10;
            this.tb_worker_color.Visible = false;
            // 
            // tb_subject_color
            // 
            this.tb_subject_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_subject_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_subject_color.Enabled = false;
            this.tb_subject_color.Location = new System.Drawing.Point(220, 333);
            this.tb_subject_color.Multiline = true;
            this.tb_subject_color.Name = "tb_subject_color";
            this.tb_subject_color.Size = new System.Drawing.Size(10, 61);
            this.tb_subject_color.TabIndex = 11;
            this.tb_subject_color.Visible = false;
            // 
            // tb_settings_color
            // 
            this.tb_settings_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_settings_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_settings_color.Enabled = false;
            this.tb_settings_color.Location = new System.Drawing.Point(220, 400);
            this.tb_settings_color.Multiline = true;
            this.tb_settings_color.Name = "tb_settings_color";
            this.tb_settings_color.Size = new System.Drawing.Size(10, 61);
            this.tb_settings_color.TabIndex = 12;
            this.tb_settings_color.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.pnl_multiple);
            this.Controls.Add(this.pnl_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_multiple;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_subject;
        private System.Windows.Forms.Button btn_worker;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_teacher;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox tb_settings_color;
        private System.Windows.Forms.TextBox tb_subject_color;
        private System.Windows.Forms.TextBox tb_worker_color;
        private System.Windows.Forms.TextBox tb_student_color;
        private System.Windows.Forms.TextBox tb_teacher_color;
        private System.Windows.Forms.TextBox tb_home_color;
    }
}