namespace DavinSys.StockReader.Data
{
    public partial class PortFolio
    {
    }

    public partial class Holding
    {
        public Holding(string ticker)
        {
            TickerText = ticker;
        }

        public Holding()
        {
        }

        public double SharesHeld
        {
            get
            {
                double res = 0.0;

                if (TransactionList != null)
                {
                    foreach (TransactionType trans in TransactionList)
                    {
                        if (trans.Action == TransactionMode.DividendReInv || trans.Action == TransactionMode.Purchase)
                            res += trans.ShareCount;

                        if (trans.Action == TransactionMode.Sale)
                            res -= trans.ShareCount;
                    }
                }
                return res;
            }
        }

        public double CostBasis
        {
            get
            {
                double res = 0.0;

                if (TransactionList != null)
                {
                    foreach (TransactionType trans in TransactionList)
                    {
                        if (trans.Action == TransactionMode.DividendReInv || trans.Action == TransactionMode.Purchase)
                            res += trans.ShareCount * trans.SharePrice;

                        if (trans.Action == TransactionMode.Sale)
                            res -= trans.ShareCount * trans.SharePrice;
                    }
                }
                return res;

            }
        }

        public double InvestmentBasis
        {
            // ignore divendent reinvestment to get net out of pocket investment
            get
            {
                double res = 0.0;

                if (TransactionList != null)
                {
                    foreach (TransactionType trans in TransactionList)
                    {
                        if (trans.Action == TransactionMode.Purchase)
                            res += trans.ShareCount * trans.SharePrice;

                        if (trans.Action == TransactionMode.Sale)
                            res -= trans.ShareCount * trans.SharePrice;
                    }
                }
                return res;


            }
        }

    }
}