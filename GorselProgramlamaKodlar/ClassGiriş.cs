using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
 /* Bir sýnýfýn kalýtým almasýný istemiyorsak
  * önüne "sealed" ekini getirmeliyiz. 
  */
 public class Dortgen
 {
  public int en;
  public int boy;

  public Dortgen() // Constructor (Kurucu fonksiyon)
  {
   // Kurucu fonksiyona baþlangýç deðerleri girilir.
   Console.WriteLine("Parametresiz kurucu çalýþtý.");
   en = 5;
   boy = 5;
  }

  public Dortgen(int en, int boy)
  {
   Console.WriteLine("2 parametreli kurucu çalýþtý.");
   this.en = en;
   this.boy = boy;
  }

  public int Cevre()
  {
   return (en + boy) * 2;
  }

  public int Alan()
  {
   return en * boy;
  }

  public void Yazdir()
  {
   Console.WriteLine("En : " + en + "\nBoy : " + boy);
  }
 }
 class Program
 {
  static void Main(string[] args)
  {
   //Dortgen d1 = new Dortgen();

   Dortgen d1;
   d1 = new Dortgen(); // kurucu çalýþýr
   d1.en = 21;
   d1.Yazdir();

   Dortgen d2 = new Dortgen(15, 26);
   d2.Yazdir();

   Console.WriteLine("Çevre = {0}", d1.Cevre());
   Console.WriteLine("Alan = {0}", d1.Alan());
   Console.ReadKey();

  }
 }
}
