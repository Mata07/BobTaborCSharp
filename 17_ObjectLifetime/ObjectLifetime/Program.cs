﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Mode { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
