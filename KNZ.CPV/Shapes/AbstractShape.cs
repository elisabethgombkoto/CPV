using KNZ.CPV;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KNZ.CPV.Shapes
{
    public abstract class AbstractMyShape<T> : IShape where T : Shape
    {
        public double StrokeThickness { get; set; } = 2;
        public Brush Stroke { get; set; } = Brushes.Black;

        private readonly double _width;
        private readonly double _height;
        private readonly double _left;
        private readonly double _bottom;

        public AbstractMyShape(double width, double height, double left, double bottom)
        {
            _width = width;
            _height = height;
            _left = left;
            _bottom = bottom;
        }

        public virtual void DrawOnCanvas(Canvas myCanvas)
        {
            T shape = Create();
            shape.Width = _width;
            shape.Height = _height;
            shape.StrokeThickness = StrokeThickness;
            shape.Stroke = Stroke;
            
            SetPosition(shape);

            myCanvas.Children.Add(shape);
        }

        protected abstract T Create();

        protected virtual void SetPosition(T uiElement)
        {
            Canvas.SetLeft(uiElement, _left);
            Canvas.SetBottom(uiElement, _bottom);
        }
    }
}