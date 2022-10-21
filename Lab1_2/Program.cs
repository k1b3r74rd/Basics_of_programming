using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{ // Разработать программу вычисляющие сумму чисел 𝑆 = 2 + 4 + 8 + 16+ ..., до тех пор, пока сумма не превышает 1024.
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 2;

            do
            {
                sum += n;
                n *= 2;

                Console.WriteLine(sum);
            } while (sum <= 1024);
        }
    }
}
