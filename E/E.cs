using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class E
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (number <= Math.Pow(2, i))
                {
                    if(number < Math.Pow(2, i))
                        Console.WriteLine(i - 1);
                    if(number == Math.Pow(2, i))
                        Console.WriteLine(i);
                    return;
                }
            }
            
        }
    }
}
