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
    public partial class TeacherPanel : Form
    {
        public string acceptedid;
        public TeacherPanel(string id)
        {
            InitializeComponent();
            acceptedid = id;
            callHome();
            
        }
        private void btn_point_Click(object sender, EventArgs e)
        {
            tb_home_color.Visible = false;
            tb_point_color.Visible = true;
            if (this.pnl_teacher.Controls.Count > 0)
                this.pnl_teacher.Controls.RemoveAt(0);
            PointTeacher pointTeacher = new PointTeacher(acceptedid);
            pointTeacher.TopLevel = false;
            pointTeacher.Dock = DockStyle.Fill;
            this.pnl_teacher.Controls.Add(pointTeacher);
            this.pnl_teacher.Tag = pointTeacher;
            pointTeacher.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            callHome();
        }
        public void callHome()
        {
            tb_home_color.Visible = true;
            tb_point_color.Visible = false;
            if (this.pnl_teacher.Controls.Count > 0)
                this.pnl_teacher.Controls.RemoveAt(0);
            HomeTeacher homeTeacher = new HomeTeacher(acceptedid);
            homeTeacher.TopLevel = false;
            homeTeacher.Dock = DockStyle.Fill;
            this.pnl_teacher.Controls.Add(homeTeacher);
            this.pnl_teacher.Tag = homeTeacher;
            homeTeacher.Show();
        }
    }
}
