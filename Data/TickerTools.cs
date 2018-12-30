using System;
using System.Collections.Generic;
using System.Text;

using DavinSys.StockReader.Comm;
using Newtonsoft.Json.Serialization;

namespace DavinSys.StockReader.Data
{
    public class TickerTools
    {
        // sample url
        //https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=MSFT&interval=15min&outputsize=full&apikey=QICQFHX23L7CIS3V

        public static string API_KEY = "QICQFHX23L7CIS3V";
        public static string URLBase = @"https://www.alphavantage.co/query?";
        public static string URLTicker = @"symbol=";
        public static string URLFunction = @"function=TIME_SERIES_INTRADAY";
        public static string URLDataArgs = @"interval=15min&outputsize=compact";

        private static char[] trimChars = { '"', '\'' };
		private static char[] splitChars = { ',' };

        public static string GetURLForTicker(string ticker)
        {
            string request = URLBase + URLFunction + "&" + URLTicker + ticker + "&" + URLDataArgs + "&apikey=" + API_KEY;

            return request;
        }

        public static bool ValidateTicker(string ticker)
        {
            string[] response;
			string[] values;
            string request;
            string tmp;

            request = GetURLForTicker(ticker);

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
