
namespace SchoolManagementSystem
{
    partial class SearchStudent
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
            this.dgw_studentdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_studentdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_studentdata
            // 
            this.dgw_studentdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_studentdata.Location = new System.Drawing.Point(0, 0);
            this.dgw_studentdata.Name = "dgw_studentdata";
            this.dgw_studentdata.ReadOnly = true;
            this.dgw_studentdata.Size = new System.Drawing.Size(804, 497);
            this.dgw_studentdata.TabIndex = 2;
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.dgw_studentdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchStudent";
            this.Text = "SearchStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_studentdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_studentdata;
    }
}