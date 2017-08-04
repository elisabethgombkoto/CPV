using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using static KNZ.CPV.MonitorData;

namespace KNZ.CPV
{
    internal class MyRectangle 
    {
        public SolidColorBrush Stroke { get; set; }
        public double StrokeThickness { get; set; }
        public SolidColorBrush Fill { get; set; }

        
        internal void DrawOnMyCanvas(RectangleCalculatedDatas calculatedDatas, Canvas myCanvas)
        {
            UIElement uiElement = Create(calculatedDatas);
            Canvas.SetBottom(uiElement, calculatedDatas.Bottom);
            Canvas.SetLeft(uiElement, calculatedDatas.Left);

            myCanvas.Children.Add(uiElement);
        }

        private UIElement Create(RectangleCalculatedDatas calculatedDatas)
        {
            Rectangle rect = new Rectangle()
            {
                Width = calculatedDatas.Width,
                Height = calculatedDatas.Height,
                StrokeThickness = this.StrokeThickness = 2,
                RadiusX = 0.00,
                Stroke = Brushes.Black
            };

            return rect;
        }
    }
}