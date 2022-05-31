using OOPLab2.Figures;
using System.Collections.Generic;
using System.Windows.Media;

namespace OOPLab2.Drawing
{
    public class LineDrawer : Drawer
    {
        public override List<PathFigure> Draw(List<Point> dots)
        {
            List<PathFigure> result = new List<PathFigure>();
            PathFigure f;
            LineSegment line;
            for (int i = 0; i < dots.Count - 1; i++)
            {
                f = new PathFigure();
                line = new LineSegment();
                f.StartPoint = new System.Windows.Point(dots[i].X, dots[i].Y);
                line.Point = new System.Windows.Point(dots[i + 1].X, dots[i + 1].Y);
                f.Segments.Add(line);
                result.Add(f);
            }
            f = new PathFigure();
            line = new LineSegment();
            f.StartPoint = new System.Windows.Point(dots[0].X, dots[0].Y);
            line.Point = new System.Windows.Point(dots[dots.Count - 1].X, dots[dots.Count - 1].Y);
            f.Segments.Add(line);
            result.Add(f);
            return result;
        }
    }
}
