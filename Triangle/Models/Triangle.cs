using System;
using Tracker;


namespace TriangleTracker
{
    public class Triangle
    {
        public bool IsTriangleLength(int Side1, int Side2, int Side3)
        {
            if (Side1 == Side2 && Side1 == Side3 && Side2 == Side3)
            {
                Program.equalMethod();
                return true;
            }
            else if (Side1 == Side2 && Side1 != Side3 && Side2 != Side3)
            {
                Program.isosMethod();
                return false;

            }
            else if (Side1 != Side2 && Side2 != Side3 && Side1 != Side3)
            {
                Program.scaleneMethod();
                return true;
            }
            else if (Side1 + Side2 > Side3 || Side1 + Side3 > Side2 || Side2 + Side3 > Side1)
            {
                Program.notTriangle();
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}