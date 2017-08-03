namespace KNZ.CPV
{
    internal class CircleCalculatedDatas
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }

        public CircleCalculatedDatas(double width, double height, double top, double left)
        {
            Width = width;
            Height = height;
            Top = top;
            Left = left;
        }
    }
}