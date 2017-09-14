using System;
using System.Collections;
using System.Collections.Generic;

namespace KNZ.CPV.Modul
{
    public class MonitorData : IMonitorData
    { 
        public List<TargetDatas> Targets { get; set; }
        public List<RectangleDatas> Rectangles { get; set; }
        public List<CapsuleDatas> Capsules { get; set; }
        public List<CircleDatas> Circles { get; set; }
        public List<LineSegmentDatas> LineSegments { get; set; }

        public MonitorData(List<TargetDatas> targets, List<RectangleDatas> rectangles, List<CapsuleDatas> capsules, List<CircleDatas> circles, List<LineSegmentDatas> lineSegments)
        {
            Targets = targets;
            Rectangles = rectangles;
            Capsules = capsules;
            Circles = circles;
            LineSegments = lineSegments;
        }

    }

}

