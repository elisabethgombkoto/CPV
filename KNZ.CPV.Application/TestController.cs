using KNZ.Plc;
using KNZ.Plc.Mock;
using KNZ.Plc.Siemens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNZ.CPV.Application
{
    public class TestController
    {
        public async void DoIt()
        {
            // use DI here
            IModulePocoFactory modulePocoFactory = new CpvModulePocoFactory();
            // use DI here
            IModuleBasedAddressConverter  moduleBasedAddressConverter = new S7ModuleBasedAddressConverter();
            // use DI here
            S7PlcConfiguration s7PlcConfig = new S7PlcConfiguration
            {
                CpuType = "S71500",
                IpAddress = "192.168.1.1",
                Rack = 0,
                Slot = 0,
                UsePermanentConnection = true
            };

            // make your own IPlcFactory which creates the plc instance
            // use the IPlcFactory interface for this
            ModuleBasedPlc moduleBasedPlc = new S7Plc(
                modulePocoFactory,
                moduleBasedAddressConverter,
                s7PlcConfig);

            ModuleBasedAddress addressToRead = new ModuleBasedAddress("DB1.DBW0", MonitorDataPoco.DB_INDEX);
            // this way you read by address
            PlcReadResult readByAddressResult = await moduleBasedPlc.ReadAsync(new string[] { addressToRead.Address });
            // this way you parse the measurement for a given address from a read result
            object measurementByAddress = readByAddressResult.GetMeasurementForAddress(addressToRead.Address);

            // this way you read by module poco
            MonitorDataPoco readByModulePocoResult = await moduleBasedPlc.ReadAsync<MonitorDataPoco>(MonitorDataPoco.DB_INDEX);
            // here you have the module poco and you
            // cann access the measurments by address like this:
            object measurmentByAddressFromModulePoco = readByModulePocoResult.GetValueByAddress(addressToRead);

            // or simply by using the properties
            short measurementByPropertyFromModulePoco = readByModulePocoResult.Value1;
        }
    }
}
