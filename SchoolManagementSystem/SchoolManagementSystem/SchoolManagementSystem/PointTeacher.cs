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
    public partial class PointTeacher : Form
    {
        
        string id;
        string[] studentdata = null;
        public PointTeacher(string id)
        {
            InitializeComponent();
            this.id = id;
            changelabelText();
            
        }

        public void changelabelText()
        {
            Database db = new Database();
            lbl_point.Text = "Edit " + db.getidData(id, "teacher")[4] + " point";
        }
        private void btn_searchid_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            studentdata = db.getidData(tb_id.Text.Trim(),"student");
            tb_namesurname.Text = studentdata[0]+ " " + studentdata[1];
        }

        private void btn_editpoint_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                if (tb_point.Text != null && tb_point.Text != "")
                {
                    bool trueteacher = false;
                    string[] subjects = db.getClass(studentdata[4]).Split(' ');
                    string teacherprofession = db.getidData(id, "teacher")[4];
                    string newclassname = studentdata[4];
                    for (int i = 0; i < subjects.Length; i++)
                    {
                        if (subjects[i] == teacherprofession)
                        {
                            trueteacher = true;
                        }
                    }
                    if (db.setavargepoint(tb_point.Text.Trim(), db.getidData(id, "teacher")[4],newclassname,tb_id.Text.Trim()) && trueteacher)
                    {
                        MessageBox.Show("Average point successfuly changed");
                    }
                    else
                    { 

                        MessageBox.Show("Please,try another class.You are not teacher in this class");
                    }
                }
                else
                {
                    MessageBox.Show("Point cannot be empty!");
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Set point Error");
            }
        }
    }
}
