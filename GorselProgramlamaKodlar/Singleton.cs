	class SingletonExample
    {
        private static SingletonExample Airport;

        private SingletonExample()
        { }

// Nesne oluşturmadan kullanabilmek için.
        public static SingletonExample airport()
        {
            if (Airport == null)
                Airport = new SingletonExample();
            return Airport;
        }

        public string HavaYolu()
        {
            Dictionary<string, string> havayolu = new Dictionary<string, string>();
            havayolu.Add("06","Ankara");
            havayolu.Add("34", "İstanbul");
            havayolu.Add("35", "İzmir");
            havayolu.Add("11", "Bilecik");
            havayolu.Add("14", "Bolu");
            havayolu.Add("54", "Sakarya");

            Console.Write("Havaalanı kodunu giriniz");
            string kod = Convert.ToString(Console.ReadLine());

            try
            {
                string deger = havayolu[kod];
                return deger;
            }
            catch (Exception d)
            {
                return "Kod bulunamadi";
            }
        }

        static void Main(string[] args)
        {
            //SingletonExample ap1 = new SingletonExample(); private
            SingletonExample ap1 = SingletonExample.airport();
            string hava1 = ap1.HavaYolu();
            Console.WriteLine(hava1);
        }