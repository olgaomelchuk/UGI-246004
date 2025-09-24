using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону прямоугольника");
            var b = double.Parse(Console.ReadLine());

            var area = a * b;
            var perimeter = (a + b) * 2;

            var double_a = Math.Pow(a, 2);
            var double_b = Math.Pow(b, 2);
            var diagonal = Math.Sqrt(double_a+double_b);

            Console.WriteLine("Площадь прямоугольника равна " + area);
            Console.WriteLine("Периметр прямоугольника равен " + p);
            Console.WriteLine("Длина диагонали прямоугольника равна " + d);
        }
    }
}
