using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
    public struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int a, int b)
        {
            x = a;
            y = b;
        }
        public static Coordinate operator +(Coordinate a, Coordinate b)
        {
            int newX = a.x + b.x;
            int newY = a.y + b.y;
            return new Coordinate(newX, newY);
        }
        public string GetInfo()
        {
            return $"{x},{y}";
        }
    }
}
