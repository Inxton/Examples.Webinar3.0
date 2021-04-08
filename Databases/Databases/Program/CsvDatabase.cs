using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Program
{
    public class CsvDatabase<T> : IDatabase<T>
    {
        public CsvDatabase()
        {
            using var writer = new StreamWriter("stData.csv");
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            if (csv.HeaderRecord?.Any() ?? true)
                csv.WriteHeader<T>();
            csv.NextRecord();
        }


        public void Write(T data)
        {
            using var writer = new StreamWriter("stData.csv",true);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecord(data);
            csv.NextRecord();
        }
    }

}
