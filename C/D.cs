using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace D
{
    internal class D
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            int number = int.Parse(Console.ReadLine());
            string[] input = new string[number];
            for (int i = 0; i < number; i++)
            {
                input[i] = Console.ReadLine(); 
            }
            for (int i = 0; i < number; i++)
            {

                if (double.Parse(input[i].Split(' ')[0]) >= 3.5)
                {
                    if (input[i].Split(' ')[1] == "A" || input[i].Split(' ')[1] == "B")
                        Console.WriteLine("1");
                }
                else
                    Console.WriteLine("0");
            } 
        }
    }
}
