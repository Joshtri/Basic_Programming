using System;
using System.Collections.Generic;
using System.Collections;

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

            //Console.WriteLine(3<5);
            //Console.WriteLine(3>5);


            //Contoh login menggunakan kondisi. 


            //kalo sudah daftar otomatis kesimpan datanya di data center. 
            //const string Email = "raffi1408@gmail.com";
            //const int Password = 554001;



            // label. 
            //mau login.
            //

            /*
            
            MenuLogin:
            Console.Write("Masukkan Email = ");
            var Useremail = Console.ReadLine();


            Console.Write("Masukkan password =");
            var Pswd = int.Parse(Console.ReadLine());
            if (Useremail == Email && Pswd == Password)
            {
                Console.WriteLine("Selamat datang di Facebook");
                
            }

            else if (Useremail != Email  && Pswd != Password && Useremail == Email)
            {
                Console.WriteLine("Masukkan ulang data anda\n");
                goto MenuLogin;
            }

            else
            {
                Console.WriteLine("Masukkan ulang data anda\n");
                goto MenuLogin;
            }


            // statement if,else if, else sudah kelar. 
            // sekarang masuk ke statement condition switch. 


            Console.WriteLine("1. Menu Daftar Makanan");
            Console.WriteLine("2. Menu Daftar Harga");
            Console.WriteLine("3. Menu Daftar Deskripsi");

            Console.Write("Masukkan menu yang anda inginkan");
            var Select = int.Parse(Console.ReadLine());

            if (Select == 1)
            {
                Console.WriteLine("Selamat datang di menu daftar makanan");
            }

            else if (Select == 2)
            {
                Console.WriteLine("Selamat datang di menu Daftar Harga");
            }


            /*
            switch (Select)
            {
                // gak perlu Select == 0 karena udah terotomatis ditentukan value true untuk memilih opsi.
                case 1:
                    Console.WriteLine("Selamat datang di menu daftar makanan");
                    break;
                case 2:
                    Console.WriteLine("Selamat datang di menu Daftar Harga");
                    break;

                default:
                    break;



            }
            */


            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");
            //Console.WriteLine("100");

            //statement perulangan.

            /*
             *      1. For Loop
             *      2. While
             *      3. Do-While
             */

            // Si raffi mau mencetak namanya sebanyak 100 kali. 
            //string Nama = "Raffi";
            //var Hitungkarakter = Nama.Length;
            //Console.WriteLine("Nama anda {0}",Nama);
            //Console.WriteLine("Jumlah nama anda yaitu {0} ",Hitungkarakter);

            string Name = "Raffi";

            //int i = 0;
            //while (i > 100)
            //{
            //    Console.WriteLine("Nama dia adalah {0} = loop ke-{1} ", Name, i);
            //    i++;

            //    //gunakan increment(i++) dan decrement(i--) dalam perulangan.
            //}

            //do
            //{
            //    Console.WriteLine("Helo");
            //    i++;

            //} while (i < 100);



            //for loop



            //array 1 Dimensi. 
            //int[] Arr = new int[5] { 1, 5, 6, 5, 6 };

            ////Console.WriteLine(Arr[0]+" "+ Arr[1]); // tidak efektif ya. 

            //// cara lebih baik menggunakan for loop, do while, dan while. 
            //var i = 0;
            //var Length_Array = Arr.Length;
            //while (i < Arr.Length)
            //{
            //    Console.Write(" "+ Arr[i]);

            //}

            //Console.WriteLine("\n\n\n");
            //Console.ForegroundColor = ConsoleColor.DarkGreen; 
            //Console.WriteLine($"Panjang array adalah = {Length_Array}");
            //Console.ResetColor();

            Console.Write("Input the array length :");
            var n = int.Parse(Console.ReadLine());

            //deklarasi array. 
            int[] Numbers = new int[n];


            //gunakan perulangan untuk input data pada array.
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"Masukkan data ke-{i} = ");
                Numbers[i] = int.Parse(Console.ReadLine());
            }


            //untuk menampilkan data yang sudah di input. 
            Console.WriteLine("Data yang kamu input adalah : ");
            foreach (var item in Numbers)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(" "+ item);
                Console.ResetColor();

            }

            Console.ReadLine();

            //int[] Array 
            //int[] arrs = { 45 };
            //int[] arrry = new int[5]{34,5,6,4,5 };

            // ada 4 macam deklarasi array. untuk apa sih itu array? 
            // kegunaannya untuk menginput data" berupa text/string dan angka. 



        }
    }
}
