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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        public bool candelete = false;
        private void btn_searchID_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            tb_namesurname.Text = db.deletePersonal("student", tb_id.Text.Trim());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Students", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Database db = new Database();
                candelete = true;
                db.deletePersonal(candelete, tb_id.Text.Trim(), "student");
                MessageBox.Show("Student deleted");

            }
            else if (dialogResult == DialogResult.No)
            {
                Database db = new Database();
                candelete = false;
                db.deletePersonal(candelete, tb_id.Text.Trim(), "student");
            }
        }
    }
}
