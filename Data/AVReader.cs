using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace DavinSys.StockReader.Data
{
    // class to read Alpha Vantage price data
    public class AVReader
    {
        private static string avUrlBase = @"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={0}&interval=1min&outputsize=compact&apikey=QICQFHX23L7CIS3V";

        public static bool TickerIsValid(string ticker)
        {
            return false;
        }

        public static bool ValidateTicker(string ticker)
        {
            string url = string.Format(avUrlBase, ticker);
            PriceData pData = new PriceData();
            string s;

            using (WebClient client = new WebClient())
            {
                s = client.DownloadString(url);

            }

            if (s.Contains("Error Message"))
                return false;
            else
                return true;


        }

        public static PriceData GetLatestPriceData(string ticker)
        {
            string url = string.Format(avUrlBase, ticker);
            PriceData pData = new PriceData();
            string s;

            try
            {
                using (WebClient client = new WebClient())
                {
                    s = client.DownloadString(url);

                }

                if (s.Contains("Error Message"))
                    return null;

                JToken token = JObject.Parse(s);

                JToken meta = token.SelectToken("['Meta Data']");
                string time = (string)meta.SelectToken(@"['3. Last Refreshed']");
                JToken priceSet = token.SelectToken("['Time Series (1min)']");
                JToken pricing = priceSet.SelectToken("['" + time + "']");

                pData.Open = (float)pricing.SelectToken("['1. open']");
                pData.High = (float)pricing.SelectToken("['2. high']");
                pData.Low = (float)pricing.SelectToken("['3. low']");
                pData.Close = (float)pricing.SelectToken("['4. close']");
                pData.Volume = (long)pricing.SelectToken("['5. volume']");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return pData;
        }

    }
}
