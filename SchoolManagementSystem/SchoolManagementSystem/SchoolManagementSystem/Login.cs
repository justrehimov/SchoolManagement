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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
            db = new Database();
            db.createTables();
            db.createAdmin();
            rb_admin.Checked = true;
        }
        Database db;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string logintype;
            if (!rb_admin.Checked)
            {
                logintype = rb_teacher.Checked ? "teacher" : "student";
            }
            else
            {
                logintype = "admin";
            }
            if (db.hasUser(tb_ID.Text.Trim(), tb_password.Text.Trim(), logintype))
            {
                if (logintype == "admin")
                {
                    this.Hide();
                    var admin = new Admin();
                    admin.Closed += (s, args) => this.Close();
                    admin.Show();
                }
                else if(logintype == "teacher")
                {
                    this.Hide();
                    var teacher = new TeacherPanel(tb_ID.Text);
                    teacher.Closed += (s, args) => this.Close();
                    teacher.Show();
                }
                else if (logintype == "student")
                {
                    this.Hide();
                    var student = new StudentPanel(tb_ID.Text);
                    student.Closed += (s, args) => this.Close();
                    student.Show();
                }

            }
            else
            {
                MessageBox.Show("Id or Password isn't correct");
            }
        }
    }
}
