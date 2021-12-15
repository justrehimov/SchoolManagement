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
    public partial class HomeTeacher : Form
    {
        string id;
        public HomeTeacher(string id)
        {
            InitializeComponent();
            this.id = id;
            loadData();
            
        }
        public void loadData()
        {
            Database db = new Database();
            string[] dataarr = db.getidData(id, "teacher");
            tb_namesurname.Text = "Name:" + dataarr[0] + "          Surname:" + dataarr[1];
            tb_emailId.Text = "Email:" + dataarr[2] + "         Password:" + dataarr[3];
            tb_professiongender.Text = "Profession:" + dataarr[4] + "            Id:" + id;
        }
    }
}
