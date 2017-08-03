using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KNZ.CPV
{
    internal class MyTarget 
    {
        public double Width { get; internal set; }
        public double Height { get; internal set; }
        public SolidColorBrush Stroke { get; internal set; }
        public double StrokeThickness { get; internal set; }
        public SolidColorBrush Fill { get; internal set; }



        internal void DrawOnMyCanvas(TargetCalculatedDatas calculatedDatas, Canvas myCanvas)
        {
            UIElement uiElement = Create(calculatedDatas);
            Canvas.SetTop(uiElement, calculatedDatas.Top);
            Canvas.SetLeft(uiElement, calculatedDatas.Left);

            myCanvas.Children.Add(uiElement);
           
        }

        private UIElement Create(TargetCalculatedDatas calculatedDatas)
        {
            Ellipse elli = new Ellipse()
            {
                Width = calculatedDatas.Width,
                Height = calculatedDatas.Height,
                Stroke = Brushes.Red,
                StrokeThickness = this.StrokeThickness = 1
            };
            
            return elli;
        }

        /*
        internal void DrawTargetOnCanvas(double r, double x, double y, Canvas myCanvas, int v)
        {
           
            myCanvas.Children.Add(new MyTarget().Create(r, x, y));
          
            if (v > 1)
            {
                v = v - 1;
                DrawTargetOnCanvas(r * 0.3, x, y ,myCanvas, v);
            }
    
        }
        internal UIElement Create(double r, double x, double y)
        { 
            double width = CalculateWidth(r);
            double height = CalculateHeight(r);
            double top = CalculateDistanceToUperEdge(r, y);
            double left = CalculateDistanceToSideEdge(r, x);

            Ellipse eli = new Ellipse()
            {
                Width = width,
                Height = height,
                Stroke = Brushes.Red,
                StrokeThickness = this.StrokeThickness = 1
            };
            Canvas.SetTop(eli, top);
            Canvas.SetLeft(eli, left);
            return eli;
        }

        private double CalculateDistanceToSideEdge(double r, double x)
        {
            return x-r ;
        }

        private double CalculateDistanceToUperEdge(double r, double y)
        {
            return y-r;
        }

        private double CalculateHeight(double r)
        {
            return 2 * r;
        }

        private double CalculateWidth(double r)
        {
            return 2 * r;
        }

        */


        /*
         internal void Draw(Canvas myCanvas, Calculator cc)
         {
             myCanvas.Children.Add(new MyTarget().CreateMyPoint(cc));
             myCanvas.Children.Add(new MyTarget().CreateMyCircle(cc));
         }

         private Ellipse CreateMyPoint(Calculator cc)
         {
             double width = 6;
             double height = 6;
             double top = cc.CalculateDistanceToUperEdge(cc.Mdc.GetAllShapeParameter().TargetY, height);
             double left = cc.CalculateDistanceToSideEdge(cc.Mdc.GetAllShapeParameter().TargetX, width);

             Ellipse point = new Ellipse()
             {
                 Width = width,
                 Height = height,
                 Stroke = Brushes.Red,
                 StrokeThickness = this.StrokeThickness = 2,
                 Fill = new SolidColorBrush(Colors.Red)
             };
             Canvas.SetTop(point, top);
             Canvas.SetLeft(point, left);
             return point;
         }

         private Ellipse CreateMyCircle(Calculator cc)
         {

             double width = 30;
             double height = width;
             double top = cc.CalculateDistanceToUperEdge(cc.Mdc.GetAllShapeParameter().TargetY, height);
             double left = cc.CalculateDistanceToSideEdge(cc.Mdc.GetAllShapeParameter().TargetX, width);

             Ellipse eli = new Ellipse()
             {
                 Width = width,
                 Height = height,
                 Stroke = Brushes.Red,
                 StrokeThickness = this.StrokeThickness = 2
             };
             Canvas.SetTop(eli, top);
             Canvas.SetLeft(eli, left);

             return eli;
          }

     */
    }
}