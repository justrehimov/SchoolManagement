using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            loadHome();
        }
        private void loadHome()
        {
            if (this.pnl_multiple.Controls.Count > 0)
                this.pnl_multiple.Controls.RemoveAt(0);
            Home home = new Home();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            this.pnl_multiple.Controls.Add(home);
            this.pnl_multiple.Tag = home;
            home.Show();
            tb_teacher_color.Visible = false;
            tb_student_color.Visible = false;
            tb_worker_color.Visible = false;
            tb_subject_color.Visible = false;
            tb_settings_color.Visible = false;
            tb_home_color.Visible = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            if (this.pnl_multiple.Controls.Count > 0)
                this.pnl_multiple.Controls.RemoveAt(0);
            Teacher teacher = new Teacher();
            teacher.TopLevel = false;
            teacher.Dock = DockStyle.Fill;
            this.pnl_multiple.Controls.Add(teacher);
            this.pnl_multiple.Tag = teacher;
            teacher.Show();

            tb_home_color.Visible = false;
            tb_student_color.Visible = false;
            tb_worker_color.Visible = false;
            tb_subject_color.Visible = false;
            tb_settings_color.Visible = false;
            tb_teacher_color.Visible = true;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            loadHome();
            
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            if (this.pnl_multiple.Controls.Count > 0)
                this.pnl_multiple.Controls.RemoveAt(0);
            Student student = new Student();
            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            this.pnl_multiple.Controls.Add(student);
            this.pnl_multiple.Tag = student;
            student.Show();

            tb_home_color.Visible = false;
            tb_teacher_color.Visible = false;
            tb_worker_color.Visible = false;
            tb_subject_color.Visible = false;
            tb_settings_color.Visible = false;
            tb_student_color.Visible = true;
        }

        private void btn_worker_Click(object sender, EventArgs e)
        {
            if (this.pnl_multiple.Controls.Count > 0)
                this.pnl_multiple.Controls.RemoveAt(0);
            Worker worker = new Worker();
            worker.TopLevel = false;
            worker.Dock = DockStyle.Fill;
            this.pnl_multiple.Controls.Add(worker);
            this.pnl_multiple.Tag = worker;
            worker.Show();

            tb_home_color.Visible = false;
            tb_teacher_color.Visible = false;
            tb_student_color.Visible = false;
            tb_subject_color.Visible = false;
            tb_settings_color.Visible = false;
            tb_worker_color.Visible = true;
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            if (this.pnl_multiple.Controls.Count > 0)
                this.pnl_multiple.Controls.RemoveAt(0);
            Subject subject = new Subject();
            subject.TopLevel = false;
            subject.Dock = DockStyle.Fill;
            this.pnl_multiple.Controls.Add(subject);
            this.pnl_multiple.Tag = subject;
            subject.Show();

            tb_home_color.Visible = false;
            tb_teacher_color.Visible = false;
            tb_student_color.Visible = false;
            tb_worker_color.Visible = false;
            tb_settings_color.Visible = false;
            tb_subject_color.Visible = true;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (this.pnl_multiple.Controls.Count > 0)
                this.pnl_multiple.Controls.RemoveAt(0);
            AdminSettings adminSettings = new AdminSettings();
            adminSettings.TopLevel = false;
            adminSettings.Dock = DockStyle.Fill;
            this.pnl_multiple.Controls.Add(adminSettings);
            this.pnl_multiple.Tag = adminSettings;
            adminSettings.Show();

            tb_home_color.Visible = false;
            tb_teacher_color.Visible = false;
            tb_student_color.Visible = false;
            tb_worker_color.Visible = false;
            tb_subject_color.Visible = false;
            tb_settings_color.Visible = true;
        }
    }
}
