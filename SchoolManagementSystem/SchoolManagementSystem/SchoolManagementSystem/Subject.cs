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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        string[] subject = null;
        string subjects = "";
        public int count = 0;
        int subjectcount;
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                
                subjectcount = int.Parse(cb_countsubjects.Text.Trim());
                if(subjectcount > count) {
                    if (!(subjects.IndexOf(cb_subjects.Text.Trim()) >= 0) && subjectcount.ToString() != "Subject count" && cb_grade.Text.Trim() !="Grade")
                    {
                        subjects += cb_subjects.Text.Trim() + " ";
                        lbl_subjects.Text ="SUBJECTS:" + subjects;
                        subject = new string[subjectcount];
                        count++;
                    }
                    else
                    {
                        MessageBox.Show("This subject already has been added");
                    }

                }
                else
                {
                    MessageBox.Show("Subject are limited!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Data is not true");
            }
        }
        public bool addsubjecttoArray()
        {
            for (int i = 0; i < subjects.Trim().Split(' ').Length; i++)
            {
                subject[i] = subjects.Trim().Split(' ')[i];
            }
            return true;
        }
        private void btn_addsubject_Click(object sender, EventArgs e)
        {
            
            Database db = new Database();
            string classname = cb_grade.Text.Trim().Split(' ')[0] + cb_grade.Text.Trim().Split(' ')[1] + cb_gradetype.Text;
            if (subjectcount == count)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Add subjects", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (db.checkeismptyclass(classname) && addsubjecttoArray())
                    {

                        db.addSubject(classname, subjects.Trim());
                        db.createResult(classname, subject);
                        MessageBox.Show("Subjects successfully added!");
                    }
                    else
                    {
                        MessageBox.Show("Subjects have already been added to this class");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    subject = null;
                    subjects = "";
                    count = 0;
                    lbl_subjects.Text = "SUBJECTS:";

                }
            }
            else
            {
                MessageBox.Show("Subject count isn't true");
            }
        }

        private void btn_resetsubject_Click(object sender, EventArgs e)
        {
            subject = null;
            subjects = "";
            count = 0;
            lbl_subjects.Text = "SUBJECTS:";
        }
    }
}
