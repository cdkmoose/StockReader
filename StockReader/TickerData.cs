using System;
using System.Collections.Generic;
using System.Text;

namespace StockReader
{
    class TickerData
    {
		char[] delim;
        string tickerSymbol;
		string price;
		string change;
		string volume;
		string avgDailyVolume;
        string exchange;
        string marketCap;
		string bookValue;
        string ebitda;
        string dividendPerShare;
        string dividendYield;
        string earningsPerShare;
		string high52Week;
		string low52Week;
		string movingAvg50;
		string movingAvg200;
		string priceEarningsRatio;
		string priceEarningsGrowthRatio;
		string priceSalesRatio;
		string priceBookRatio;
		string shortRatio;
		string open;
		string low;
		string high;

        public TickerData()
        {
			Initialize();
        }

        public TickerData(string source)
        {
			Initialize();
            SetData(source);
        }

		private void Initialize()
		{
			delim = "\"\'".ToCharArray();
		}

        public void SetData(string source)
        {
            String[] values = source.Split(new Char[] {','});

            tickerSymbol = values[0].Trim(delim);
            price = values[1];
            change = values[2];
            volume = values[3];
            avgDailyVolume = values[4];
            exchange = values[5];
            marketCap = values[6];
            bookValue = values[7];
            ebitda = values[8];
            dividendPerShare = values[9];
            dividendYield = values[10];
            earningsPerShare = values[11];
            high52Week = values[12];
            low52Week = values[13];
            movingAvg50 = values[14];
            movingAvg200 = values[15];
            priceEarningsRatio = values[16];
            priceEarningsGrowthRatio = values[17];
            priceSalesRatio = values[18];
            priceBookRatio = values[19];
            shortRatio = values[20];
			open = values[21];
			low = values[22];
			high = values[23];

		}

		#region Properties
		public string TickerSymbol
		{
			get 
			{
				return tickerSymbol;
			}
		}

		public string Price
		{
			get
			{
				return price;
			}
		}

		public string Change
		{
			get 
			{
				return change;
			}
		}

		public string Volume
		{
			get 
			{
				return volume;
			}
		}

		public string AvgDailyVolume
		{
			get 
			{
				return avgDailyVolume;
			}
		}

		public string Exchange
		{
			get 
			{
				return exchange;
			}
		}

		public string MarketCap
		{
			get 
			{
				return marketCap;
			}
		}

		public string BookValue
		{
			get 
			{
				return bookValue;
			}
		}

		public string Ebitda
		{
			get 
			{
				return ebitda;
			}
		}

		public string DividendPerShare
		{
			get 
			{
				return dividendPerShare;
			}
		}

		public string DividendYield
		{
			get 
			{
				return dividendYield;
			}
		}

		public string EarningsPerShare
		{
			get 
			{
				return earningsPerShare;
			}
		}

		public string High52Week
		{
			get 
			{
				return high52Week;
			}
		}

		public string Low52Week
		{
			get 
			{
				return low52Week;
			}
		}

		public string MovingAvg50
		{
			get 
			{
				return movingAvg50;
			}
		}

		public string MovingAvg200
		{
			get 
			{
				return movingAvg200;
			}
		}

		public string PriceEarningsRatio
		{
			get 
			{
				return priceEarningsRatio;
			}
		}

		public string PriceEarningsGrowthRatio
		{
			get 
			{
				return priceEarningsGrowthRatio;
			}
		}

		public string PriceSalesRatio
		{
			get 
			{
				return priceSalesRatio;
			}
		}

		public string PriceBookRatio
		{
			get 
			{
				return priceBookRatio;
			}
		}

		public string ShortRatio
		{
			get
			{
				return shortRatio;
			}
		}

		public string Open
		{
			get
			{
				return open;
			}
		}

		public string Low
		{
			get
			{
				return low;
			}
		}

		public string High
		{
			get
			{
				return high;
			}
		}
		#endregion

    }
}
