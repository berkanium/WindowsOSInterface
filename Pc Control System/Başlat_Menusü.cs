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
    public partial class Baslat_Menusü : Form
    {
        public Baslat_Menusü()
        {
            InitializeComponent();
        }

        private void btnKayıtDefteri_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("regedit.exe");
        }

        private void btnCmdEkran_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe");
        }
        private void btnGorevYoneticisi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskmgr.exe");
        }
        private void btnDiskTemizleme_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cleanmgr.exe");
        }

        private void btnGuvenlikBakım_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wscui.cpl");
        }

        private void btnSistemBilgisi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msinfo32.exe");
        }
        private void PcSecenek()
        {
            Ac_Kapa_Beklet cagirma = new Ac_Kapa_Beklet();
            this.Hide();
            cagirma.Show();

        }
        private void lblAcKapaBeklet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            PcSecenek();
        }
        private void masa()
    {
    Masaüstü_Alanı masa =new Masaüstü_Alanı();
    this.Close();
    masa.ShowDialog();
    }
        private void btnBaslatGeri_Click(object sender, EventArgs e)
        {
            masa();
        }
    }
}
