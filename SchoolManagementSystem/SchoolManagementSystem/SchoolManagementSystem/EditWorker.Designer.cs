
namespace SchoolManagementSystem
{
    partial class EditWorker
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
            this.btn_editworker_data = new System.Windows.Forms.Button();
            this.btn_searchID = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_profession = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cb_profession = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_editworker_data
            // 
            this.btn_editworker_data.BackColor = System.Drawing.Color.Transparent;
            this.btn_editworker_data.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(153)))), ((int)(((byte)(211)))));
            this.btn_editworker_data.FlatAppearance.BorderSize = 0;
            this.btn_editworker_data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_editworker_data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_editworker_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editworker_data.Location = new System.Drawing.Point(408, 356);
            this.btn_editworker_data.Name = "btn_editworker_data";
            this.btn_editworker_data.Size = new System.Drawing.Size(300, 40);
            this.btn_editworker_data.TabIndex = 68;
            this.btn_editworker_data.UseVisualStyleBackColor = false;
            this.btn_editworker_data.Click += new System.EventHandler(this.btn_editworker_data_Click);
            // 
            // btn_searchID
            // 
            this.btn_searchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(212)))));
            this.btn_searchID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(212)))));
            this.btn_searchID.FlatAppearance.BorderSize = 0;
            this.btn_searchID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(212)))));
            this.btn_searchID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(212)))));
            this.btn_searchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchID.ForeColor = System.Drawing.Color.White;
            this.btn_searchID.Location = new System.Drawing.Point(441, 61);
            this.btn_searchID.Name = "btn_searchID";
            this.btn_searchID.Size = new System.Drawing.Size(160, 36);
            this.btn_searchID.TabIndex = 67;
            this.btn_searchID.Text = "Search Phone";
            this.btn_searchID.UseVisualStyleBackColor = false;
            this.btn_searchID.Click += new System.EventHandler(this.btn_searchID_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.Color.White;
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(176, 69);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(250, 28);
            this.tb_ID.TabIndex = 66;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.White;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(65, 274);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(300, 25);
            this.tb_email.TabIndex = 65;
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.White;
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(413, 274);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(300, 25);
            this.tb_phone.TabIndex = 64;
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.Color.White;
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_surname.Enabled = false;
            this.tb_surname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_surname.Location = new System.Drawing.Point(413, 177);
            this.tb_surname.Multiline = true;
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(300, 25);
            this.tb_surname.TabIndex = 63;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Enabled = false;
            this.tb_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(65, 177);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(300, 25);
            this.tb_name.TabIndex = 62;
            // 
            // lbl_profession
            // 
            this.lbl_profession.AutoSize = true;
            this.lbl_profession.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profession.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profession.Location = new System.Drawing.Point(59, 331);
            this.lbl_profession.Name = "lbl_profession";
            this.lbl_profession.Size = new System.Drawing.Size(75, 16);
            this.lbl_profession.TabIndex = 61;
            this.lbl_profession.Text = "Profession";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(405, 235);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(48, 16);
            this.lbl_phone.TabIndex = 60;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(405, 138);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(65, 16);
            this.lbl_surname.TabIndex = 59;
            this.lbl_surname.Text = "Surname";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(59, 235);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 58;
            this.lbl_email.Text = "Email";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(59, 138);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_name.TabIndex = 57;
            this.lbl_name.Text = "Name";
            // 
            // cb_profession
            // 
            this.cb_profession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_profession.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_profession.FormattingEnabled = true;
            this.cb_profession.Items.AddRange(new object[] {
            "Security",
            "Bus Driver",
            "School Chef",
            "Librarian",
            "Gardener",
            "Secretary",
            "Maid"});
            this.cb_profession.Location = new System.Drawing.Point(65, 365);
            this.cb_profession.Name = "cb_profession";
            this.cb_profession.Size = new System.Drawing.Size(300, 24);
            this.cb_profession.TabIndex = 69;
            this.cb_profession.Text = "Security";
            // 
            // EditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.editworkerbck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.cb_profession);
            this.Controls.Add(this.btn_editworker_data);
            this.Controls.Add(this.btn_searchID);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_profession);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditWorker";
            this.Text = "EditWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editworker_data;
        private System.Windows.Forms.Button btn_searchID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_profession;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ComboBox cb_profession;
    }
}