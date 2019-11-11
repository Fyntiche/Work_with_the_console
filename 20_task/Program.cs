using System;

namespace _20_task
{
    class Program
    {
        /*
         * Пользователь вводит время в минутах и расстояние в километрах. 
         * Найдите скорость в м/c.
         */
        static void Main(string[] args)
        {
            int time;
            int distance;
            Double speed;
            Console.WriteLine("Введите время в минутах");
            time = Convert.ToInt32(Console.ReadLine())/60;
            Console.WriteLine("Введите расстояние в километрах");
            distance = Convert.ToInt32(Console.ReadLine());
            speed = distance / time / 3.6;
            Console.WriteLine($"Скорость в м/с = {speed}");
            Console.ReadLine();
        }
    }
}
