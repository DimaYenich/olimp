using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC
{
    internal class C
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int X = int.Parse(str.Split(' ')[0]);
            int Y = int.Parse(str.Split(' ')[1]);
            int W = int.Parse(str.Split(' ')[2]);
            if (X+Y+W == 2020) 
            {
                Console.WriteLine($"{X}+{Y}+{W}");
            }
            else if (X + Y - W == 2020)
            { 
                Console.WriteLine($"{X}+{Y}-{W}");
            }
            else if (X - Y + W == 2020)
            { 
                Console.WriteLine($"{X}-{Y}+{W}");
            }
            else if (X - Y - W == 2020)
            {
                Console.WriteLine($"{X}-{Y}-{W}");
            }
            else if (Y + W - X == 2020)
            {
                Console.WriteLine($"{Y}+{W}-{X}");
            }
            else if (Y - W - X == 2020)
            {
                Console.WriteLine($"{Y}-{W}-{X}");
            }
            else if (W - Y - X == 2020)
            {
                Console.WriteLine($"{W}-{Y}-{X}");

            }
            else
                Console.WriteLine("CORONA");
        }
    }
}
