using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{ // Составить программу, которая проверяет правописание «жи – ши» (т. е. если в заданном тексте
  // после «ш» или «ж» встретится «ы», то программа должна выдавать сообщение об ошибке)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            char[] text = Console.ReadLine().ToCharArray();

            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == 'ж' || text[i] == 'ш')
                {
                    if (text[i+1] == 'ы')
                    {
                        Console.WriteLine("Ошибка в тексте.");
                        break;
                    }
                }
            }
        }
    }
}
