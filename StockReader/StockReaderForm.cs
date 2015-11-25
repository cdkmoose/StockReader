using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

using DavinSys.StockReader.Comm;
using DavinSys.StockReader.Data;
using DavinSys.StockReader.Utility;

namespace DavinSys.StockReader.UI
{
	public partial class StockReaderForm : Form
	{

        private SortableBindingList<TickerData> dataList;
		private StockReaderConfig config;
		private DataGridViewColumn sortColumn = null;
		private SortOrder sortOrder;

		public StockReaderForm()
		{
			InitializeComponent();
			stockDataGridView.AutoGenerateColumns = false;
			LoadConfigInfo();
			BindColumns();

			notifyIcon1.Visible = false;

            dataList = new SortableBindingList<TickerData>();

			ProcessTickers();

			sortColumn = stockDataGridView.Columns[0];
			sortOrder = stockDataGridView.SortOrder;

			//int interval = info.TimerInterval;

			if (config.ConfigData.Timer.interval <= 0)
			{
				tickerTimer.Interval = 60000;  // default to 1 minute
			}
			else
			{
				tickerTimer.Interval = config.ConfigData.Timer.interval * 60000;
			}

			tickerTimer.Enabled = true;

		}

		private void LoadConfigInfo()
		{
			FileStream fStream = null;
			try
			{
				//XmlSerializer input = new XmlSerializer(typeof(StockReaderInfo));
				XmlSerializer configInput = new XmlSerializer(typeof(StockReaderConfig));

				//fStream = new FileStream("StockReaderInfo.xml", FileMode.Open,
				//    FileAccess.Read, FileShare.None);

				//info = (StockReaderInfo)input.Deserialize(fStream);
				//fStream.Close();

				fStream = new FileStream("StockReaderConfig.xml", FileMode.Open,
					FileAccess.Read, FileShare.None);

				config = (StockReaderConfig)configInput.Deserialize(fStream);
                
				fStream.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Loading File");
			}
			finally
			{
				if (fStream != null)
					fStream.Close();

                if (config.ConfigData.Timer.interval < 1)
                {
                    config.ConfigData.Timer.interval = 60000;
                }
                else if (config.ConfigData.Timer.interval > 3600000)
                {
                    config.ConfigData.Timer.interval = 3600000;
                }
			}

		}

        private bool SaveConfigData()
        {
            bool result = true;
			FileStream fStream = null;

			try
			{
				XmlSerializer output = new XmlSerializer(typeof(StockReaderConfig));

				fStream = new FileStream("StockReaderConfig.xml", FileMode.Create,
					FileAccess.Write, FileShare.None);

                output.Serialize(fStream, config);

                result = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Saving Config File");

                result = false;
            }
			finally
			{
				if (fStream != null)
					fStream.Close();
			}

            return result;

        }

		private void btnReadUrl_Click(object sender, EventArgs e)
		{
            bool result;

			ProcessTickers();
            result = TickerTools.ValidateTicker("RADS");
		}

		private void ProcessTickers()
		{
			string[] response;
            string request;
			string tickers;

			try
			{
				tickers = TickerListString();

				if (tickers.Length == 0)
				{
					return;
				}

                request = TickerTools.URLBase + TickerTools.URLTicker + tickers + "&" + TickerTools.URLDataArgs;

                response = NetComm.GetDataResponse(request);

				dataList.Clear();

				foreach (string data in response)
				{
					if (data != null && data.Trim().Length > 0)
					{
						TickerData stats = new TickerData(data);
						dataList.Add(stats);
					}
				}

				stockDataGridView.DataSource = dataList;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected HTTP error: " + ex.Message);
			}
		}

		private string TickerListString()
		{
			StringBuilder sb = new StringBuilder();
			string result = "";

			foreach (TickerType ticker in config.TickerList)
			{
				sb.Append(ticker.TickerText + ",");
			}

			if (sb.Length > 0)
			{
				result = sb.ToString();
				result = result.Substring(0, result.Length - 1);
			}

			return result;
		}

        private void StockReaderForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

		private void tickerTimer_Tick(object sender, EventArgs e)
		{
			tickerTimer.Enabled = false;

			stockDataGridView.SuspendLayout();
			ProcessTickers();

			if (sortOrder == SortOrder.Ascending)
			{
				stockDataGridView.Sort(sortColumn, ListSortDirection.Ascending);
			}
			else
			{
				stockDataGridView.Sort(sortColumn, ListSortDirection.Descending);
			}
			stockDataGridView.ResumeLayout();

			tickerTimer.Enabled = true;


		}

