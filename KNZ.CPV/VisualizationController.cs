using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Controls;
using KNZ.CPV.Shapes;

namespace KNZ.CPV
{
    public class VisualizationController
    {
        private readonly IMonitorDataProvider _monitorDataProvider;
        private readonly IConverterStrategy _converterStrategy;

        public VisualizationController(
            IMonitorDataProvider monitorDataProvider, 
            IConverterStrategy converterStrategy)
        {
            _monitorDataProvider = monitorDataProvider;
            _converterStrategy = converterStrategy;
        }


        public void DrawShapesOnCanvas(Canvas myCanvas)
        {
            myCanvas.Children.Clear();

            IMonitorData monitorData = _monitorDataProvider.Fetch();
            IEnumerable<IShape> myShapes = _converterStrategy.Convert(monitorData);

            foreach (IShape myShape in myShapes)
            {
                myShape.DrawOnMyCanvas(myCanvas);
            }
        }
    }
}