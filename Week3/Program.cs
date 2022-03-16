using System;


namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mobil mini_cooper = new Mobil("mini cooper","bensin","hitam");

            //mini_cooper.MatikanMesin();

            //Kendaraan.Mobil lambo = new Kendaraan.Mobil();

            //lambo.Posisi();
            
            Kalkulator kalkulator = new Kalkulator();

            
            Console.WriteLine(kalkulator.Tambah());

            Console.WriteLine("===========");

            kalkulator.setX(10);

            Console.WriteLine(kalkulator.Tambah());

            Console.WriteLine("===========");

            Console.WriteLine(kalkulator.getX());


        }
    }

    

}

namespace Kendaraan
{
    class Mobil
    {
        public void Posisi()
        {
            Console.WriteLine("Aku di namespace kendaraan");
        }
    }
}
