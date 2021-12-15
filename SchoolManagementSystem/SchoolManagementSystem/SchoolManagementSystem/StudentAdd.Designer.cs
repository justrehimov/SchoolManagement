
namespace SchoolManagementSystem
{
    partial class StudentAdd
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
            this.btn_addstudent = new System.Windows.Forms.Button();
            this.btn_getID = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_fathername = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_fathername = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cb_grade_type = new System.Windows.Forms.ComboBox();
            this.cb_grade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_addstudent
            // 
            this.btn_addstudent.BackColor = System.Drawing.Color.Transparent;
            this.btn_addstudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.btn_addstudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_addstudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addstudent.Location = new System.Drawing.Point(577, 411);
            this.btn_addstudent.Name = "btn_addstudent";
            this.btn_addstudent.Size = new System.Drawing.Size(146, 37);
            this.btn_addstudent.TabIndex = 41;
            this.btn_addstudent.UseVisualStyleBackColor = false;
            this.btn_addstudent.Click += new System.EventHandler(this.btn_addstudent_Click);
            // 
            // btn_getID
            // 
            this.btn_getID.BackColor = System.Drawing.Color.Transparent;
            this.btn_getID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_getID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_getID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_getID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_getID.Location = new System.Drawing.Point(314, 244);
            this.btn_getID.Name = "btn_getID";
            this.btn_getID.Size = new System.Drawing.Size(66, 35);
            this.btn_getID.TabIndex = 40;
            this.btn_getID.Text = "Get ID";
            this.btn_getID.UseVisualStyleBackColor = false;
            this.btn_getID.Click += new System.EventHandler(this.btn_getID_Click);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.White;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(427, 253);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(300, 25);
            this.tb_email.TabIndex = 39;
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.Color.White;
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_surname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_surname.Location = new System.Drawing.Point(427, 73);
            this.tb_surname.Multiline = true;
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(300, 25);
            this.tb_surname.TabIndex = 37;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(80, 343);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(300, 25);
            this.tb_password.TabIndex = 36;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.White;
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(80, 252);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(228, 25);
            this.tb_id.TabIndex = 35;
            // 
            // tb_fathername
            // 
            this.tb_fathername.BackColor = System.Drawing.Color.White;
            this.tb_fathername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fathername.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fathername.Location = new System.Drawing.Point(80, 163);
            this.tb_fathername.Multiline = true;
            this.tb_fathername.Name = "tb_fathername";
            this.tb_fathername.Size = new System.Drawing.Size(300, 25);
            this.tb_fathername.TabIndex = 34;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(80, 72);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(300, 25);
            this.tb_name.TabIndex = 33;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.BackColor = System.Drawing.Color.Transparent;
            this.rb_female.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.Location = new System.Drawing.Point(641, 351);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(72, 20);
            this.rb_female.TabIndex = 32;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = false;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gender.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(576, 314);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(60, 16);
            this.lbl_gender.TabIndex = 31;
            this.lbl_gender.Text = "Gender:";
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.BackColor = System.Drawing.Color.Transparent;
            this.rb_male.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(579, 351);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(56, 20);
            this.rb_male.TabIndex = 30;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = false;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(427, 348);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(115, 23);
            this.dtp.TabIndex = 29;
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.BackColor = System.Drawing.Color.Transparent;
            this.lbl_birthday.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthday.Location = new System.Drawing.Point(424, 314);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(68, 16);
            this.lbl_birthday.TabIndex = 28;
            this.lbl_birthday.Text = "Birthday:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(80, 310);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(70, 16);
            this.lbl_password.TabIndex = 27;
            this.lbl_password.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(422, 221);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 26;
            this.lbl_email.Text = "Email";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(80, 218);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(22, 16);
            this.lbl_ID.TabIndex = 25;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.BackColor = System.Drawing.Color.Transparent;
            this.lbl_class.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(422, 131);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(42, 16);
            this.lbl_class.TabIndex = 24;
            this.lbl_class.Text = "Class";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(422, 38);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(65, 16);
            this.lbl_surname.TabIndex = 23;
            this.lbl_surname.Text = "Surname";
            // 
            // lbl_fathername
            // 
            this.lbl_fathername.AutoSize = true;
            this.lbl_fathername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fathername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fathername.Location = new System.Drawing.Point(80, 131);
            this.lbl_fathername.Name = "lbl_fathername";
            this.lbl_fathername.Size = new System.Drawing.Size(85, 16);
            this.lbl_fathername.TabIndex = 22;
            this.lbl_fathername.Text = "Fathername";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(80, 38);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_name.TabIndex = 21;
            this.lbl_name.Text = "Name";
            // 
            // cb_grade_type
            // 
            this.cb_grade_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_grade_type.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_grade_type.FormattingEnabled = true;
            this.cb_grade_type.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cb_grade_type.Location = new System.Drawing.Point(568, 159);
            this.cb_grade_type.Name = "cb_grade_type";
            this.cb_grade_type.Size = new System.Drawing.Size(40, 24);
            this.cb_grade_type.TabIndex = 43;
            this.cb_grade_type.Text = "A";
            // 
            // cb_grade
            // 
            this.cb_grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_grade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_grade.FormattingEnabled = true;
            this.cb_grade.Items.AddRange(new object[] {
            "I grade",
            "II grade",
            "III grade",
            "IV grade",
            "V grade",
            "VI grade",
            "VII grade",
            "VIII grade",
            "IX grade",
            "X grade",
            "XI grade"});
            this.cb_grade.Location = new System.Drawing.Point(427, 159);
            this.cb_grade.Name = "cb_grade";
            this.cb_grade.Size = new System.Drawing.Size(135, 24);
            this.cb_grade.TabIndex = 42;
            this.cb_grade.Text = "Grade";
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.stdaddbck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.cb_grade_type);
            this.Controls.Add(this.cb_grade);
            this.Controls.Add(this.btn_addstudent);
            this.Controls.Add(this.btn_getID);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_fathername);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lbl_birthday);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_fathername);
            this.Controls.Add(this.lbl_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentAdd";
            this.Text = "StudentAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addstudent;
        private System.Windows.Forms.Button btn_getID;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_fathername;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_fathername;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ComboBox cb_grade_type;
        private System.Windows.Forms.ComboBox cb_grade;
    }
}