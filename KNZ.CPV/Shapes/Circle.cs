using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KNZ.CPV.Shapes
{
    public class Circle : AbstractMyShape<Ellipse>
    {
        public Circle(
          double width,
          double height,
          double left,
          double bottom) 

            : base(width, height, left, bottom)
        {
            StrokeThickness = 1;
            Stroke = Brushes.Red;
        }

        protected override Ellipse Create()
        {
            return new Ellipse();
        }
    }
}