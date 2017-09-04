
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
        public ShapeDataConverter ShapeDataConverter { get; set; }

        public VisualizationController(DataController mdc, ShapeDataConverter sdc)
        {
            _mdc = mdc;
            ShapeDataConverter = sdc;
        }

        public VisualizationController(DataController mdc)
        {
            _mdc = mdc;
        }

        public void DrawShapesOnCanvas(Canvas myCanvas)
        {
            myCanvas.Children.Clear();
            MonitorData monitorData = _mdc.GetAllShapeParameter();
          
            DrawRectangels(myCanvas, monitorData.Rectangles);
            DrawLineSegments(myCanvas, monitorData.LineSegments);
            DrawCapsules(myCanvas, monitorData.Capsules);
            DrawCircles(myCanvas, monitorData.Circles);
            DrawTarget(myCanvas, monitorData.Targets);
        }

        private void DrawTarget(Canvas myCanvas, List<TargetDatas> targets)
        {
           foreach(TargetDatas datas in targets)
            {
                ShapeDataConverter.CreateMyTarget(datas).DrawOnMyCanvas(myCanvas);
            }
        }

        private void DrawRectangels(Canvas myCanvas, List<RectangleDatas> rectangleDatas)
        {
            foreach (RectangleDatas datas in rectangleDatas)
            {
                ShapeDataConverter.CreateMyRectangle(datas).DrawOnMyCanvas( myCanvas);
            }
        }
        private void DrawLineSegments(Canvas myCanvas, List<LineSegmentDatas> rectangleDatas)
        {
            foreach (LineSegmentDatas datas in rectangleDatas)
            {
                ShapeDataConverter.CreateMyLineSegmets(datas).DrawOnMyCanvas(myCanvas);
            }
        }
        private void DrawCapsules(Canvas myCanvas, List<CapsuleDatas> capsulesDatas)
        {
            foreach(CapsuleDatas datas in capsulesDatas)
            {
                ShapeDataConverter.CreateMyCapsule(datas).DrawOnMyCanvas(myCanvas);
            }
        }
        
        private void DrawCircles(Canvas myCanvas, List<CircleDatas> circleDatas)
        {
            foreach(CircleDatas datas in circleDatas)
            {
                ShapeDataConverter.CreateMyCircle(datas).DrawOnMyCanvas(myCanvas);
            }
        }
       
    }
}