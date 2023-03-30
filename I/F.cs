using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    internal class F
    {
        static void Main(string[] args)
        {
            string startWord = Console.ReadLine();
            string pref = Console.ReadLine();
            string suf = Console.ReadLine();
            if (startWord.Substring(0, pref.Length) == pref)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            string reverseStart = null;
            string reverseSuf = null;

            for (int i = startWord.Length-1; i >= 0; i--)
            {
                reverseStart += startWord[i];
            }
            for (int i = suf.Length-1 ; i >= 0; i--)
            {
                reverseSuf += suf[i];
            }
            if (reverseStart.Substring(0, reverseSuf.Length) == reverseSuf)
                Console.WriteLine("True");
            else
                Console.WriteLine("False"); 
        }
    }
}
