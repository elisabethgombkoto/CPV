using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KNZ.CPV
{
    internal class MyCapsule
    {
        public SolidColorBrush Stroke { get; set; }
        public double StrokeThickness { get; set; }
        public SolidColorBrush Fill { get; set; }

        public MyCapsule()
        {
        }
        internal void DrawOnMyCanvas(CalculatedDatas calculatedDatas, Canvas myCanvas)
        {
            UIElement uiElement = Create(calculatedDatas);
            Canvas.SetBottom(uiElement, calculatedDatas.ThirdShapePositionParameter);
            Canvas.SetLeft(uiElement, calculatedDatas.FourthShapePositionParameter);

            myCanvas.Children.Add(uiElement);
        }
        private UIElement Create(CalculatedDatas calculatedDatas)
        {
            Rectangle rect = new Rectangle()
            {
                Width = calculatedDatas.FirstShapePostionParameter,
                Height = calculatedDatas.SecondShapePositionParameter,
                StrokeThickness = this.StrokeThickness = 1,
                RadiusX = 80.00,
                RadiusY = 80.00,
                Stroke = Brushes.Green
            };

            return rect;
        }
    }
}