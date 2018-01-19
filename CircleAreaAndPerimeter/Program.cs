using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var areaCircle = Math.PI * radius * radius;
            var perimeterCircle = 2 * Math.PI * radius;
            Console.WriteLine($"Ärea = {areaCircle}");
            Console.WriteLine($"Perimeter= {perimeterCircle}");
        }
    }
}
