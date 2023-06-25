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
   Array takimlar = Array.CreateInstance(typeof(string), 3);
   string[] takim_adlari = (string[])takimlar; // tip dönüþümü

   takim_adlari[0] = "Galatasaray";
   takim_adlari[1] = "Fenerbahçe";
   takim_adlari[2] = "Beþiktaþ";

   Console.WriteLine(takim_adlari[0]);

   Type tip = takim_adlari.GetType();

   if (tip.IsArray)
    Console.WriteLine("Bu bir dizidir.");
   else
    Console.WriteLine("Bu bir dizi deðildir.");

   takim_adlari.SetValue("Trabzonspor", 2);
   Console.WriteLine(takim_adlari.GetValue(2).ToString());

   string string_takimlar = String.Join("-", takim_adlari);
   Console.WriteLine(string_takimlar);

   if(string_takimlar.Contains("Galatasaray"))
    Console.WriteLine("Ýçerik mevcut");
   if(takim_adlari.Contains("Galatasaray"))
    Console.WriteLine("Ýçerik mevcut");
  }
 }
}
