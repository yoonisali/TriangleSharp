using System;
using TriangleTracker;

namespace Tracker
{
    public class Program
    {
        public static void Main()
        {
            Triangle newTriangle = new Triangle();
            
            Console.WriteLine("Enter your first number for your Traingle!");
            string stringSide1 = Console.ReadLine();
            int Side1 = int.Parse(stringSide1);
            Console.WriteLine("Enter your second number for your Traingle!");
            string stringSide2 = Console.ReadLine();
            int Side2 = int.Parse(stringSide2);
            Console.WriteLine("Enter your third number for your Traingle!");
            string stringSide3 = Console.ReadLine();
            int Side3 = int.Parse(stringSide3);

            newTriangle.IsTriangleLength(Side1, Side2, Side3);

        }


        public static void equalMethod()
        {
            Console.WriteLine("Equilateral Triangle!");
        }

        public static void isosMethod()
        {
            Console.WriteLine("Isosceles Triangle!");
        }

        public static void scaleneMethod()
        {
            Console.WriteLine("Scalene Triangle!");
        }

        public static void notTriangle()
        {
            Console.WriteLine("Not a Triangle Dummy!");
        }
    }


}
