using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Всички стойности са в лева
            var value = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            var BGN = 1.0;
            var USD = 1.79549;
            var EUR = 1.95583;
            var GBP = 2.53405;
            switch (input)
            {
                case "BGN":
                    break;
                case "USD":
                    value = value * USD;
                    break;
                case "EUR":
                    value = value * EUR;
                    break;
                case "GBP":
                    value = value * GBP;
                    break;
            }
            switch (output)
            {
                case "BGN":
                    break;
                case "USD":
                    value = value / USD;
                    break;
                case "EUR":
                    value = value / EUR;
                    break;
                case "GBP":
                    value = value / GBP;
                    break;
            }
            Console.WriteLine(Math.Round(value, 2) + " " + output);
        }
    }
}