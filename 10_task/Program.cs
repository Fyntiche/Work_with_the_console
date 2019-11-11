using System;

namespace _10_task
{
    class Program
    {
        /*
         * Вычислите значение выражения (x+1) во 2 +3(x+1) при а) x=1.7; б) x=3. Ответ: а) 15.39 б) 28
         */
        static void Main(string[] args)
        {
            double x;
            double c;
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            c = Math.Pow((x + 1), 2) + 3 * (x + 1);
            Console.WriteLine($"Ответ = {Math.Round(c, 2)}");
            Console.ReadLine();
        }
    }
}
