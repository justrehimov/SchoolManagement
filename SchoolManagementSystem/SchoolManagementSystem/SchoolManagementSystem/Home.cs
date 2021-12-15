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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Database db = new Database();
            int[] count = db.GetCountPersonal();
            lbl_tchcount.Text = count[0].ToString();
            lbl_stdcount.Text = count[1].ToString();
            lbl_workercount.Text = count[2].ToString();
        }
    }
}
