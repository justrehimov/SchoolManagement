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
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if(tb_newpass.Text.Trim() == tb_confirmpass.Text.Trim())
            {
                if (db.changePass(tb_currentpass.Text.Trim(), tb_newpass.Text.Trim())){
                    MessageBox.Show("Password successfully changed");
                }
                else
                {
                    MessageBox.Show("Password was not changed");
                }
            }
            else
            {
                MessageBox.Show("New password doesn't match confirm password");
            }
        }
    }
}
