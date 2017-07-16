using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool isSpecial = false;

            for (int ch = 1; ch <= userInput; ch++)
            {
                number = ch;

                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }

                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{number} -> {isSpecial}");

                sum = 0;
                ch = number;
            }
        }
    }
}
