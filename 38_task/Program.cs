using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введите 1 число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            y = Convert.ToInt32(Console.ReadLine());
            if ((x - y) > 100 || (y - x) > 100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
            
        }
    }
}
