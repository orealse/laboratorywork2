using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Point
    {
        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public Point()
        { 
            // Создать и инициализировать Rectangle.
            Rectangle r = new Rectangle();
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 10;
            r.TopLeft = p1;
            Point p2 = new Point();
            p2.X = 200;
            p2.Y = 200;
            r.BottomRight = p2;  
      }
        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
        }
    }
}
