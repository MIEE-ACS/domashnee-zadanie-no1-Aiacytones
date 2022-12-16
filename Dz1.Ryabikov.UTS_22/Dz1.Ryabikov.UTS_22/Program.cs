using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dz1.Ryabikov.UTS_22
{
    // Так как в моем задании нет диапазона, но в требованиях к лабе он есть, придумаю свой
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x == 1)
            {
                Console.Write("Введите число из диапазона [-10; 10]: ");
                double A = double.Parse(Console.ReadLine());
                if (A < -10 || A > 10)
                {
                    Console.Write("Введите число из диапазона [-10; 10]: ");
                    A = double.Parse(Console.ReadLine());
                    continue;
                }
                else if (A >= -10 || A <= 10)
                {
                    double B = Math.Pow(A, 2);
                    Console.WriteLine("A^2 = {0}", Math.Round(B, 3));
                    double B1 = Math.Pow(A, 4);
                    Console.WriteLine("A^4 = {0}", Math.Round(B1, 3));
                    double B2 = Math.Pow(A, 8);
                    Console.WriteLine("A^8 = {0}", Math.Round(B2, 3));
                }
                Console.WriteLine("1.Повтор программы");
                Console.WriteLine("2.Выход");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                    continue;
                else if (x == 2)
                    break;
                else
                    Console.WriteLine("Введите команду коректно");
                    x = int.Parse(Console.ReadLine());
            }
        }
    }
}