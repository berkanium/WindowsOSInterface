using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Pc_Control_System
{
    public partial class Calar_Saat : Form
    {
        public Calar_Saat()
        {
            InitializeComponent();
        
        }
        int saat, Dakika, saniye, farkSaat, farkDakika, farkSaniye, sonucSaat, sonucDakika, sonucSaniye;
        private void Çalar_Saat_Load(object sender, EventArgs e)
        {

            tmrCalarSaati.Interval = 1000;
            for (int i = 1; i < 24; i++)
            {
                if (i < 10) cmcSaat.Items.Add("0" + i);
                else cmcSaat.Items.Add(i);

            }
            for (int i = 1; i < 60; i++)
            {
                if (i < 10) cmcDakika.Items.Add("0" + i);
                else cmcDakika.Items.Add(i);

            }
            for (int i = 1; i < 60; i++)
            {
                if (i < 10) cmcSaniye.Items.Add("0" + i);
                else cmcSaniye.Items.Add(i);

            }
            tmrCalarSaati.Enabled = true;
        }
        private void btnAlarmıKur_Click(object sender, EventArgs e)
        {
            sonucSaat = saat - farkSaat;
            sonucDakika = Dakika - farkDakika;
            sonucSaniye = saniye - farkSaniye;
            MessageBox.Show("Alarmın Çalmasına Şu Kadar Zaman Kaldı : " + sonucSaat + " " + "Saat ve" + " " + sonucDakika + " " + "Dakika" + " " + sonucSaniye + " " + "Saniye Var..", "Alarm Ayarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAlarmıKur.Text = "Alarm Kuruldu";
            btnAlarmıKur.Enabled = true;
        }

        private void cmcSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSaat.Text = cmcSaat.SelectedItem.ToString();
            saat = Convert.ToInt32(cmcSaat.SelectedItem);
        }

        private void cmcDakika_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDakika.Text = cmcDakika.SelectedItem.ToString();
            Dakika = Convert.ToInt32(cmcDakika.SelectedItem);
        }

        private void cmcSaniye_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSaniye.Text = DateTime.Now.Second.ToString();
            saniye = Convert.ToInt32(cmcSaniye.SelectedItem);
        }
        SoundPlayer ses = new SoundPlayer();
        private void muzikCal()
        {
            string muzik = Application.StartupPath + "\\Play.wav";
            ses.SoundLocation = muzik;
            ses.Play();
            btnAlarmıKur.Text = "Haydi Kalk...";
            btnAlarmıKur.Enabled = true;
        }
        
        private void tmrCalarSaati_Tick(object sender, EventArgs e)
        {
            farkSaat = Convert.ToInt32(DateTime.Now.Hour);
            farkDakika = Convert.ToInt32(DateTime.Now.Minute);
            farkSaniye = Convert.ToInt32(DateTime.Now.Second);
            lblSuankiSaat.Text = DateTime.Now.ToLongTimeString();
            if (saat == farkSaat && Dakika == farkDakika && saniye == farkSaniye)
            {
                muzikCal();
            }
        }
        private void SaatCikisi()
        {
            Masaüstü_Alanı dsktp = new Masaüstü_Alanı();
            this.Close();
            ses.Stop();
            dsktp.Show();
        }
        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            SaatCikisi();
        }
     
    }
}
