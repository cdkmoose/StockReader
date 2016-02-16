using System;
using System.Collections.Generic;
using System.Text;

namespace DavinSys.StockReader.Data
{
    public class TickerData
    {
        private static char[] delim = { '"', '\'' };
        private Holding holding;
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
		string exDividend;

        public TickerData()
        {
			Initialize();
        }

        public TickerData(Holding source)
        {
			Initialize();
            holding = source;
            tickerSymbol = holding.TickerText;
        }

		private void Initialize()
		{
			// placeholder for now, original code moived to static declaration
		}

        public void SetDynamicData(string[] values)
        {
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
			exDividend = values[24];
			exDividend = exDividend.Trim(delim); 

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

        public string PercentChange
        {
            get 
            {
                double delta;
                double price;
                double pct;

                if (double.TryParse(change, out delta) == true && double.TryParse(open, out price) == true)
                {
                    pct = (delta / price);

                    return string.Format("{0:#0.##%}", pct);

                }
                else
                {
                    return "N/A";
                }

            }

        }

		public string Volume
		{
			get 
			{
                int vol;

                if (volume == null || volume == "" || volume.Length == 0 ||
                    int.TryParse(volume, out vol) == false)
                {
                    return volume;
                }
                else
                {
                    return String.Format("{0:N0}", vol);
                }
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
				Decimal val;

				if (Decimal.TryParse(dividendPerShare, out val) == true)
				{
					if (val == 0.0M)
					{
						return "N/A";
					}
					else
					{
						return String.Format("{0:c}", val);
					}
				}
				else
				{
					return "N/A";
				}
			}
		}

		public string DividendYield
		{
			get 
			{
				if (DividendPerShare == "N/A")
				{
					return "N/A";
				}
				else
				{
					double div;

					if (double.TryParse(dividendYield, out div) == true)
					{
						return dividendYield + "%";
					}
					else
					{
						return "N/A";
					}
				}
			}
		}

		public string EarningsPerShare
		{
			get 
			{
				double earnings;

				if (double.TryParse(earningsPerShare, out earnings) == true)
				{
					return String.Format("{0:c}", earnings);
				}
				else
				{
					return "N/A";
				}
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

		public string ExDividend
		{
			get
			{
				return exDividend;
			}
		}

		public string ExDividendShort
		{
			get
			{
				DateTime date;

				if (DividendPerShare == "N/A")
				{
					return "N/A";
				}
				else
				{
					if (exDividend.Length != 0)
					{
						date = DateTime.Parse(exDividend);

						return date.ToShortDateString();
					}
					else
					{
						return exDividend;
					}
				}
			}
		}

        public Holding Position
        {
            get
            {
                return holding;
            }

            set
            {
                holding = value;
            }
        }

        public double NumShares
        {
            get
            {
                return holding.SharesHeld;
            }
        }

        public double AssetValue
        {
            get
            {
                double curPrice = double.Parse(price);
                return curPrice * holding.SharesHeld;
            }
        }

        public double CostProfit
        {
            get
            {
                return AssetValue - CostBasis;
            }
        }

        public double InvestmentProfit
        {
            get
            {
                return AssetValue - InvestmentBasis;

            }
        }
        public double CostBasis
        {
            get
            {
                return holding.CostBasis;
            }
        }

        public double InvestmentBasis
        {
            get
            {
                return holding.InvestmentBasis;
            }
        }

        #endregion

    }
}
