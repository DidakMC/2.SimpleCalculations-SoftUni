﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchToCentimetres
{
    class Program
    {
        static void Main(string[] args)
        {
            var inch = double.Parse(Console.ReadLine());
            var centimetres = inch * 2.54;
            Console.WriteLine(centimetres);
        }
    }
}
