using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
 public interface ISeriler
 {
  int seriBaslangic();
 }

 public class A : ISeriler
 {
  public int seriBaslangic()
  {
   return 5;
  }
 }

 public class B : ISeriler
 {
  public int seriBaslangic()
  {
   return 6;
  }
 }

 public class C
 {
  public void Yazdir(ISeriler seri)
  {
   Console.WriteLine("Deger = " + seri.seriBaslangic());
  }
 }

 class Program
 {
  static void Main(string[] args)
  {
   A a = new A();
   a.seriBaslangic();
   B b = new B();
   b.seriBaslangic();
   //ISeriler seri = new ISeriler(); hatalı
   //ISeriler seri; // instance = örnek
   ISeriler seri1 = new A();
   B seri2 = new B();

   C c = new C();
   c.Yazdir(seri1);
   c.Yazdir(seri2);
  }
 }
}
