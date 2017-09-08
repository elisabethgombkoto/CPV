using System;

namespace KNZ.CPV
{
    public class MockMonitorDataProvider : IMonitorDataProvider
    {
        private int moving = 0;

        public IMonitorData Fetch()
        {
            IMonitorData md = new MonitorData(moving);
            moving++;

            return md;
               
        }        
    }
}