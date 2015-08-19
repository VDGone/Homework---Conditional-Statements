using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TheBiggestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three numbers.

            Console.WriteLine("Enter number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("And another number: ");
            double c = double.Parse(Console.ReadLine());

            double biggerFirstTime = Math.Max(a, b);
            double biggerSecondTime = Math.Max(b, c);
            double biggestNumber = Math.Max(biggerFirstTime, biggerSecondTime);

            Console.WriteLine("Biggest: {0}", biggestNumber);
        }
    }
}
