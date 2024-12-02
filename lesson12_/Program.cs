using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Circle.GetLenght(r) + " " + Circle.GetSquare(r));
            Console.WriteLine("Введите точку с координатами x, y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (Circle.GetPrin(x, y, r))
            {
                Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит окружности");
            }
            Console.ReadKey();
        }
    }
}