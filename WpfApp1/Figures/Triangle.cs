using System;
using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public class Triangle : Line
    {
        protected Point C { get; set; }

        public Triangle(Point a, Point b)
            : base(a, b)
        {
            C = new Point(Math.Abs(a.X - b.X) / 2 + a.X, Math.Abs(a.X - b.X + (a.X - b.X) / 2));
        }

        public override List<Point> GetDots()
            => new List<Point>() { A, B, C };
    }
}
