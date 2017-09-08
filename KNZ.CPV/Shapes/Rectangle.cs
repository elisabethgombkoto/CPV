using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace KNZ.CPV.Shapes
{
    public class Rectangle : AbstractMyShape<System.Windows.Shapes.Rectangle>
    {
        public Rectangle(
            double width,
            double height,
            double left,
            double bottom) 

            : base(width, height, left, bottom)
        {
            StrokeThickness = 2;
            Stroke = Brushes.Black;
        }

        protected override System.Windows.Shapes.Rectangle Create()
        {
            return new System.Windows.Shapes.Rectangle();
        }
    }
}