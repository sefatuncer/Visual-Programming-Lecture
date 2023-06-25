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
   int sayac = 0;
   string metin = "www.ahmetcanseverahmet.com";
   string aranan = "ahmet";

   //string d = string.Concat("sefa", " bilecik");

   for (int i = 0; i < metin.Length - aranan.Length ; i++)
   {
    if (metin.Substring(i, aranan.Length)==aranan)
    {
     sayac++;
    }
   }
   Console.WriteLine(aranan + " kelimesi " + sayac + " adet bulunmaktadýr.");
  }
 }
}
