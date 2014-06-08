using System;

namespace ExchageIfGreater
{
    class ExchageIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app exchages values of two integers if the first one is greater");
            Console.WriteLine();
            Console.WriteLine("Please enter two numbers (on separate line): ");
            Console.Write("Enter first number : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} , {1}", b, a);
            }
            else
            {
                Console.WriteLine("The first number is not greater than the second one");
            }

        }
    }
}
