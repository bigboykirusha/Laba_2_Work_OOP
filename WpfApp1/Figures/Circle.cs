using System;
using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public class Circle : Ellipse
    {
        public Circle(Point a, Point b)
            : base(a, b)
        {
            MainAxsis = SubAxsis = Math.Abs(b.X - a.X) < Math.Abs(b.Y - a.Y) ? Math.Abs(b.Y - a.Y) : Math.Abs(b.X - a.X);
        }

        public override List<Point> GetDots()
            => base.GetDots();
        

    }
}
