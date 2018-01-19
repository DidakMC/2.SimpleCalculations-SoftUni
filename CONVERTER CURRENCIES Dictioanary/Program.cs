using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumtoconv = decimal.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();

            Dictionary<string, decimal>

                currencies = new Dictionary<string, decimal>()

              {
                  { "USD", 1.79549m },
                 { "EUR", 1.95583m },
                  { "GBP", 2.53405m },
                  { "BGN", 1 }

              };

            var result = sumtoconv * (currencies[currency1] / currencies[currency2]);


            Console.WriteLine("{0} {1}", Math.Round(result, 2), currency2);
        }
    }
}