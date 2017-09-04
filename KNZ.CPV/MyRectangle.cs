using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using static KNZ.CPV.MonitorData;

namespace KNZ.CPV
{
    internal class MyRectangle : MyShape
    {
        public MyRectangle(double argFirstShapePostionParameter, double argSecondShapePositionParameter, double argThirdShapePositionParameter, double argFourthShapePositionParameter) : base(argFirstShapePostionParameter, argSecondShapePositionParameter, argThirdShapePositionParameter, argFourthShapePositionParameter)
        {
        }
        
        internal override void DrawOnMyCanvas( Canvas myCanvas)
        {
            UIElement uiElement = Create();
            Canvas.SetBottom(uiElement, ThirdShapePositionParameter);
            Canvas.SetLeft(uiElement, FourthShapePositionParameter);

            myCanvas.Children.Add(uiElement);
        }

        private UIElement Create()
        {
            Rectangle rect = new Rectangle()
            {
                Width = FirstShapePostionParameter,
                Height = SecondShapePositionParameter,
                StrokeThickness = this.StrokeThickness = 2,
                RadiusX = 0.00,
                Stroke = Brushes.Black
            };

            return rect;
        }
        /*
        public SolidColorBrush Stroke { get; set; }
        public double StrokeThickness { get; set; }
        public SolidColorBrush Fill { get; set; }

        
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
                StrokeThickness = this.StrokeThickness = 2,
                RadiusX = 0.00,
                Stroke = Brushes.Black
            };

            return rect;
        }
        */
    }
}