		private void stockDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			double val;


			if (stockDataGridView.Columns[e.ColumnIndex].Name == "Change")
			{
				e.CellStyle.ForeColor = Color.Black;

				if (double.TryParse(e.Value.ToString(), out val) == true)
				{
					if (val > 0.0F)
					{
						e.CellStyle.ForeColor = Color.Green;
					}
					else if (val < 0.0F)
					{
						e.CellStyle.ForeColor = Color.Red;
					}
				}
			}
            else if (stockDataGridView.Columns[e.ColumnIndex].Name == "PctChange")
            {
				e.CellStyle.ForeColor = Color.Black;

                TickerData data = (TickerData) stockDataGridView.Rows[e.RowIndex].DataBoundItem;

                if (double.TryParse(data.Change, out val) == true)
                {
                    if (val > 0.0F)
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (val < 0.0F)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }

		}

        private void StockReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveConfigData();
        }

        private void tsbIncreaseFont_Click(object sender, EventArgs e)
        {
            int padding = 0;
            System.Drawing.Font gridFont;

            gridFont = stockDataGridView.Font;

            if (gridFont.Size < 20)
            {
                padding = stockDataGridView.RowTemplate.Height - stockDataGridView.Font.Height;

                stockDataGridView.Font = new Font(gridFont.FontFamily, gridFont.Size + 1);

                SetRowHeight(stockDataGridView.Font.Height + padding);
            }

        }

        private void tsbDecreaseFont_Click(object sender, EventArgs e)
        {
            int padding = 0;
            System.Drawing.Font gridFont;

            gridFont = stockDataGridView.Font;

            if (gridFont.Size > 6)
            {
                padding = stockDataGridView.RowTemplate.Height - stockDataGridView.Font.Height;

                stockDataGridView.Font = new Font(gridFont.FontFamily, gridFont.Size - 1);

                SetRowHeight(stockDataGridView.Font.Height  + padding);
            }
        }

        private void SetRowHeight(int newHeight)
        {
            foreach (DataGridViewRow row in stockDataGridView.Rows)
            {
                row.Height = newHeight;
            }

            stockDataGridView.RowTemplate.Height = newHeight;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Dispose();
            this.Close();
        }

        private void timerIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerIntervalForm form = new TimerIntervalForm();

            form.Interval = config.ConfigData.Timer.interval;

            if (form.ShowDialog() == DialogResult.OK)
            {
				config.ConfigData.Timer.interval = form.Interval;
                tickerTimer.Interval = config.ConfigData.Timer.interval * 60000;
            }
        }

        private void tickerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TickerListForm form = new TickerListForm();

			form.TickerList = new List<TickerType>(config.TickerList);
			if (form.ShowDialog() == DialogResult.OK)
			{
                config.TickerList = form.TickerList.ToArray();

				ProcessTickers();
			}
        }

		private void stockDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string symbol;
			TickerData data;

			if (e.RowIndex == -1 || e.ColumnIndex == -1)
			{
				return;
			}

			symbol = stockDataGridView.Rows[e.RowIndex].Cells["Ticker"].Value.ToString();

			data = (TickerData) stockDataGridView.Rows[e.RowIndex].DataBoundItem;
			TickerDetailForm form = new TickerDetailForm();
            form.TickerTrans = GetTickerTrans(symbol);

			form.InitializeFieldData(data);
			form.ShowDialog();
		}

        private TickerType GetTickerTrans(string ticker)
        {
            for (int i = 0; i < config.TickerList.Length; i++)
                if (config.TickerList[i].TickerText == ticker)
                    return config.TickerList[i];

            return null;
        }

        private void stockDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
			sortColumn = stockDataGridView.Columns[e.ColumnIndex];
			sortOrder = stockDataGridView.SortOrder;

			if (sortOrder == SortOrder.Ascending)
			{
				stockDataGridView.Sort(sortColumn, ListSortDirection.Ascending);
			}
			else
			{
				stockDataGridView.Sort(sortColumn, ListSortDirection.Descending);
			}
		}

		private void selectColumnsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColumnSelectForm frm = new ColumnSelectForm();

			frm.SetColumnList(new List<ColumnDefType>(config.ColumnList));

			if (frm.ShowDialog() == DialogResult.OK)
			{
				foreach (ColumnDefType col in config.ColumnList)
				{
					stockDataGridView.Columns[col.ColName].Visible = col.Selected;
				}
			}
		}

	}
}