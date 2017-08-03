namespace KNZ.CPV
{
    public abstract class Datas
    {
    }

    public class RectangleDatas : Datas
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }

        public RectangleDatas() { }
        public RectangleDatas(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
    }

    public class CapsuleDatas : Datas
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double R { get; set; }

        public CapsuleDatas() { }
        public CapsuleDatas(double x1, double y1, double x2, double y2, double r)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            R = r;
        }
    }

    public class CircleDatas : Datas
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }

        public CircleDatas() { }
        public CircleDatas(double x, double y, double r)
        {
            X = x;
            Y = y;
            R = r;
        }
    }

    public class TargetDatas : Datas
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }

        public TargetDatas() { }
        public TargetDatas(double x, double y, double r)
        {
            X = x;
            Y = y;
            R = r;
        }
    }

    public class LineSegmentDatas : Datas
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        
        public LineSegmentDatas() { }
        public LineSegmentDatas(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
    }

}