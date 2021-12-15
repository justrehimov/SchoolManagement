
namespace SchoolManagementSystem
{
    partial class StudentPanel
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
            this.pnl_student = new System.Windows.Forms.Panel();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.tb_result_color = new System.Windows.Forms.TextBox();
            this.tb_home_color = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_student
            // 
            this.pnl_student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_student.Location = new System.Drawing.Point(230, 0);
            this.pnl_student.Name = "pnl_student";
            this.pnl_student.Size = new System.Drawing.Size(570, 537);
            this.pnl_student.TabIndex = 1;
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pnl_sidebarstudent;
            this.pnl_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_sidebar.Controls.Add(this.tb_result_color);
            this.pnl_sidebar.Controls.Add(this.tb_home_color);
            this.pnl_sidebar.Controls.Add(this.btn_exit);
            this.pnl_sidebar.Controls.Add(this.btn_logout);
            this.pnl_sidebar.Controls.Add(this.btn_point);
            this.pnl_sidebar.Controls.Add(this.btn_home);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(230, 537);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // tb_result_color
            // 
            this.tb_result_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_result_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_result_color.Enabled = false;
            this.tb_result_color.Location = new System.Drawing.Point(220, 133);
            this.tb_result_color.Multiline = true;
            this.tb_result_color.Name = "tb_result_color";
            this.tb_result_color.Size = new System.Drawing.Size(10, 61);
            this.tb_result_color.TabIndex = 9;
            this.tb_result_color.Visible = false;
            // 
            // tb_home_color
            // 
            this.tb_home_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_home_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_home_color.Enabled = false;
            this.tb_home_color.Location = new System.Drawing.Point(220, 62);
            this.tb_home_color.Multiline = true;
            this.tb_home_color.Name = "tb_home_color";
            this.tb_home_color.Size = new System.Drawing.Size(10, 61);
            this.tb_home_color.TabIndex = 8;
            this.tb_home_color.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(12, 265);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(189, 54);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(12, 198);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(189, 54);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.Color.Transparent;
            this.btn_point.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_point.FlatAppearance.BorderSize = 0;
            this.btn_point.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_point.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_point.Location = new System.Drawing.Point(12, 133);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(189, 54);
            this.btn_point.TabIndex = 5;
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(3, 73);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(189, 50);
            this.btn_home.TabIndex = 4;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.pnl_student);
            this.Controls.Add(this.pnl_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPanel";
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_student;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox tb_result_color;
        private System.Windows.Forms.TextBox tb_home_color;
    }
}