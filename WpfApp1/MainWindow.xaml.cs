using OOPLab2.Figures;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace OOPLab2
{

    public partial class MainWindow : Window
    {
        private BaseFigure f;
        private PathGeometry pathGeometry;
        private PathFigureCollection pathFigureCollection;
        private Figures.Point firstMousePos;
        private Figures.Point lastMousePos;

        public MainWindow()
        {
            InitializeComponent();
            pathGeometry = new PathGeometry();
            pathFigureCollection = new PathFigureCollection();
            myPath.Stroke = Brushes.Red;
            myPath.StrokeThickness = 3;
        }

        private void myPath_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Point currentPosition = e.GetPosition(myPath);
            firstMousePos = new Figures.Point((int)currentPosition.X, (int)currentPosition.Y);
        }

        private void myPath_MouseUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Point endPosition = e.GetPosition(myPath);
            lastMousePos = new Figures.Point((int)endPosition.X, (int)endPosition.Y);
            FigureCollection figuresCollection = new FigureCollection(firstMousePos, lastMousePos);
            f = figuresCollection.GetFigure(cbFigures.SelectedIndex);
            List<PathFigure> pathFigureList = new List<PathFigure>(f.drawMethod.Draw(f.GetDots()));
            foreach (PathFigure f in pathFigureList)
                pathFigureCollection.Add(f);
            pathGeometry.Figures = pathFigureCollection;
            myPath.Data = pathGeometry;
        }
    }
}
