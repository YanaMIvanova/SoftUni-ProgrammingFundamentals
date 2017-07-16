using System;

namespace _05.Special_Numbers.cs
{
    class Program
    {
        private static bool IsSpecial(int num)
        {
            return num == 5 || num == 7 || num == 11;
        }

        private static int GetSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine($"{i} -> {IsSpecial(GetSum(i))}");
            }
        }
    }
}