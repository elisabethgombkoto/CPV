using System;

namespace KNZ.CPV
{
    internal class Calculator
    {
        //Width, height of Canvas and Picture
        public double Width { get; set; } 
        public double Height { get; set; }

        private double _workspaceWidth = 1000;
        private double _workspaceHeight = 1000;

        public Calculator() { }

        public Calculator(double width, double height)
        {
            Width = width;
            Height = height;
        }

        internal RectangleCalculatedDatas CalculateRectangleDatas(RectangleDatas datas)
        {
            double relativeX1 = Width / _workspaceWidth * datas.X1;
            double relativeX2 = Width / _workspaceWidth * datas.X2;
            double relativeY1 = Height / _workspaceHeight * datas.Y1;
            double relativeY2 = Height / _workspaceHeight * datas.Y2;
            
            double width = Math.Abs(relativeX2 - relativeX1);
            double height = Math.Abs(relativeY2 - relativeY1);
            double top = Math.Min(relativeY1, relativeY2);
            double left = Math.Min(relativeX1, relativeX2);

            return new RectangleCalculatedDatas(width,height,top,left);
        }

        internal LineSegmentCalculatedDatas CalculateLineDatas(LineSegmentDatas datas)
        {
            double relativeX1 = Width / _workspaceWidth * datas.X1;
            double relativeX2 = Width / _workspaceWidth * datas.X2;
            double relativeY1 = Height / _workspaceHeight * datas.Y1;
            double relativeY2 = Height / _workspaceHeight * datas.Y2;

           
            double top = Math.Min(relativeY1, relativeY2);
            double left = Math.Min(relativeX1, relativeX2);

            return new LineSegmentCalculatedDatas(relativeX1, relativeY1, relativeX2, relativeY2, top, left);
        }

        internal CapsuleCalculatedDatas CalculateCapsuleDatas(CapsuleDatas datas)
        {
            throw new NotImplementedException();
        }

        internal CircleCalculatedDatas CalculateCircleDatas(CircleDatas datas)
        {
            double relativeX = Width / _workspaceWidth * datas.X;
            double relativeY = Height / _workspaceHeight * datas.Y;
            double relativeR = (datas.R * Height) / _workspaceHeight;

            double width = 2 * relativeR;
            double height = 2 * relativeR;
            double left = relativeX - relativeR;
            double top = relativeY - relativeR;

            return new CircleCalculatedDatas(width, height, top, left);
        }

        internal TargetCalculatedDatas CalculateTargetDatas(TargetDatas d)
        {
            throw new NotImplementedException();
        }
    }
}