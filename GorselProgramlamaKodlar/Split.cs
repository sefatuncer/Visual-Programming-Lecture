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
   string ifade = "";

   string[] dizi;

   Console.Write("Bir ifade giriniz : ");
   ifade = Console.ReadLine();


   dizi = ifade.Split('+'); // ifade'yi böl ve diziye aktar

   int toplam = 0;
   foreach (var item in dizi)
   {
    int gecici = Convert.ToInt32(item);
    toplam += gecici;
   }
   Console.WriteLine("Toplam : " + toplam.ToString());
  }
 }
}
