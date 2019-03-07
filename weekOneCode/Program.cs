using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekOneCode
{
    class Program
    {
        static void Main(string[] args)
            {
                int i = 10, j = 20;

                if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }

                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                }

                if (i == j)
                {
                    Console.WriteLine("i is equl to j");
                }

                int x = 10;

                switch (x)
                {
                    case 5:
                        Console.WriteLine("Value of x is 5");
                        break;
                    case 10:
                        Console.WriteLine("Value of x is 10");
                        break;
                    case 15:
                        Console.WriteLine("Value of x is 15");
                        break;
                    default:
                        Console.WriteLine("Unknown value");
                        break;
                }

                do
                {
                    Console.WriteLine("Vaule of i: {0}", i);
                    i++;
                    if (i > 5)
                        break;
                } while (true);
                int[] intArray = new int[5] { 10, 20, 30, 40, 50 };

                for (int a = 0; i < intArray.Length; i++)
                    Console.WriteLine(intArray[i]);
            }

        }
    }

