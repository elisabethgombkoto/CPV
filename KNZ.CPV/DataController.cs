using System;

namespace KNZ.CPV
{
    public class DataController : IMonitorDataFactory
    {
        int moving = 0;

        public IMonitorData Create()
        {
            return new MonitorData(moving);
        }

        public IMonitorData GetAllShapeParameter()
        {
            IMonitorData md = Create();
            moving++;
            return md;
               
        }        
    }
}