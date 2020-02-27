using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pc_Control_System
{
    public partial class Kullanıcı_Dogrulama : Form
    {
        public Kullanıcı_Dogrulama()
        {
            InitializeComponent();
        }
        string kullaniciAdi = "admin", password = "1234";
        Masaüstü_Alanı dsktp = new Masaüstü_Alanı();
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdi.Text==kullaniciAdi&&txtPassword.Text==password)
            {
                MessageBox.Show("Giriş Onaylandı Sayın" + " " + txtKullanıcıAdi.Text + " " + "Hoşgeldiniz", "Giriş Protokolü Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                dsktp.ShowDialog();
            }
            else if (txtKullanıcıAdi.Text==""&&txtPassword.Text=="")
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Alanı Boş Bırakılamaz.", "Boş Alan Protokolü", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Geçersiz Kullanıcı Adı Veya Şifre Hatalı Girildi.", "Hata Protokolü", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtKullanıcıAdi.Clear();
            }
        }

        private void chckPasswordKontrol_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPasswordKontrol.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        DialogResult cikis = new DialogResult();
        private void btnExit_Click(object sender, EventArgs e)
        {
            cikis = MessageBox.Show("Programdan Çıkış Yapmak İster Misiniz?", "Program Protokolü", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (cikis==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Çıkış İşlemi İptal Edildi", "İptal Protokolü", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
