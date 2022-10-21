using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{ /* Дан массив из N элементов (вещественные числа). Вычислить:
    1) минимальный элемент массива;
    2) сумму элементов массива, расположенных между первым и последним положительными элементами.
    Преобразовать массив так, чтобы сначала располагались все элементы, равные нулю, а потом –остальные.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Введите размерность массива n: "); 
            n = int.Parse(Console.ReadLine());

            // Объявление массива
            double[] Array = new double[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i} элемент массива: "); 
                Array[i] = double.Parse(Console.ReadLine());
            }

            // 1. Нахождение минимального элемента
            double min = Array[0];
            Console.Write("1. Минимальный элемент массива: ");
            foreach (double number in Array)
            {
                if (min > number)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);

            // 2. Сумма элементов между первым и последним положительными элементами
            double sum = 0;
            int numMaxFirst = -1;

            for (int i = 0; i < n; i++) // Поиск позиции первого положительного элемента
            {
                if (Array[i] > 0)
                {       
                    numMaxFirst = i;
                    break;
                }
            }

            if (numMaxFirst == -1) // Проверка на наличие положительных элементов в массиве
            {
                Console.WriteLine("2. Положительных элементов в массиве нет.");
            } 
            else 
            {
                // ищем с конца положительный элемент
                for (int i = n-1; i >= 0; --i)
                {
                    if (Array[i] > 0)
                    {
                        if (i == numMaxFirst) // позиция совпала с уже имеющимся - элемент один
                        {
                            Console.WriteLine("2. В массиве всего один положительный элемент.");
                        }
                        else  
                        { 
                            for (int j = numMaxFirst + 1; j < i; j++)
                                sum += Array[j];
                            Console.WriteLine($"2. Сумма элементов между первым и последним положительными элементами: {sum}");
                        }
                        break;
                    }

                }
            }

            // 3. Преобразовать массив так, чтобы сначала располагались все элементы, равные нулю, а потом –остальные.
            for (int i = 0; i < n; i++)
            {
                if (Array[i] == 0)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Array[j] = Array[j - 1];
                    }
                    Array[0] = 0;
                }
            }

            Console.Write("3. Упорядоченный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Array[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
