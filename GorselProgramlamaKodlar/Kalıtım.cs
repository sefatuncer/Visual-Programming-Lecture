using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
 public class Araba
 {
  protected string renk;
  protected string model;
  protected byte vites;
  protected bool vitesTuru;

  public Araba()
  {
   renk = "beyaz";
   vites = 0;
   vitesTuru = false;
  }

  public Araba(string r, string m, byte v, bool vT)
  {
   renk = r; // önüne this koyulabilir.
   model = m;
   this.vites = v;
   this.vitesTuru = vT;
  }

  public void Yaz()
  {
   Console.WriteLine("Arabanýn rengi : {0}", renk);
   Console.WriteLine("Arabanýn modeli : {0}", model);
   Console.WriteLine("Arabanýn vites sayýsý : {0}", vites);
   Console.WriteLine("Arabanýn vites türü : {0}", vitesTuru.ToString());
  }

  // Alt sýnýflarda ezdirilecek fonksiyon
  public virtual int[] Lastik()
  {
   int[] ebat = { 55, 16 };
   return ebat;
   //return new int[]{1,2,3};
  }

 }

 // Kamyon sýnýfý Araba sýnýfýndan türetiliyor
 public class Kamyon : Araba
 {
  private bool damper;
  public static string kamyonArkasiYazisi;

  public bool Damper // Kapsülleme:Encapsulation
  {
   get { return damper; }
   set { damper = value; }
  }

  // parametreli kurucu
  public Kamyon(string r, string m, byte v, bool vT, bool d)
   : base(r, m, v, vT)
  {
   this.damper = d;
  }

  public void Yaz2()
  {
   base.Yaz(); // kalýtým alýnan sýnýftaki Yaz() fonksiyonu
   Console.WriteLine("Arabanýn damperi var mý? : " + damper.ToString());
  }

  // Polymorphism (Çok biçimlilik) virtual, override
  // Araba sýnýfýndaki Lastik fonksiyonu ezildi.
  public override int[] Lastik()
  {
   int[] ebat = { 85, 35 };
   return ebat;
  }

  public static int KalanMesafe()
  {
   int alinanYol = 100;
   int toplamYol = 1200;
   return toplamYol - alinanYol;
  }
 }

 class Program
 {
  static void Main(string[] args)
  {
   Araba araba = new Araba(); // araba nesnesi
   araba.Yaz();
   //int[] ebatlar = araba.Lastik();
   Console.WriteLine("Araba lastik ebatlarý : {0},{1}",
    araba.Lastik()[0], araba.Lastik()[1]);
   Araba araba2 = new Araba("Kýrmýzý", "Toyota Corolla", 6, false);
   araba2.Yaz();
   //Kamyon kamyon = new Kamyon();
   //Hata verir. Çünkü parametresiz kurucu mevcut deðil.
   Kamyon kamyon = new Kamyon("Siyah", "MAN", 6, false, true);
   kamyon.Yaz2();
   int[] ebatlar = kamyon.Lastik();
   Console.WriteLine("Kamyon lastik ebatlarý : {0},{1}",
    ebatlar[0], ebatlar[1]);

   // static deðiþkenler sadece sýnýf ismiyle çaðrýlabilir.
   // nesne ile çaðrýlamazlar.
   Kamyon.kamyonArkasiYazisi = "Hatalýysam aramýzda kalsýn!";
   Console.WriteLine(Kamyon.kamyonArkasiYazisi);
   Console.WriteLine(Kamyon.KalanMesafe() + " km yol kalmýþtýr.");
  }
 }
}
