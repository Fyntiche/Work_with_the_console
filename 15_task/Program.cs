using System;

namespace _15_task
{
    class Program
    {
        /*
         * Пользователь вводит число. Выведите на экран квадрат этого числа, куб этого числа.
         */
        static void Main(string[] args)
        {
            double a;
            double a2;
            double a3;
            Console.WriteLine("Введите число");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = Math.Pow(a, 2);
            a3 = Math.Pow(a, 3);
            Console.WriteLine($"Квадрат числа = {a2}, куб числа = {a3}");
            Console.ReadLine();
        }
    }
}
