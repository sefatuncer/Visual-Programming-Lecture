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
    public partial class Zamanlayici : Form
    {
        private int sayac;
        private int saniye;
        private int dakika;
        private int saat;
        public Zamanlayici()
        {
            InitializeComponent();
        }

        private void Zamanlayici_Load(object sender, EventArgs e)
        {
            sayac = 0;
            timer1.Enabled = false;
            timer1.Interval = 1; // 1 milisaniye

            label1.Text = "Kronometre";

            ToolTip aciklama = new ToolTip();
            aciklama.ToolTipIcon = ToolTipIcon.Error;
            aciklama.ToolTipTitle = "Uyarı";
            aciklama.SetToolTip(button1,"Timer harekete geçer");
            aciklama.SetToolTip(button2, "Timer durur");
            aciklama.SetToolTip(button3, "Başlar ve durdurur");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            // timer1.Start();
        }
        // Timer enable edildiği an harekete geçen olay(fonksiyon)
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            
            if(saniye>=60)
            {
                dakika++;
                saniye = 0;
            }
            if(dakika>=60)
            {
                saat++;
                dakika = 0;
            }
            label1.Text = "Saat:" + saat + ":" + dakika
                + ":" + saniye;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //timer1.Enabled = false;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if(timer1.Enabled) // if(timer1.Enabled==true)
            {
                timer1.Stop();
            }
            else // Start ve Enable(true) aynı
            { // Stop ve Enable(false) aynı
                timer1.Enabled = true;
            }
        }
    }
}
