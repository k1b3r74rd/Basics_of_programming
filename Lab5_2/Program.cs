using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
    Сгенерировать текст воспользовавшись сервисом расположенным по адресу
    http://www.randomtextgenerator.com/. Сохранить сгенерированный текст в текстовый файл. 
    В зависимости от варианта выполнить задание с полученным файлом
 */
namespace Lab5_2
{ // Посчитать количество строк в файле.
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            StreamReader basefile = new StreamReader(@"G:\0.PROJECTS\C#\TUSUR\Labs_1-kurs\Lab5_2\Text.txt");

            int sum = 0;

            line = basefile.ReadLine();
            while (line != null)
            {
                sum += 1;
                line = basefile.ReadLine();
            }

            basefile.Close();
            Console.WriteLine(sum);
        }
    }
}
