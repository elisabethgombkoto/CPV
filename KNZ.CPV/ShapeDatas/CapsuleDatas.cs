using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNZ.CPV
{
    public class CapsuleDatas
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

}
