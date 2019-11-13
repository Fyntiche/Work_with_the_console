using System;

namespace _25_task
{
    class Program
    {
        /*
         * Пользователь вводит количество недель, 
         * месяцев, лет и получает количество дней 
         * за это время. Считать, что в месяце 30 
         * дней.
         */
        static void Main(string[] args)
        {
            int days;
            int weeks;
            int month;
            int year;
            Console.WriteLine("Введите колличество недель");
            weeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество месяцев");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество лет");
            year = Convert.ToInt32(Console.ReadLine());
            days = weeks * 7 + month * 30 + year * 12 * 30;
            Console.WriteLine($"Количество дней = {days}");
            Console.ReadLine();
        }
    }
}
