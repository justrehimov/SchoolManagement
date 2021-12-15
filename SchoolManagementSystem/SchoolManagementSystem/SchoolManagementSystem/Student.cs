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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            callStudent();
            btn_search_student.Enabled = false;
            tb_search_student.ReadOnly = true;
        }
        public void callStudent()
        {
            if (this.pnl_student_table.Controls.Count > 0)
                this.pnl_student_table.Controls.RemoveAt(0);
            StudentAdd student = new StudentAdd();
            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            this.pnl_student_table.Controls.Add(student);
            this.pnl_student_table.Tag = student;
            student.Show();
        }

        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            callStudent();
            btn_search_student.Enabled = false;
            tb_search_student.ReadOnly = true;
            tb_search_student.Enabled = false;
            tb_search_student.Text = "Enter name";
            tb_search_student.ForeColor = Color.Silver;
        }

        private void btn_view_student_Click(object sender, EventArgs e)
        {
            btn_search_student.Enabled = true;
            btn_search_student.Enabled = true;
            tb_search_student.ReadOnly = false;
            tb_search_student.Enabled = true;
            if (this.pnl_student_table.Controls.Count > 0)
                this.pnl_student_table.Controls.RemoveAt(0);
            ViewStudent student = new ViewStudent();
            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            this.pnl_student_table.Controls.Add(student);
            this.pnl_student_table.Tag = student;
            student.Show();
        }

        private void tb_search_student_Click(object sender, EventArgs e)
        {
            tb_search_student.Text = "";
            tb_search_student.ForeColor = Color.Black;
        }

        private void btn_editStudent_Click(object sender, EventArgs e)
        {
            btn_search_student.Enabled = false;
            tb_search_student.ReadOnly = true;
            tb_search_student.Enabled = false;
            tb_search_student.Text = "Enter name";
            tb_search_student.ForeColor = Color.Silver;

            if (this.pnl_student_table.Controls.Count > 0)
                this.pnl_student_table.Controls.RemoveAt(0);
            EditStudent editstudent = new EditStudent();
            editstudent.TopLevel = false;
            editstudent.Dock = DockStyle.Fill;
            this.pnl_student_table.Controls.Add(editstudent);
            this.pnl_student_table.Tag = editstudent;
            editstudent.Show();
        }

        private void btn_deletstudent_Click(object sender, EventArgs e)
        {
            btn_search_student.Enabled = false;
            tb_search_student.ReadOnly = true;
            tb_search_student.Enabled = false;
            tb_search_student.Text = "Enter name";
            tb_search_student.ForeColor = Color.Silver;

            if (this.pnl_student_table.Controls.Count > 0)
                this.pnl_student_table.Controls.RemoveAt(0);
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.TopLevel = false;
            deleteStudent.Dock = DockStyle.Fill;
            this.pnl_student_table.Controls.Add(deleteStudent);
            this.pnl_student_table.Tag = deleteStudent;
            deleteStudent.Show();
        }
        public static string searchtext = null;
        private void btn_search_student_Click(object sender, EventArgs e)
        {
            searchtext = tb_search_student.Text.Trim();
            if (this.pnl_student_table.Controls.Count > 0)
                this.pnl_student_table.Controls.RemoveAt(0);
            SearchStudent student = new SearchStudent(searchtext);
            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            this.pnl_student_table.Controls.Add(student);
            this.pnl_student_table.Tag = student;
            student.Show();
        }
    }
}
