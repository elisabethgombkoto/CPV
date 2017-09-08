namespace KNZ.CPV
{
    public class CircleDatas
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
}
