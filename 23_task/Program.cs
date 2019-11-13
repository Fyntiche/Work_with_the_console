using System;


namespace _23_task
{
    class Program
    {
        /*
         * Известно, что x кг конфет стоит a рублей. 
         * Определите, сколько стоит y кг этих конфет, 
         * а также сколько кг конфет можно купить на k рублей. 
         * Все значения вводит пользователь.

         */
        static void Main(string[] args)
        {
            double x;
            double a;
            double y;
            double k;
            double fullCena;
            double fullKG;
            
            Console.WriteLine("Введите кг конфет");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите желаемое количество кг конфет");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите желаемую сумму");
            k = Convert.ToDouble(Console.ReadLine());
            fullCena = a / x * y;
            fullKG = k / a / x;
            Console.WriteLine($"{y} кг конфет будет стоить {fullCena}," +
                $"за {k} рублей можно купить {fullKG} кг конфет");
            Console.ReadLine();
        }
    }
}
