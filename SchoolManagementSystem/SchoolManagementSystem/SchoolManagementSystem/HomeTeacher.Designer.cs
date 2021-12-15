
namespace SchoolManagementSystem
{
    partial class HomeTeacher
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
            this.tb_professiongender = new System.Windows.Forms.TextBox();
            this.tb_emailId = new System.Windows.Forms.TextBox();
            this.tb_namesurname = new System.Windows.Forms.TextBox();
            this.pnl_teacher = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tb_professiongender
            // 
            this.tb_professiongender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.tb_professiongender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_professiongender.Enabled = false;
            this.tb_professiongender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_professiongender.Location = new System.Drawing.Point(65, 448);
            this.tb_professiongender.Multiline = true;
            this.tb_professiongender.Name = "tb_professiongender";
            this.tb_professiongender.ReadOnly = true;
            this.tb_professiongender.Size = new System.Drawing.Size(493, 39);
            this.tb_professiongender.TabIndex = 6;
            // 
            // tb_emailId
            // 
            this.tb_emailId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.tb_emailId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_emailId.Enabled = false;
            this.tb_emailId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_emailId.Location = new System.Drawing.Point(65, 392);
            this.tb_emailId.Multiline = true;
            this.tb_emailId.Name = "tb_emailId";
            this.tb_emailId.ReadOnly = true;
            this.tb_emailId.Size = new System.Drawing.Size(493, 39);
            this.tb_emailId.TabIndex = 5;
            // 
            // tb_namesurname
            // 
            this.tb_namesurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.tb_namesurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_namesurname.Enabled = false;
            this.tb_namesurname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namesurname.Location = new System.Drawing.Point(65, 337);
            this.tb_namesurname.Multiline = true;
            this.tb_namesurname.Name = "tb_namesurname";
            this.tb_namesurname.ReadOnly = true;
            this.tb_namesurname.Size = new System.Drawing.Size(493, 39);
            this.tb_namesurname.TabIndex = 4;
            // 
            // pnl_teacher
            // 
            this.pnl_teacher.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.teacher;
            this.pnl_teacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_teacher.Location = new System.Drawing.Point(12, 12);
            this.pnl_teacher.Name = "pnl_teacher";
            this.pnl_teacher.Size = new System.Drawing.Size(546, 270);
            this.pnl_teacher.TabIndex = 7;
            // 
            // HomeTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.std_tch_homeback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 537);
            this.Controls.Add(this.pnl_teacher);
            this.Controls.Add(this.tb_professiongender);
            this.Controls.Add(this.tb_emailId);
            this.Controls.Add(this.tb_namesurname);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeTeacher";
            this.Text = "HomeTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_professiongender;
        private System.Windows.Forms.TextBox tb_emailId;
        private System.Windows.Forms.TextBox tb_namesurname;
        private System.Windows.Forms.Panel pnl_teacher;
    }
}