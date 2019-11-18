using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_task
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, answer;
            Console.Write("Введите x: ");
            x = Convert.ToSingle(Console.ReadLine());
            if (Math.Sqrt(x) % 1 != 0)
            {
                Console.Write("Число х не имеет квадратных корней.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write("Введите y: ");
            y = Convert.ToSingle(Console.ReadLine());
            if (Math.Sqrt(y) % 1 != 0)
            {
                Console.WriteLine("Число y не имеет квадратных корней.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (x < y)
            {
                Console.WriteLine("Отрицательное число!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            answer = Convert.ToSingle(Math.Sqrt(x - Math.Sqrt(y)));
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
