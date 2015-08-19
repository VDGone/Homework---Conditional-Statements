using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program that finds the biggest of five numbers by using only five if statements.

            Console.WriteLine("Enter number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("And another number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("And another number: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("And another number: ");
            double e = double.Parse(Console.ReadLine());

            double biggest = a;

            if (a > b)
            {
                biggest = a;
            }
            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c) 
            {
                biggest = c;
            }
            if (biggest < d)
            {
                biggest = d;
            }
            if (biggest < e)
            {
                biggest = e;
            }

            Console.WriteLine("Biggest: {0}", biggest);

        }
    }
}
