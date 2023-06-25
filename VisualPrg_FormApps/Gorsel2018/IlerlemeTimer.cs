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
    public partial class IlerlemeTimer : Form
    {
        PictureBox pBox = new PictureBox();
        Random rnd = new Random();
        PictureBox[] pDizi = new PictureBox[100];
        private int sayac;
        public int yatayYon;
        public int duseyYon;
        public IlerlemeTimer() // Kurucu
        {
            InitializeComponent(); // Başlangıç Bileşenleri

            yatayYon = 1; // Sağa (kontrol)
            duseyYon = 1; // Aşağı
            sayac = 0;

            pBox.BackColor = Color.Transparent;
            pBox.Location = new Point(0,0); // Yer
            pBox.Size = new Size(30,30); // Boyut
            pBox.Image = Image.FromFile("ball.png");
            pBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.Controls.Add(pBox); // Panele ekle (add)

            btnStart.BackgroundImage = Image.FromFile("start.png");
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Buton start/stop (timer) işlemi yapar
            if (!timer1.Enabled)
            {
                timer1.Start(); // timer1.Enabled = true;
                btnStart.BackgroundImage = Image.FromFile("stop.png");
            }
            else
            {
                timer1.Stop();
                btnStart.BackgroundImage = Image.FromFile("start.png");
            }
        }

        public void RasgeleKordinat(PictureBox resim)
        {
            int x = rnd.Next(14)*30;
            int y = rnd.Next(11)*30;
            resim.Location = new Point(x,y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(yatayYon == 1) // Sağa
            {
                if (pBox.Left < panel1.Width - 30)
                    pBox.Left += 30;
                else
                {
                    yatayYon = 2; // Sola
                    panel1.BackColor = RasgeleRenk();
                    ResimYerlestir();
                }
            }
            else // Sola (yatayYon=2)
            {
                if (pBox.Left > 0)
                    pBox.Left -= 30;
                else
                    yatayYon = 1; // Sağa
            }
            if(duseyYon == 1) // Aşağı
            {
                if (pBox.Top < panel1.Height - 30)
                    pBox.Top += 30;
                else
                    duseyYon = 2; // Yukarı
            }
            else
            {
                if (pBox.Top > 0)
                    pBox.Top -= 30;
                else
                    duseyYon = 1; // Aşağı
            }
            label1.Text = "Left: " + pBox.Left + " Right" +
                pBox.Right; // Sol, Sağ
            label2.Text = "Top: " + pBox.Top + " Bottom: " + 
                pBox.Bottom; // Üst, Alt
        }

        public Color RasgeleRenk()
        {
            switch(rnd.Next(0,3))
            {
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Yellow;
                case 3:
                    return Color.Orange;
                default:
                    return Color.LightSteelBlue;
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(comboBox1.Text);
        }

        public void ResimYerlestir()
        {
            pDizi[sayac] = new PictureBox();
            pDizi[sayac].BackColor = Color.Transparent;
            pDizi[sayac].Location = new Point(5 + 30*sayac, 5); // Yer
            pDizi[sayac].Size = new Size(30, 30); // Boyut
            pDizi[sayac].Image = Image.FromFile("hearth.png");
            pDizi[sayac].SizeMode = PictureBoxSizeMode.StretchImage;
            panel2.Controls.Add(pDizi[sayac]); // Panele ekle (add)
            sayac++;
        }

    }
}