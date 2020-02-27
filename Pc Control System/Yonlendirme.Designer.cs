namespace Pc_Control_System
{
    partial class Yonlendirme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonlendirme));
            this.prgYonlendirme = new System.Windows.Forms.ProgressBar();
            this.tmrYonlendirme = new System.Windows.Forms.Timer(this.components);
            this.ntfyYonlendir = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgYonlendirme
            // 
            this.prgYonlendirme.Location = new System.Drawing.Point(12, 214);
            this.prgYonlendirme.Name = "prgYonlendirme";
            this.prgYonlendirme.Size = new System.Drawing.Size(399, 51);
            this.prgYonlendirme.TabIndex = 0;
            // 
            // tmrYonlendirme
            // 
            this.tmrYonlendirme.Tick += new System.EventHandler(this.tmrYonlendirme_Tick);
            // 
            // ntfyYonlendir
            // 
            this.ntfyYonlendir.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyYonlendir.Icon")));
            this.ntfyYonlendir.Text = "Yönlendiriliyorsunuz...";
            this.ntfyYonlendir.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(109, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönlendiriliyorsunuz...";
            // 
            // Yonlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgYonlendirme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Yonlendirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönlendirme";
            this.Load += new System.EventHandler(this.Yonlendirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgYonlendirme;
        private System.Windows.Forms.Timer tmrYonlendirme;
        private System.Windows.Forms.NotifyIcon ntfyYonlendir;
        private System.Windows.Forms.Label label1;
    }
}

