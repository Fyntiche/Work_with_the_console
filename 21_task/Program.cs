using System;

namespace _21_task
{
    class Program
    {
        /*
         * Даны катеты прямоугольного треугольника. 
         * Найдите площадь, периметр и гипотенузу треугольника.
         */ 
        static void Main(string[] args)
        {
            int a;
            int b;
            double s;
            double p;
            double c;
            Console.WriteLine("Введите длинну 1 катета");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длинну 2 катета");
            b = Convert.ToInt32(Console.ReadLine());
            s = (a * b) / 2;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            p = a + b + c;
            Console.WriteLine($"Площать = {s}," +
                $"периметр = {p}, гипотенуза = {c}");
            Console.ReadLine();
        }
    }
}
