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

		public List<string> TickerList
		{
			get
			{
				List<string> list = new List<string>();

				foreach (object item in lbTickers.Items)
				{
					list.Add(item.ToString());
				}

				return list;
			}

			set
			{
				lbTickers.Items.Clear();

				lbTickers.Items.AddRange(value.ToArray());
			}

		}

		private void btnAddTicker_Click(object sender, EventArgs e)
		{
			if (TickerTools.ValidateTicker(txtTicker.Text) == true)
			{
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
			lbTickers.Items.RemoveAt(lbTickers.SelectedIndex);
		}
    }
}