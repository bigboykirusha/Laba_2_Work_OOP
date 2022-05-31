using OOPLab2.Drawing;
using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public abstract class BaseFigure
    {
        public abstract Drawer drawMethod { get; set; }

        public abstract List<Point> GetDots();
    }
}
