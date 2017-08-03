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
        internal void DrawOnMyCanvas(CapsuleCalculatedDatas calculatedDatas, Canvas myCanvas)
        {
            UIElement uiElement = Create(calculatedDatas);
            Canvas.SetTop(uiElement, calculatedDatas.Top);
            Canvas.SetLeft(uiElement, calculatedDatas.Left);

            myCanvas.Children.Add(uiElement);
        }
        private UIElement Create(CapsuleCalculatedDatas calculatedDatas)
        {
            Rectangle rect = new Rectangle()
            {
                Width = calculatedDatas.Width,
                Height = calculatedDatas.Height,
                StrokeThickness = this.StrokeThickness = 1,
                RadiusX = 10.00,
                RadiusY = 10.00,
                Stroke = Brushes.Green
            };

            return rect;
        }




        /*
        protected override UIElement Create(CapsuleDatas datas)
        {
            double width = CalculateWidth(datas);
            double height = CalculateHeight(datas);

            Rectangle rect = new Rectangle()
            {
                Width = width,
                Height = height,
                StrokeThickness = this.StrokeThickness = 2,
                RadiusX = 20,
                RadiusY = 20,
                Stroke = Brushes.Green
            };

            return rect;
        }

        private double CalculateHeight(CapsuleDatas datas)
        {
            return 2 *  CalculateRb(datas.R);
        }
        
        private double CalculateWidth(CapsuleDatas datas)
        {
            return 2 * CalculateRb(datas.R) + Math.Abs(datas.X1 - datas.X2);
        }

        protected override double CalculateDistanceToSideEdge(CapsuleDatas datas)
        {
            return CalculateXb(datas.X1) - CalculateRb(datas.R);
        }

        protected override double CalculateDistanceToUperEdge(CapsuleDatas datas)
        {
            return CalculateYb(datas.Y1) - CalculateRb(datas.R);
        }

        private double CalculateRb(double r)
        {
            // double r --> It corresponds to relative position in SPS
            double xEins = 10; //It is assumed here that 10 pixels on the screen corresponds 1 meter in Workspace
            return r * xEins;
        }

    */
    }
}