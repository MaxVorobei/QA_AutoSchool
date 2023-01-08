using System;
using System.Collections.Generic;
using System.Text;

namespace Points
{
    internal class Point
    {
        public int x;
        public int y;

        public string GetInfo()
        {
            return "Point coordinates: (" + x + ", " + y + ")";
        }

        public void RandomCoordinates()
        {
            Random mark = new Random();
     
            this.x = mark.Next(-25, 26);
            this.y = mark.Next(-25, 26);
        }
    }
}
