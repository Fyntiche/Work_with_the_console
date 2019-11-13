using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Введите 1 число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"1 число = {a}, 2 число = {b} ");
            Console.ReadLine();
        }
    }
}
