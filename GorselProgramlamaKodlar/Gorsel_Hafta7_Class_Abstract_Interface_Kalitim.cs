using System;
using System.Collections.Generic;

namespace AbstractInterface
{
    public enum Vites
    {
        Manuel,
        Otomatik,
        Triptonik
    }
    public abstract class AbstractAraba
    {
        protected string renk;
        protected string model;
        protected byte vites;
        public Vites vitesTuru;
        public AbstractAraba()
        {
            renk = model = " ";
            vites = 0;
        }
        public AbstractAraba(string r, string m, byte v)
        {
            renk = r;
            model = m;
            vites = v;
        }
        // Abstract fonksiyon kesinlikle override edilmelidir.
        public abstract void Yaz();

        // Polymorphism (Çok Biçimlilik)
        public virtual List<int> LastikEbati()
        {
            return new List<int>
            {
                32, 24, 22
            };
        }
        public virtual Vites VitesTuru()
        {
            return Vites.Triptonik;
        }
    }

    public interface IArabaYonetimi
    {
        byte YolcuKapasitesi();
        int BagajHacmi();
    }

    public sealed class Kamyon : AbstractAraba, IArabaYonetimi
    {
        bool damper;
        public Kamyon(string r, string m, byte v, bool d) : base(r, m, v)
        {
            damper = d;
        }

        public int BagajHacmi()
        {
            return 20000;
        }

        public override void Yaz()
        {
            Console.WriteLine("Damper={0}", damper);
        }

        public byte YolcuKapasitesi()
        {
            return 4;
        }
    }

    public class Otomobil : AbstractAraba, IArabaYonetimi
    {
        public int bagajHacmi;
        public int BagajHacmi() => 500;

        public override List<int> LastikEbati()
        {
            return new List<int>
            {
                32,24,20
            };
        }
        public override Vites VitesTuru()
        {
            return Vites.Manuel;
        }

        public override void Yaz()
        {
            Console.WriteLine("Otomobil");
            Console.WriteLine(VitesTuru());
            foreach (var item in LastikEbati())
            {
                Console.WriteLine(item);
            }
        }

        public byte YolcuKapasitesi()
        {
            return 5;
        }
    }

    // Static fonksiyonlar sınıfın adı
    // kullanılarak direk çağrılır.
    public static class Islem
    {
        private static Otomobil otomobil;
        public static void BagajHacmiYazdir(IArabaYonetimi ay) => Console.WriteLine(ay.BagajHacmi());
        public static void YolcuKapasitesiYazdir(IArabaYonetimi ay) => Console.WriteLine(ay.YolcuKapasitesi());

        public static bool LastikEbatiAyniMi(Otomobil o, Kamyon k)
        {
            if (o.LastikEbati() == k.LastikEbati())
                return true;
            return false;
        }

        public static Otomobil NesneOlustur()
        {
            if (otomobil == null)
                otomobil = new Otomobil();
            return otomobil;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Kamyon k = new Kamyon("Kırmızı", "2015", 12, true);

            Console.WriteLine(k.VitesTuru());

            Otomobil o = new Otomobil();

            foreach (var item in o.LastikEbati())
            {
                Console.WriteLine(item);
            }

            List<Otomobil> ot = new List<Otomobil>();
            ot.Add(new Otomobil());
            ot.Add(new Otomobil());
            ot.Add(new Otomobil()
            {
                bagajHacmi = 300,
                vitesTuru = Vites.Otomatik
            });

            ot[0].vitesTuru = Vites.Otomatik;
            ot[1].vitesTuru = Vites.Manuel;
            ot[2].vitesTuru = Vites.Triptonik;

            foreach (var item in ot)
            {
                Console.WriteLine(item.vitesTuru);
            }

            Otomobil[] obil = new Otomobil[10];


            Islem.BagajHacmiYazdir(ot[1]);
            Islem.YolcuKapasitesiYazdir(k);
            Console.WriteLine(Islem.LastikEbatiAyniMi(o, k));

            Otomobil yeni = Islem.NesneOlustur();
        }
    }
}
