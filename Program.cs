using System;

namespace GenericsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GenericsProblem");



           string  maximumStringNumber = MaximumNumberCheck.maximumStringNumber("Apple", "peach", "Banana");
            Console.WriteLine(maximumStringNumber);
        }
    }
}
