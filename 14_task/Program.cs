using System;

namespace _14_task
{
    class Program
    {
        /*
         * Пользователь вводит два числа. Найдите сумму и произведение данных чисел.
         */
        static void Main(string[] args)
        {
            double a;
            double b;
            double summ;
            double op;
            Console.WriteLine("Введите 1 число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            b = Convert.ToDouble(Console.ReadLine());
            summ = a + b;
            op = a * b;
            Console.WriteLine($"Сумма = {summ}, произведение = {op}");
            Console.ReadLine();

        }
    }
}
