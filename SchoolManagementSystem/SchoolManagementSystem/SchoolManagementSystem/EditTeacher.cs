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
    public partial class EditTeacher : Form
    {
        public EditTeacher()
        {
            InitializeComponent();
        }

        private void btn_searchID_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tb_ID.Text.Trim();
                Database db = new Database();
                string[] datarr = db.getidData(id, "teacher");
                if (datarr != null)
                {
                    tb_name.Text = datarr[0];
                    tb_surname.Text = datarr[1];
                    tb_email.Text = datarr[2];
                    tb_password.Text = datarr[3];
                    cb_profession.Text = datarr[4];
                }
                else
                {
                    MessageBox.Show("Teacher data not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Teacher data not found");
            }
            
        }

        private void editteacher_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.setData(tb_email.Text.Trim(), tb_password.Text.Trim(), cb_profession.Text.Trim(), "teacher", tb_ID.Text.Trim());
                MessageBox.Show("Teacher data successfully changed");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Edit teacher Error");
            }
        }
    }
}

