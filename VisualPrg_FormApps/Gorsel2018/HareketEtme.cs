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
    public partial class HareketEtme : Form
    {
        private Label lbl;
        private Random rnd = new Random();
        public HareketEtme()
        {
            InitializeComponent();
        }
        // Klavyeden herhangi bir tuşa basıldığında çalışır
        private void HareketEtme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's' || e.KeyChar == 'S')
                pictureBox1.Top += 30;
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
                pictureBox1.Top -= 30;
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
                pictureBox1.Left -= 30;
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
                pictureBox1.Left += 30;
            label1.Text = pictureBox1.Location.ToString();
            label2.Text = lbl.Location.ToString();
            HareketKontrol();
            YerDegistir();
        }

        private void HareketEtme_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Klavye girişi kontrolü
            pictureBox1.Focus(); // Odaklanma

            lbl = new Label(); // Yeni nesne oluştu
            this.lbl.Size = new Size(30,30); // Boyut
            this.lbl.Location = new Point(60,60); // Nokta (Yer)
            this.lbl.BackColor = Color.Red;
            panel1.Controls.Add(this.lbl); // Panele ekle
        }

        public int RasgeleSayi()
        {
            return rnd.Next(0,11)*30; // 0-330 arası sayı
        }

        private bool YemYediMi()
        {
            if (pictureBox1.Location == lbl.Location)
                return true;
            return false;
        }

        private void HareketKontrol()
        {
            if(YemYediMi())
            {
                lbl.Location = new Point(RasgeleSayi(),RasgeleSayi());
                //lbl.Show();
            }
        }

        private void YerDegistir()
        {
            if (pictureBox1.Left > panel1.Width-30)
                pictureBox1.Left = 0;
            else if (pictureBox1.Left < 0)
                pictureBox1.Left = panel1.Width;
            else if (pictureBox1.Top > panel1.Height-30)
                pictureBox1.Top = 0;
            else if (pictureBox1.Top < 0)
                pictureBox1.Top = panel1.Height;
        }

    }
}
