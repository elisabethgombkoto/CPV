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

       
        public MonitorData()
        {
            double random = new Random().NextDouble();
           double r = new Random().NextDouble();
            

            this.Targets = new List<TargetDatas>();
            for (int i = 0; i < 4; i++)
            {
                TargetDatas tar = new TargetDatas();

                tar.X = random;
                tar.Y = random+r;
                tar.R = random;
                Targets.Add(tar);
            }

            this.Circles = new List<CircleDatas>();           
            for (int i = 0; i < 4; i++)
            {
                CircleDatas cir = new CircleDatas();

                cir.X = r ;
                cir.Y = random;
                cir.R = random+r;
                Circles.Add(cir);
            }
            this.Rectangles = new List<RectangleDatas>();
            for (int i = 0; i < 8; i++)
            {
                RectangleDatas rad = new RectangleDatas();

                rad.X1 = 0;
                rad.Y1 = 0;
                rad.X2 = 20;
                rad.Y2 = 20;
                Rectangles.Add(rad);
            }

            this.Capsules = new List<CapsuleDatas>();
            for (int i = 0; i < 8; i++)
            {
                CapsuleDatas cap = new CapsuleDatas();
                cap.X1 = random;
                cap.Y1 = r ;
                cap.X2 = r+i;
                cap.Y2 = random + r;
                cap.R = random;
                Capsules.Add(cap);
            }

            this.LineSegments = new List<LineSegmentDatas>();
            for(int i = 0; i< 5; i++)
            {
                LineSegmentDatas lins = new LineSegmentDatas();
                lins.X1 = random + (i + 2);
                lins.Y1 = (random + i);
                lins.X2 = r + (i + 5);
                lins.Y2 = r + random;
                LineSegments.Add(lins);
            }
        }

    }

}

