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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
            viewStudents();
        }
        public void viewStudents()
        {
            dgv_studentdata.DataSource = viewData();
            dgv_studentdata.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgv_studentdata.EnableHeadersVisualStyles = false;
            dgv_studentdata.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_studentdata.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgv_studentdata.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_studentdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_studentdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public DataTable viewData()
        {
            DataTable dataTable = new DataTable();
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = "select * from students";
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
