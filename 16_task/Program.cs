using System;

namespace _16_task
{
    class Program
    {
        /*
         * Пользователь вводит три числа. Увеличьте первое число в два раза, 
         * второе числа уменьшите на 3, третье число возведите в квадрат и 
         * затем найдите сумму новых трех чисел.
         */
        static void Main(string[] args)
        {
            double a1;
            double a2;
            double a3;
            double summ;
            Console.WriteLine("Введите 1 число");
            a1 = Convert.ToDouble(Console.ReadLine());
            a1 *= 3;
            Console.WriteLine("Введите 2 число");
            a2 = Convert.ToDouble(Console.ReadLine());
            a2 -= 3;
            Console.WriteLine("Введите 3 число");
            a3 = Convert.ToDouble(Console.ReadLine());
            a3 = Math.Pow(a3, 2);
            summ = a1 + a2 + a3;
            Console.WriteLine($"Первое число = {a1}, второе = {a2}," +
                $"третье = {a3}, сумма = {summ}");
            Console.ReadLine();
        }
    }
}
