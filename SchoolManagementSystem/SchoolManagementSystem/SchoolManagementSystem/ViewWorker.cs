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
    public partial class ViewWorker : Form
    {
        public ViewWorker()
        {
            InitializeComponent();
            viewWorkers();
        }
        public void viewWorkers()
        {
            dgv_worker_data.DataSource = viewData();
            dgv_worker_data.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgv_worker_data.EnableHeadersVisualStyles = false;
            dgv_worker_data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_worker_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgv_worker_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_worker_data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_worker_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public DataTable viewData()
        {
            DataTable dataTable = new DataTable();
            try
            {

                string conString = "server=localhost;port=3306;uid=root;password=123456789;database=schooldb;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = "select * from workers";
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
