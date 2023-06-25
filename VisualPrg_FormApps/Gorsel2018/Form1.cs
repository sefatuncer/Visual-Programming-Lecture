using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            HesapMakinesi h = new HesapMakinesi();
            h.Show(); // h formunu göster
            //this.Hide(); // form1'i gizle 
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Zamanlayici z = new Zamanlayici();
            z.Show(); // Zamanlayıcı formu
            //this.Hide(); // Bu form
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            ListeAsalSayi liste = new ListeAsalSayi();
            liste.Show();
        }

        private void btnHareket_Click(object sender, EventArgs e)
        {
            HareketEtme h = new HareketEtme();
            h.Show();
        }

        private void btnIlerleme_Click(object sender, EventArgs e)
        {
            IlerlemeTimer ilerleme = new IlerlemeTimer();
            ilerleme.Show();
        }
    }
}
