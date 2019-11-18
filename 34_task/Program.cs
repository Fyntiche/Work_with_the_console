using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 3)
            {
                x += 10;
            }
             else
            {
                x += 10;
            }
            Console.WriteLine($"x={x}");
            Console.ReadLine();
        }
    }
}
