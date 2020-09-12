using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;


namespace DavinSys.StockReader.Data
{
    public class FinnHubReader
    {
        private static string fhUrlQuoteBase = @"https://www.finnhub.io/api/v1/quote?symbol={0}";
        private static string fhUrlCandleBase = @"https://www.finnhub.io/api/v1//stock/candle?symbol={0}&resolution=D&from={1}&to={2}";

        private static string finnHubKey = @"bt2qsdv48v6sj2tj4k10";

        public static bool TickerIsValid(string ticker)
        {
            return false;
        }

        private static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private static long DateTimeToUnixTimestamp(DateTime dateTime)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (dateTime.ToUniversalTime() - unixStart).Ticks;
            return (long)(unixTimeStampInTicks / TimeSpan.TicksPerSecond);
        }
        public static bool ValidateTicker(string ticker)
        {
            string url = string.Format(fhUrlQuoteBase, ticker);
            PriceData pData = new PriceData();
            string s;

            using (WebClient client = new WebClient())
            {

                client.Headers.Add("X-Finnhub-Token", finnHubKey);
                s = client.DownloadString(url);

            }

            if (s.Contains("Error Message"))
                return false;
            else
                return true;


        }

        public static CandleData GetCandleData(string ticker)
        {
            string url = string.Format(fhUrlCandleBase, ticker,
                DateTimeToUnixTimestamp(DateTime.Now.AddYears(-1)),
                DateTimeToUnixTimestamp(DateTime.Now));
            CandleData cData = new CandleData();
            string s;
            try
            {
                using (WebClient client = new WebClient())
                {

                    client.Headers.Add("X-Finnhub-Token", finnHubKey);
                    s = client.DownloadString(url);

                    JToken token = JObject.Parse(s);

                    cData.OpenData = token["o"].Select(x => (decimal)x).ToList();
                    cData.HighData = token["h"].Select(x => (decimal)x).ToList();
                    cData.LowData = token["l"].Select(x => (decimal)x).ToList();
                    cData.CloseData = token["c"].Select(x => (decimal)x).ToList();
                    cData.TimeStampData = token["t"].Select(x => UnixTimeStampToDateTime((long)x)).ToList();
                    cData.VolumeData = token["v"].Select(x => (long)x).ToList();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cData;
        }


        public static PriceData GetLatestPriceData(string ticker)
        {
            string url = string.Format(fhUrlQuoteBase, ticker) ;
            PriceData pData = new PriceData();
            string s;

            try
            {
                using (WebClient client = new WebClient())
                {

                    client.Headers.Add("X-Finnhub-Token", finnHubKey);
                    s = client.DownloadString(url);

                    JToken token = JObject.Parse(s);

                    pData.Open = (decimal)token.SelectToken("o");
                    pData.High = (decimal)token.SelectToken("h");
                    pData.Low = (decimal)token.SelectToken("l");
                    pData.Close = (decimal)token.SelectToken("pc");
                    pData.Current = (decimal)token.SelectToken("c");
                    pData.TimeStamp = UnixTimeStampToDateTime((double)token.SelectToken("t"));

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return pData;
        }

    }
}
