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

            /*
            // input dan deklarasikan. 
            int Alas = 3;
            int Tinggi = 5;
            double Luas;

            //proses 
            Luas =  0.5 * Alas * Tinggi;

            //outputnya 
            Console.WriteLine("Hasil dari hitungan diatas adalah {0} ", Luas);

            // perbedaan statis dan dinamis. 

            // statis => inputan nilainya langsung pada program. 
            // dinamis => inputan by user (diinput tanpa melalui program) 

            // input secara dinamis. 
            */
            /*
            int s1;
            int s2;
            int s3;

            Console.Write("Masukkan s1 : ");
            s1 = int.Parse(Console.ReadLine());

            Console.WriteLine(); // cuman spasi. 

            Console.Write("Masukkan s2 :");
            s2 = int.Parse(Console.ReadLine());

            Console.WriteLine(); // cuman spasi.

            Console.Write("Masukkan s3 : ");
            s3 = int.Parse(Console.ReadLine());

            //proses 
            int K;

            K = s1 + s2 + s3;

            Console.WriteLine("Demostrasi string Placeholder\n\n");
            //string.placeholder. 
            Console.WriteLine($"{s1}+{s2}+{s3} = {K}\n"); // teknik/gaya coding 1 => oke.
            Console.WriteLine("{0}+{1}+{2}= {3}",s1,s2,s3,K); // gaya coding 2 => lumayan 
            Console.WriteLine(s1+"+"+ s2 + "+" + s3+"="+ K); // gaya coding 3 => gk efektif

            Console.WriteLine("Jadi, keliling segitiga sama sisi adalah {0} cm.", K);
           
            var x1 = 3.5;
            var x2 = 5.6;

            var ngitungmodulasi = x1 % x2;
            var ngitungbagi = x1 / x2;  
            Console.WriteLine($"Pembagian :{ngitungbagi}");
            Console.WriteLine($"Modulasi : {ngitungmodulasi}");
           
            Console.ReadKey();

             

            //escape sequence. 
                    //cari di internet. 


            Console.WriteLine("Anak anjing\n");
            Console.WriteLine("\tAnak Bangsat (Bagus Sopan Terpelajar) ");
            Console.WriteLine("Anak Baik");
            Console.WriteLine("Anak Songong itu \"Baik\"");
            */

            //statement condition. 

            //statement if.
            /*contoh kasus.
             * 
             *      mencari buku di perpustakaan. dengan judul "Aku Anak Baik"
             */

            /*Operator Logic
             * 
             *      != 
             *      == 
             *      > 
             *      < 
             *      >=
             *      <=
             *      ||
             *      |
             *      &&
             *      &
             */

            /*
            Console.Write("Barang apa yang anda cari : ");
            string Find = Console.ReadLine();

            Console.WriteLine("\n");
            if (Find == "Buku")
            {
                Console.WriteLine("Judul Bukunya apa : ");
                string AskBook =  Console.ReadLine();

                if (AskBook == "Aku Anak Baik")
                {
                    Console.WriteLine("Itu dek, bukunya di lemari nomor 5\n");

                    Console.WriteLine("Kamu udah pinjama berapa lama ?");
                    int Borrow = int.Parse(Console.ReadLine());

                    if (Borrow <= 3)
                    {
                        Console.WriteLine("Oke, kamu tidak lewat dari batas peminjaman");
                    }

                    else if (Borrow >= 3)
                    {
                        Console.WriteLine("Kamu kena denda Rp.100K");
                    }
                }
            }

            else if (Find != "Book")
            {
                Console.WriteLine("Barang yang anda cari bukan disini.");
            }

            //else
            //{
            //    Console.WriteLine("Pulang Sana!");
            //}
            */

            Console.WriteLine(3<5);
            Console.WriteLine(3>5);

        }
    }
}
