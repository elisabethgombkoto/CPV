
using System.Windows.Controls;
using System.Drawing;
using System.Windows.Shapes;
using System.Windows.Media;
using static KNZ.CPV.MonitorData;
using System.Collections.Generic;
using System;

namespace KNZ.CPV
{
    internal class VisualizationController
    {
        private DataController _mdc;
        public Calculator CC { get; set; }
        public VisualizationController(DataController mdc, Calculator cc)
        {
            _mdc = mdc;
            CC = cc;
        }
        public VisualizationController(DataController mdc)
        {
            _mdc = mdc;
        }
       
        
        public void DrawShapesOnCanvas(Canvas myCanvas)
        {
            DrawLineSegments(myCanvas);
            DrawRectangels(myCanvas);
            //DrawTarget(myCanvas);
            DrawCircles(myCanvas);
            DrawCapsules(myCanvas);            
            
        }

        private void DrawRectangels(Canvas myCanvas)
        {
            List<RectangleDatas> rectangles = _mdc.GetAllShapeParameter().Rectangles;
            foreach (RectangleDatas datas in rectangles)
            {
                RectangleCalculatedDatas calculated = CC.CalculateRectangleDatas(datas);
                new MyRectangle().DrawOnMyCanvas(calculated, myCanvas);
            }
        }

        private void DrawLineSegments(Canvas myCanvas)
        {
            List<LineSegmentDatas> linesegments = _mdc.GetAllShapeParameter().LineSegments;
            foreach (LineSegmentDatas datas in linesegments)
            {
                LineSegmentCalculatedDatas calculated = CC.CalculateLineDatas(datas);
                new MyLineSegment().DrawOnMyCanvas(calculated, myCanvas);
            }
        }

        private void DrawCapsules(Canvas myCanvas)
        {
            List<CapsuleDatas> capsules = _mdc.GetAllShapeParameter().Capsules;
            foreach (CapsuleDatas datas in capsules)
            {
                CapsuleCalculatedDatas calculated = CC.CalculateCapsuleDatas(datas);
                new MyCapsule().DrawOnMyCanvas(calculated, myCanvas);
            }
        }

        private void DrawCircles(Canvas myCanvas)
        {
            List<CircleDatas> circles = _mdc.GetAllShapeParameter().Circles;
            foreach (CircleDatas datas in circles)
            {
                CircleCalculatedDatas calculated = CC.CalculateCircleDatas(datas);
                new MyCircle().DrawOnMyCanvas(calculated, myCanvas);
            }
        }

        private void DrawTarget(Canvas myCanvas)
        {
            int level = 10;
            List<TargetDatas> targets = _mdc.GetAllShapeParameter().Targets;
            foreach (TargetDatas datas in targets)
            {
                TargetDatas d = datas;
                TargetCalculatedDatas calculated = CC.CalculateTargetDatas(d);
                DrawTarget(calculated, myCanvas, level);
                if (level > 0)
                {
                    level = level - 1;
                    d.R = d.R * 0.3;
                    calculated = CC.CalculateTargetDatas(d);
                    DrawTarget(calculated, myCanvas, level);
                }  
            }
        }

        

        private void DrawTarget(TargetCalculatedDatas calculated, Canvas myCanvas, int level)
        {
            new MyTarget().DrawOnMyCanvas(calculated,  myCanvas);
        }


        

        /*
        private void DrawTarget(Canvas myCanvas)
        {
            List<TargetDatas> targets = _mdc.GetAllShapeParameter().Targets;
            foreach(TargetDatas datas in targets)
            {
                DrawTarget(datas.R, datas.X, datas.Y, myCanvas);
            }
        }

        private void DrawTarget(double r, double x, double y, Canvas myCanvas)
        {
            int v = 8;
            new MyTarget().DrawTargetOnCanvas(r, x, y, myCanvas, v);
        }

       

        private void DrawCircles(Canvas myCanvas)
        {
            List<CircleDatas> circles = _mdc.GetAllShapeParameter().Circles;
            foreach(CircleDatas datas in circles)
            {
                new MyCircle().DrawOnMyCanvas(datas, myCanvas);
            }
        }

        private void DrawCapsules(Canvas myCanvas)
        {
            List<CapsuleDatas> capsules = _mdc.GetAllShapeParameter().Capsules;
            foreach(CapsuleDatas datas in capsules)
            {
                new MyCapsule().DrawOnMyCanvas(datas, myCanvas);
            }
        }
        
        private void DrawLineSegments(Canvas myCanvas)
        {
            List<LineSegmentDatas> linesegments = _mdc.GetAllShapeParameter().LineSegments;
            foreach (LineSegmentDatas datas in linesegments)
            {
                new MyLineSegment().DrawOnMyCanvas(datas, myCanvas);
            }
        }

        private void DrawRectangels (Canvas myCanvas)
        {   
            List <RectangleDatas> rectangles = _mdc.GetAllShapeParameter().Rectangles;            
            foreach(RectangleDatas datas in rectangles)
            {
                new MyRectangle().DrawOnMyCanvas(datas, myCanvas);
            }  
        }  
        */
    }
}