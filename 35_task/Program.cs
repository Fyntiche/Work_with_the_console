using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 7)
            {
                Console.WriteLine("Yes");
            }
            if (x > 10)
            {
                Console.WriteLine("No");
            }
            if (x == 9)
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}
