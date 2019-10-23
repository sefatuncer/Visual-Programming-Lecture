using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface
{

 public interface ISeriler
 {
  int  BirSonraki();
  void Resetle();
  void BaslangicAyarla(int x);
 }

 public class Uygulama : ISeriler
 {
  int ilk, deger;

  public Uygulama()
  {
   ilk = deger = 0;
  }

  public int BirSonraki()
  {
   deger += 2;
   return deger;
  }

  public void Resetle()
  {
   deger = ilk;
  }

  public void BaslangicAyarla(int x)
  {
   ilk = x;
   deger = ilk;
  }
 }

 //public interface IDeneme : ISeriler
 //{ 

 //}

 class Program
 {
  static void Main(string[] args)
  {
   Uygulama u = new Uygulama();

   //ISeriler u2 = new Uygulama();

   for (int i = 0; i < 5; i++)
   {
    Console.WriteLine("Bir sonraki = " + u.BirSonraki());
   }
   u.Resetle();
   for (int i = 0; i < 5; i++)
   {
    Console.WriteLine("Bir sonraki = " + u.BirSonraki());
   }
   u.BaslangicAyarla(150);
   for (int i = 0; i < 5; i++)
   {
    Console.WriteLine("Bir sonraki = " + u.BirSonraki());
   }
  }
 }
}
