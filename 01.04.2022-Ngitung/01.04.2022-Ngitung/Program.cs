using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04._2022_Ngitung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program Statis menghitung luas segitiga.
                
                //"Luas = 1/2 x alas x tinggi"

            // input dan deklarasikan. 
            int Alas = 3;
            int Tinggi = 5;
            double Luas;

            //proses 
            Luas =  0.5 * Alas * Tinggi;

            //outputnya 
            Console.WriteLine("Hasil dari hitungan diatas adalah {0} ", Luas);




        }
    }
}
