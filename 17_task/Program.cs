using System;

namespace _17_task
{
    class Program
    {
        /*
         * Пользователь вводит три числа. Найдите среднее арифметическое этих чисел, 
         * а также разность удвоенной суммы первого и третьего чисел и утроенного 
         * второго числа.
         */
        static void Main(string[] args)
        {
            double a1;
            double a2;
            double a3;
            double z;
            double x;
            Console.WriteLine("Введите 1 число");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 3 число");
            a3 = Convert.ToDouble(Console.ReadLine());
            z = (a1 + a2 + a3) / 3;
            x = (a1 + a3) * 2 - a2 * 2;
            Console.WriteLine($"Среднее арифметическое = {z}," +
                $"разность = {x}");
            Console.ReadLine();

        }
    }
}
