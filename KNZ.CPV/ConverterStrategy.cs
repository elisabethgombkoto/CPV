using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using KNZ.CPV.Model;
using KNZ.CPV.Shapes;


namespace KNZ.CPV
{
    public class ConverterStrategy : IConverterStrategy
    {
        private const double WORKSPACE_WIDTH = 1000;
        private const double WORKSPACE_HEIGHT = 1000;

        private readonly double _width;
        private readonly double _height;

        public ConverterStrategy(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public IEnumerable<IShape> Convert(IMonitorData monitorData)
        {
            var shapes = new List<IShape>();

            //foreach(RectangleDatas rectDatas in monitorData.Rectangles)
            //{
            //    myShapes.Add(CreateMyRectangle(rectDatas));
            //}
            shapes.AddRange(monitorData.Rectangles.Select(x => CreateRectangle(x)));
            shapes.AddRange(monitorData.Capsules.Select(x => CreateCapsule(x)));
            shapes.AddRange(monitorData.Circles.Select(x => CreateCircle(x)));
            shapes.AddRange(monitorData.LineSegments.Select(x => CreateLineSegmets(x)));

            //foreach (TargetDatas targetDatas in monitorData.Targets)
            //{
            //    IEnumerable<Circle> targetCircles = CreateMyTarget(targetDatas);
            //    foreach(Circle circle in targetCircles)
            //    {
            //        myShapes.Add(circle);
            //    }
            //}
            shapes.AddRange(monitorData.Targets.SelectMany(x => CreateTarget(x)));

            return shapes;
        }

        private Rectangle CreateRectangle(RectangleDatas datas)
        {
            double relativeX1 = _width / WORKSPACE_WIDTH * datas.X1;
            double relativeX2 = _width / WORKSPACE_WIDTH * datas.X2;
            double relativeY1 = _height / WORKSPACE_HEIGHT * datas.Y1;
            double relativeY2 = _height / WORKSPACE_HEIGHT * datas.Y2;

            double width = Math.Abs(relativeX2 - relativeX1);
            double height = Math.Abs(relativeY2 - relativeY1);
            double bottom = Math.Min(relativeY1, relativeY2);
            double left = Math.Min(relativeX1, relativeX2);

            return new Rectangle(width, height, left, bottom);
        }

        private LineSegment CreateLineSegmets(LineSegmentDatas datas)
        {
            double relativeX1 = (_width / WORKSPACE_WIDTH) * datas.X1;
            double relativeX2 = (_width / WORKSPACE_WIDTH) * datas.X2;
            double relativeY1 = ((WORKSPACE_HEIGHT - datas.Y1) / WORKSPACE_HEIGHT) * _height;
            double relativeY2 = ((WORKSPACE_HEIGHT - datas.Y2) / WORKSPACE_HEIGHT) * _height;

            return new LineSegment(relativeX1, relativeY1, relativeX2, relativeY2);
        }

        private Capsule CreateCapsule(CapsuleDatas datas)
        {
            double relativeX1 = _width / WORKSPACE_WIDTH * datas.X1;
            double relativeX2 = _width / WORKSPACE_WIDTH * datas.X2;
            double relativeY1 = _height / WORKSPACE_HEIGHT * datas.Y1;
            double relativeY2 = _height / WORKSPACE_HEIGHT * datas.Y2;
            double relativeR = (datas.R * _height) / WORKSPACE_HEIGHT;

            double width = Math.Abs(relativeX2 - relativeX1) + 2 * relativeR;
            double height = 2 * relativeR;
            double bottom = Math.Min(relativeY1, relativeY2) - relativeR;
            double left = Math.Min(relativeX1, relativeX2) - relativeR;

            return new Capsule(width, height, left, bottom);
        }

        private Circle CreateCircle(CircleDatas datas)
        {
            return CreateCircle(datas.X, datas.Y, datas.R);
        }

        private IEnumerable<Circle> CreateTarget(TargetDatas datas)
        {
            List<Circle> circles = new List<Circle>();

            Circle outerCircle = CreateCircle(datas.X, datas.Y, datas.R);
            outerCircle.StrokeThickness = 5;
            circles.Add(outerCircle);

            double currentRadius = datas.R;
            int level = 2;
            while (level > 1)
            {
                currentRadius *= 0.5;

                Circle innerCircle = CreateCircle(datas.X, datas.Y, currentRadius);
                innerCircle.StrokeThickness = 5;

                circles.Add(innerCircle);

                level = level - 1;
            }

            currentRadius = 6;

            Circle center = CreateCircle(datas.X, datas.Y, currentRadius);
            center.StrokeThickness = 5;

            circles.Add(center);

            return circles;
        }

        private Circle CreateCircle(double x, double y, double r)
        {
            double relativeX = _width / WORKSPACE_WIDTH * x;
            double relativeY = _height / WORKSPACE_HEIGHT * y;
            double relativeR = (r * _height) / WORKSPACE_HEIGHT;

            double width = 2 * relativeR;
            double height = 2 * relativeR;
            double left = relativeX - relativeR;
            double bottom = relativeY - relativeR;

            return new Circle(width, height, left, bottom);
        }
    }
}