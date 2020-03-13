using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("Pilih Menu Calculator :");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Input Nomer Menu [1..4] = ");
            int menu = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (menu < 1)
            {
                Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia"); 
            }
            else if (menu > 4)
            {
                Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
            }
            else
            {
                Console.Write("Input Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input Nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                }
                else
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
            }
            Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
            Console.ReadKey();

        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
