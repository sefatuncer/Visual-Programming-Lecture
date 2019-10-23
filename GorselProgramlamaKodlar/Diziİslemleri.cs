using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselHafta4
{
 class Program
 {

  static void Main(string[] args)
  {
   int uzunluk = 0;
   string enuzunmetin = "";
   int index = 0;

   string[] dizi = new string[10];

   for (int i = 0; i < dizi.Length; i++)
   {
    Console.Write("{0}. eleman  ", (i + 1));
    dizi[i] = Console.ReadLine();
   }

   for (int i = 0; i < dizi.Length; i++)
   {
    if (dizi[i].Length > uzunluk)
    {
     uzunluk = dizi[i].Length;
     enuzunmetin = dizi[i];
     index = i;
    }
   }

   //foreach (var eleman in dizi)
   //{
   // if (eleman.Length > uzunluk)
   // {
   //  uzunluk = eleman.Length;
   //  enuzunmetin = eleman;
   //  //index = i;
   // }
   //}

   Console.WriteLine("En uzun metin : " + enuzunmetin);
   Console.WriteLine("Uzunluk = " + uzunluk + " Index no = " + index);

  }
 }
}
