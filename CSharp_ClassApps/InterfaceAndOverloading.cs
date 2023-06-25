public interface IOverloadingExample
{
    int toplam(int a,int b);
    int toplam(int a,int b,int c);
    double toplam(double a,double b);
    string parcala(string cumle);
    string parcala(string cumle, char karakter);
    List<string> parcala(string[] cumle);
}

public class OverloadingExample : IOverloadingExample
{
    public string parcala(string cumle)
    {
        string[] parca = cumle.Split('.');
        return parca[0];
    }

    public string parcala(string cumle, char karakter)
    {
        string[] parca = cumle.Split(karakter);
        return parca[0];
    }

    public List<string> parcala(string[] cumle)
    {
        List<string> parcali = new List<string>();
        foreach (var item in cumle)
        {
            string[] temp;
            temp = item.Split('.');
            foreach (var i in temp)
            {
                parcali.Add(i);
            }
        }
        return parcali;
    }

    public int toplam(int a, int b)
    {
        return a + b;
    }

    public int toplam(int a, int b, int c)
    {
        return a + b + c;
    }

    public double toplam(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IOverloadingExample o = new OverloadingExample();

        Console.WriteLine(o.toplam(1,2));
        Console.WriteLine(o.parcala("21.02.2019"));
        string[] cumleler = {"sefa.tuncer", "14.10.2019","bilecik.üniversitesi"};

        List<string> temp = o.parcala(cumleler);
        foreach (var item in temp)
        {
            Console.WriteLine(item);
        }
    }
}
