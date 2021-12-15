
namespace SchoolManagementSystem
{
    partial class PointTeacher
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
            this.tb_point = new System.Windows.Forms.TextBox();
            this.btn_searchid = new System.Windows.Forms.Button();
            this.btn_editpoint = new System.Windows.Forms.Button();
            this.lbl_nmaesurname = new System.Windows.Forms.Label();
            this.lbl_point = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_namesurname
            // 
            this.tb_namesurname.BackColor = System.Drawing.Color.White;
            this.tb_namesurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_namesurname.Enabled = false;
            this.tb_namesurname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namesurname.Location = new System.Drawing.Point(45, 150);
            this.tb_namesurname.Multiline = true;
            this.tb_namesurname.Name = "tb_namesurname";
            this.tb_namesurname.Size = new System.Drawing.Size(465, 25);
            this.tb_namesurname.TabIndex = 1;
            // 
            // tb_point
            // 
            this.tb_point.BackColor = System.Drawing.Color.White;
            this.tb_point.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_point.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_point.Location = new System.Drawing.Point(49, 245);
            this.tb_point.Multiline = true;
            this.tb_point.Name = "tb_point";
            this.tb_point.Size = new System.Drawing.Size(135, 23);
            this.tb_point.TabIndex = 2;
            // 
            // btn_searchid
            // 
            this.btn_searchid.BackColor = System.Drawing.Color.Transparent;
            this.btn_searchid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(212)))));
            this.btn_searchid.FlatAppearance.BorderSize = 0;
            this.btn_searchid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_searchid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_searchid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchid.ForeColor = System.Drawing.Color.Transparent;
            this.btn_searchid.Location = new System.Drawing.Point(320, 44);
            this.btn_searchid.Name = "btn_searchid";
            this.btn_searchid.Size = new System.Drawing.Size(137, 35);
            this.btn_searchid.TabIndex = 3;
            this.btn_searchid.UseVisualStyleBackColor = false;
            this.btn_searchid.Click += new System.EventHandler(this.btn_searchid_Click);
            // 
            // btn_editpoint
            // 
            this.btn_editpoint.BackColor = System.Drawing.Color.Transparent;
            this.btn_editpoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(153)))), ((int)(((byte)(211)))));
            this.btn_editpoint.FlatAppearance.BorderSize = 0;
            this.btn_editpoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_editpoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_editpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editpoint.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editpoint.ForeColor = System.Drawing.Color.White;
            this.btn_editpoint.Location = new System.Drawing.Point(223, 235);
            this.btn_editpoint.Name = "btn_editpoint";
            this.btn_editpoint.Size = new System.Drawing.Size(287, 35);
            this.btn_editpoint.TabIndex = 4;
            this.btn_editpoint.UseVisualStyleBackColor = false;
            this.btn_editpoint.Click += new System.EventHandler(this.btn_editpoint_Click);
            // 
            // lbl_nmaesurname
            // 
            this.lbl_nmaesurname.AutoSize = true;
            this.lbl_nmaesurname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nmaesurname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nmaesurname.ForeColor = System.Drawing.Color.Black;
            this.lbl_nmaesurname.Location = new System.Drawing.Point(42, 117);
            this.lbl_nmaesurname.Name = "lbl_nmaesurname";
            this.lbl_nmaesurname.Size = new System.Drawing.Size(190, 16);
            this.lbl_nmaesurname.TabIndex = 5;
            this.lbl_nmaesurname.Text = "Student name and surname";
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.BackColor = System.Drawing.Color.Transparent;
            this.lbl_point.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_point.ForeColor = System.Drawing.Color.Black;
            this.lbl_point.Location = new System.Drawing.Point(42, 212);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(121, 16);
            this.lbl_point.TabIndex = 6;
            this.lbl_point.Text = "Edit English point";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.White;
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(100, 54);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(214, 25);
            this.tb_id.TabIndex = 7;
            // 
            // PointTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pointbck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 537);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.lbl_nmaesurname);
            this.Controls.Add(this.btn_editpoint);
            this.Controls.Add(this.btn_searchid);
            this.Controls.Add(this.tb_point);
            this.Controls.Add(this.tb_namesurname);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PointTeacher";
            this.Text = "PointTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_namesurname;
        private System.Windows.Forms.TextBox tb_point;
        private System.Windows.Forms.Button btn_searchid;
        private System.Windows.Forms.Button btn_editpoint;
        private System.Windows.Forms.Label lbl_nmaesurname;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.TextBox tb_id;
    }
}