﻿//#define LOCAL // Comment if your target is remote

using Vortex.Adapters.Connector.Tc3.Adapter;

namespace HansPlc
{
    public static class Entry
    {

#if DEBUG
        const bool isDebug = true;
#else
        const bool isDebug = false;
#endif
#if LOCAL
        const string AmsId = null; // your ams id or set to 'null' if local
        const int Port = 851;
#else
        const string AmsId = "172.20.10.2.1.1"; // set your target ams id
        const int Port = 851;
#endif
        public static HansPlcTwinController HansPlc { get; } = new HansPlcTwinController(Tc3ConnectorAdapter.Create(AmsId, Port, isDebug));
    }
}