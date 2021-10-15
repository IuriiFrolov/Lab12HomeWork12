using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод переменных
            Console.WriteLine("Программа для работы с окружностью");
            Console.Write("Введите центр окружности X0=");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите центр окружности Y0=");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите радиус окружности R=");
            double radius = Convert.ToDouble(Console.ReadLine());
            if (radius >= 0)
            {
                Console.Write("Введите для точки кординату  X1=");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите для точки кординату  Y1=");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                // Вывод данных (Ответ)
                Console.WriteLine("Длина окружности = {0:f2}", Circle.Lenght(radius));
                Console.WriteLine("Площадь окружности = {0:f2}", Circle.Area(radius));
                Console.WriteLine("Точка {0} к окружности  ", Circle.Belong(x0, y0, radius, x1, y1));
            }
            else
            {
                Console.WriteLine("Радиус не может быть меньше 0 !");
            }
            Console.ReadKey();
        }
        public static class Circle
        {
            public static double Lenght(double radius)
            {
                double lenght = 2 * radius * Math.PI;
                return lenght;
            }
            public static double Area(double radius)
            {
                double area = radius * radius * Math.PI;
                return area;
            }
            public static string Belong(double x0, double y0, double radius, double x1, double y1)
            {
                string belong = " НЕ пренадлежит";

                if (Math.Pow((x0 - x1), 2) + Math.Pow((y0 - y1), 2) <= Math.Pow(radius, 2))
                {
                    string value = "пренадлежит";
                    belong = value;
                }
                return belong;
            }
        }
    }
}
