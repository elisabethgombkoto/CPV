
using System.Collections.Generic;
using System.Windows.Controls;

namespace KNZ.CPV
{
    internal class VisualizationController 
    {
        private IMonitorDataFactory _mdc;
        public IConverterStrategy ConverterStrategy { get; set; }

        public VisualizationController(IMonitorDataFactory mdc, IConverterStrategy converterStrategy)
        {
            _mdc = mdc;
            ConverterStrategy = converterStrategy;
        }

       
        public void DrawShapesOnCanvas(Canvas myCanvas)
        {
            myCanvas.Children.Clear();
            IMonitorData monitorData = _mdc.GetAllShapeParameter();
          
            DrawRectangels(myCanvas, monitorData.Rectangles);
            DrawLineSegments(myCanvas, monitorData.LineSegments);
            DrawCapsules(myCanvas, monitorData.Capsules);
            DrawCircles(myCanvas, monitorData.Circles);
            DrawTarget(myCanvas, monitorData.Targets);
        }

        private void DrawTarget(Canvas myCanvas, List<TargetDatas> targets)
        {
            int level = 2;
            foreach (TargetDatas datas in targets)
            {
                DrawTargetRecursive(datas, myCanvas, level);
                while (level > 1)
                {
                    level = level - 1;
                    datas.R = datas.R - (datas.R * 0.5);
                    DrawTargetRecursive(datas, myCanvas, level);
                }
                datas.R = 6;
                ConverterStrategy.CreateMyTarget(datas).DrawOnMyCanvas(myCanvas);
            }
        }

        private void DrawTargetRecursive (TargetDatas datas, Canvas myCanvas, int level)
        {
            ConverterStrategy.CreateMyTarget(datas).DrawOnMyCanvas(myCanvas);
        }        

        private void DrawRectangels(Canvas myCanvas, List<RectangleDatas> rectangleDatas)
        {
            foreach (RectangleDatas datas in rectangleDatas)
            {
                ConverterStrategy.CreateMyRectangle(datas).DrawOnMyCanvas( myCanvas);
            }
        }

        private void DrawLineSegments(Canvas myCanvas, List<LineSegmentDatas> rectangleDatas)
        {
            foreach (LineSegmentDatas datas in rectangleDatas)
            {
                ConverterStrategy.CreateMyLineSegmets(datas).DrawOnMyCanvas(myCanvas);
            }
        }

        private void DrawCapsules(Canvas myCanvas, List<CapsuleDatas> capsulesDatas)
        {
            foreach(CapsuleDatas datas in capsulesDatas)
            {
                ConverterStrategy.CreateMyCapsule(datas).DrawOnMyCanvas(myCanvas);
            }
        }
        
        private void DrawCircles(Canvas myCanvas, List<CircleDatas> circleDatas)
        {
            foreach(CircleDatas datas in circleDatas)
            {
                ConverterStrategy.CreateMyCircle(datas).DrawOnMyCanvas(myCanvas);
            }
        }       
    }
}