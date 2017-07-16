using System;

namespace _06.Triples_of_Letters.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

            for (int first = 0; first < userInput; first++)
            {
                for (int second = 0; second < userInput; second++)
                {
                    for (int third = 0; third < userInput; third++)
                    {
                        char firstLetter = (char)('a' + first);
                        char secondLetter = (char)('a' + second);
                        char thirdLetter = (char)('a' + third);

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
