using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KNZ.CPV.Shapes
{
    public class LineSegment : IShape
    {
        private readonly double _x1;
        private readonly double _x2;
        private readonly double _y1;
        private readonly double _y2;

        public double StrokeThickness { get; set; } = 2;

        public LineSegment(double x1, double y1, double x2, double y2)
        {
            _x1 = x1;
            _x2 = x2;
            _y1 = y1;
            _y2 = y2;
        }

        public void DrawOnMyCanvas(Canvas canvas)
        {
            var line = new Line()
            {
                X1 = _x1,
                Y1 = _y1,
                X2 = _x2,
                Y2 = _y2,
                Stroke = Brushes.Black,
                StrokeThickness = StrokeThickness
            };

            canvas.Children.Add(line);
        }
    }

}