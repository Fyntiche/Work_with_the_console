using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int c;
            int y;
            Console.WriteLine("Введите 1 число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            y = Convert.ToInt32(Console.ReadLine());
            if (x>y)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                c = x;
                x = y;
                y = c;
                Console.WriteLine($"1 число ={x}, " +
                    $"2 число = {y}");
            }
            Console.ReadLine();

        }
    }
}
