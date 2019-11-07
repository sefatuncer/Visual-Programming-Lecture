using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
 class Program
 {
  static int Sonuc(int[] dizi)
  {
   int toplam = 0;
   foreach (var item in dizi)
   {
    toplam += item;
   }
   return toplam;
  }

  static int ToplamaIslemi(params int[] dizi)
  {
   int toplam = 0;
   foreach (var item in dizi)
   {
    toplam += item;
   }
   return toplam;
  }


  static void Main(string[] args)
  {
   //List<int> sayilar = new List<int>();
   int[] sayilar = new int[5];

   for (int i = 0; i < sayilar.Length; i++)
   {
    sayilar[i] = int.Parse(Console.ReadLine());
   }
   Console.WriteLine("Toplam = " + Sonuc(sayilar));

   Console.WriteLine("Toplam = " + ToplamaIslemi(5,4,3,2,7,8,9));
  }
 }
}
