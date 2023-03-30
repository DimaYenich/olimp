using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перше число: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Друге число: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Третє число: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            if (firstNumber == (secondNumber + thirdNumber) || secondNumber == (firstNumber + thirdNumber) || thirdNumber == (firstNumber + secondNumber))
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
            Console.ReadLine();
        }
    }
}
