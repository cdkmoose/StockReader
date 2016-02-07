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
        private List<TransactionType> transList;
        BindingSource src;

		public TickerDetailForm()
		{
			InitializeComponent();
            transactionGrid.AutoGenerateColumns = false;
		}

        public Holding TickerTrans
        {
            get
            {
                if (transList != null)
                    tickerTrans.TransactionList = transList.ToArray();

                return tickerTrans;
            }

            set
            {
                tickerTrans = value;
                if (tickerTrans != null)
                {
                    if (tickerTrans.TransactionList == null)
                        transList = new List<TransactionType>();
                    else
                        transList = new List<TransactionType>(tickerTrans.TransactionList);

                    src = new BindingSource();
                    src.DataSource = transList;
                    transactionGrid.DataSource = src;
                }

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

        private void transactionDatePicker_ValueChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void transactionTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void SharesTextbox_TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private bool TransactionDateHasValidValue()
        {
            bool valid = true;

            DateTime transDate = transactionDatePicker.Value;

            if (transDate == null)
                valid = false;
            else if (transDate > System.DateTime.Now)
                valid = false;

            return valid;

        }

        private bool TransactionTypeHasValidValue()
        {
            string s = transactionTypeCombo.SelectedItem.ToString();
            if (string.IsNullOrEmpty(transactionTypeCombo.SelectedItem.ToString()))
                return false;
            else
                return true;
            
        }

        private bool ShareCountHasValidValue()
        {
            string val = sharesTextbox.Text;
            double sharesValue;

            if (string.IsNullOrEmpty(val))
                return false;

            if (Double.TryParse(val, out sharesValue) == false)
                return false;

            if (sharesValue <= 0.0F)
                return false;

            return true;
        }

        private bool SharePriceHasValidValue()
        {
            string val = priceTextBox.Text;
            double sharePrice;

            if (string.IsNullOrEmpty(val))
                return false;

            if (Double.TryParse(val, out sharePrice) == false)
                return false;

            if (sharePrice <= 0.0F)
                return false;

            return true;
        }

        private void EnableAddButton()
        {
            if (ShareCountHasValidValue() && SharePriceHasValidValue() &&
                TransactionDateHasValidValue() && TransactionTypeHasValidValue())
                addTransactionButton.Enabled = true;
            else
                addTransactionButton.Enabled = false;

        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            TransactionType trans = new TransactionType();

            trans.ShareCount = Double.Parse(sharesTextbox.Text);
            trans.SharePrice = Double.Parse(priceTextBox.Text);
            trans.TransactionDate = transactionDatePicker.Value;

            switch (transactionTypeCombo.SelectedItem.ToString())
            {
                case "Buy":
                    trans.Action = TransactionMode.Purchase;
                    break;

                case "Sell":
                    trans.Action = TransactionMode.Sale;
                    break;

                case "DivReInv":
                    trans.Action = TransactionMode.DividendReInv;
                    break;

                default:
                    break;
            }

            transList.Add(trans);
            src.ResetBindings(false);
        }

        private void TickerDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (transList != null)
                tickerTrans.TransactionList = transList.ToArray();
        }
	}
}