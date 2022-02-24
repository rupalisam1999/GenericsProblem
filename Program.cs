using System;

namespace GenericsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GenericsProblem");

            int maxIntNumber = MaximumNumberCheck.maximumIntegerNumber(500, 700, 600);
            Console.WriteLine(maxIntNumber);
        }
    }
}
