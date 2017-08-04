namespace KNZ.CPV
{
    internal class TargetCalculatedDatas
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Bottom{ get; set; }
        public double Left { get; set; }

        public TargetCalculatedDatas(double width, double height, double bottom, double left)
        {
            Width = width;
            Height = height;
            Bottom = bottom;
            Left = left;
        }
    }
}