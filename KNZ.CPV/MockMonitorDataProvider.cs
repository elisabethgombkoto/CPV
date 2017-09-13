using System;
using System.Collections.Generic;

namespace KNZ.CPV
{
    public class MockMonitorDataProvider : IMonitorDataProvider
    {
        private int moving = 0;

        public IMonitorData Fetch()
        {
            IMonitorData md = MockFetch(moving);
            moving++;

            return md;
               
        }  

        private IMonitorData MockFetch( int moving)
        {
            List<TargetDatas> targets = new List<TargetDatas>();
            TargetDatas tar = new TargetDatas();

            tar.X = 200;
            tar.Y = 300;
            tar.R = 100;
            targets.Add(tar);

            List<RectangleDatas> rectangles = new List<RectangleDatas>();
            double trollyX1 = 650;
            double trollyY1 = 700;
            double trollyX2 = 750;
            double trollyY2 = 800;

            double rad1X1 = 200;
            double rad1Y1 = 650;
            double rad1X2 = 400;
            double rad1Y2 = 750;

            double recX1 = 700;
            double recY1 = 600;
            double recX2 = 800;
            double recY2 = 700;

            double rec2X1 = 100;
            double rec2Y1 = 200;
            double rec2X2 = 300;
            double rec2Y2 = 400;

            trollyX1 = trollyX1 - moving;
            trollyY1 = trollyY1 - moving;
            trollyX2 = trollyX2 - moving;
            trollyY2 = trollyY2 - moving;


            RectangleDatas trolly = new RectangleDatas()
            {
                X1 = trollyX1,
                Y1 = trollyY1,
                X2 = trollyX2,
                Y2 = trollyY2
            };
            rectangles.Add(trolly);

            RectangleDatas rad1 = new RectangleDatas()
            {
                X1 = rad1X1,
                Y1 = rad1Y1,
                X2 = rad1X2,
                Y2 = rad1Y2
            };
            rectangles.Add(rad1);

            RectangleDatas rec = new RectangleDatas()
            {
                X1 = recX1,
                Y1 = recY1,
                X2 = recX2,
                Y2 = recY2
            };
            rectangles.Add(rec);

            RectangleDatas rec2 = new RectangleDatas()
            {
                X1 = rec2X1,
                Y1 = rec2Y1,
                X2 = rec2X2,
                Y2 = rec2Y2
            };
            rectangles.Add(rec2);

            List <CircleDatas> circles = new List<CircleDatas>();
            CircleDatas cir = new CircleDatas()
            {
                X = 500,
                Y = 500,
                R = 500
            };
            circles.Add(cir);


            List<LineSegmentDatas> lineSegments = new List<LineSegmentDatas>();

            double vectorX1 = tar.X;
            double vectorY1 = tar.Y;
            double vectorX2 = 700;
            double vectorY2 = 750;

            double axisX1 = 700;
            double axisY1 = 1000;
            double axisX2 = 700;
            double axisY2 = 0;

            //vectorX1 = vectorX1 - moving;
            //vectorY1 = vectorY1 - moving;
            vectorX2 = vectorX2 - moving;
            vectorY2 = vectorY2 - moving;

            axisX1 = axisX1 - moving;
            axisX2 = axisX2 - moving;

            LineSegmentDatas vector = new LineSegmentDatas()
            {
                X1 = vectorX1,
                Y1 = vectorY1,
                X2 = vectorX2,
                Y2 = vectorY2
            };
            lineSegments.Add(vector);

            LineSegmentDatas axis = new LineSegmentDatas()
            {
                X1 = axisX1,
                Y1 = axisY1,
                X2 = axisX2,
                Y2 = axisY2
            };
            lineSegments.Add(axis);


            List<CapsuleDatas> capsules = new List<CapsuleDatas>();
            CapsuleDatas cap = new CapsuleDatas()
            {
                X1 = 100,
                Y1 = 700,
                X2 = 400,
                Y2 = 700,
                R = 100
            };
            capsules.Add(cap);

            CapsuleDatas cap1 = new CapsuleDatas()
            {
                X1 = 750,
                Y1 = 650,
                X2 = 750,
                Y2 = 650,
                R = 75
            };
            capsules.Add(cap1);

            return new MonitorData(targets, rectangles, capsules, circles, lineSegments); 
        }
    }
}