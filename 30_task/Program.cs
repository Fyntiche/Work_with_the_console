using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_task
{
    class Program
    {
        /*
         * Дано число a. Не пользуясь никакими арифметическими операциями 
         * кроме умножения, получите 
         * а)a4 за две операции; 
         * б) a6 за три операции; 
         * в) a15 за пять операций.
         */
        static void Main(string[] args)
        {
            int a;
            int a4;
            int a2;
            int a6;
            int a8;
            int a16;
            int a15;
            Console.WriteLine("Введите a");
            a = Convert.ToInt32(Console.ReadLine());
            a2 = a * a;
            a4 =  a2 * a2;

            a2 = a * a;
            a6 = a2 * a2;
            a6 = a6 * a2;

            a2 = a * a;
            a4 = a2 * a2;
            a8 = a4 * a4;
            a16 = a8 * a8;
            a15 = a16 / a;

            Console.WriteLine($"а в 4 = {a4}, " +
                $"a в 6 = {a6}, " +
                $"a в 15 = {a15}");
            Console.ReadLine();
        }
    }
}
