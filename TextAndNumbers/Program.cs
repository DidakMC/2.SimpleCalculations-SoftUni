﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAndNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Console.ReadLine();
            var secondname = Console.ReadLine();
            var age = Console.ReadLine();
            var town = Console.ReadLine();
            Console.WriteLine($"You are {firstname} {secondname}, a {age}-years old person from {town}.");

        }
    }
}