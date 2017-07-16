using System;

namespace _04.Elevator.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            if (numberOfPeople == elevatorCapacity)
            {
                Console.WriteLine("All the persons fit inside in the elevator. Only one course is needed.");
            }

            double courseNeeded = numberOfPeople / (double)elevatorCapacity;

            Console.WriteLine($"{Math.Ceiling(courseNeeded)}");
        }
    }
}