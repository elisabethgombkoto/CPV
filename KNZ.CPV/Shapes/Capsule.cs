using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KNZ.CPV.Shapes
{
    public class Capsule : Rectangle
    {
        public Capsule(
            double width,
            double height,
            double left,
            double bottom) 

            : base(width, height, left, bottom)
        {
            StrokeThickness = 2;
            Stroke = Brushes.Green;
        }

        protected override System.Windows.Shapes.Rectangle Create()
        {
            System.Windows.Shapes.Rectangle rect = base.Create();
            rect.RadiusX = 80.0;
            rect.RadiusY = 80.0;

            return rect;
        }
    }

}