using System;

namespace _8_task
{
    class Program
    {
        /*
         * Вычислите значение выражения (a+4b)(a−3b)+a2 при a=2 и b=3. Ответ:  -94
        */
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToInt32(Console.ReadLine());
            c = (a + 4 * b) * (a - 3 * b) + a * 2;
            Console.WriteLine($"Результат = {c}");
            Console.ReadLine();
        }
    }
}
