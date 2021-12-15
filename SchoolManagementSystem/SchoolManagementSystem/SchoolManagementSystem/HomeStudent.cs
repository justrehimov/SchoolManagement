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
    public partial class HomeStudent : Form
    {
        string id;
        public HomeStudent(string id)
        {
            InitializeComponent();
            this.id = id;
            loadData();
        }

        public void loadData()
        {
            Database db = new Database();
            string[] dataarr = db.getidData(id, "student");
            tb_namesurname.Text = "Name:" + dataarr[0] + "          Surname:" + dataarr[1];
            tb_emailId.Text = "Email:" + dataarr[2] + "         Password:" + dataarr[3];
            tb_classgender.Text = "Class:" + dataarr[4] + "         Id:" + id;
        }
    }
}
