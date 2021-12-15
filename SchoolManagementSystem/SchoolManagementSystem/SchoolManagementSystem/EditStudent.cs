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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btn_searchID_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tb_ID.Text.Trim();
                Database db = new Database();
                string[] datarr = db.getidData(id, "student");
                if (datarr != null)
                {
                    tb_name.Text = datarr[0];
                    tb_surname.Text = datarr[1];
                    tb_email.Text = datarr[2];
                    tb_password.Text = datarr[3];
                    string classname = datarr[4];
                    cb_grade.Text = classname.Split(' ')[0] + " " + classname.Split(' ')[1];
                    cb_grade_type.Text = classname.Split(' ')[2];
                }
                else
                {
                    MessageBox.Show("Student data not found!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Student data not found!");
            }
        }

        private void btn_editstudent_data_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.setData(tb_email.Text.Trim(), tb_password.Text.Trim(), cb_grade.Text.Trim().Split(' ')[0] + cb_grade.Text.Trim().Split(' ')[1] + cb_grade_type.Text, "student", tb_ID.Text.Trim());
                MessageBox.Show("Student data successfully changed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Edit student Error");
            }
        }
    }
}
