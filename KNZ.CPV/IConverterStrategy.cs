namespace KNZ.CPV
{
    internal interface IConverterStrategy
    {
        MyRectangle CreateMyRectangle(RectangleDatas datas);
        MyCapsule CreateMyCapsule(CapsuleDatas datas);
        MyCircle CreateMyCircle(CircleDatas datas);
        MyLineSegment CreateMyLineSegmets(LineSegmentDatas datas);
        MyTarget CreateMyTarget(TargetDatas datas);
    }
}