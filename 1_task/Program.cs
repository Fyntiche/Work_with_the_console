using System;

namespace Work_with_the_console
{
    /*
     *Вывести на экран текущее название дня недели, название месяца и свое имя. Каждое слово должно быть в отдельной строке. 
     */
    class Program
    {
        enum Days
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье


        }
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            int dayOfWeek = (int)date.DayOfWeek;
            string name;

            Console.WriteLine("Введите пожалуйста свое имя");
            name = Console.ReadLine();
           
            Console.WriteLine($"Текущий день недели {(Days)dayOfWeek}. \n Ваше имя {name}");
            Console.ReadLine();
        }
    }
}
