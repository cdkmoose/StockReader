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
    public partial class TickerListForm : Form
    {
        private List<Holding> positions;
        public TickerListForm()
        {
            InitializeComponent();
        }

        private void lbTickers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTickers.SelectedIndex != -1)
            {
                btnRemoveTicker.Enabled = true;
            }
            else
            {
                btnRemoveTicker.Enabled = false;
            }

        }

        private void txtTicker_TextChanged(object sender, EventArgs e)
        {
            if (txtTicker.Text != null && txtTicker.Text.Length > 0)
            {
                btnAddTicker.Enabled = true;
            }
            else
            {
                btnAddTicker.Enabled = false;
            }
        }

		public List<Holding> TickerList
		{
			get
			{
                return positions;
            }

			set
			{
                positions = value;

				lbTickers.Items.Clear();

                foreach (Holding h in positions)
                    lbTickers.Items.Add(h.TickerText);
			}

		}

		private void btnAddTicker_Click(object sender, EventArgs e)
		{
			if (FinnHubReader.ValidateTicker(txtTicker.Text) == true)
			{
                positions.Add(new Holding(txtTicker.Text.ToUpper()));
				lbTickers.Items.Add(txtTicker.Text.ToUpper());
				txtTicker.Text = "";
			}
			else
			{
				MessageBox.Show(txtTicker.Text + " is not a valid stock ticker symbol.\r\nPlease check spelling and try again.");
			}
		}

		private void btnRemoveTicker_Click(object sender, EventArgs e)
		{
            bool doDelete = true;
            string ticker = lbTickers.SelectedItem.ToString();

            Holding h = positions.Find(p => p.TickerText.Equals(ticker));

            if (h.SharesHeld > 0)
            {
                DialogResult d = MessageBox.Show(ticker + " has transactions, are you sure you wish to delete it?", "Delete Ticker", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                    doDelete = false;
            }

            if (doDelete == true)
            {
                lbTickers.Items.RemoveAt(lbTickers.SelectedIndex);

                positions.Remove(h);
            }
		}
    }
}