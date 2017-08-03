using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KNZ.CPV
{
    internal class MyLineSegment 
    {
        public PointCollection Points { get; set; }
        public double X1 { get; internal set; }
        public double X2 { get; internal set; }
        public double Y1 { get; internal set; }
        public double Y2 { get; internal set; }
        public SolidColorBrush Stroke { get; internal set; }
        public double StrokeThickness { get; internal set; }

        //könnte man abstrachieren
        internal void DrawOnMyCanvas(LineSegmentCalculatedDatas calculatedDatas, Canvas myCanvas)
        {
            UIElement uiElement = Create(calculatedDatas);
            Canvas.SetTop(uiElement, calculatedDatas.Top);
            Canvas.SetLeft(uiElement, calculatedDatas.Left);

            myCanvas.Children.Add(uiElement);
        }

        private UIElement Create(LineSegmentCalculatedDatas calculatedDatas)
        {
            Line line = new Line()
            {
                X1 = calculatedDatas.X1,
                Y1 = calculatedDatas.Y1,
                X2 = calculatedDatas.X2,
                Y2 = calculatedDatas.Y2,
                Stroke = Brushes.Black,
                StrokeThickness = this.StrokeThickness = 2
            };           

            return line;
        }






        /*
                protected override double CalculateDistanceToSideEdge(LineSegmentDatas datas)
                {
                    return CalculateXb(datas.X1);
                }

                protected override double CalculateDistanceToUperEdge(LineSegmentDatas datas)
                {
                    return CalculateYb(datas.Y1);
                }

                protected override UIElement Create(LineSegmentDatas datas)
                {

                    Line line = new Line()
                    {
                        X1 = CalculateXb(datas.X1),
                        Y1 = CalculateYb(datas.Y1),
                        X2 = CalculateXb(datas.X2),
                        Y2 = CalculateYb(datas.Y2),
                        Stroke = Brushes.Black,
                        StrokeThickness = this.StrokeThickness = 2
                    };


                    return line;
                }

               */


        /*
        internal void Draw(Canvas myCanvas)
        {
            myCanvas.Children.Add(new MyLineSegment().CreateMyLineSegment();

        }
                
        private UIElement CreateMyPolyLine(Calculator cc)
        {
            Point trollyPos = cc.CalculatePoint(cc.Md.ActX, cc.Md.ActY);
            double lengthTrolly = 5;
            Point trollyStart = new Point(trollyPos.X - lengthTrolly, trollyPos.Y);
            Point trollyEnd = new Point(trollyPos.X + lengthTrolly,trollyPos.Y);
            Point craneAxisTop = new Point(trollyPos.X, 0);
            Point craneAxisBottom = new Point(trollyPos.X, cc.Mdc.GetAllShapeParameter().HeightTotal);
            Point target = cc.CalculatePoint(cc.Mdc.GetAllShapeParameter().TargetX, cc.Mdc.GetAllShapeParameter().TargetY);

            Polyline pline = new Polyline()
            {
                Points = { trollyStart, trollyEnd, trollyPos, craneAxisTop, craneAxisBottom, trollyPos, target },
                Stroke = Brushes.Black,
                StrokeThickness = this.StrokeThickness = 1
            };
            return pline;
        }


        */


        /*
        internal void DrawOnCanvas
            (Canvas myCanvas, double actX, double actY, double desiredCenterX, double desiredCenterY, double heightTotal, double widthTotal)
        {
            myCanvas.Children.Add(new MyLineSegment().CreatePolyLine(actX, actY, desiredCenterX, desiredCenterY));
            
            myCanvas.Children.Add( new MyLineSegment().
                CreateLineSegmentBetweenTwoPoints(actX, actY, desiredCenterX, desiredCenterY, heightTotal, widthTotal));

            myCanvas.Children.Add(new MyLineSegment().
                CreateLinesegmentFromGivenPointParalelToXAxis(actX, actY, heightTotal, widthTotal));

            myCanvas.Children.Add(new MyLineSegment().
                CreateLineSegmentFromGivenPointParalelToYAxis(actX, heightTotal));
                
        }
        
        private Polyline CreatePolyLine(double actX, double actY, double desiredCenterX, double desiredCenterY)
        {
            
            double lengthTrolly = 5;
            double yMax = 10000;

            Point katzeStart = new Point (actX-lengthTrolly, actY);
            Point katzeEnd = new Point(actX + lengthTrolly, actY);
            Point craneAxisStart = new Point(actX, 0);
            Point craneAxisEnd = new Point(actX, yMax);
            Point vectorStart = new Point(actX, actY);
            Point vectorEnd = new Point(desiredCenterX, desiredCenterY);

            Polyline pline = new Polyline()
            {
                Points = {  katzeStart, katzeEnd, vectorStart, craneAxisStart, craneAxisEnd, vectorStart, vectorEnd },
                Stroke = Brushes.Black,
                StrokeThickness = this.StrokeThickness = 2
            };
            Canvas.SetBottom(pline, 100);
            Canvas.SetLeft(pline, 100);
            return pline;
        }

        
        private Line CreateLineSegmentBetweenTwoPoints
            (double actX, double actY, double desiredCenterX, double desiredCenterY, double heightTotal, double widthTotal)
        {
            Line line = new Line()
            {
                X1 =heightTotal - actX,
                Y1 = actY,
                X2 = heightTotal - desiredCenterX,
                Y2 = desiredCenterY,
                Stroke = Brushes.Black,
                StrokeThickness = this.StrokeThickness = 2
            };
            Canvas.SetBottom(line, actY);
            Canvas.SetLeft(line,actX );
            return line;
        }

        private Line CreateLinesegmentFromGivenPointParalelToXAxis
            (double actX, double actY, double heightTotal, double widthTotal )
        {
            double lineLength = 5;
            double bottom = heightTotal - actY;
            double left = actX - widthTotal;
            Line line = new Line()
            {
                X1 = actX - lineLength,
                X2 = actX + lineLength,
                Y1 = actY,
                Y2 = actY,
                Stroke = Brushes.Black,
                StrokeThickness = this.StrokeThickness = 2
            };
            Canvas.SetBottom(line, bottom);
            Canvas.SetLeft(line, left);
            return line;
        }

        private Line CreateLineSegmentFromGivenPointParalelToYAxis(double actX, double heightTotal )
        {
            double left = heightTotal - actX;
            Line line = new Line()
            {
                X1 = actX,
                X2 = actX,
                Y1 = heightTotal,
                Y2 = 0,
                Stroke = Brushes.Black,
                StrokeThickness = this.StrokeThickness = 2
            };
            Canvas.SetLeft(line, left);
            return line;
        }
        */
    }

}