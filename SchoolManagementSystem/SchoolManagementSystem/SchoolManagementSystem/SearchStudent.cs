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
    public partial class SearchStudent : Form
    {
        public string searchtext = null;
        public SearchStudent(string searchtext)
        {
            this.searchtext = searchtext;
            InitializeComponent();
            viewStudents();
        }
        public void viewStudents()
        {
            if (searchtext == "")
            {
                MessageBox.Show("Name cannot empty");
            }
            else
            {
                dgw_studentdata.DataSource = viewData(searchtext);
                dgw_studentdata.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
                dgw_studentdata.EnableHeadersVisualStyles = false;
                dgw_studentdata.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgw_studentdata.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
                dgw_studentdata.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgw_studentdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgw_studentdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            
        }
        public DataTable viewData(string searchtext)
        {
            DataTable dataTable = new DataTable();
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = String.Format("select * from students where name='{0}'", searchtext);
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
