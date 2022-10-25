using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Создать класс Fraction для работы с дробными числами. Число должно быть представлено двумя полями: 
    целая часть – длинное целое со знаком, дробная часть – беззнаковое короткое целое. 
    Реализовать арифметические операции сложения, вычитания, умножения и операции сравнения.
 */
namespace Lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, b11, b22; string b1, b2;
            Console.WriteLine("Введите первое число в порядке: целая часть, дробная часть");
            a1 = int.Parse(Console.ReadLine());
            b1 = Console.ReadLine();
            Console.WriteLine("Введите второе число в порядке: целая часть, дробная часть");
            a2 = int.Parse(Console.ReadLine());
            b2 = Console.ReadLine();
            for (int i = b1.Length; i < b2.Length; i++) b1 += '0';
            for (int i = b2.Length; i < b1.Length; i++) b2 += '0';
            b11 = int.Parse(b1);
            b22 = int.Parse(b2);
            Fraction Aa = new Fraction(a1, b11); Fraction Bb = new Fraction(a2, b22);
            Console.WriteLine($"\nРезультаты:\nСложение: {Aa.Sum(Bb)}\nВычитание: {Aa.Vch(Bb)}");
            Console.WriteLine($"Умножение: {Aa.Umn(Bb)}\b ");
            Console.WriteLine($"Сравнение: Число № {Aa.Srav(Bb)}\b больше");
        }
    }
    class Fraction
    {
        private double a; private int b; public double A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public Fraction(double a, int b)
        {
            this.a = a; this.b = b;
        }
        public Fraction Sum(Fraction second)
        {
            double result_a = a + second.A; int result_b = b + second.B;
            if (result_b > 10)
            {
                result_b -= 10; result_a++;
            }
            return new Fraction(result_a, result_b);
        }
        public Fraction Vch(Fraction second)
        {
            double result_a = a - second.A; int result_b = b - second.B;
            if (result_b < 0)
            {
                result_b = result_b * (-1);
            }
            return new Fraction(result_a, result_b);
        }
        public Fraction Umn(Fraction second)
        {
            double m1 = int.Parse(Convert.ToString(a) + Convert.ToString(b)) / Math.Pow(10, Convert.ToString(b).Length);
            double m2 = int.Parse(Convert.ToString(second.A) + Convert.ToString(second.B)) / Math.Pow(10, Convert.ToString(second.B).Length); double result_a = m1 * m2;
            return new Fraction(result_a, 0);
        }
        public Fraction Srav(Fraction second)
        {
            double result_srav; if (a > second.A)
                result_srav = 1;
            else
            if (a < second.A) result_srav = 2;
            else
            if (b > second.b)
                result_srav = 1;
            else
                result_srav = 2;
            return new Fraction(result_srav, 0);
        }
        public override string ToString()
        {
            return $"{a} {b}";
        }
    }
} 
