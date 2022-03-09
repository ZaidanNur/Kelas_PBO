// See https://aka.ms/new-console-template for more information
namespace Login
{
    class Pertemuan1
    {
        static void Main(string[] args)
        {
            // Data type

            // Integer
            // Long
            // Float
            // Double
            // Boolean
            // String
            //int angka4 = 9;
            //long aangka = 9L;
            //Console.WriteLine(angka.GetType());
            //Console.WriteLine(aangka.GetType());

            //string angka3 = Convert.ToString(angka4);
            //Console.WriteLine(angka3);


            //float flot = 2.3f;
            //double dobel = 3.7d;
            //float bagi = angka / flot;
            //double bagi2 = angka / dobel;
            //Console.WriteLine(bagi);
            //Console.WriteLine(bagi2);
            //Console.WriteLine(flot.GetType());
            //Console.WriteLine(dobel.GetType());

            //bool benar = true;
            //string huruf = "Angka";
            //char kata = 'A';
            //Console.WriteLine(huruf.GetType());
            //Console.WriteLine(kata.GetType());
            int angka = 8;
            int angka2 = 9;
            // == >= <= !=
            // && (and) || (or)
            if ((angka == angka2) || (angka <= angka2))
            {
                Console.WriteLine("Benar");
            }

            else if (angka <= angka2)
            {
                Console.WriteLine("Lebih");
            }
            else
            {
                Console.WriteLine("Salah");
            };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Angka");
            }
            while (angka <= 10)
            {
                Console.WriteLine(angka);
                angka++;
            }
            do
            {
                Console.WriteLine(angka);
                angka++;
            }
            while (angka >= 15);

            List<string> daftar = new List<string>();

            daftar.Add("buku");
            daftar.Add("pensil");

            foreach (string s in daftar)
            {
                Console.WriteLine(s);
            }
        }
    }
}

