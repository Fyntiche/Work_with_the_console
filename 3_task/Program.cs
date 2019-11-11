using System;

namespace _3_task
{
    class Program
    {
        /*
         *Вывести на экран пять строк из нулей, причем количество нулей в каждой строке равно номеру строки.
        */
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i ++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
