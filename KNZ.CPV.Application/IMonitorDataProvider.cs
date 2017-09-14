using KNZ.CPV.Model;

namespace KNZ.CPV.Application
{
    public interface IMonitorDataProvider
    {
        IMonitorData Fetch();
    }
}