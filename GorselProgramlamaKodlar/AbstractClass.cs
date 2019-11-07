using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
 public abstract class Kisi
 {
  public string AdSoyad;

  // Abstract fonksiyonlar ezdirilmek zorundadır
  public abstract string Meslek
  {
   get;
  }

  // Abstract fonksiyonu sadece deklare edilir.,
  // Abstract fonksiyonlar kalıtım alan sınıflarda
  // kesinlikle ezdirilmelidir.
  public abstract int Yas();

  // virtual fonksiyonlar ezdirilmek zorunda değildir
  public virtual void Yaz()
  {
   Console.WriteLine("Adı Soyadı : " + AdSoyad);
   Console.WriteLine("Meslek : " + Meslek);
  }
 }

 public class Ogrenci : Kisi
 {
  public int sinif;

  public Ogrenci()
  {
   this.sinif = 3;
  }

  public override string Meslek
  {
   get { return "Öğrenci"; }
  }

  public override int Yas()
  {
   return 21;
  }

  /*Kisi sınıfındaki Yaz fonksiyonu ezildi.*/
  public override void Yaz()
  {
   Console.WriteLine("Adı Soyadı : " + AdSoyad);
   Console.WriteLine("Meslek : " + Meslek);
   Console.WriteLine("Sınıf : " + sinif);
  }
 }

 public class Ogretmen : Kisi
 {
  public string brans;

  public override string Meslek
  {
   get { return "Öğretmen"; }
  }

  public override int Yas()
  {
   return 45;
  }

  /*Kisi sınıfındaki Yaz fonksiyonu ezildi.*/
  public override void Yaz()
  {
   base.Yaz(); // Kalıtım alınan sınıftaki Yaz fonksiyonu çalışır.
   Console.WriteLine("Branş : {0}", brans);
  }
 }


 class Program
 {
  static void Main(string[] args)
  {
   // Abstract class'tan nesne oluşturulamaz
   // Fakat instance (örnek) oluşturulabilir.
   Kisi kisi1; // instance
   //kisi1 = new Kisi(); hatalı
   //kisi1 = new Ogrenci(); doğru kullanım

   Ogrenci ogrenci1 = new Ogrenci();
   ogrenci1.AdSoyad = "Ahmet Yüksel";
   ogrenci1.sinif = 3;
   // ogrenci1.Meslek = "Ogrenci değil"; hatalı
   ogrenci1.Yaz();

   // Ogrenci sınıfı dizisi
   Ogrenci[] ogrenciler = new Ogrenci[5];
   List<Ogrenci> list = new List<Ogrenci>(); // Generic list

   for (int i = 0; i < ogrenciler.Length; i++)
   {
    ogrenciler[i] = new Ogrenci(); // Öğrenci nesnesi
    Console.Write("{0}. Öğrenci Adı Soyadı : ", (i + 1));
    ogrenciler[i].AdSoyad = Console.ReadLine();
    list.Add(ogrenciler[i]);
   }
   Console.WriteLine("******************************");
   foreach (var item in list)
   {
    Console.WriteLine(item.AdSoyad);
    Console.WriteLine(item.sinif);
   }

   Console.WriteLine("*******************************");
   Ogretmen ogretmen1 = new Ogretmen();
   ogretmen1.AdSoyad = "Mustafa Ersoy";
   ogretmen1.brans = "Bilgisayar Öğretmeni";
   ogretmen1.Yaz();

  }
 }
}
