using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public class FigureCollection
    {
        public List<BaseFigure> figures;

        public FigureCollection(Point a, Point b)
        {
            figures = new List<BaseFigure>()
            {
                new Line(a, b),
                new Triangle(a, b),
                new Rectangle(a, b),
                new Circle(a, b),
                new Ellipse(a, b)
            };
        }

        public BaseFigure GetFigure(int cbIndex)
            => figures[cbIndex];
    }
}
