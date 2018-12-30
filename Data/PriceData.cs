using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavinSys.StockReader.Data
{
    public class PriceData
    {
        public float High { get; set; }
        public float Low { get; set; }
        public float Open { get; set; }
        public float Close { get; set; }
        public long Volume { get; set; }
    }
}
