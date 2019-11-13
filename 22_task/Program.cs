using System;


namespace _22_task
{
    class Program
    {
        /*
         * Дано значение температуры в градусах Цельсия. 
         * Вывести температуру  в градусах Фаренгейта.
         */
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.WriteLine("Введите температуру в градусах Цельсия");
            a = Convert.ToDouble(Console.ReadLine());
            b = a * 1.8 + 32;
            Console.WriteLine($"температуру в градусах Фаренгейта = " +
                $"{b}");
            Console.ReadLine();
        }
    }
}
 