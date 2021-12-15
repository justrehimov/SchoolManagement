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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            callTeacher();
            btn_searchteacher.Enabled = false;
            tb_searchteacher.ReadOnly = true;
        }
        public void callTeacher()
        {
            if (this.pnl_teacher_table.Controls.Count > 0)
                this.pnl_teacher_table.Controls.RemoveAt(0);
            TeacherAdd teacher = new TeacherAdd();
            teacher.TopLevel = false;
            teacher.Dock = DockStyle.Fill;
            this.pnl_teacher_table.Controls.Add(teacher);
            this.pnl_teacher_table.Tag = teacher;
            teacher.Show();
        }
        private void btn_addTeacher_Click(object sender, EventArgs e)
        {
            callTeacher();
            btn_searchteacher.Enabled = false;
            tb_searchteacher.ReadOnly = true;
            tb_searchteacher.Enabled = false;
            tb_searchteacher.Text = "Enter name";
            tb_searchteacher.ForeColor = Color.Silver;
        }

        private void btn_viewteacherdata_Click(object sender, EventArgs e)
        {
            btn_searchteacher.Enabled = true;
            tb_searchteacher.ReadOnly = false;
            tb_searchteacher.Enabled = true;
            if (this.pnl_teacher_table.Controls.Count > 0)
                this.pnl_teacher_table.Controls.RemoveAt(0);
            ViewTeacher viewTeacher = new ViewTeacher();
            viewTeacher.TopLevel = false;
            viewTeacher.Dock = DockStyle.Fill;
            this.pnl_teacher_table.Controls.Add(viewTeacher);
            this.pnl_teacher_table.Tag = viewTeacher;
            viewTeacher.Show();
        }

        private void tb_searchteacher_Click(object sender, EventArgs e)
        {
            tb_searchteacher.Text = "";
            tb_searchteacher.ForeColor = Color.Black;
        }

        private void btn_editTeacher_Click(object sender, EventArgs e)
        {
            btn_searchteacher.Enabled = false;
            tb_searchteacher.ReadOnly = true;
            tb_searchteacher.Enabled = false;
            tb_searchteacher.Text = "Enter name";
            tb_searchteacher.ForeColor = Color.Silver;

            if (this.pnl_teacher_table.Controls.Count > 0)
                this.pnl_teacher_table.Controls.RemoveAt(0);
            EditTeacher editteacher = new EditTeacher();
            editteacher.TopLevel = false;
            editteacher.Dock = DockStyle.Fill;
            this.pnl_teacher_table.Controls.Add(editteacher);
            this.pnl_teacher_table.Tag = editteacher;
            editteacher.Show();
        }

        private void btn_deleteTeacher_Click(object sender, EventArgs e)
        {
            btn_searchteacher.Enabled = false;
            tb_searchteacher.ReadOnly = true;
            tb_searchteacher.Enabled = false;
            tb_searchteacher.Text = "Enter name";
            tb_searchteacher.ForeColor = Color.Silver;

            if (this.pnl_teacher_table.Controls.Count > 0)
                this.pnl_teacher_table.Controls.RemoveAt(0);
            DeleteTeacher deleteTeacher = new DeleteTeacher();
            deleteTeacher.TopLevel = false;
            deleteTeacher.Dock = DockStyle.Fill;
            this.pnl_teacher_table.Controls.Add(deleteTeacher);
            this.pnl_teacher_table.Tag = deleteTeacher;
            deleteTeacher.Show();
        }
        public static string searchtext = null;
        private void btn_searchteacher_Click(object sender, EventArgs e)
        {
            searchtext = tb_searchteacher.Text.Trim();
            if (this.pnl_teacher_table.Controls.Count > 0)
                this.pnl_teacher_table.Controls.RemoveAt(0);
            SearchTeacher viewTeacher = new SearchTeacher(searchtext);
            viewTeacher.TopLevel = false;
            viewTeacher.Dock = DockStyle.Fill;
            this.pnl_teacher_table.Controls.Add(viewTeacher);
            this.pnl_teacher_table.Tag = viewTeacher;
            viewTeacher.Show();
        }
    }
}

