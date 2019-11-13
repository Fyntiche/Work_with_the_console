using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_task
{
    class Program
    {
        /*
         * Даны две переменных с некоторыми значениями. 
         * Поменять местами значения этих переменных
         */
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Первое число = {a}, " +
                $"второе число = {b}");
            Console.ReadLine();
        }
    }
}
