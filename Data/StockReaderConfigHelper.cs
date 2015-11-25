using System;
using System.Collections.Generic;
using System.Text;

namespace DavinSys.StockReader.Data
{
	public partial class ColumnDefType
	{

		public override string ToString()
		{
			return ColHeading;
		}

	}
    public partial class TickerType
    {
        public override string ToString()
        {
            return this.TickerText;
        }
    }

}
