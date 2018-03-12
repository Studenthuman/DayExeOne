using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.day1
{
    class Receipt
    {
        class Receipt
        {
            private string develop;
            private int year;
            private int vers;
            public int Numb { get; set; }
            public string Date { get; set; }
            public float Summ { get; set; }

            public Receipt()
            {
                Numb = 0;
                Date = null;
                Summ = 0;
            }

            public virtual void Input()
            {
                Console.WriteLine("Введите характеристики системного ПО------------------------");
                Console.WriteLine("Введите номер:");
                Numb = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите дату:");
                Date = Console.ReadLine();
                Console.WriteLine("Введите сумму:");
                Summ = Int32.Parse(Console.ReadLine());

            }
            public virtual void Print()
            {
                Console.WriteLine("Разработчик:" + Numb);
                Console.WriteLine("Год:" + Date);
                Console.WriteLine("Версия:" + Summ);
            }
        }
    }
}
