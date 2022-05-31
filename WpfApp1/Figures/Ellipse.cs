using OOPLab2.Drawing;
using System;
using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public class Ellipse : BaseFigure
    {
        protected Point Center { get; set; }

        protected int MainAxsis { get; set; }

        protected int SubAxsis { get; set; }

        public override Drawer drawMethod { get; set; }

        public Ellipse(Point a, Point b)
        {
            Center = a;
            MainAxsis = Math.Abs(a.X - b.X);
            SubAxsis = Math.Abs(a.Y - b.Y);
            drawMethod = new EllipseDrawer();
        }

        public override List<Point> GetDots()
            => new List<Point>() { new Point(Center.X - MainAxsis, Center.Y), new Point(Center.X, Center.Y - SubAxsis),
                                   new Point(Center.X + MainAxsis, Center.Y), new Point(Center.X, Center.Y + SubAxsis)};
    }
}
