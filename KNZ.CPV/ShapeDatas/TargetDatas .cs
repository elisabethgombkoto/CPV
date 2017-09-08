namespace KNZ.CPV
{
    public class TargetDatas
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
}
