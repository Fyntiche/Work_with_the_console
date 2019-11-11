using System;

namespace _19_task
{
    class Program
    {
        /*
         * Пользователь вводит цены 1 кг конфет и 1 кг печенья. 
         * Найдите стоимость: а) одной покупки из 300 г конфет и 400 г печенья; 
         * б) трех покупок, каждая из 2 кг печенья и 1 кг 800 г конфет.
         */
        static void Main(string[] args)
        {
            double konf;
            double pech;
            Console.WriteLine("Введите цену 1 кг конфет");
            konf = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену 1 кг печенья");
            pech = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Одна покупка из 300 г конфет и 400 г печенья " +
                $"= {konf * 0.30 + pech * 0.40}. Цена 3 покупок = " +
                $"{(2*konf + 1.8 * pech) * 3}");
            Console.ReadLine();
        }
    }
}
