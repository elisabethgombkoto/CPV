using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace KNZ.CPV
{
    public abstract class MyShape : UIElement 
    {
        public double StrokeThickness { get; set; }
        public double FirstShapePostionParameter { get; set; }//width, x1
        public double SecondShapePositionParameter { get; set; }//height, y1
        public double ThirdShapePositionParameter { get; set; }//bottom, x2
        public double FourthShapePositionParameter { get; set; }//left, y2

        public MyShape (double argFirstShapePostionParameter, double argSecondShapePositionParameter, double argThirdShapePositionParameter, double argFourthShapePositionParameter)
        {
            FirstShapePostionParameter = argFirstShapePostionParameter;
            SecondShapePositionParameter = argSecondShapePositionParameter;
            ThirdShapePositionParameter = argThirdShapePositionParameter;
            FourthShapePositionParameter = argFourthShapePositionParameter;
        }
        internal abstract  void DrawOnMyCanvas(Canvas myCanvas);

    }
}