namespace KNZ.CPV
{
    public class CalculatedDatas
    {
        public double FirstShapePostionParameter { get; set; }//width, x1
        public double SecondShapePositionParameter { get; set; }//height, y1
        public double ThirdShapePositionParameter { get; set; }//bottom, x2
        public double FourthShapePositionParameter { get; set; }//left, y2

        public CalculatedDatas(double argFirstShapePostionParameter, double argSecondShapePositionParameter, double argThirdShapePositionParameter, double argFourthShapePositionParameter)
        {
            FirstShapePostionParameter = argFirstShapePostionParameter;
            SecondShapePositionParameter = argSecondShapePositionParameter;
            ThirdShapePositionParameter = argThirdShapePositionParameter;
            FourthShapePositionParameter = argFourthShapePositionParameter;
        }
    }
}