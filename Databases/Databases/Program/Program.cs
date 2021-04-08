using HansPlc;
using System;
using System.Collections.Generic;
using System.Threading;
using Vortex.Connector;
using Vortex.Connector.ValueTypes;

namespace Program
{
    class Program
    {
        static fbData fbData { get; set; }
        static IList<IDatabase<PlainstData>> DataTargets { get; } = new List<IDatabase<PlainstData>>();
        static void Main(string[] args)
        {
            Entry.HansPlc.Connector.ReadWriteCycleDelay = 0;
            Entry.HansPlc.Connector.BuildAndStart();
            fbData = Entry.HansPlc.MAIN.Data;
            fbData._logStart.Subscribe(OnValueChange);

            //DataTargets.Add(new InfluxDatabase<PlainstData>());
            DataTargets.Add(new CsvDatabase<PlainstData>());

            Console.ReadKey();
        }


        private static void SaveDataToDatabase()
        {
            var data = fbData.PlcData.CreatePlainerType();
            fbData.PlcData.FlushOnlineToPlain(data);
            foreach (var dataTarget in DataTargets)
            {
                dataTarget.Write(data);
            }
        }


        private static void OnValueChange(IValueTag sender, ValueChangedEventArgs args)
        {
            Thread.Sleep(500);
            if (fbData._logStart.Synchron > fbData._logDone.Synchron)
            {
                try
                {
                    SaveDataToDatabase();
                    fbData._logDone.Synchron = fbData._logStart.Synchron;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Oooops, something is wrong; here's what: {ex.ToString()}");
                }
            }
        }

    }

}
