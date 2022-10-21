using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
    Разработать программу – клавиатурный тренажер. В ходе работы программы должны генерироваться
символы, которые необходимо вводить пользователю, количество правильно введенных символов должно
подсчитываться, при вводе неверного символа, счетчик правильно введенных символов должен обнуляться,
по завершению работы тренажера результат верно введенных символов должен выводиться на экран. Выход
из режима тренажера должен осуществляться по нажатию клавиши «Esc». При вводе неверного символа
необходимо выдавать звуковое сопровождение (системный звук). При запуске приложения должен
предоставляться выбор набор символов какого языка необходимо тренировать: русский или английский.
*/

namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char neededKey, pressedKey; 
            int kod, a, d;
            a = 0; d = 0;

            Console.WriteLine("Введите 1 для продолжения на русском языке или 0, если хотите работать на английском:");
            int x = int.Parse(Console.ReadLine()); 
            if (x == 0)
            {
                Random rand = new Random();
                Console.WriteLine($"Вводите символы которые видите на экране"); 
                while (true)
                {
                    kod = rand.Next(33, 122); 
                    neededKey = (char)kod; 
                    var key = ConsoleKey.Escape; 
                    Console.Write(neededKey);

                    pressedKey = Console.ReadKey().KeyChar; 
                    key = (ConsoleKey)pressedKey; 
                    Console.Write('\b');

                    if (key != ConsoleKey.Escape) 
                        if (neededKey != pressedKey)
                        {
                            Console.WriteLine("\nОшибка!"); 
                            Console.Beep();
                            d = 0;
                        }
                        else
                        {
                            d = d + 1; 
                            a = a + 1;
                            Console.WriteLine("\nПравильно: " + d);
                        }
                    else
                    {
                        Console.WriteLine("\n_Ваш рекорд: " + a); 
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Random rand = new Random();
                Console.WriteLine($"Вводите символы которые видите на экране"); 
                while (true)
                {
                    kod = rand.Next(1040, 1103); 
                    neededKey = (char)kod; 
                    var key = ConsoleKey.Escape; 
                    Console.Write(neededKey);

                    pressedKey = Console.ReadKey().KeyChar; 
                    key = (ConsoleKey)pressedKey; 
                    Console.Write('\b');

                    if (key != ConsoleKey.Escape) 
                        if (neededKey != pressedKey)
                        {
                            Console.WriteLine("\nОшибка!"); 
                            Console.Beep();
                            d = 0;
                        }
                        else
                        {
                            d = d + 1; 
                            a = a + 1;
                            Console.WriteLine("\nПравильно: " + d);
                        }
                    else
                    {
                        Console.WriteLine("\n_Ваш рекорд: " + a); 
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
