using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_BGN_USD_EUR_GBP
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();
            var BGN = "BGN";
            var USD = "USD";
            var GBP = "GBP";
            var EUR = "EUR";

            switch (currency1) {
                case "USD":
                    switch (USD)
                    {
                        case "BGN":
                            Console.WriteLine(sum * 1.79549);
                            break;
                        case "GBP":
                            Console.WriteLine(sum * 0.70854);
                            break;
                        case "EUR":
                            Console.WriteLine(sum * 0.91801);
                            break;
                    }
                case "BGN":
                    switch (BGN)
                    {
                        case "USD":
                            Console.WriteLine(sum * 1);
                            break;
                        case "GBP":
                            Console.WriteLine(sum * 0.70854);
                            break;
                        case "EUR":
                            Console.WriteLine(sum * 0.91801);
                            break;
                    }
                case "EUR":
                    switch (EUR)
                    {
                        case "USD":
                            Console.WriteLine(sum * 1);
                            break;
                        case "BGN":
                            Console.WriteLine(sum * 1.79549);
                            break;
                        case "GBP":
                            Console.WriteLine(sum * 0.70854);
                            break;
                    }
                case "GBP":
                    switch (GBP)
                    {
                        case "USD":
                            Console.WriteLine(sum * 1);
                            break;
                        case "BGN":
                            Console.WriteLine(sum * 1.79549);
                            break;
                        case "EUR":
                            Console.WriteLine(sum * 0.91801);
                            break;
                    }
            }
             Console.WriteLine(Math.Round(sum,2) + currency2);

        }
        
    }
}
