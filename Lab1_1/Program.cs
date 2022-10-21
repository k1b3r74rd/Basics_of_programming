using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{ // Для заданного натурального числа n и вещественного x рассчитать сумму: 𝑐𝑡𝑔𝑥 + 𝑐𝑡𝑔2𝑥 + 𝑐𝑡𝑔3𝑥+. . . +𝑐𝑡𝑔𝑛𝑥
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;  // Степень
            Console.WriteLine("Введите натуральное число N:");
            n = int.Parse(Console.ReadLine());

            double x;   // "Угол"
            Console.WriteLine("Введите вещественное число X:");
            x = double.Parse(Console.ReadLine());

            double ctg = 1.0 / Math.Tan(x); // Котангенс
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(ctg, i);
            }

            Console.WriteLine(sum);
        }
    }
}
