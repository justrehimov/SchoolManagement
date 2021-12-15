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
    public partial class TeacherAdd : Form
    {
        public TeacherAdd()
        {
            InitializeComponent();
            rb_male.Checked = true;
        }
        Database db;

        private void btn_getID_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                Random random = new Random();
                string idText;
                int n = random.Next(100000, 200000);
                idText = "TCH" + n.ToString();
                if (!db.usedId(idText, "teacher"))
                {
                    tb_id.Text = idText;
                    btn_getID.Enabled = false;
                }
                else
                {
                    btn_getID_Click(null, EventArgs.Empty);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Random ID Error");
            }
        }
        public void clearTb()
        {
            foreach (TextBox control in Controls.OfType<TextBox>())
            {
                (control).Text = "";

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
        private void add_teacher_Click(object sender, EventArgs e)
        {
            if (checkTb())
            {
                string gender = (rb_male.Checked) ? "Male" : "Female";
                Database db = new Database();
                db.addTeacher(tb_name.Text.Trim(), tb_surname.Text.Trim(), cb_profession.Text.Trim(), tb_phone.Text.Trim(), tb_id.Text.Trim(), tb_email.Text.Trim(), tb_password.Text.Trim(), dtp.Value.ToShortDateString().Trim(), gender);
                MessageBox.Show("Teacher data successfully added!");
                clearTb();
                btn_getID.Enabled = true;
            }
            else
            {
                MessageBox.Show("Data cannot be empty");
            }
            
        }
    }
}

