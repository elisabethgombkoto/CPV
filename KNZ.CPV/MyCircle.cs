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
















        /*
       
        protected override UIElement Create(CircleDatas datas)
        {
            double width = CalculateWidth(datas);
            double height = CalculateHeight(datas);
            double top = CalculateDistanceToUperEdge(datas);
            double left = CalculateDistanceToSideEdge(datas);
            Ellipse eli = new Ellipse()
            {
                Width = width,
                Height = height,
                Stroke = Brushes.Red,
                StrokeThickness = this.StrokeThickness = 1
            };
           
            return eli; 
        }

        private double CalculateHeight(CircleDatas datas)
        {
            return 2 * datas.R;
        }

        private double CalculateWidth(CircleDatas datas)
        {
            return 2 * datas.R;
        }

        protected override double CalculateDistanceToUperEdge(CircleDatas datas)
        {
            return CalculateYb(datas.Y) - CalculateRb(datas.R);
        }

        protected override double CalculateDistanceToSideEdge(CircleDatas datas)
        {
            return CalculateXb( datas.X ) - CalculateRb( datas.R);
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