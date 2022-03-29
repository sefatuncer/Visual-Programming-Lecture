using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel_Hafta5
{
 public interface IOverLoading
 {
  int Toplam(int a, int b);
  int Toplam(int a, int b, int c);
 }

 public interface IOverLoading2
 {
  float Toplam(float a, float b);
  double Toplam(double a, double b);
  int Toplam(params int[] dizi);
 }

 public class A:IOverLoading,IOverLoading2
 {
  public int Toplam(int a, int b)
  {
   return a + b;
  }

  public int Toplam(int a, int b, int c)
  {
   return a + b + c;
  }

  public float Toplam(float a, float b)
  {
   return a + b;
  }

  public double Toplam(double a, double b)
  {
   return a + b;
  }

  public int Toplam(params int[] dizi)
  {
   int toplam = 0;
   foreach (int item in dizi)
   {
    toplam += item;
   }
   return toplam;
  }
 }
}
