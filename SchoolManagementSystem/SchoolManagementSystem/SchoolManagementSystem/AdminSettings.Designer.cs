
namespace SchoolManagementSystem
{
    partial class AdminSettings
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
            this.lbl_newpass = new System.Windows.Forms.Label();
            this.lbl_currentpass = new System.Windows.Forms.Label();
            this.lbl_confirmpass = new System.Windows.Forms.Label();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.tb_confirmpass = new System.Windows.Forms.TextBox();
            this.tb_currentpass = new System.Windows.Forms.TextBox();
            this.btn_changepass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_newpass
            // 
            this.lbl_newpass.AutoSize = true;
            this.lbl_newpass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_newpass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newpass.ForeColor = System.Drawing.Color.White;
            this.lbl_newpass.Location = new System.Drawing.Point(80, 76);
            this.lbl_newpass.Name = "lbl_newpass";
            this.lbl_newpass.Size = new System.Drawing.Size(103, 16);
            this.lbl_newpass.TabIndex = 1;
            this.lbl_newpass.Text = "New Password";
            // 
            // lbl_currentpass
            // 
            this.lbl_currentpass.AutoSize = true;
            this.lbl_currentpass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentpass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentpass.ForeColor = System.Drawing.Color.White;
            this.lbl_currentpass.Location = new System.Drawing.Point(423, 76);
            this.lbl_currentpass.Name = "lbl_currentpass";
            this.lbl_currentpass.Size = new System.Drawing.Size(124, 16);
            this.lbl_currentpass.TabIndex = 2;
            this.lbl_currentpass.Text = "Current Password";
            // 
            // lbl_confirmpass
            // 
            this.lbl_confirmpass.AutoSize = true;
            this.lbl_confirmpass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmpass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmpass.ForeColor = System.Drawing.Color.White;
            this.lbl_confirmpass.Location = new System.Drawing.Point(80, 173);
            this.lbl_confirmpass.Name = "lbl_confirmpass";
            this.lbl_confirmpass.Size = new System.Drawing.Size(124, 16);
            this.lbl_confirmpass.TabIndex = 3;
            this.lbl_confirmpass.Text = "Confirm Password";
            // 
            // tb_newpass
            // 
            this.tb_newpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.tb_newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_newpass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newpass.Location = new System.Drawing.Point(83, 112);
            this.tb_newpass.Multiline = true;
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(299, 30);
            this.tb_newpass.TabIndex = 4;
            // 
            // tb_confirmpass
            // 
            this.tb_confirmpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.tb_confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_confirmpass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmpass.Location = new System.Drawing.Point(83, 210);
            this.tb_confirmpass.Multiline = true;
            this.tb_confirmpass.Name = "tb_confirmpass";
            this.tb_confirmpass.Size = new System.Drawing.Size(299, 30);
            this.tb_confirmpass.TabIndex = 5;
            // 
            // tb_currentpass
            // 
            this.tb_currentpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.tb_currentpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_currentpass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_currentpass.Location = new System.Drawing.Point(426, 112);
            this.tb_currentpass.Multiline = true;
            this.tb_currentpass.Name = "tb_currentpass";
            this.tb_currentpass.Size = new System.Drawing.Size(299, 30);
            this.tb_currentpass.TabIndex = 6;
            // 
            // btn_changepass
            // 
            this.btn_changepass.BackColor = System.Drawing.Color.Transparent;
            this.btn_changepass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(86)))), ((int)(((byte)(41)))));
            this.btn_changepass.FlatAppearance.BorderSize = 0;
            this.btn_changepass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_changepass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepass.Location = new System.Drawing.Point(426, 196);
            this.btn_changepass.Name = "btn_changepass";
            this.btn_changepass.Size = new System.Drawing.Size(299, 44);
            this.btn_changepass.TabIndex = 7;
            this.btn_changepass.UseVisualStyleBackColor = false;
            this.btn_changepass.Click += new System.EventHandler(this.btn_changepass_Click);
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.adminsettingsbck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.btn_changepass);
            this.Controls.Add(this.tb_currentpass);
            this.Controls.Add(this.tb_confirmpass);
            this.Controls.Add(this.tb_newpass);
            this.Controls.Add(this.lbl_confirmpass);
            this.Controls.Add(this.lbl_currentpass);
            this.Controls.Add(this.lbl_newpass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminSettings";
            this.Text = "AdminSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newpass;
        private System.Windows.Forms.Label lbl_currentpass;
        private System.Windows.Forms.Label lbl_confirmpass;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.TextBox tb_confirmpass;
        private System.Windows.Forms.TextBox tb_currentpass;
        private System.Windows.Forms.Button btn_changepass;
    }
}