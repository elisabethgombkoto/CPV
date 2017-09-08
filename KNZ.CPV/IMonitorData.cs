using System.Collections.Generic;

namespace KNZ.CPV
{
    public interface IMonitorData
    {
        List<TargetDatas> Targets { get; set; }
        List<RectangleDatas> Rectangles { get; set; }
        List<CapsuleDatas> Capsules { get; set; }
        List<CircleDatas> Circles { get; set; }
        List<LineSegmentDatas> LineSegments { get; set; }
    }
}