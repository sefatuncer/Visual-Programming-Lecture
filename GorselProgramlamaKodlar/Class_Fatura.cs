using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
 class Program
 {
  static void Main(string[] args)
  {
   Fatura f1 = new Fatura(); // nesne1
   Fatura f2; // Kurucu çalýþmaz.
   f2 = new Fatura(); // Kurucu çalýþýr.

   f1.Ad = "Ýstanbul Yayýnevi";
   f1.Tutar = 35;

   f2.Tutar = f1.Tutar;

   Console.WriteLine(f1.Ad);
   Console.WriteLine(f1.Adres);
   Console.WriteLine(f1.No);
   Console.WriteLine(f1.Tutar);

   int fToplam = f1.Toplam();
   int fToplam2 = f2.Toplam();

   Console.WriteLine(fToplam);
   Console.WriteLine(fToplam2);


  }
 }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
 public class Fatura
 {
  public string Ad;
  public string No;
  public string Adres;
  public int Tutar;

  /*
   * Kurucu fonksiyon class ile ayný isimde olmaz zorundadýr.
   * Kurucu fonksiyonda baþlangýç deðerleri tutulur.
   * Herhangi bir deðer geri döndürmez. (return yapmaz.)
   * Nesne oluþturulur oluþturulmaz çalýþýr. (new yapýldýðý an çalýþýr)
   */
  public Fatura() // Kurucu fonksiyon (Constructor)
  {
   this.Ad = "Ankara Yayýnevi";
   this.Adres = "Kýzýlay/ANKARA";
   this.No = "0-312-344-45-66";
   this.Tutar = 30;
  }


  // Bu kullaným çok doðru deðildir.
  // Her fonksiyon tek iþlevi yerine getirmelidir.
  public int Toplam()
  {
   int Konusma, Mesaj, Diger;
   Console.Write("Konusma Tutarý:");
   Konusma = int.Parse(Console.ReadLine());
   Console.Write("Mesaj Tutarý:");
   Mesaj = int.Parse(Console.ReadLine());
   Console.Write("Diger Tutar:");
   Diger = int.Parse(Console.ReadLine());

   return Konusma + Mesaj + Diger;
  }

 }
}

