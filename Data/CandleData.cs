using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavinSys.StockReader.Data
{
    public class CandleData
    {
        public List<decimal> OpenData { get; set; }
        public List<decimal> CloseData { get; set; }
        public List<decimal> HighData { get; set; }
        public List<decimal> LowData { get; set; }
        public List<DateTime> TimeStampData { get; set; }
        public List<long> VolumeData { get; set; }
    }
}
