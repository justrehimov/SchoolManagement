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
    public partial class Worker : Form
    {

        public Worker()
        {
            InitializeComponent();
            callWorker();
            btn_search_worker.Enabled = false;
            tb_search_worker.ReadOnly = true;
        }
        public void callWorker()
        {
            if (this.pnl_worker_table.Controls.Count > 0)
                this.pnl_worker_table.Controls.RemoveAt(0);
            WorkerAdd worker = new WorkerAdd();
            worker.TopLevel = false;
            worker.Dock = DockStyle.Fill;
            this.pnl_worker_table.Controls.Add(worker);
            this.pnl_worker_table.Tag = worker;
            worker.Show();
        }
        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            callWorker();
            btn_search_worker.Enabled = false;
            tb_search_worker.ReadOnly = true;
            tb_search_worker.Enabled = false;
            tb_search_worker.Text = "Enter name";
            tb_search_worker.ForeColor = Color.Silver;
        }
        
        private void btn_view_worker_Click(object sender, EventArgs e)
        {
            btn_search_worker.Enabled = true;
            tb_search_worker.ReadOnly = false;
            tb_search_worker.Enabled = true;
            if (this.pnl_worker_table.Controls.Count > 0)
                this.pnl_worker_table.Controls.RemoveAt(0);
            ViewWorker viewWorker = new ViewWorker();
            viewWorker.TopLevel = false;
            viewWorker.Dock = DockStyle.Fill;
            this.pnl_worker_table.Controls.Add(viewWorker);
            this.pnl_worker_table.Tag = viewWorker;
            viewWorker.Show();
        }

        private void tb_search_worker_Click(object sender, EventArgs e)
        {
            tb_search_worker.Text = "";
            tb_search_worker.ForeColor = Color.Black;
        }

        private void btn_editWorker_Click(object sender, EventArgs e)
        {
            btn_search_worker.Enabled = false;
            tb_search_worker.ReadOnly = true;
            tb_search_worker.Enabled = false;
            tb_search_worker.Text = "Enter name";
            tb_search_worker.ForeColor = Color.Silver;

            if (this.pnl_worker_table.Controls.Count > 0)
                this.pnl_worker_table.Controls.RemoveAt(0);
            EditWorker editworker = new EditWorker();
            editworker.TopLevel = false;
            editworker.Dock = DockStyle.Fill;
            this.pnl_worker_table.Controls.Add(editworker);
            this.pnl_worker_table.Tag = editworker;
            editworker.Show();
        }
        public static string searchtext = null;
        private  void btn_search_worker_Click(object sender, EventArgs e)
        {
            searchtext = tb_search_worker.Text.Trim();
            if (this.pnl_worker_table.Controls.Count > 0)
                this.pnl_worker_table.Controls.RemoveAt(0);
            SearchWorker student = new SearchWorker(searchtext);
            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            this.pnl_worker_table.Controls.Add(student);
            this.pnl_worker_table.Tag = student;
            student.Show();
        }
        
    }
}
