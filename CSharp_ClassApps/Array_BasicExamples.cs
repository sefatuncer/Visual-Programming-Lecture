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
  
  static void Main(string[] args)
  {
   Random r = new Random();
   int[] dizi = new int[10];
   int[] arr  = new int[10];
   int[] dizi2 = new int[20];
   char[,] matris = new char[30,15];

   for (int i = 0; i < dizi.Length; i++)
   {
    dizi[i] = r.Next(0,100);
    Console.Write(dizi[i] + "  ");
   }
   Console.WriteLine();
   arr = (int [])dizi.Clone();

   for (int i = 0; i < arr.Length; i++)
   {
    Console.Write(arr[i] + "  ");
   }
   Console.WriteLine();
   dizi.CopyTo(dizi2, 10);

   for (int i = 0; i < dizi2.Length; i++)
   {
    Console.Write(dizi2[i] + "  ");
   }

   Console.WriteLine("\n" + matris.GetLength(1));
   Console.WriteLine("Upper bound: {0}", matris.GetUpperBound(1));

   int index = 5;
   Console.WriteLine("{0}. indeksteki veri: {1}", index, dizi.GetValue(index));

   dizi.SetValue(25, index);

   Console.WriteLine("{0}. indeksteki veri: {1}", index, dizi.GetValue(index));

   Array.Clear(dizi, 6, 3);

   for (int i = 0; i < dizi.Length; i++)
   {
    Console.Write(dizi[i] + "  ");
   }
   Console.WriteLine();
   Array.Reverse(dizi);

   for (int i = 0; i < dizi.Length; i++)
   {
    Console.Write(dizi[i] + "  ");
   }
   Console.WriteLine();
   Array.Sort(dizi);

   for (int i = 0; i < dizi.Length; i++)
   {
    Console.Write(dizi[i] + "  ");
   }


   for (int i = 0; i < 11; i++)
   {
    Console.WriteLine(Array.LastIndexOf(dizi, r.Next(0,100)));
   }

   Array.Resize(ref dizi, 15);

   for (int i = 0; i < dizi.Length; i++)
   {
    Console.Write(dizi[i] + "  ");
   }

   Array arr2 = Array.CreateInstance(typeof(int), 30);
   

   Console.ReadKey();
  }
 }
}
