namespace KNZ.CPV
{
    internal class CapsuleCalculatedDatas : CapsuleDatas
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }

        public CapsuleCalculatedDatas(double width, double height, double top, double left)
        {
            Width = width;
            Height = height;
            Top = top;
            Left = left;
        }
    }
}