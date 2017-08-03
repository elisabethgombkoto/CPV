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
            Canvas.SetTop(uiElement, calculatedDatas.Top);
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







        /*
        protected override UIElement Create(RectangleDatas datas)
        {
            double width = CalculateWidth(datas);
            double height = CalculateHeight(datas);

            Rectangle rect = new Rectangle()
            {
                Width = width,
                Height = height,
                StrokeThickness = this.StrokeThickness = 2,
                RadiusX = 0.00,
                Stroke = Brushes.Black
            };
            
            return rect;
        }

        private double CalculateWidth(RectangleDatas datas)
        {
            return Math.Abs(CalculateXb(datas.X1) - CalculateXb(datas.X2));
            
        }

        private double CalculateHeight(RectangleDatas datas)
        {
            return Math.Abs(CalculateYb(datas.Y1) - CalculateYb(datas.Y2));
           
        }

        protected override double CalculateDistanceToSideEdge(RectangleDatas datas)
        {
            return CalculateXb(datas.X1);
        }

        protected override double CalculateDistanceToUperEdge(RectangleDatas datas)
        {
            return CalculateYb(datas.Y1) - CalculateHeight(datas);
        }

        
        */



        /*

        internal void DrawOnMyCanvas(Canvas myCanvas, RectAnglesDatas rectangles, double heightTotal, double widthTotal)
        {
            myCanvas.Children.Add(new MyRectangle().CreateMyRect( rectangles));                      
        }

        private Rectangle CreateMyRect( RectAnglesDatas rectangles)
        {
            double width = CalculateWidth(rectangles);
            double height = CalculateHeight(rectangles);
            double bottom = CalculateBottom(rectangles);
            double left = CalculateLeft(rectangles);
            bool moving = rectangles.Moving;

            Rectangle rect = new Rectangle()
            {
                Width = width,
                Height = height,
                StrokeThickness = this.StrokeThickness = 2,
                RadiusX = RadiusY = 0.00,
                Stroke = Brushes.Black
        };
            if (moving)
            {
                rect.RadiusX = 20;
                rect.RadiusY = 20;
                rect.Stroke = Brushes.Green;
            }
  
                Canvas.SetBottom(rect, bottom);
                Canvas.SetLeft(rect, left);
                return rect;
        }

        private double CalculateLeft(RectAnglesDatas rectangles)
        {
            return rectangles.X1;
        }

        private double CalculateBottom(RectAnglesDatas rectangles)
        {
            return rectangles.Y1;
        }
        
        private double CalculateWidth(RectAnglesDatas rectangles)
        {
            double width = Math.Abs(rectangles.X1 - rectangles.X2);
            return width;
        }

        private double CalculateHeight(RectAnglesDatas rectangles)
        {
            double height = Math.Abs(rectangles.Y1 - rectangles.Y2);
            return height;
        }
        */
    }
}