using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{ // Найти наименьшее общее кратное (через наибольший общий делитель): НОК=a*b/ НОД.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(NOK(a, b));
        }
        static int NOD(int a, int b)
        {
            int div;
            if (a == b)
            {
                return a;
            }

            int d = a - b;
            if (d < 0)
            {
                d = -d; 
                div = NOD(a, d);
            } 
            else 
            {
                div = NOD(b, d);
            }
            return div;
        }

        static double NOK(int a, int b)
        {
            return (a * b / NOD(a, b));
        }
    }
}
