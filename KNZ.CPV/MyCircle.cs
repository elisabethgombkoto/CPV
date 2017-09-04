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

        internal void DrawOnMyCanvas(CalculatedDatas calculatedDatas, Canvas myCanvas)
        {
            UIElement uiElement = Create(calculatedDatas);
            Canvas.SetBottom(uiElement, calculatedDatas.ThirdShapePositionParameter);
            Canvas.SetLeft(uiElement, calculatedDatas.FourthShapePositionParameter);

            myCanvas.Children.Add(uiElement);
        }
        private UIElement Create(CalculatedDatas calculatedDatas)
        {
            Ellipse elli = new Ellipse()
            {
                Width = calculatedDatas.FirstShapePostionParameter,
                Height = calculatedDatas.SecondShapePositionParameter,
                StrokeThickness = this.StrokeThickness = 1,
                Stroke = Brushes.Red
            };

            return elli;
        }
    }
}