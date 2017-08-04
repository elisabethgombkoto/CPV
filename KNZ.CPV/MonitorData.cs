using System;
using System.Collections.Generic;

namespace KNZ.CPV
{
    public class MonitorData
    {
        public List<TargetDatas> Targets { get; set; }
        public List<RectangleDatas> Rectangles { get; set; }// Hier vielleicht wäre strukt besser
        public List<CapsuleDatas> Capsules { get; set; }
        public List<CircleDatas> Circles { get; set; }
        public List<LineSegmentDatas> LineSegments { get; set; }


        public MonitorData(double moving)
        {
            this.Targets = new List<TargetDatas>();
            TargetDatas tar = new TargetDatas();

            tar.X = 200;
            tar.Y = 300;
            tar.R = 100;
            Targets.Add(tar);

            this.Rectangles = new List<RectangleDatas>();
            double trollyX1 = 650;
            double trollyY1 = 700;
            double trollyX2 = 750;
            double trollyY2 = 800;

            double rad1X1 = 200;
            double rad1Y1 = 650;
            double rad1X2 = 400;
            double rad1Y2 = 750;

            trollyX1 = trollyX1 - moving;
            trollyY1 = trollyY1 - moving;
            trollyX2 = trollyX2 - moving;
            trollyY2 = trollyY2 - moving;


            RectangleDatas trolly = new RectangleDatas();
            
            trolly.X1 = trollyX1;
            trolly.Y1 = trollyY1;
            trolly.X2 = trollyX2;
            trolly.Y2 = trollyY2;
            Rectangles.Add(trolly);

            RectangleDatas rad1 = new RectangleDatas();
            rad1.X1 = rad1X1;
            rad1.Y1 = rad1Y1;
            rad1.X2 = rad1X2;
            rad1.Y2 = rad1Y2;
            Rectangles.Add(rad1);


            this.Circles = new List<CircleDatas>();
            CircleDatas cir = new CircleDatas();

            cir.X = 500;
            cir.Y = 500;
            cir.R = 500;
            Circles.Add(cir);


            this.LineSegments = new List<LineSegmentDatas>();
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
           
            LineSegmentDatas vector = new LineSegmentDatas();
            vector.X1 = vectorX1;
            vector.Y1 = vectorY1;
            vector.X2 = vectorX2;
            vector.Y2 = vectorY2;
            LineSegments.Add(vector);

            LineSegmentDatas axis = new LineSegmentDatas();
            axis.X1 = axisX1;
            axis.Y1 = axisY1;
            axis.X2 = axisX2;
            axis.Y2 = axisY2;
            LineSegments.Add(axis);


            this.Capsules = new List<CapsuleDatas>();
            CapsuleDatas cap = new CapsuleDatas();
            cap.X1 = 100;
            cap.Y1 = 700;
            cap.X2 = 400;
            cap.Y2 = 700;
            cap.R = 100;
            Capsules.Add(cap);


           
        }

    }

}

