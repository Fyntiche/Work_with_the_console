using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_task
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 999; i++)
            {
                if ((i % 10).ToString() + ((i - i % 10) / 10).ToString() == "237")
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
