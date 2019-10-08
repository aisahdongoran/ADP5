using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segitiga
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int n = int.Parse(args[0]);

            if (args[1] == "1")
            {
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("{0}", args[2]);

                    }
                    for (j = n; j > i; j--)
                    {
                        Console.Write("{0}", args[3]);
                    }
                    Console.Write("\n");
                }

            }

            if (args[1] == "2")
            {
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("{0}", args[3]);

                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("{0}", args[2]);
                    }
                    Console.Write("\n");

                }
            }
            if (args[1] == "3")
            {
                for (i = n; i <= 1; i--)
                {
                    for (j = 5; j > i; j--)
                    {
                        Console.Write("{0}", args[3]);

                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("{0}", args[2]);
                    }
                    Console.Write("\n");
                
                }
            }
            if (args[1] == "4")
            {
                for (i = n; i >= 1; i--)
                {
                    for (j = i; j >= 1; j--)
                    {
                        Console.Write("{0}", args[2]);

                    }
                    for (j = n; j > i; j--)
                    {
                        Console.Write("{0}", args[3]);
                    }
                    Console.Write("\n");

                }
            }

        }
    }




                }
            
            