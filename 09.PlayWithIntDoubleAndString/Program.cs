using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithIntDoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            //If the variable is int or double, the program increases it by one.
            //If the variable is a string, the program appends * at the end.
            //Print the result at the console. Use switch statement.

            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string ");
            string input = Console.ReadLine();
            int intTipeValue;
            double doubleTipeValue;
            string userText;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Please enter a int: ");
                    intTipeValue = int.Parse(Console.ReadLine());
                    Console.WriteLine(intTipeValue + 1);
                    break;
                case "2":
                    Console.WriteLine("Please enter a double: ");
                    doubleTipeValue = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleTipeValue + 1);
                    break;
                case "3":
                    Console.WriteLine("Please enter a string ");
                    userText = Console.ReadLine();
                    Console.WriteLine("{0}*", userText);
                    break;
                default:
                    Console.WriteLine("It's not a valid tipe!");
                    break;
            }
        }
    }
}
