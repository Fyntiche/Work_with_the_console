using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_task
{
    class Program
    {
        /*
         * Даны три переменные a, b и c. Изменить значения этих переменных так, 
         * чтобы в a хранилось значение a+b, в b хранилась разность старых 
         * значений c−a, а в c хранилось сумма старых значений a+b+c. 
         */
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = c - (a - b);
            c += (a - b) + b + a + c;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            Console.ReadLine();

        }
    }
}
