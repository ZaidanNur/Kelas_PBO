using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class Kalkulator
    {
        double x = 5;
        double y = 4;

        //Mobil mobil = new Mobil("mini cooper", "bensin", "hitam");

        public double Tambah()
        {
            //mobil.MatikanMesin();
            return x + y;
        }

        public void setX(double angka)
        {
            this.x = angka;
        }

        public double getX()
        {
            return x;
        }



    }

    public class Mobil
    {
        string model;
        string bahan_bakar;
        string warna;

        public Mobil(string model, string bahan_bakar, string warna)
        {
            this.model = model;
            this.bahan_bakar = bahan_bakar;
            this.warna = warna;
            Console.WriteLine("Ini dari contructor");
        }



        public void HidupkanMesin()
        {
            Console.WriteLine("Mesin hidup");
        }

        public void MatikanMesin()
        {
            Console.WriteLine("Mesin mati");
        }
    }
}
