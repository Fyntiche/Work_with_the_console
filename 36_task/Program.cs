using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_task
{
    class Program
    {
        enum Mountse
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Введите номер месяца");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{(Mountse)(num)}");
            Console.ReadLine();

        }
    }
}
