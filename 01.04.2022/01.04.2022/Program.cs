using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Text;



namespace _01._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output pertama => Hello World!
            //Console.WriteLine("Hello World!");  // statis. 


            // jenis-jenis comment. 
            // =>> one line. 

            /*
                =>> multi line.
             */

            // jenis jenis tipe data / data type

            /*
             *    -int    => bilangan integer/bulat
             *    -double => bilangan rill/pecahan.
             *    -float  => bilangan rill/pecahan.
             *    -string => berisikan kumpulan huruf-huruf.
             *    -char   => huruf
             *    -decimal => untuk bilangan desimal/ uang. 
             *    -long   => bilangan.
             *    -uint   => bilangan.
             *    -bool   => untuk boolean. 1 dan 0 => true dan false. 
             *    -var    => tipe data spesial di C#. 
             */


            Console.WriteLine("Buat variable bernama Luas dengan value = 30 dan Tinggi = 20");

            //mendeklarasikan variabel secara statis.

            // input value 30 dan 20. 
            int Luas = 300838834;
            int Tinggi = 20;

            //prosesnya 


            //output
            Console.WriteLine("\tOutput Value integer:\n");
            Console.WriteLine(Luas);
            Console.WriteLine(Tinggi);



            double Xr = 45.5; 


            Console.WriteLine("\tOutput Value double:\n");
            Console.WriteLine(Xr);
            Console.WriteLine();
            //mendeklarasikan variabel secara dinamis. 


            float Ty = 34.5F;

            Console.WriteLine("\tOutput Value float:\n");
            Console.WriteLine(Ty);
            Console.WriteLine();



            string Mantan = "ANANDA";
            Console.WriteLine("\tOutput Value string:\n");
            Console.WriteLine(Mantan);
            Console.WriteLine();




            char Huruf = 'A';
            Console.WriteLine("\tOutput Value char:\n");
            Console.WriteLine(Huruf);
            Console.WriteLine();


            decimal Money = 10000M;
            Console.WriteLine("\tOutput Value decimal:\n");
            Console.WriteLine(Money);
            Console.WriteLine();


            uint AnginSpeed = 243434343;
            Console.WriteLine("\tOutput Value uint:\n");
            Console.WriteLine();
            Console.WriteLine();


            long Jarak = -4343434343433434999;
            Console.WriteLine("\tOutput Value long:\n");
            Console.WriteLine(Jarak);
            Console.WriteLine();


            ulong CahayaSpeed = 4343434343433434999;



            Console.WriteLine("\tOutput Value ulong:\n");
            Console.WriteLine(CahayaSpeed);
            Console.WriteLine();



            bool a = true;
            bool b = false;

            Console.WriteLine("\tOutput Value bool:\n");
            Console.WriteLine(a);
            Console.WriteLine(b);


            var Umur = 34.4;
            var Umur2 = 30;
            var Nama = "Setya Novanto";

            Console.WriteLine("\tOutput Value var:\n");
            Console.WriteLine(Umur);
            Console.WriteLine(Umur2);
            Console.WriteLine(Nama);









        }
    }
}
