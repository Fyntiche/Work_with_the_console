using System;

namespace _9_task
{
    class Program
    {
        /*
         * Вычислите |x|+x в 5, если x=−2. Ответ: -30
         */
        static void Main(string[] args)
        {
            int x;
            int c;
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine());
            c = Math.Abs(x) + Convert.ToInt32(Math.Pow(x, 5));
            Console.WriteLine($"Ответ = {c}");
        }
    }
}
