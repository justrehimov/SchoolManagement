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
    public partial class WorkerAdd : Form
    {
        public WorkerAdd()
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
        public bool checkTb()
        {
            foreach (TextBox control in Controls.OfType<TextBox>())
            {
                
                if((control).Text.Trim() == "")
                {
                    return false;
                }

            }
            return true;
        }
        private void btn_addworker_Click(object sender, EventArgs e)
        {
            if (checkTb())
            {
                string gender = (rb_male.Checked) ? "Male" : "Female";
                Database db = new Database();
                db.addWorker(tb_name.Text.Trim(), tb_surname.Text.Trim(), cb_profession.Text.Trim(), tb_phone.Text.Trim(), tb_email.Text.Trim(), dtp.Value.ToShortDateString().Trim(), gender);
                MessageBox.Show("Worker data successfully added!");
                clearTb();
            }
            else
            {
                MessageBox.Show("Data cannot be empty");

            }
        }
    }
}
