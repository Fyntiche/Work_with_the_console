using System;

namespace _18_task
{
    class Program
    {
        /*
         * Пользователь вводит сторону квадрата. Найдите периметр и площадь квадрата.
         */
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите строну квадрата");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Периметр = {a * 4}, площадь = {a*a}");
            Console.ReadLine();
        }
    }
}
