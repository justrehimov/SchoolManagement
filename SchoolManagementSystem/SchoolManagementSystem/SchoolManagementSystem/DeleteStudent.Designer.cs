
namespace SchoolManagementSystem
{
    partial class DeleteStudent
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_searchID = new System.Windows.Forms.Button();
            this.tb_namesurname = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lbl_name_surname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(153)))), ((int)(((byte)(211)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(509, 161);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(122, 42);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_searchID
            // 
            this.btn_searchID.BackColor = System.Drawing.Color.Transparent;
            this.btn_searchID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(212)))));
            this.btn_searchID.FlatAppearance.BorderSize = 0;
            this.btn_searchID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_searchID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_searchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchID.Location = new System.Drawing.Point(444, 59);
            this.btn_searchID.Name = "btn_searchID";
            this.btn_searchID.Size = new System.Drawing.Size(188, 38);
            this.btn_searchID.TabIndex = 8;
            this.btn_searchID.UseVisualStyleBackColor = false;
            this.btn_searchID.Click += new System.EventHandler(this.btn_searchID_Click);
            // 
            // tb_namesurname
            // 
            this.tb_namesurname.BackColor = System.Drawing.Color.White;
            this.tb_namesurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_namesurname.Enabled = false;
            this.tb_namesurname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namesurname.Location = new System.Drawing.Point(145, 174);
            this.tb_namesurname.Multiline = true;
            this.tb_namesurname.Name = "tb_namesurname";
            this.tb_namesurname.ReadOnly = true;
            this.tb_namesurname.Size = new System.Drawing.Size(335, 28);
            this.tb_namesurname.TabIndex = 7;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.White;
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(145, 69);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(284, 28);
            this.tb_id.TabIndex = 6;
            // 
            // lbl_name_surname
            // 
            this.lbl_name_surname.AutoSize = true;
            this.lbl_name_surname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name_surname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbl_name_surname.Location = new System.Drawing.Point(138, 138);
            this.lbl_name_surname.Name = "lbl_name_surname";
            this.lbl_name_surname.Size = new System.Drawing.Size(135, 16);
            this.lbl_name_surname.TabIndex = 5;
            this.lbl_name_surname.Text = "Name and Surname";
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.bckdeletetch_std;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_searchID);
            this.Controls.Add(this.tb_namesurname);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_name_surname);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_searchID;
        private System.Windows.Forms.TextBox tb_namesurname;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lbl_name_surname;
    }
}