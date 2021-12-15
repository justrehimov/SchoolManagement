using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    public partial class ViewTeacher : Form
    {
        public ViewTeacher()
        {
            InitializeComponent();
            viewTeachers();
            
        }
        public void viewTeachers()
        {
            dgw_teacherdata.DataSource = viewData();
            dgw_teacherdata.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgw_teacherdata.EnableHeadersVisualStyles = false;
            dgw_teacherdata.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgw_teacherdata.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgw_teacherdata.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgw_teacherdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_teacherdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public DataTable viewData()
        {
            DataTable dataTable = new DataTable();
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = "select * from teachers";
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
