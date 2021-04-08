using HansPlc;
using Vortex.Connector;
using System.Collections.Generic;
using InfluxDB.Net;
using System.Threading.Tasks;
using InfluxDB.Net.Models;

namespace Program
{
    public class InfluxDatabase<T> : IDatabase<T>
    {
        const string ServerUrl = "http://localhost:8086/";
        const string DatabaseName = "ws";
        private InfluxDb Client { get; set; }
        public InfluxDatabase()
        {
            Client = new InfluxDb(ServerUrl, "root", "root");
            Task.Run(SetupInflux);
        }

        private async void SetupInflux()
        {
            await Client.DropDatabaseAsync(DatabaseName);
            await Client.CreateDatabaseAsync(DatabaseName);
        }

        public void Write(T data)
        {
            var point = new Point()
            {
                Measurement = "plc-perf",
            };

            foreach (var property in typeof(T).GetProperties())
            {
                var value = property.GetValue(data);
                if (value != null)
                    point.Fields[property.Name] = value;
            }

            Task.Run(async () => await Client.WriteAsync(DatabaseName, point));
        }

    }

}
