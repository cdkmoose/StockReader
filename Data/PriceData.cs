using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavinSys.StockReader.Data
{
    public class PriceData
    {
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal Volume { get; set; }
        public decimal Current { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
