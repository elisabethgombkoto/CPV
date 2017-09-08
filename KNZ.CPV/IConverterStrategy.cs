using KNZ.CPV.Shapes;
using System.Collections.Generic;

namespace KNZ.CPV
{
    public interface IConverterStrategy
    {
        IEnumerable<IShape> Convert(IMonitorData monitorData);
    }
}