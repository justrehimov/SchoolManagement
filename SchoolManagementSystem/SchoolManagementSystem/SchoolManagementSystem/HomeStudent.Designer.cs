
namespace SchoolManagementSystem
{
    partial class HomeStudent
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
            this.tb_namesurname = new System.Windows.Forms.TextBox();
            this.tb_emailId = new System.Windows.Forms.TextBox();
            this.tb_classgender = new System.Windows.Forms.TextBox();
            this.pnl_stdback = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tb_namesurname
            // 
            this.tb_namesurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.tb_namesurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_namesurname.Enabled = false;
            this.tb_namesurname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namesurname.Location = new System.Drawing.Point(72, 297);
            this.tb_namesurname.Multiline = true;
            this.tb_namesurname.Name = "tb_namesurname";
            this.tb_namesurname.ReadOnly = true;
            this.tb_namesurname.Size = new System.Drawing.Size(486, 39);
            this.tb_namesurname.TabIndex = 0;
            // 
            // tb_emailId
            // 
            this.tb_emailId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.tb_emailId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_emailId.Enabled = false;
            this.tb_emailId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_emailId.Location = new System.Drawing.Point(72, 352);
            this.tb_emailId.Multiline = true;
            this.tb_emailId.Name = "tb_emailId";
            this.tb_emailId.ReadOnly = true;
            this.tb_emailId.Size = new System.Drawing.Size(486, 39);
            this.tb_emailId.TabIndex = 2;
            // 
            // tb_classgender
            // 
            this.tb_classgender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.tb_classgender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_classgender.Enabled = false;
            this.tb_classgender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_classgender.Location = new System.Drawing.Point(72, 408);
            this.tb_classgender.Multiline = true;
            this.tb_classgender.Name = "tb_classgender";
            this.tb_classgender.ReadOnly = true;
            this.tb_classgender.Size = new System.Drawing.Size(486, 39);
            this.tb_classgender.TabIndex = 3;
            // 
            // pnl_stdback
            // 
            this.pnl_stdback.BackgroundImage = global::SchoolManagementSystem.Properties.Resources._100_bck;
            this.pnl_stdback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_stdback.Location = new System.Drawing.Point(12, 12);
            this.pnl_stdback.Name = "pnl_stdback";
            this.pnl_stdback.Size = new System.Drawing.Size(548, 255);
            this.pnl_stdback.TabIndex = 4;
            // 
            // HomeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.std_tch_homeback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 537);
            this.Controls.Add(this.pnl_stdback);
            this.Controls.Add(this.tb_classgender);
            this.Controls.Add(this.tb_emailId);
            this.Controls.Add(this.tb_namesurname);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeStudent";
            this.Text = "HomeStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_namesurname;
        private System.Windows.Forms.TextBox tb_emailId;
        private System.Windows.Forms.TextBox tb_classgender;
        private System.Windows.Forms.Panel pnl_stdback;
    }
}