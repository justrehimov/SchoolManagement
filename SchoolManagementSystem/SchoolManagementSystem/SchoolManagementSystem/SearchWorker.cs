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
    public partial class SearchWorker : Form
    {
        public string searchtext = null;
        public SearchWorker(string searchtext)
        {
            InitializeComponent();
            this.searchtext = searchtext;
            viewWorkers();
        }
        public void viewWorkers()
        {
            if (searchtext == "")
            {
                MessageBox.Show("Name cannot empty");
                
            }
            else
            {
                dgw_workerdata.DataSource = viewData(searchtext);
                dgw_workerdata.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
                dgw_workerdata.EnableHeadersVisualStyles = false;
                dgw_workerdata.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgw_workerdata.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
                dgw_workerdata.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgw_workerdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgw_workerdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                string query = String.Format("select * from workers where name='{0}'", searchtext);
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
