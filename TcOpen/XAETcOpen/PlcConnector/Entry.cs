#define LOCAL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcConnector
{
    public static class Entry
    {
#if LOCAL
        static string AmsId { get; } = null;
#else
        static string AmsId { get; } = "172.20.10.2.1.1";        
#endif
        public static Plc.PlcTwinController PlcController { get; } = new Plc.PlcTwinController(Vortex.Adapters.Connector.Tc3.Adapter.Tc3ConnectorAdapter.Create(AmsId, 851, true));
    }
}
