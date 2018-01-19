using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterFarenheitCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var farenheit = (celsius * 1.8000)+32;
            Console.WriteLine(Math.Round(farenheit,2));
        }
    }
}
