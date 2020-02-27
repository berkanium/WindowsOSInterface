using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;


namespace Pc_Control_System
{
    public partial class Masaüstü_Alanı : Form
    {
        public Masaüstü_Alanı()
        {
            InitializeComponent();
        }

       
       
        DialogResult tus = new DialogResult();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            tus = MessageBox.Show("Bu Program Alanını Kapatmak İstiyor Musunuz?", "Program Protokolü", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (tus == DialogResult.Yes) Application.Exit();
            else MessageBox.Show("Program Kapatılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }
        private void Masaüstü_Alanı_Load(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true)
            {
                btnİnternetKontrol.BackgroundImage = Properties.Resources.open;
            }
            else btnİnternetKontrol.BackgroundImage = Properties.Resources.off;
        }

        private void btnMediaPlayer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wmplayer.exe");
        }

        private void btnVisualStudio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("devenv.exe");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.haberler.com/");
        }

        private void btnİntagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/login/?source=auth_switcher");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void btnChrome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe");
        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe");
        }

        private void btnBuBilgisayar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\");
        }
      

        private void btnGmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/intl/tr/gmail/about/#");
        }
        private void btnPaintAc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }
        private void btnMasaustuUzantısı_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mstsc.exe");
        }

        private void btnEsitlemeMerkezi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mobsync.exe");
        }

        private void btnNotDefteri_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void btnWinrar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WinRAR.exe");
        }
        private void btnBuyutec_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("magnify.exe");
        }
        private void btnFirefox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mozilla.org/");
        }

        private void btnKarakterEslem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("charmap.exe");
        }

        private void btnHesapMakinesi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        private void calarSaat()
        {
            Calar_Saat saatCagir = new Calar_Saat();
            this.Close();
            saatCagir.Show();
        }
        private void btnCalarSaat_Click(object sender, EventArgs e)
        {
            calarSaat();
        }
        private void baslatMenu()
        {
            Baslat_Menusü menu = new Baslat_Menusü();
            this.Close();
            menu.Show();
        }
        private void btbnBaslatMenu_Click(object sender, EventArgs e)
        {
            baslatMenu();
        }
        private void SoundPlayer()
        {
            Ses_Ayarları sound = new Ses_Ayarları();
            this.Hide();
            sound.ShowDialog();
        }
        private void btnSesAyarları_Click(object sender, EventArgs e)
        {
            SoundPlayer();
        }

        private void btnİnternetKontrol_Click(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true)
            {
                MessageBox.Show("Bağlantı Ayarlarınız Sorunsuz Çalışıyor \nTarayıcınızda Rahatlıkla Gezinebilirsiniz", "İnternet Bağlı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

                MessageBox.Show("Bağlantı Ayalarınızda Sorun Gözüküyor!! \nBağlantı Ayarlarını Kontrol Edip Tekrar Deneyin!!", "İnternet Bağlı Değil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}
