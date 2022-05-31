using OOPLab2.Figures;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace OOPLab2.Drawing
{
    public class EllipseDrawer : Drawer
    {
        public override List<PathFigure> Draw(List<Point> dots)
        {
            List<PathFigure> result = new List<PathFigure>();
            PathFigure f = new PathFigure();
            ArcSegment arc1 = new ArcSegment();
            for (int i = 0; i < dots.Count - 1; i++)
            {
                f = new PathFigure();
                arc1 = new ArcSegment();
                f.StartPoint = new System.Windows.Point(dots[i].X, dots[i].Y);
                arc1.Point = new System.Windows.Point(dots[i + 1].X, dots[i + 1].Y);
                arc1.Size = new System.Windows.Size(Math.Abs(dots[0].X - dots[2].X) / 2, Math.Abs(dots[1].Y - dots[3].Y) / 2);
                arc1.SweepDirection = (i > dots.Count / 2) ? SweepDirection.Counterclockwise : SweepDirection.Clockwise;
                f.Segments.Add(arc1);
                result.Add(f);
            }
            f = new PathFigure();
            arc1 = new ArcSegment();
            f.StartPoint = new System.Windows.Point(dots[0].X, dots[0].Y);
            arc1.Point = new System.Windows.Point(dots[3].X, dots[3].Y);
            arc1.Size = new System.Windows.Size(Math.Abs(dots[0].X - dots[2].X) / 2, Math.Abs(dots[1].Y - dots[3].Y) / 2);
            arc1.SweepDirection = SweepDirection.Counterclockwise;
            f.Segments.Add(arc1);
            result.Add(f);
            return result;
        }
    }
}
