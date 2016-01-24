using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DavinSys.StockReader.Data;


namespace DavinSys.StockReader.UI
{
	public partial class TickerDetailForm : Form
	{
        private Holding tickerTrans = null;

		public TickerDetailForm()
		{
			InitializeComponent();
            transactionGrid.AutoGenerateColumns = false;
		}

        public Holding TickerTrans
        {
            get
            {
                return tickerTrans;
            }

            set
            {
                tickerTrans = value;
                if (tickerTrans != null)
                    transactionGrid.DataSource = tickerTrans.TransactionList;

            }
        }

		public void InitializeFieldData(TickerData data)
		{
			lblPrice.Text = data.Price;
			lblChange.Text = data.Change;
			lblPercentChange.Text = data.PercentChange;

			lblOpen.Text = data.Open;
			lblHigh.Text = data.High;
			lblLow.Text = data.Low;
			lblVolume.Text = data.Volume;

			lblDividend.Text = data.DividendPerShare;
			lblExDividend.Text = data.ExDividendShort;
			lblDividendYield.Text = data.DividendYield;

			lblEPS.Text = data.EarningsPerShare;
			lblPE.Text = data.PriceEarningsRatio;
		}
	}
}