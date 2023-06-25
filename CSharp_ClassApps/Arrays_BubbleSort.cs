using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_2
{
 class Program
 {

  static public int[] DiziDondur(int[] sayi)
  {
   int gecici;
   for (int i = 0; i < sayi.Length; i++)
   {
    for (int j = 0; j < sayi.Length - 1; j++)
    {
     if (sayi[j] > sayi[j + 1])
     {
      gecici = sayi[j];
      sayi[j] = sayi[j + 1];
      sayi[j + 1] = gecici;
     }
    }
   }
   return sayi;
  }
  
  static void Main(string[] args)
  {
   Random r = new Random();
   int[] dizi = new int[15];

   for (int i = 0; i < dizi.Length; i++)
   {
    dizi[i] = r.Next(0, 200);
    Console.Write(dizi[i] + " "); 
   }
   Console.WriteLine();
   int[] dizi2 = DiziDondur(dizi);
   foreach (var eleman in dizi2)
   {
    Console.Write(eleman + " "); 
   }
   Console.WriteLine();

   foreach (var eleman in dizi)
   {
    Console.Write(eleman + " ");
   }

   foreach (var eleman in DiziDondur(dizi))
   {
    Console.Write(eleman + " ");
   }
   Console.WriteLine();
   for (int i = 0; i < dizi.Length; i++)
   {
    Console.Write(DiziDondur(dizi)[i] + " ");
   }

  }
 }
}
