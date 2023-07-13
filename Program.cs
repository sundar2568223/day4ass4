using System;
namespace day4ass4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            string parity = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number is " + parity + ".");
        }
    }
}

