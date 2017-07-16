using System;

namespace _03.Exact_Sum_of_Real_Numbers.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            decimal result = 0m;

            for (int i = 0; i < counter; i++)
            {
                decimal userInput = decimal.Parse(Console.ReadLine());
                result += userInput;
            }

            Console.WriteLine($"{result}");
        }
    }
}