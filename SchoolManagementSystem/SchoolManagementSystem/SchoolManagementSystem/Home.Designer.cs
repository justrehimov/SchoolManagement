
namespace SchoolManagementSystem
{
    partial class Home
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
            this.lbl_tchcount = new System.Windows.Forms.Label();
            this.lbl_stdcount = new System.Windows.Forms.Label();
            this.lbl_workercount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tchcount
            // 
            this.lbl_tchcount.AutoSize = true;
            this.lbl_tchcount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tchcount.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tchcount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tchcount.Location = new System.Drawing.Point(35, 51);
            this.lbl_tchcount.Name = "lbl_tchcount";
            this.lbl_tchcount.Size = new System.Drawing.Size(42, 25);
            this.lbl_tchcount.TabIndex = 0;
            this.lbl_tchcount.Text = "10";
            // 
            // lbl_stdcount
            // 
            this.lbl_stdcount.AutoSize = true;
            this.lbl_stdcount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stdcount.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stdcount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_stdcount.Location = new System.Drawing.Point(305, 51);
            this.lbl_stdcount.Name = "lbl_stdcount";
            this.lbl_stdcount.Size = new System.Drawing.Size(42, 25);
            this.lbl_stdcount.TabIndex = 1;
            this.lbl_stdcount.Text = "10";
            // 
            // lbl_workercount
            // 
            this.lbl_workercount.AutoSize = true;
            this.lbl_workercount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_workercount.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workercount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_workercount.Location = new System.Drawing.Point(574, 51);
            this.lbl_workercount.Name = "lbl_workercount";
            this.lbl_workercount.Size = new System.Drawing.Size(42, 25);
            this.lbl_workercount.TabIndex = 2;
            this.lbl_workercount.Text = "10";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.homebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.lbl_workercount);
            this.Controls.Add(this.lbl_stdcount);
            this.Controls.Add(this.lbl_tchcount);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tchcount;
        private System.Windows.Forms.Label lbl_stdcount;
        private System.Windows.Forms.Label lbl_workercount;
    }
}