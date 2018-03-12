using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipt r1 = new Receipt();

            r1.Input();
            Console.Clear();
            Console.WriteLine("Вывод данных ------------");
            Console.WriteLine("---------------------------Вывод класса ------------");
            r1.Print();
            Console.ReadKey(); 

        }
    }
}
