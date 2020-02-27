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
    public partial class Yonlendirme : Form
    {
        public Yonlendirme()
        {
            InitializeComponent();
        }

        private void Yonlendirme_Load(object sender, EventArgs e)
        {
          
            prgYonlendirme.BackColor = Color.Aqua;
            prgYonlendirme.ForeColor = Color.Black;
            tmrYonlendirme.Interval = 1;
            tmrYonlendirme.Enabled = true;
            prgYonlendirme.Maximum =300;
        }
        Kullanıcı_Dogrulama giris = new Kullanıcı_Dogrulama();

        private void tmrYonlendirme_Tick(object sender, EventArgs e)
        {
               if (prgYonlendirme.Value==prgYonlendirme.Maximum)
            {
                tmrYonlendirme.Enabled = false;
                this.Hide();
                giris.ShowDialog();
            }
            else
            {
                prgYonlendirme.Value += 1;

            }
        }
    }
}
