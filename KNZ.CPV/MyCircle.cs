using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KNZ.CPV
{
    internal class MyCircle 
    {
        public MyCircle()
        {
        }

        public int StrokeThickness { get; private set; }

        internal void DrawOnMyCanvas(CircleCalculatedDatas calculatedDatas, Canvas myCanvas)
        {
            UIElement uiElement = Create(calculatedDatas);
            Canvas.SetBottom(uiElement, calculatedDatas.Bottom);
            Canvas.SetLeft(uiElement, calculatedDatas.Left);

            myCanvas.Children.Add(uiElement);
        }
        private UIElement Create(CircleCalculatedDatas calculatedDatas)
        {
            Ellipse elli = new Ellipse()
            {
                Width = calculatedDatas.Width,
                Height = calculatedDatas.Height,
                StrokeThickness = this.StrokeThickness = 1,
                Stroke = Brushes.Red
            };

            return elli;
        }
    }
}