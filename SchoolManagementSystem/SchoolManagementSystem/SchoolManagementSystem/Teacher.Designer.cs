
namespace SchoolManagementSystem
{
    partial class Teacher
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
            this.pnl_teacher_table = new System.Windows.Forms.Panel();
            this.pnl_teacher_controls = new System.Windows.Forms.Panel();
            this.btn_deleteTeacher = new System.Windows.Forms.Button();
            this.btn_editTeacher = new System.Windows.Forms.Button();
            this.btn_searchteacher = new System.Windows.Forms.Button();
            this.tb_searchteacher = new System.Windows.Forms.TextBox();
            this.btn_viewteacherdata = new System.Windows.Forms.Button();
            this.btn_addTeacher = new System.Windows.Forms.Button();
            this.pnl_teacher_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_teacher_table
            // 
            this.pnl_teacher_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_teacher_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_teacher_table.Location = new System.Drawing.Point(0, 64);
            this.pnl_teacher_table.Name = "pnl_teacher_table";
            this.pnl_teacher_table.Size = new System.Drawing.Size(804, 497);
            this.pnl_teacher_table.TabIndex = 1;
            // 
            // pnl_teacher_controls
            // 
            this.pnl_teacher_controls.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pnl_tch_cntrlback;
            this.pnl_teacher_controls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_teacher_controls.Controls.Add(this.btn_deleteTeacher);
            this.pnl_teacher_controls.Controls.Add(this.btn_editTeacher);
            this.pnl_teacher_controls.Controls.Add(this.btn_searchteacher);
            this.pnl_teacher_controls.Controls.Add(this.tb_searchteacher);
            this.pnl_teacher_controls.Controls.Add(this.btn_viewteacherdata);
            this.pnl_teacher_controls.Controls.Add(this.btn_addTeacher);
            this.pnl_teacher_controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_teacher_controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_teacher_controls.Name = "pnl_teacher_controls";
            this.pnl_teacher_controls.Size = new System.Drawing.Size(804, 64);
            this.pnl_teacher_controls.TabIndex = 0;
            // 
            // btn_deleteTeacher
            // 
            this.btn_deleteTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_deleteTeacher.FlatAppearance.BorderSize = 0;
            this.btn_deleteTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_deleteTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_deleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteTeacher.Location = new System.Drawing.Point(250, 11);
            this.btn_deleteTeacher.Name = "btn_deleteTeacher";
            this.btn_deleteTeacher.Size = new System.Drawing.Size(117, 40);
            this.btn_deleteTeacher.TabIndex = 5;
            this.btn_deleteTeacher.UseVisualStyleBackColor = false;
            this.btn_deleteTeacher.Click += new System.EventHandler(this.btn_deleteTeacher_Click);
            // 
            // btn_editTeacher
            // 
            this.btn_editTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btn_editTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_editTeacher.FlatAppearance.BorderSize = 0;
            this.btn_editTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_editTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_editTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editTeacher.Location = new System.Drawing.Point(126, 11);
            this.btn_editTeacher.Name = "btn_editTeacher";
            this.btn_editTeacher.Size = new System.Drawing.Size(100, 40);
            this.btn_editTeacher.TabIndex = 4;
            this.btn_editTeacher.UseVisualStyleBackColor = false;
            this.btn_editTeacher.Click += new System.EventHandler(this.btn_editTeacher_Click);
            // 
            // btn_searchteacher
            // 
            this.btn_searchteacher.BackColor = System.Drawing.Color.Transparent;
            this.btn_searchteacher.Enabled = false;
            this.btn_searchteacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_searchteacher.FlatAppearance.BorderSize = 0;
            this.btn_searchteacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_searchteacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_searchteacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchteacher.Location = new System.Drawing.Point(738, 12);
            this.btn_searchteacher.Name = "btn_searchteacher";
            this.btn_searchteacher.Size = new System.Drawing.Size(54, 40);
            this.btn_searchteacher.TabIndex = 3;
            this.btn_searchteacher.UseVisualStyleBackColor = false;
            this.btn_searchteacher.Click += new System.EventHandler(this.btn_searchteacher_Click);
            // 
            // tb_searchteacher
            // 
            this.tb_searchteacher.BackColor = System.Drawing.Color.White;
            this.tb_searchteacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_searchteacher.Enabled = false;
            this.tb_searchteacher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchteacher.ForeColor = System.Drawing.Color.Gray;
            this.tb_searchteacher.Location = new System.Drawing.Point(517, 23);
            this.tb_searchteacher.Multiline = true;
            this.tb_searchteacher.Name = "tb_searchteacher";
            this.tb_searchteacher.ReadOnly = true;
            this.tb_searchteacher.Size = new System.Drawing.Size(214, 25);
            this.tb_searchteacher.TabIndex = 2;
            this.tb_searchteacher.Text = "Enter name";
            this.tb_searchteacher.Click += new System.EventHandler(this.tb_searchteacher_Click);
            // 
            // btn_viewteacherdata
            // 
            this.btn_viewteacherdata.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewteacherdata.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_viewteacherdata.FlatAppearance.BorderSize = 0;
            this.btn_viewteacherdata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_viewteacherdata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_viewteacherdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewteacherdata.Location = new System.Drawing.Point(390, 12);
            this.btn_viewteacherdata.Name = "btn_viewteacherdata";
            this.btn_viewteacherdata.Size = new System.Drawing.Size(98, 40);
            this.btn_viewteacherdata.TabIndex = 1;
            this.btn_viewteacherdata.UseVisualStyleBackColor = false;
            this.btn_viewteacherdata.Click += new System.EventHandler(this.btn_viewteacherdata_Click);
            // 
            // btn_addTeacher
            // 
            this.btn_addTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btn_addTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_addTeacher.FlatAppearance.BorderSize = 0;
            this.btn_addTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_addTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTeacher.Location = new System.Drawing.Point(10, 12);
            this.btn_addTeacher.Name = "btn_addTeacher";
            this.btn_addTeacher.Size = new System.Drawing.Size(92, 40);
            this.btn_addTeacher.TabIndex = 0;
            this.btn_addTeacher.UseVisualStyleBackColor = false;
            this.btn_addTeacher.Click += new System.EventHandler(this.btn_addTeacher_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.pnl_teacher_table);
            this.Controls.Add(this.pnl_teacher_controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.pnl_teacher_controls.ResumeLayout(false);
            this.pnl_teacher_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_teacher_controls;
        private System.Windows.Forms.Panel pnl_teacher_table;
        private System.Windows.Forms.Button btn_addTeacher;
        private System.Windows.Forms.Button btn_viewteacherdata;
        private System.Windows.Forms.Button btn_searchteacher;
        private System.Windows.Forms.TextBox tb_searchteacher;
        private System.Windows.Forms.Button btn_editTeacher;
        private System.Windows.Forms.Button btn_deleteTeacher;
    }
}