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
    public partial class ListeAsalSayi : Form
    {
        private int sayac;
        private int ust;
        private int timerSayac = 0;
        public ListeAsalSayi()
        {
            InitializeComponent();
        }

        private bool AsalMi(int sayi)
        {
            sayac = 0;
            for(int i=1;i<=sayi;i++)
            {
                if (sayi % i == 0)
                    sayac++;
            }
            if (sayac <= 2)
                return true;
            return false;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            ust = Convert.ToInt32(textBox1.Text);
            for (int i=0;i<ust;i++)
            {
                if(AsalMi(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void ListeAsalSayi_Load(object sender, EventArgs e)
        {
            //ust = Convert.ToInt32(textBox1.Text);
        }

        // timer1 aktif olduğunda sürekli çalışan fonksiyon
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerSayac++;
            if (timerSayac < ust)
            {
                if (AsalMi(timerSayac))
                    listBox1.Items.Add(timerSayac);
            }
            else
                timer1.Stop();

        }

        private void btnZamanlayici_Click(object sender, EventArgs e)
        {
            ust = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            timer1.Start(); // timer_Tick harekete geçer
        }
    }
}
