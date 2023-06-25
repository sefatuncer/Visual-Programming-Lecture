using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProg_Hafta6
{
 public class A
 {
  public int en;
  public int boy;

  public int a,b,c;

  /* Kurucu fonksiyon:
   * Geri dönüş değeri bulunmaz. (return yok)
   * Sınıfın ismiyle aynı isimde olmalıdır.
   * Başlangıç değerleri bu fonksiyonda verilir.
   * Aşırı yüklenme yapılabilir. (Parametre alabilir.)
   * Sınıftan bir nesne oluşturulduğunda kurucu fonksiyon hemen çalışır.
   */
  public A() // Constructor : Kurucu fonksiyon
  {
   this.en = 5;
   this.boy = 8;
   Console.WriteLine("A sınıfının Parametresiz kurucu fonksiyonu çalıştı");
  }

  public A(int en, int boy)
  {
   this.en = en;
   this.boy = boy;
   Console.WriteLine("A sınıfının Parametreli kurucu fonksiyonu çalıştı");
  }

  public A(int a,int b,int c)
  {
   this.a = a;
   this.b = b;
   this.c = c;
  }

  public int Alan()
  {
   return en * boy;
  }

  public int Cevre()
  {
   return 2 * (en + boy);
  }

  public void Yazdir()
  {
   Console.WriteLine("Alan: " + Alan());
   Console.WriteLine("Çevre: " + Cevre());
  }

 }

 public class B : A // B sınıfı A sınıfından kalıtım alır.
 {
  public int d, e;
  public B()
  {
   this.boy = 7;
   Console.WriteLine("B sınıfının Parametresiz kurucu fonksiyonu çalıştı");
  }

  public B(int a,int en,int boy):base(en,boy)
  {
   this.en = en;
   Console.WriteLine("B sınıfının Parametreli kurucu fonksiyonu çalıştı");
  }

  // base kullanılmazsa bu kurucu fonksiyondan önce A sınıfına
  // ait parametresiz kurucu fonksiyon çalışır
  public B(int d,int e,int a,int b,int c):base(a,b,c)
  {
   this.d = d;
   this.e = 15;
  }
 }

 public class C : B
 {
  public int c;
  public C()
  {
   this.boy = 7;
   Console.WriteLine("C sınıfının Parametresiz kurucu fonksiyonu çalıştı");
  }

  public C(int c)
  {
   this.c = c;
   Console.WriteLine("C sınıfının Parametreli kurucu fonksiyonu çalıştı");
  }

 }


 class Program
 {
  static void Main(string[] args)
  {
   A a = new A();
   a.Yazdir();

   A a2 = new A(3, 4);
   a2.Yazdir();

   B b = new B(); // en=5, boy=7
   B b2 = new B(11,12,13); // (a, en, boy) en=12, boy=13

   B b3 = new B(1,2,3,4,5);

   C c = new C();

   Console.WriteLine(b2.en);

   b2 = b;

   Console.WriteLine(b2.en);

   b.en++;
   b2.en++;

   Console.WriteLine(b2.en);
   Console.WriteLine(b.en);

  }
 }
}