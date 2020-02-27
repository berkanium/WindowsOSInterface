namespace Pc_Control_System
{
    partial class Ses_Ayarları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ses_Ayarları));
            this.btnSesKapat = new System.Windows.Forms.Button();
            this.btnSesKıs = new System.Windows.Forms.Button();
            this.btnSesAc = new System.Windows.Forms.Button();
            this.btnMasaustuCagir = new System.Windows.Forms.Button();
            this.tlsSesAyar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSesKapat
            // 
            this.btnSesKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSesKapat.BackgroundImage")));
            this.btnSesKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSesKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesKapat.Location = new System.Drawing.Point(100, 179);
            this.btnSesKapat.Name = "btnSesKapat";
            this.btnSesKapat.Size = new System.Drawing.Size(61, 60);
            this.btnSesKapat.TabIndex = 1;
            this.tlsSesAyar.SetToolTip(this.btnSesKapat, "Ses Kapatmak İçin Ve Açmak Basınız..");
            this.btnSesKapat.UseVisualStyleBackColor = true;
            this.btnSesKapat.Click += new System.EventHandler(this.btnSesKapat_Click);
            // 
            // btnSesKıs
            // 
            this.btnSesKıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSesKıs.BackgroundImage")));
            this.btnSesKıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSesKıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesKıs.Location = new System.Drawing.Point(100, 103);
            this.btnSesKıs.Name = "btnSesKıs";
            this.btnSesKıs.Size = new System.Drawing.Size(61, 60);
            this.btnSesKıs.TabIndex = 2;
            this.tlsSesAyar.SetToolTip(this.btnSesKıs, "Ses Kısmak İçin Basınız...");
            this.btnSesKıs.UseVisualStyleBackColor = true;
            this.btnSesKıs.Click += new System.EventHandler(this.btnSesKıs_Click);
            // 
            // btnSesAc
            // 
            this.btnSesAc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSesAc.BackgroundImage")));
            this.btnSesAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSesAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesAc.Location = new System.Drawing.Point(100, 32);
            this.btnSesAc.Name = "btnSesAc";
            this.btnSesAc.Size = new System.Drawing.Size(61, 60);
            this.btnSesAc.TabIndex = 3;
            this.tlsSesAyar.SetToolTip(this.btnSesAc, "Seç Açmak İçin Basınız...");
            this.btnSesAc.UseVisualStyleBackColor = true;
            this.btnSesAc.Click += new System.EventHandler(this.btnSesAc_Click);
            // 
            // btnMasaustuCagir
            // 
            this.btnMasaustuCagir.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnMasaustuCagir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMasaustuCagir.BackgroundImage")));
            this.btnMasaustuCagir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasaustuCagir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasaustuCagir.Location = new System.Drawing.Point(1, 2);
            this.btnMasaustuCagir.Name = "btnMasaustuCagir";
            this.btnMasaustuCagir.Size = new System.Drawing.Size(35, 33);
            this.btnMasaustuCagir.TabIndex = 4;
            this.btnMasaustuCagir.UseVisualStyleBackColor = false;
            this.btnMasaustuCagir.Click += new System.EventHandler(this.btnMasaustuCagir_Click);
            // 
            // Ses_Ayarları
            // 
            this.AcceptButton = this.btnSesAc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(263, 255);
            this.Controls.Add(this.btnMasaustuCagir);
            this.Controls.Add(this.btnSesAc);
            this.Controls.Add(this.btnSesKıs);
            this.Controls.Add(this.btnSesKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ses_Ayarları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ses_Ayarları";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSesKapat;
        private System.Windows.Forms.Button btnSesKıs;
        private System.Windows.Forms.Button btnSesAc;
        private System.Windows.Forms.Button btnMasaustuCagir;
        private System.Windows.Forms.ToolTip tlsSesAyar;
    }
}