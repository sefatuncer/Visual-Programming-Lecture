using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel_Hafta5
{
 public class DiziIslem
 {
  Random r = new Random();
  int[] dizi;
  public int[] DiziOlustur(byte boyut)
  {
   dizi = new int[boyut];

   for (int i = 0; i < boyut; i++)
   {
    dizi[i] = r.Next(50,350);
   }
   return dizi;
  }

  public float[] DiziOlustur(int boyut)
  {
   float[] dizi = new float[boyut];

   for (int i = 0; i < boyut; i++)
   {
    dizi[i] = SayiUret();
   }
   return dizi;
  }

  public float SayiUret()
  {
   //int tam = r.Next(250,500);
   //float ondalik = (float)(r.Next(0,99))/100;
   //return (float)tam + ondalik;
   return (float)(r.Next(250, 500)) + (float)(r.Next(0, 99)) / 100;
  }

  public int EnBuyukIndis(int[] arr)
  {
   int enb = arr[0];
   int index = 0;
   for (int i = 1; i < arr.Length; i++)
   {
    if (enb < arr[i])
    {
     index = i;
     enb = arr[i];
    }
   }
   return index;
  }
 }

 class Program
 {
  static void Main(string[] args)
  {
   DiziIslem d = new DiziIslem();

   Console.Write("Dizinin boyutunu giriniz:");
   byte N = Convert.ToByte(Console.ReadLine());

   int[] A = d.DiziOlustur(N);

   foreach (var item in A)
   {
    Console.Write(item + " ");
   }
   Console.WriteLine();
   Console.WriteLine(d.EnBuyukIndis(A));

   float[] B = d.DiziOlustur((int)25);

   foreach (float item in B)
   {
    Console.Write(item + " ");
   }

   //Generic List

   List<float> liste = new List<float>();
   for (int i = 0; i < 10; i++)
   {
    liste.Add(d.SayiUret());
    Console.Write(liste[i] + " ");
   }
   Console.WriteLine("****************");
   liste.Sort();
   liste.Reverse();
   foreach (var item in liste)
   {
    Console.Write(item + " ");
   }
  }
 }
}
