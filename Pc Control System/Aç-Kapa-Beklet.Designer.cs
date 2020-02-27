namespace Pc_Control_System
{
    partial class Ac_Kapa_Beklet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ac_Kapa_Beklet));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnBeklet = new System.Windows.Forms.Button();
            this.btnYenidenBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblİptalEt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(50, 81);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(78, 72);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnBeklet
            // 
            this.btnBeklet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBeklet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeklet.BackgroundImage")));
            this.btnBeklet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeklet.Location = new System.Drawing.Point(176, 81);
            this.btnBeklet.Name = "btnBeklet";
            this.btnBeklet.Size = new System.Drawing.Size(78, 72);
            this.btnBeklet.TabIndex = 2;
            this.btnBeklet.UseVisualStyleBackColor = false;
            this.btnBeklet.Click += new System.EventHandler(this.btnBeklet_Click);
            // 
            // btnYenidenBaslat
            // 
            this.btnYenidenBaslat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnYenidenBaslat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYenidenBaslat.BackgroundImage")));
            this.btnYenidenBaslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYenidenBaslat.Location = new System.Drawing.Point(299, 81);
            this.btnYenidenBaslat.Name = "btnYenidenBaslat";
            this.btnYenidenBaslat.Size = new System.Drawing.Size(78, 72);
            this.btnYenidenBaslat.TabIndex = 3;
            this.btnYenidenBaslat.UseVisualStyleBackColor = false;
            this.btnYenidenBaslat.Click += new System.EventHandler(this.btnYenidenBaslat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(47, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kapat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(178, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bekletme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(296, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeniden Başlat";
            // 
            // lblİptalEt
            // 
            this.lblİptalEt.AutoSize = true;
            this.lblİptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİptalEt.Location = new System.Drawing.Point(365, 192);
            this.lblİptalEt.Name = "lblİptalEt";
            this.lblİptalEt.Size = new System.Drawing.Size(59, 17);
            this.lblİptalEt.TabIndex = 3;
            this.lblİptalEt.Text = "İptal Et";
            this.lblİptalEt.Click += new System.EventHandler(this.lblİptalEt_Click);
            // 
            // Ac_Kapa_Beklet
            // 
            this.AcceptButton = this.btnKapat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(436, 232);
            this.Controls.Add(this.lblİptalEt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYenidenBaslat);
            this.Controls.Add(this.btnBeklet);
            this.Controls.Add(this.btnKapat);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ac_Kapa_Beklet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aç_Kapa_Beklet";
            // this.Load += new System.EventHandler(this.Ac_Kapa_Beklet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBeklet;
        private System.Windows.Forms.Button btnYenidenBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblİptalEt;
    }
}