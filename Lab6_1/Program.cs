using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Создать класс Angle для работы с углами на плоскости, задаваемыми величинами в градусах и
    минутах. Обязательно должны быть реализованы: перевод в радианы, приведение к диапазону 0–360,
    увеличение и уменьшение угла на заданную величину, получение синуса, сравнение углов.
 */
namespace Lab6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle A = new Angle();
            Console.WriteLine("Введите градусы и минуты угла A: ");
            A.deg = Convert.ToDouble(Console.ReadLine());
            A.mins = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите, на сколько градусов нужно изменить угол: ");
            int change = Convert.ToInt32(Console.ReadLine());
            Angle B = new Angle();
            Console.WriteLine("Введите градусы и минуты угла B: ");
            B.deg = Convert.ToDouble(Console.ReadLine());
            B.mins = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Исчисления для угла А");
            Console.WriteLine("Градусы в радианы: " + A.DegreesToRadians());
            Console.WriteLine("Приведение к диапазону 0-360: " + A.Normalize360());
            Console.WriteLine("Изменение угла: " + A.IncDecAngle(change));
            Console.WriteLine("Синус угла А: " + A.Sinus());
            Console.WriteLine("Сравнение угла А и В: " + A.Comparsion(A.FullAngle(), B.FullAngle()));
        }
    }
    public class Angle {
        public double deg;
        public double mins;

        public double FullAngle() { // Перевод минут в градусы.
            double mins_in_deg = mins / 60;
            double full_angle_deg = deg + mins_in_deg;
            return full_angle_deg;

        }

        public double DegreesToRadians() { // Градусы в радианы.
            double radians = FullAngle() * Math.PI / 180;
            return radians;
        }

        public double Normalize360() { // Нормализовать угол к формату 360 градусов.
            double angle = FullAngle();
            angle = angle % 360;
            if (angle < 0) {
                angle = angle + 360;
            }
            return angle;
        }

        public double IncDecAngle(double change) { // Увеличить или уменишь угол на заданную величину.
            double angle = FullAngle();
            double new_angle = angle + change;
            if ((new_angle % 360) < 0) {
                new_angle += 360;
            }
            return new_angle;
        }

        public double Sinus() { // Вычисление синуса угла.
            double angle = FullAngle();
            double sinus = Math.Sin(angle);
            return sinus;
        }

        public string Comparsion(double A, double B) { // Сравнить два угла.
            string result = "A";
            if (B > A) {
                result = "B";
            }
            return $"Угол {result} больше.";
        }
    }
}
