
namespace SchoolManagementSystem
{
    partial class Worker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_worker_table = new System.Windows.Forms.Panel();
            this.pnl_worker_controls = new System.Windows.Forms.Panel();
            this.tb_search_worker = new System.Windows.Forms.TextBox();
            this.btn_editWorker = new System.Windows.Forms.Button();
            this.btn_view_worker = new System.Windows.Forms.Button();
            this.btn_search_worker = new System.Windows.Forms.Button();
            this.btn_addWorker = new System.Windows.Forms.Button();
            this.pnl_worker_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_worker_table
            // 
            this.pnl_worker_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_worker_table.Location = new System.Drawing.Point(0, 64);
            this.pnl_worker_table.Name = "pnl_worker_table";
            this.pnl_worker_table.Size = new System.Drawing.Size(804, 497);
            this.pnl_worker_table.TabIndex = 1;
            // 
            // pnl_worker_controls
            // 
            this.pnl_worker_controls.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pnl_worker_bck;
            this.pnl_worker_controls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_worker_controls.Controls.Add(this.tb_search_worker);
            this.pnl_worker_controls.Controls.Add(this.btn_editWorker);
            this.pnl_worker_controls.Controls.Add(this.btn_view_worker);
            this.pnl_worker_controls.Controls.Add(this.btn_search_worker);
            this.pnl_worker_controls.Controls.Add(this.btn_addWorker);
            this.pnl_worker_controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_worker_controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_worker_controls.Name = "pnl_worker_controls";
            this.pnl_worker_controls.Size = new System.Drawing.Size(804, 64);
            this.pnl_worker_controls.TabIndex = 0;
            // 
            // tb_search_worker
            // 
            this.tb_search_worker.BackColor = System.Drawing.Color.White;
            this.tb_search_worker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search_worker.Enabled = false;
            this.tb_search_worker.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_worker.ForeColor = System.Drawing.Color.Gray;
            this.tb_search_worker.Location = new System.Drawing.Point(474, 22);
            this.tb_search_worker.Multiline = true;
            this.tb_search_worker.Name = "tb_search_worker";
            this.tb_search_worker.ReadOnly = true;
            this.tb_search_worker.Size = new System.Drawing.Size(239, 25);
            this.tb_search_worker.TabIndex = 6;
            this.tb_search_worker.Text = "Enter name";
            this.tb_search_worker.Click += new System.EventHandler(this.tb_search_worker_Click);
            // 
            // btn_editWorker
            // 
            this.btn_editWorker.BackColor = System.Drawing.Color.Transparent;
            this.btn_editWorker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_editWorker.FlatAppearance.BorderSize = 0;
            this.btn_editWorker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_editWorker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_editWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editWorker.Location = new System.Drawing.Point(125, 13);
            this.btn_editWorker.Name = "btn_editWorker";
            this.btn_editWorker.Size = new System.Drawing.Size(98, 39);
            this.btn_editWorker.TabIndex = 9;
            this.btn_editWorker.UseVisualStyleBackColor = false;
            this.btn_editWorker.Click += new System.EventHandler(this.btn_editWorker_Click);
            // 
            // btn_view_worker
            // 
            this.btn_view_worker.BackColor = System.Drawing.Color.Transparent;
            this.btn_view_worker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_view_worker.FlatAppearance.BorderSize = 0;
            this.btn_view_worker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_view_worker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_view_worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_worker.Location = new System.Drawing.Point(250, 12);
            this.btn_view_worker.Name = "btn_view_worker";
            this.btn_view_worker.Size = new System.Drawing.Size(195, 40);
            this.btn_view_worker.TabIndex = 8;
            this.btn_view_worker.UseVisualStyleBackColor = false;
            this.btn_view_worker.Click += new System.EventHandler(this.btn_view_worker_Click);
            // 
            // btn_search_worker
            // 
            this.btn_search_worker.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_worker.Enabled = false;
            this.btn_search_worker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_search_worker.FlatAppearance.BorderSize = 0;
            this.btn_search_worker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_search_worker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_search_worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_worker.Location = new System.Drawing.Point(729, 12);
            this.btn_search_worker.Name = "btn_search_worker";
            this.btn_search_worker.Size = new System.Drawing.Size(54, 40);
            this.btn_search_worker.TabIndex = 7;
            this.btn_search_worker.UseVisualStyleBackColor = false;
            this.btn_search_worker.Click += new System.EventHandler(this.btn_search_worker_Click);
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.BackColor = System.Drawing.Color.Transparent;
            this.btn_addWorker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(125)))), ((int)(((byte)(212)))));
            this.btn_addWorker.FlatAppearance.BorderSize = 0;
            this.btn_addWorker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_addWorker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addWorker.Location = new System.Drawing.Point(10, 12);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(92, 40);
            this.btn_addWorker.TabIndex = 2;
            this.btn_addWorker.UseVisualStyleBackColor = false;
            this.btn_addWorker.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.pnl_worker_table);
            this.Controls.Add(this.pnl_worker_controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Worker";
            this.Text = "Worker";
            this.pnl_worker_controls.ResumeLayout(false);
            this.pnl_worker_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_worker_controls;
        private System.Windows.Forms.Panel pnl_worker_table;
        private System.Windows.Forms.Button btn_addWorker;
        private System.Windows.Forms.Button btn_view_worker;
        private System.Windows.Forms.Button btn_search_worker;
        private System.Windows.Forms.TextBox tb_search_worker;
        private System.Windows.Forms.Button btn_editWorker;
    }
}