using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5_1
{ // Записать выходной файл, вычтя из каждого числа сумму чисел файла.
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var numbers = File.ReadAllLines(@"G:\0.PROJECTS\C#\TUSUR\Labs_1-kurs\Lab5_1\TextFile1.txt");
            
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToInt32(numbers[i]);
            }

            StreamWriter Newfile = new StreamWriter(@"G:\0.PROJECTS\C#\TUSUR\Labs_1-kurs\Lab5_1\TextFile2.txt");
            for(int i = 0; i < numbers.Length; i++)
            {
                int newnum = Convert.ToInt32(numbers[i]) - sum;
                Newfile.WriteLine(newnum);
            }
            Newfile.Close();
        }
    }
}
