using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{ // Дана матрица 5Х5. Вывести ее в транспонированном виде (поменять местами строки со столбцами).
    internal class Program
    {
        static void Main(string[] args)
        {
            // Объявление матрицы и её заполнение
            double[,] Matrix = new double[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++) 
                { 
                    Console.WriteLine($"Введите элемент [{i }, {j}]");
                    Matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Транспонирование 
            double[,] Matrix_transp = new double[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix_transp[i,j] = Matrix[j,i];
                    Console.Write($"{Matrix_transp[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
