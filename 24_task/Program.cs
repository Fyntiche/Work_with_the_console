using System;

namespace _24_task
{
    class Program
    {
        /*
         * Пользователь вводит количество дней, указывает 
         * процент скидки и вводит сумму. Рассчитать прибыль, 
         * если за каждый день сумма увеличивается на 3 $  и 
         * затем применяется скидка, то есть итоговая сумма 
         * еще увеличивается на данное число процентов.
         */
        static void Main(string[] args)
        {
            int days;
            int sale;
            double sum = 0;
            Console.WriteLine("Введите количество дней");
            days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку");
            sale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму");
            sum = Convert.ToDouble(Console.ReadLine());
            sale /= 100;
            for (int i= 0; i<days; i++)
            {
                sum += 3;
                sum += sum * sale;

            }
            Console.WriteLine($"Итоговая прибыль равна ={sum}");
            Console.ReadLine();
        }
    }
}
