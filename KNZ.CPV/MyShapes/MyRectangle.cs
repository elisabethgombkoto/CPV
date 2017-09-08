using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace KNZ.CPV
{
    internal class MyRectangle : MyShape
    {
        public MyRectangle(double argFirstShapePostionParameter, double argSecondShapePositionParameter, double argThirdShapePositionParameter, double argFourthShapePositionParameter) : base(argFirstShapePostionParameter, argSecondShapePositionParameter, argThirdShapePositionParameter, argFourthShapePositionParameter)
        {
        }      

        internal override UIElement Create()
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

        internal override void SetPosition(UIElement uiElement)
        {
            Canvas.SetBottom(uiElement, ThirdShapePositionParameter);
            Canvas.SetLeft(uiElement, FourthShapePositionParameter);
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