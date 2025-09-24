using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Александр Сергеевич Пушкин");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Зимнее утро");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Мороз и солнце; день чудесный!");
            Console.WriteLine("Еще ты дремлешь, друг прелестный —");
            Console.WriteLine("Пора, красавица, проснись:");
            Console.WriteLine("Открой сомкнуты негой взоры");
            Console.WriteLine("Навстречу северной Авроры,");
            Console.WriteLine("Звездою севера явись!");

            Console.ResetColor();
        }
    }
}
