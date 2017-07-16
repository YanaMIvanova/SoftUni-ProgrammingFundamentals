using System;

namespace _02.Circle_Area_Precision_12_.cs
{
    class Program
    {
        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Program.CircleArea(radius);
            Console.WriteLine($"{area:F12}");
        }
    }
}