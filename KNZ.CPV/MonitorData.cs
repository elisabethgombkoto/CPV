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
            this.Rectangles = new List<RectangleDatas>();
            for (int i = 0; i < 1; i++)
            {
                RectangleDatas rad = new RectangleDatas();
                RectangleDatas rad1 = new RectangleDatas();
                rad.X1 = 650;
                rad.Y1 = 700;
                rad.X2 = 750;
                rad.Y2 = 800;
                Rectangles.Add(rad);        
                
                rad1.X1 = 200;
                rad1.Y1 = 650;
                rad1.X2 = 400;
                rad1.Y2 = 750;
                Rectangles.Add(rad1);
            }

            this.Circles = new List<CircleDatas>();
            for (int i = 0; i < 4; i++)
            {
                CircleDatas cir = new CircleDatas();

                cir.X = 500;
                cir.Y = 500;
                cir.R = 500;
                Circles.Add(cir);
            }

            this.LineSegments = new List<LineSegmentDatas>();
            for (int i = 0; i < 1; i++)
            {
                LineSegmentDatas lins1 = new LineSegmentDatas();
                LineSegmentDatas lins = new LineSegmentDatas();
                lins.X1 = 200;
                lins.Y1 = 300;
                lins.X2 = 700;
                lins.Y2 = 750;
                LineSegments.Add(lins);

                lins1.X1 = 700;
                lins1.Y1 = 1000;
                lins1.X2 = 700;
                lins1.Y2 = 0;
                LineSegments.Add(lins1);
            }

            this.Capsules = new List<CapsuleDatas>();
            for (int i = 0; i < 1; i++)
            {
                CapsuleDatas cap = new CapsuleDatas();
                cap.X1 = 100;
                cap.Y1 = 700;
                cap.X2 = 400;
                cap.Y2 = 700;
                cap.R = 100;
                Capsules.Add(cap);
            }

            this.Targets = new List<TargetDatas>();
            for (int i = 0; i < 1; i++)
            {
                TargetDatas tar = new TargetDatas();

                tar.X = 200;
                tar.Y = 300;
                tar.R = 100;
                Targets.Add(tar);
            }


            /*
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
            */
        }

    }

}

