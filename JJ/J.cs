using System;
using System.Runtime;

namespace JJ
{
    internal class J
    {
        static void Main(string[] args)
        {
            int h1 = int.Parse(Console.ReadLine());
            long factorial;
            if (h1 == 0)
                Console.WriteLine(1);
            else
            {
                factorial = 1;
                for (int i = 1; i <= h1; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
            Console.ReadLine();
        }
    }
}
