using System;

namespace KNZ.CPV
{
    public class DataController
    {
        int moving = 0;
        public MonitorData GetAllShapeParameter()
        {
            MonitorData md = new MonitorData(moving);
            moving++;
            return md;
               
        }
        
    }
}