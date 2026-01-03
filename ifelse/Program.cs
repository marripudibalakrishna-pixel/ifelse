using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("The first number is greater than the second number.");
            }
            else if (a < b)
            {
                Console.WriteLine("The first number is less than the second number.");
            }
            else
            {
                Console.WriteLine("The two numbers are equal.");
            }



        }
    }
}
