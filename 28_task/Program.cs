using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_task
{
    class Program
    {
        /*
         * Пользователь вводит сумму вклада в банк и годовой процент. 
         * Найдите сумму вклада через 5 лет 
         */
        static void Main(string[] args)
        {
            double summ;
            double proc;
            Console.WriteLine("Введите сумму");
            summ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент вклада");
            proc = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i< 5; i++)
            {
                summ += summ * proc/100;
            }
            Console.WriteLine($"Сумма вклада через 5 лет = {Math.Round(summ,3)}");
            Console.ReadLine();
        }
    }
}
