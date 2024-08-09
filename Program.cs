using System;

namespace TinhSoNgayTrongThang
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;

            Console.Write("Ban muon dem so ngay cua thang nao: ");
            m = int.Parse(Console.ReadLine());

            switch (m)
            {
                case 2:
                    Console.WriteLine($"Thang {m} co 28 hoac 29 ngay");
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Thang {m} co 31 ngay");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Thang {m} co 30 ngay");
                    break;
            }
        }
    }
}