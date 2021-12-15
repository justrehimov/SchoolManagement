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
    public partial class EditWorker : Form
    {
        public EditWorker()
        { 
            InitializeComponent();
        }

        private void btn_searchID_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = tb_ID.Text.Trim();
                Database db = new Database();
                string[] datarr = db.getphoneData(phone);
                if (datarr != null)
                {
                    tb_name.Text = datarr[0];
                    tb_surname.Text = datarr[1];
                    tb_email.Text = datarr[2];
                    tb_phone.Text = datarr[3];
                    cb_profession.Text = datarr[4];
                }
                else
                {
                    MessageBox.Show("Worker data not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Worker data not found");
            }

        }

        private void btn_editworker_data_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.setData(tb_email.Text.Trim(), tb_phone.Text.Trim(), cb_profession.Text.Trim(), "worker", tb_ID.Text.Trim());
                MessageBox.Show("Worker data successfully changed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Edit worker Error");
            }
        }
    }
}
