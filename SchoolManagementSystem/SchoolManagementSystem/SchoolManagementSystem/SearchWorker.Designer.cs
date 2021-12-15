
namespace SchoolManagementSystem
{
    partial class SearchWorker
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
            this.dgw_workerdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_workerdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_workerdata
            // 
            this.dgw_workerdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_workerdata.Location = new System.Drawing.Point(0, 0);
            this.dgw_workerdata.Name = "dgw_workerdata";
            this.dgw_workerdata.ReadOnly = true;
            this.dgw_workerdata.Size = new System.Drawing.Size(804, 497);
            this.dgw_workerdata.TabIndex = 3;
            // 
            // SearchWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.dgw_workerdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchWorker";
            this.Text = "SearchWorker";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_workerdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_workerdata;
    }
}