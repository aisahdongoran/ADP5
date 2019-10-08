using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kalkulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int c;
            int a = int.Parse(args[0]);
            int b = int.Parse(args[2]);

            if (args[1] == "+")
            {
                c = a + b;
                Console.Write("={0}", c);
            }
            else if (args[1] == "-")
            {
                c = a - b;
                Console.Write("={0}", c);
            }

            else if (args[1] == "/")
            {
                c = a / b;
                Console.Write("={0}", c);
            }
            else if (args[1] == "*")
            {
                c = a * b;
                Console.Write("={0}", c);
            }
            else if (args[1] == "%")
            {
                c = a % b;
                Console.Write("={0}", c);
            }
            else Console.Write("Inputan salah");


        }

    }
}