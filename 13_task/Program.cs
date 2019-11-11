using System;

namespace _13_task
{
    class Program
    {
        /*
         * Вычислите значение выражения x2+b−−−−−√5−b2sin3(x+a)x при a=0.1, b=0.2 и x=1 Ответ: 1.0088
         */
        static void Main(string[] args)
        {
            double x;
            double b;
            double a;
            double c;
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            c = Math.Pow(Math.Pow(x, 2) + b, 1 / 5) - ((Math.Pow(b, 2) *
                Math.Pow(Math.Sin(x + a), 3)) / x);
            Console.WriteLine($"Ответ = {Math.Round(c, 4)}");
            Console.ReadLine();
        }
    }
}
