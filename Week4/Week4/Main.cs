using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week4
{
    class main
    {
        static void Main(string[] args)
        {
            hewan ayam = new hewan();
            ayam.suara();
            hewan anggora = new kucing("alo","anggora" ,"whiskas", "jalanan");
            anggora.suara();
            Console.WriteLine(anggora.tempat);
            Console.WriteLine(anggora.detail("felix", "pusing"));
           

            
        }
    }

    class hewan
        //Parent
    {
        public string? nama; //Emg ga diisi :>
        public string? jenis;
        protected string? pakan;
        internal string? tempat;

        public virtual void suara()
        {
            Console.WriteLine("ini suara hewan");
        }

        public void detail(int obat, string spesies)
        {
            Console.WriteLine("By Order Parameter");
        }
        public void detail(string spesies, int obat)
        {
            Console.WriteLine("By Order Parameter");
        }
        public string detail(string spesies2, string obat2)
        {
            return spesies2; //By data type
        }
        
        public string detail(string obat)
        {
            return obat; //By Number of Parameter
        }


    }
    class kucing : hewan
    //Child
    {
        public kucing(string Nama, string Jenis, string Pakan, string Tempat="Kolong Kasur")//Default Parameter
        {
            this.nama = Nama; //Inherited Attribute
            this.jenis = Jenis;
            this.pakan = Pakan;
            this.tempat = Tempat;
        }

        public override void suara() //Inherited method
        {
            Console.WriteLine("Meong");
        }

        


    }
    class ayam : hewan
    {
        //Ngaco ni ayam

    }
}
