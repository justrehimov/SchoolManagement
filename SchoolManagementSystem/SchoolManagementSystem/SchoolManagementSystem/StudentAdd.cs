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
    public partial class StudentAdd : Form
    {
        public StudentAdd()
        {
            InitializeComponent();
            rb_male.Checked = true;
        }
        public void clearTb()
        {
            foreach (TextBox control in Controls.OfType<TextBox>())
            {
                (control).Text = "";
   
            }
        }
        private void btn_getID_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                Random random = new Random();
                string idText;
                int n = random.Next(100000, 200000);
                idText = "STD" + n.ToString();
                if (!db.usedId(idText, "student"))
                {
                    tb_id.Text = idText;
                    btn_getID.Enabled = false;
                }
                else
                {
                    btn_getID_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Random ID Error");
            }
        }
        public bool checkTb()
        {
            foreach (TextBox control in Controls.OfType<TextBox>())
            {

                if ((control).Text.Trim() == "")
                {
                    return false;
                }

            }
            return true;
        }
        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            if (checkTb())
            {
                string gender = (rb_male.Checked) ? "Male" : "Female";
                Database db = new Database();
                db.addStudent(tb_name.Text.Trim(), tb_surname.Text.Trim(), tb_fathername.Text.Trim(), cb_grade.Text.Trim().Split(' ')[0] + cb_grade.Text.Trim().Split(' ')[1] + cb_grade_type.Text, tb_id.Text.Trim(), tb_email.Text.Trim(), tb_password.Text.Trim(), dtp.Value.ToShortDateString().Trim(), gender);
                MessageBox.Show("Student data successfully added!");
                btn_getID.Enabled = true;
                clearTb();
            }
            else
            {
                MessageBox.Show("Data cannot be empty");

            }

        }
    }
}
