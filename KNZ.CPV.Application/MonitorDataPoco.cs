using KNZ.Plc;
using KNZ.Plc.ModulePoco;
using KNZ.Plc.Siemens;
using KNZ.Plc.Siemens.ModulePoco;

namespace KNZ.CPV.Application
{
    public class MonitorDataPoco : AbstractS7ModulePoco
    {
        public const int DB_INDEX = 1337;

        public MonitorDataPoco(S7PlcAddressParser argS7PlcAddressParser) : base(argS7PlcAddressParser)
        {
        }

        public override PlcDataPointAccess Access => PlcDataPointAccess.Read;
        public override string ModuleName => "MonitorData";
        public override int ModuleIndex => DB_INDEX;

        // with this attribute (annotion in java) the
        // property value is lazy loaded.
        // you have to set this attribute for every property
        // otherwise the data won't be set when
        // you read from the plc and you have to use
        // the GetValueByAddress method
        [AbstractS7ModulePocoLazyLoadedProperty]
        public short Value1 { get; set; }

        protected override void InitializeAllProperties()
        {
            // nothing to initialize yet
        }
    }
}