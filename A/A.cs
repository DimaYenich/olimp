﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class A
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if(x <= y+z)
                Console.WriteLine(x);
            if(x >= y+z) 
                Console.WriteLine(y + z);
        }
    }
}
