
namespace SchoolManagementSystem
{
    partial class TeacherPanel
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
            this.pnl_teacher = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.tb_home_color = new System.Windows.Forms.TextBox();
            this.tb_point_color = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_teacher
            // 
            this.pnl_teacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_teacher.Location = new System.Drawing.Point(230, 0);
            this.pnl_teacher.Name = "pnl_teacher";
            this.pnl_teacher.Size = new System.Drawing.Size(570, 537);
            this.pnl_teacher.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pnlbckteacher;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tb_point_color);
            this.panel1.Controls.Add(this.tb_home_color);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_point);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 537);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(0, 263);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(189, 54);
            this.btn_exit.TabIndex = 3;
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
            this.btn_logout.Location = new System.Drawing.Point(0, 196);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(189, 54);
            this.btn_logout.TabIndex = 2;
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
            this.btn_point.Location = new System.Drawing.Point(0, 131);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(189, 54);
            this.btn_point.TabIndex = 1;
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(0, 71);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(189, 54);
            this.btn_home.TabIndex = 0;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // tb_home_color
            // 
            this.tb_home_color.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tb_home_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_home_color.Enabled = false;
            this.tb_home_color.Location = new System.Drawing.Point(220, 64);
            this.tb_home_color.Multiline = true;
            this.tb_home_color.Name = "tb_home_color";
            this.tb_home_color.Size = new System.Drawing.Size(10, 61);
            this.tb_home_color.TabIndex = 8;
            this.tb_home_color.Visible = false;
            // 
            // tb_point_color
            // 
            this.tb_point_color.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tb_point_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_point_color.Enabled = false;
            this.tb_point_color.Location = new System.Drawing.Point(220, 131);
            this.tb_point_color.Multiline = true;
            this.tb_point_color.Name = "tb_point_color";
            this.tb_point_color.Size = new System.Drawing.Size(10, 61);
            this.tb_point_color.TabIndex = 9;
            this.tb_point_color.Visible = false;
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.pnl_teacher);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_teacher;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox tb_point_color;
        private System.Windows.Forms.TextBox tb_home_color;
    }
}