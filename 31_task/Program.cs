using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 647;
            int b = 170;
            int c = 30;
            int count = 0;
            count = (a / c) * (b / c);
            Console.WriteLine($"Вырезанных кваратов = {count}");
            Console.ReadLine();
        }
    }
}
