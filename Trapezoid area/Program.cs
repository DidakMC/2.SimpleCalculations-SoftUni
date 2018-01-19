using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var Hight = double.Parse(Console.ReadLine());
            var area = (sideA + sideB) * Hight / 2;
            Console.WriteLine(area);

        }
    }
}
