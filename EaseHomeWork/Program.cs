using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaseHomeWork
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
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите для точки кординату  X1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите для точки кординату  Y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());

            double lenght = 2 * r * Math.PI;

            double area = r * r * Math.PI;

            string belong = "";
            if (((x0 - x1)* (x0 - x1)) + ((y0 - y1)*(y0 - y1)) <= (r*r))
            {
                string value = "пренадлежит";
                belong = value;
                
            }
            else
            {
                string value = "НЕ пренадлежит";
                belong = value;
            }

            //Вывод ответа
            Console.WriteLine("Длина окружности = {0:f2} ", lenght);
            Console.WriteLine("Площадь круга = {0:f2} ", area);
            Console.WriteLine("Точка {0} к окружности  ", belong);
            Console.ReadKey();
        }
    }
}
