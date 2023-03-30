using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G
{
    internal class H
    {
        static void Main(string[] args)
        {
            int time = 0;
            int number = int.Parse(Console.ReadLine());
            int[] krots = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(krots);

            int[] nori = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(nori);

            for (int i = 0; i < number; i++)
            {
                int dist = Math.Abs(krots[i] - nori[i]);
                if (dist > time)
                {
                    time = dist;
                }
            }
            Console.WriteLine(time);
        }
    }
}
