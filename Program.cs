using System;

namespace Pemograman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            int a = 0;
            int b = 0;

            int total = 0;

            Console.Write("Masukan angka a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan angka b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Pembagian");
            Console.WriteLine("4. Perkalian");
            Console.Write("Masukan Operator : ");
            Console.Write("Masukan Operator : ");
            switch (Console.ReadLine())
            {
                case "1":
                    total = a + b;
                    Console.WriteLine("Hasil : " + total);
                    break;
                case "2":
                    total = a - b;
                    Console.WriteLine("Hasil : " + total);
                    break;
                case "3":
                    total = a / b;
                    Console.WriteLine("Hasil : " + total);
                    break;
                case "4":
                    total = a * b;
                    Console.WriteLine("Hasil : " + total);
                    break;

                    

                   
            }
        }
    }
}
