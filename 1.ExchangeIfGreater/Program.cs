using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
            // As a result print the values a and b, separated by a space.

            Console.WriteLine("Enter number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
