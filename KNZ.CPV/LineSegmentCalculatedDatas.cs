using System.Windows;

namespace KNZ.CPV
{
    internal class LineSegmentCalculatedDatas 
    {
      
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }

        public LineSegmentCalculatedDatas(double x1, double y1, double x2, double y2, double top, double left)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Top = top;
            Left = left;
        }
    }
}