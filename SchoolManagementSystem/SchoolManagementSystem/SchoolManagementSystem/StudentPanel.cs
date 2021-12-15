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
    public partial class StudentPanel : Form
    {
        string id;
        public StudentPanel(string id)
        {
            InitializeComponent();
            this.id = id;
            callHome();
            
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            tb_home_color.Visible = false;
            tb_result_color.Visible = true;

            if (this.pnl_student.Controls.Count > 0)
                this.pnl_student.Controls.RemoveAt(0);
            ResultStudent resultstudent = new ResultStudent(id);
            resultstudent.TopLevel = false;
            resultstudent.Dock = DockStyle.Fill;
            this.pnl_student.Controls.Add(resultstudent);
            this.pnl_student.Tag = resultstudent;
            resultstudent.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            callHome();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void callHome()
        {
            tb_home_color.Visible = true;
            tb_result_color.Visible = false;
            if (this.pnl_student.Controls.Count > 0)
                this.pnl_student.Controls.RemoveAt(0);
            HomeStudent homestudent = new HomeStudent(id);
            homestudent.TopLevel = false;
            homestudent.Dock = DockStyle.Fill;
            this.pnl_student.Controls.Add(homestudent);
            this.pnl_student.Tag = homestudent;
            homestudent.Show();
        }

    }
}
