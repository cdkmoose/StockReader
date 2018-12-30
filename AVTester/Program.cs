using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DavinSys.StockReader.Data;

namespace AVTester
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceData pData = AVReader.GetLatestPriceData("MSFT");

            Console.WriteLine(pData.Open);
            Console.WriteLine(AVReader.ValidateTicker("MSFA"));

            Console.ReadLine();
        }
    }
}
