using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel_Hafta5
{
/*
Static class özellikleri:
 Static class'ların fonksiyonları da static olmak zorundadır.
 Static class'lardan nesne oluşturulamaz.
 Static class'larda kalıtım yoktur.
 İçinde bulunan fonksiyon veya değişkenler direk sınıf ismi ile çağrılır.
 Sınıfları static olarak tanımlamak zorunlu değildir, sadece okunabilirlik açısından
 static olarak tanımlanmaktadır. Yani herhangi bir sınıfın içerisinde static fonksiyonlar
 bulunabilir.
*/
 public static class DortIslem
 {
  public static int Toplam(int a, int b)
  {
   return a + b;
  }
  public static int Fark(int a, int b)
  {
   return a - b;
  }
  public static int Carpma(int a, int b)
  {
   return a * b;
  }
  public static int Bolme(int a, int b)
  {
   return a / b;
  }
 }

 class Program
 {
  static void Main(string[] args)
  {
   //DortIslem d = new DortIslem();

   Console.Write("Birinci sayıyı giriniz:");
   int sayi1 = Convert.ToInt16(Console.ReadLine());
   Console.Write("İkinci sayıyı giriniz:");
   int sayi2 = Convert.ToInt16(Console.ReadLine());

   char islem = '+';

   Console.Write("Bir işlem seçiniz: (+,-,*,/)");
   islem = Convert.ToChar(Console.ReadLine());

   switch (islem)
   {
    case '+':
     Console.WriteLine("{0} {3} {1} = {2}", sayi1, sayi2, DortIslem.Toplam(sayi1,sayi2),islem);
     break;
    case '-':
     Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, DortIslem.Fark(sayi1,sayi2));
     break;
    case '*':
     Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, DortIslem.Carpma(sayi1, sayi2));
     break;
    case '/':
     Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, DortIslem.Bolme(sayi1, sayi2));
     break;
    default:
     break;
   }
  }
 }
}
