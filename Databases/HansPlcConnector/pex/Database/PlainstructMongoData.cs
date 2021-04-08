using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HansPlc
{
    public partial class PlainstData
    {
        public dynamic id { get; set; } 

        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
