using System;

namespace _11_task
{
    class Program
    {
        /*
         * Вычислите значение выражения |x−5|−sinx 3+x2+2014−−−−−−−−√cos2x−3 при x=−2.34. Ответ: -1.76911 (проверено!)
         */
        static void Main(string[] args)
        {
            double x;
            double c;
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            c = (Math.Abs(x - 5) - Math.Sin(x)) / 3 + Math.Sqrt(Math.Pow(x, 2) + 2014) * Math.Cos(2 * x) - 3;
            Console.WriteLine($"Ответ = {Math.Round(c, 5)}");
            Console.ReadLine();
        }
    }
}
