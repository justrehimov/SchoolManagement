using MySql.Data.MySqlClient;
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
    public partial class ResultStudent : Form
    {
        string id;
        string classname;
        public ResultStudent(string id)
        {
            InitializeComponent();
            this.id = id;
            loadResult();
            loadclassresults();
            
        }
        public void loadResult()
        {
            Database db = new Database();
            string[] data = db.getidData(id, "student");
            lbl_result.Text = "Avarage point of " + db.getidData(id, "student")[4];
            classname = db.getidData(id, "student")[4];
        }
        public void loadclassresults()
        {
            dgw_classresult.DataSource = viewData();
            dgw_classresult.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgw_classresult.EnableHeadersVisualStyles = false;
            dgw_classresult.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgw_classresult.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgw_classresult.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgw_classresult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_classresult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public DataTable viewData()
        {
            DataTable dataTable = new DataTable();
            try
            {
           
                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = String.Format("select * from {0} where id='{1}'", classname,id);
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ViewData Error");
            }

            return dataTable;
        }
    }
}
