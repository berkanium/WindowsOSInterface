using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pc_Control_System
{
    public partial class Ses_Ayarları : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
        IntPtr wParam, IntPtr lParam);

        public Ses_Ayarları()
        {
            InitializeComponent();
        }

        private void btnSesKapat_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,(IntPtr)APPCOMMAND_VOLUME_MUTE);

        }

        private void btnSesKıs_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,(IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void btnSesAc_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,(IntPtr)APPCOMMAND_VOLUME_UP);

        }
        private void masaustu()
        {
            Masaüstü_Alanı masaustuAlanı = new Masaüstü_Alanı();
            this.Close();
            masaustuAlanı.Show();
        }
        private void btnMasaustuCagir_Click(object sender, EventArgs e)
        {
            masaustu();
        }
    }
}
