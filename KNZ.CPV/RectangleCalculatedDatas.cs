namespace KNZ.CPV
{
    internal class RectangleCalculatedDatas
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }

        public RectangleCalculatedDatas(double width, double height, double top, double left)
        {
            Width = width;
            Height = height;
            Top = top;
            Left = left;
        }
    }
}