using KNZ.Plc;
using KNZ.Plc.ModulePoco;
using KNZ.Plc.Siemens;
using System;

namespace KNZ.CPV.Application
{
    public class CpvModulePocoFactory : IModulePocoFactory
    {
        // no need to use DI here, because we'll always use this parser
        // for s7 module pocos
        private readonly S7PlcAddressParser _s7PlcAddressParser = new S7PlcAddressParser();

        public CpvModulePocoFactory()
        {
        }

        public IModulePoco GetModulePoco(int argModuleIndex)
        {
            if(argModuleIndex == MonitorDataPoco.DB_INDEX)
            {
                return new MonitorDataPoco(_s7PlcAddressParser);
            }

            throw new Exception($"No module poco defined for module index '{argModuleIndex}'");
        }
    }
}