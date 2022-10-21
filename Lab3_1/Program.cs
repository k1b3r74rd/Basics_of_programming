using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{ // Даны четыре натуральных числа. Найти наименьшее общее кратное (НОК) для этих четырех чисел.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите d: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine($"Наименьшее общее кратное: {NOK(a, b, c, d)}");
        }
        static double NOK(double a, double b, double c, double d)
        {
            double s = a * b * c * d;
            for (int i = 1; i <= s; i++)
            {
                if ((i % a == 0) && (i % b == 0) && (i % c == 0) && (i % d == 0))
                {
                    return i;
                }
            }
            return s;
        }
    }
}
