using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            //Use a sequence of if operators.

            Console.WriteLine("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter last number: ");
            double c = double.Parse(Console.ReadLine());

            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c < 0)) 
            {
                Console.WriteLine("+");
            }
            if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
            {
                Console.WriteLine("-");
            }
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
