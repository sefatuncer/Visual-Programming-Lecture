using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
 class Program
 {
  static void Main(string[] args)
  {
   int toplam = 0;
   int[] dizi = {11,22,33,45,67};

   Console.WriteLine(dizi.Length);

   Console.WriteLine("****************");

   Array.Resize(ref dizi, 7);
   Console.WriteLine(dizi.Length);

   Console.WriteLine("****************");

   dizi = new int[9];
   
   Console.WriteLine(dizi.Length);

   foreach (var eleman in dizi)
   {
    Console.WriteLine(eleman.ToString());
    toplam += eleman;
   }

   //for (int i = 0; i < dizi.Length; i++)
   //{
   // toplam += dizi[i];
   //}

   Console.WriteLine("Toplam = " + toplam.ToString());
   Console.WriteLine("Toplam = {0}", toplam.ToString());
  }
 }
}
