using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var hight = double.Parse(Console.ReadLine());
            var area = side * hight / 2;
            Console.WriteLine($"Triangle area = {Math.Round(area,2)}");

        }
    }
}
