using System;

namespace _4_task
{
    class Program
    {
        /*
         *Вывести на экран прямоугольник, заполненный буквами А. Количество строк в прямоугольнике равно 5, количество столбцов равно 8. 
         */
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j ++)
                {
                    Console.Write("A");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
