
namespace SchoolManagementSystem
{
    partial class ViewStudent
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
            this.dgv_studentdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_studentdata
            // 
            this.dgv_studentdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_studentdata.Location = new System.Drawing.Point(0, 0);
            this.dgv_studentdata.Name = "dgv_studentdata";
            this.dgv_studentdata.Size = new System.Drawing.Size(804, 497);
            this.dgv_studentdata.TabIndex = 0;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.dgv_studentdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewStudent";
            this.Text = "ViewStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_studentdata;
    }
}