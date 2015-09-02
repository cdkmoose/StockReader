using System;
using System.Collections.Generic;
using System.Text;

using DavinSys.StockReader.Comm;

namespace DavinSys.StockReader.Data
{
    public class TickerTools
    {
        public static string URLBase = @"http://download.finance.yahoo.com/d/quotes.csv?";
        public static string URLTicker = @"s=";
        public static string URLTickerArgs = @"f=sxn";
        public static string URLDataArgs = @"f=sl1c1va2xj1b4j4dyekjm3m4rr5p5p6s7oghq";

        private static char[] trimChars = { '"', '\'' };
		private static char[] splitChars = { ',' };

        public static bool ValidateTicker(string ticker)
        {
            string[] response;
			string[] values;
            string request;
            string tmp;

            request = URLBase + URLTicker + ticker + "&" + URLTickerArgs;

            response = NetComm.GetDataResponse(request);

			values = response[0].Split(splitChars);
			tmp = values[1].Trim(trimChars).ToUpper();

            if (tmp == null || tmp.Length == 0 || tmp == "N/A")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
