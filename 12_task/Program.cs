using System;

namespace _12_task
{
    class Program
    {
        /*
         * Вычислите значение выражения ex−2+|sin(x)|−x4⋅cos1x при x=3.6 Ответ: -156.1276
         */
        static void Main(string[] args)
        {
            Double x;
            Double c;
            Console.WriteLine("Введите х");
            x = Convert.ToDouble(Console.ReadLine());
            c = Math.Pow(Math.E, x - 2) + Math.Abs(Math.Sin(x)) - Math.Pow(x, 4)
                * Math.Cos(1 / x);
            Console.WriteLine($"Ответ = {Math.Round(c, 4)}");
            Console.ReadLine();
        }
    }
}
