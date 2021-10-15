using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikMetod
{
    static class Circle
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
        public static string Belong (double x0, double y0, double radius, double x1, double y1 )
        {
            string belong = "не пренадлежит";

            if (Math.Pow((x0 - x1), 2) - Math.Pow((y0 - y1), 2) <= Math.Pow(radius, 2))
            {
                string value = "пренадлежит";
                belong = value;
            }
            return belong;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Длина окружности = {0:f2}", Circle.Lenght(5));
            Console.WriteLine("Площадь окружности = {0:f2}", Circle.Area(5));
            Console.WriteLine("Площадь окружности = {0:f2}", Circle.Belong(0,0,5,4,4));
            Console.ReadKey();


        }
    }

}
