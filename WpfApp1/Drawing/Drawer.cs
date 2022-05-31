using OOPLab2.Figures;
using System.Collections.Generic;
using System.Windows.Media;

namespace OOPLab2.Drawing
{
    public abstract class Drawer
    {
        public abstract List<PathFigure> Draw(List<Point> dots);
    }
}
