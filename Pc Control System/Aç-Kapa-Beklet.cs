using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pc_Control_System
{
    public partial class Ac_Kapa_Beklet : Form
    {
        public Ac_Kapa_Beklet()
        {
            InitializeComponent();
        }
        DialogResult tus = new DialogResult();
        private void btnKapat_Click(object sender, EventArgs e)
        {
            tus = MessageBox.Show("Sayın Kullanıcı Bilgisayar Kapanacak Onaylıyor Musunuz?", "Kapatma Protokolü", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (tus==DialogResult.Yes)
            {
                Process.Start("shutdown", "-s");
            }
            else
            {
                MessageBox.Show("Kapatma İşlemi İptal Edildi", "İptal Protokolü", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBeklet_Click(object sender, EventArgs e)
        {
            tus = MessageBox.Show("Sayın Kullanıcı Beklemeye Alınacak Onaylıyor Musunuz?", "Bekletme Protokolü", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (tus == DialogResult.Yes)
            {
                Process.Start("shutdown", "-h");
            }
            else
            {
                MessageBox.Show("Kapatma İşlemi İptal Edildi", "İptal Protokolü", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnYenidenBaslat_Click(object sender, EventArgs e)
        {
            tus = MessageBox.Show("Sayın Kullanıcı Yeniden Başlatılacak Onaylıyor Musunuz?", "Restart Protokolü", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (tus == DialogResult.Yes)
            {
                Process.Start("shutdown", "-r");
            }
            else
            {
                MessageBox.Show("Kapatma İşlemi İptal Edildi", "İptal Protokolü", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        Masaüstü_Alanı ds = new Masaüstü_Alanı();
        private void lblİptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
            ds.Show();
        }
    }
}
