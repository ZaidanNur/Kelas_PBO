using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// OUTLINE MATERI
// 1. Abstract class
// 2. Interface
// 3. Error Handling
namespace Week12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kendaraan kendaraan = new Kendaraan();


            //Mobil mobil1 = new Mobil();

            //mobil.Berjalan();
            //Console.WriteLine("");
            //motor.Berjalan();
            //Console.WriteLine("");
            //mobil1.Berjalan();

            //IMangsa mangsa = new Kelinci();


            //Console.ReadKey();

            Kendaraan mobil = new Mobil();
            Kendaraan motor = new Motor();
            Kendaraan perahu = new Perahu();

            //perahu.Berjalan();

            //Kendaraan[] listKendaraan = { mobil,motor,perahu };

            //foreach (Kendaraan kendaraan in listKendaraan)
            //{
            //    kendaraan.Berjalan();
            //}

            IMangsa ikan = new Ikan();

            ikan.Minum();


        }
    }

    // Sebuah abstract class menunjukkan bahwa class tersebut merupakan sebuah class yang belum lengkap
    // dengan begitu pembuatan instance dari suatu abstract class tidak dimungkinkan

    abstract class Mamalia
    {

    }

    abstract class Kendaraan
    {
        // untuk mengizinkan si anak nya untuk meng override method dari parent nya
        // maka di abstract class harus dibikin method nya
        int JumlahRoda;
        public abstract void Mengerem();
        public virtual void Berjalan() {
            Console.WriteLine("Kendaraan berjalan");
        }
    }

    class Perahu : Kendaraan
    {

        public override void Mengerem()
        {
            Console.WriteLine("Perahu mengerem");
        }


        public override void Berjalan()
        {
            Console.WriteLine("Perahu berjalan");
        }
       
    }

    class Mobil : Kendaraan
    {
        public override void Mengerem()
        {
            Console.WriteLine("Mobil mengerem");

        }

        public override void Berjalan()
        {
            Console.WriteLine("Mobil berjalan wuzz wuzz");
        }
    }

    class Motor : Kendaraan
    {
        public override void Mengerem()
        {
            Console.WriteLine("Motor mengerem");
        }

        public override void Berjalan()
        {
            Console.WriteLine("Motor berjalan ngeng ngeng");
        }
    }


    // Interface merupakan sebuah kontrak yang berisikan apa saja yang harus dimiliki
    // oleh kelas turunannya
    // interface mendeklarasikan apa saja yang harus ada di dalam suatu class
    // dan class yang menginheritnya mendetailkan isi tugas yang dilakukan
    // didalam interface kita hanya bisa mendeklarasikan sebuah method dan tidak bisa 
    // mendefinisikan field / attribute

    interface IPredator
    {
        void Berburu();
        void Minum();
        void Makan();
    }

    interface IMangsa
    {
        void MelarikanDiri();
        void Minum();
        void Makan();
    }

    class Kelinci : IMangsa
    {
        public void Makan()
        {
            
        }

        public void MelarikanDiri()
        {
            Console.WriteLine("Kelinci melarikan diri");
        }

        public void Minum()
        {
            throw new NotImplementedException();
        }
    }

    class Elang : IPredator
    {
        public void Berburu()
        {
            Console.WriteLine("Elang sedang mencari mangsa");
        }

        public void Makan()
        {
            
        }

        public void Minum()
        {
            
        }
    }

    class Ikan : Kendaraan ,IMangsa ,IPredator
    {
        public override void Mengerem()
        {

        }
        public void MelarikanDiri()
        {

        }
        public void Berburu()
        {

        }

        void IPredator.Minum()
        {
            Console.WriteLine("Minum darah");
        }

        void IMangsa.Minum()
        {
            Console.WriteLine("Minum air");
        }

        public void Makan()
        {
            
        }
    }
}

