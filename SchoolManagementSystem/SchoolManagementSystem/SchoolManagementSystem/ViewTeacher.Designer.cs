
namespace SchoolManagementSystem
{
    partial class ViewTeacher
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
            this.dgw_teacherdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_teacherdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_teacherdata
            // 
            this.dgw_teacherdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_teacherdata.Location = new System.Drawing.Point(0, 0);
            this.dgw_teacherdata.Name = "dgw_teacherdata";
            this.dgw_teacherdata.ReadOnly = true;
            this.dgw_teacherdata.Size = new System.Drawing.Size(804, 497);
            this.dgw_teacherdata.TabIndex = 0;
            // 
            // ViewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.dgw_teacherdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewTeacher";
            this.Text = "ViewTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_teacherdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_teacherdata;
    }
}