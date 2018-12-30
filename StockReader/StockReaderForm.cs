using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
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
        private static char[] delim = { '"', '\'' };
        private SortableBindingList<TickerData> dataList;
		private StockReaderConfig config;
		private DataGridViewColumn sortColumn = null;
		private SortOrder sortOrder;
        private PortFolio portfolio;
        private string portfolioPath;

		public StockReaderForm()
		{
			InitializeComponent();
			stockDataGridView.AutoGenerateColumns = false;
			LoadConfigInfo();
			BindColumns();

			notifyIcon1.Visible = false;

            dataList = new SortableBindingList<TickerData>();

            portfolioPath = "";
            if (portfolio != null)
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

        public void LoadPortfolio(string fName)
        {
            FileStream fStream = null;
            try
            {
                XmlSerializer portInput = new XmlSerializer(typeof(PortFolio));

                fStream = new FileStream(fName, FileMode.Open, FileAccess.Read, FileShare.None);

                portfolio = (PortFolio)portInput.Deserialize(fStream);

                fStream.Close();
                portfolioPath = fName;

                foreach (Holding hld in portfolio.Positions)
                {
                    dataList.Add(new TickerData(hld));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Portfolio File");
                portfolio = null;
                portfolioPath = "";
            }
            finally
            {
                if (fStream != null)
                    fStream.Close();

            }
        }

        private void SavePortfolio(string fName)
        {
            FileStream fStream = null;
            try
            {
                XmlSerializer portOutput = new XmlSerializer(typeof(PortFolio));

                fStream = new FileStream(fName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);

                portOutput.Serialize(fStream, portfolio);

                fStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving Portfolio File");
            }
            finally
            {
                if (fStream != null)
                    fStream.Close();

            }
        }

        private void LoadConfigInfo()
		{
			FileStream fStream = null;
			try
			{
                string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
				XmlSerializer configInput = new XmlSerializer(typeof(StockReaderConfig));
                
				fStream = new FileStream(path + "\\StockReaderConfig.xml", FileMode.Open,
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
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                XmlSerializer output = new XmlSerializer(typeof(StockReaderConfig));

				fStream = new FileStream(path + "\\StockReaderConfig.xml", FileMode.Create,
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
            result = AVReader.ValidateTicker("RADS");
		}

		private void ProcessTickers()
		{
			List<string> tickers;

			try
			{
				tickers = TickerList();

				if (tickers.Count == 0)
				{
					return;
				}

				foreach (string tkr in tickers)
				{
                    PriceData d = AVReader.GetLatestPriceData(tkr);

                    if (d == null)
                        continue;

                    TickerData tick = FindTickerDataItem(tkr);
                    if (tick != null)
                        tick.SetDynamicData(d);
                    
				}

				stockDataGridView.DataSource = dataList;

                SetStatusValues();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected HTTP error: " + ex.Message);
			}
		}

        private void SetStatusValues()
        {
            double nav = 0.0F;
            double portProfit = 0.0F;
            double invProfit = 0.0F;

            foreach (TickerData t in dataList)
            {
                nav += t.AssetValue;
                portProfit += t.CostProfit;
                invProfit += t.InvestmentProfit;
            }

            navStatusLabel.Text = string.Format("NAV: {0:C2}", nav);
            portProfitLabel.Text = string.Format("Portfolio Profit: {0:C2}", portProfit);
            invProfitLabel.Text = string.Format("Investment Profit: {0:C2}", invProfit);
        }

        private TickerData FindTickerDataItem(string ticker)
        {
            foreach (TickerData tckr in dataList)
                if (tckr.TickerSymbol == ticker)
                    return tckr;

            return null;
        }

        private string TickerListString()
        {
            StringBuilder sb = new StringBuilder();
            string result = "";

            foreach (Holding hld in portfolio.Positions)
            {
                sb.Append(hld.TickerText + ",");
            }

            if (sb.Length > 0)
            {
                result = sb.ToString();
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }

        private List<string> TickerList()
        {
            List<string> allTickers = new List<string>();

            foreach (Holding hld in portfolio.Positions)
            {
                allTickers.Add(hld.TickerText);
            }

            return allTickers;
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
            if (portfolio == null)
                return;

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

			if (stockDataGridView.Columns[e.ColumnIndex].Name == "Change" ||
                stockDataGridView.Columns[e.ColumnIndex].Name == "PctChange" ||
                stockDataGridView.Columns[e.ColumnIndex].Name == "CostProfit" ||
                stockDataGridView.Columns[e.ColumnIndex].Name == "InvProfit" )
			{
                SetCellForeground(e);
			}

		}

        private void SetCellForeground(DataGridViewCellFormattingEventArgs e)
        {
            double val;

            if (e.Value == null)
                return;

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
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
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

			form.TickerList = new List<Holding>(portfolio.Positions);
			if (form.ShowDialog() == DialogResult.OK)
			{
                portfolio.Positions = form.TickerList.ToArray();

                foreach (Holding hld in portfolio.Positions)
                {
                    if (TickerIsInDatalist(hld.TickerText) == false)
                        dataList.Add(new TickerData(hld));
                }

				ProcessTickers();
			}
        }

        private bool TickerIsInDatalist(string ticker)
        {
            foreach (TickerData tdata in dataList)
                if (tdata.TickerSymbol.Equals(ticker) == true)
                    return true;

            return false;
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

        private Holding GetTickerTrans(string ticker)
        {
            for (int i = 0; i < portfolio.Positions.Length; i++)
                if (portfolio.Positions[i].TickerText == ticker)
                    return portfolio.Positions[i];

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

        private void loadPortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\temp";
            dlg.Filter = "Portfolio files (*.prtf)|*.prtf";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadPortfolio(dlg.FileName);

                if (portfolio != null)
                    ProcessTickers();
            }
        }

        private void newPortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (portfolio != null)
            {
                if (MessageBox.Show("Are you sure you wish to lose the current portfolio?", "New Portfolio", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                    return;
            }
            portfolio = new PortFolio();

            TickerListForm frm = new TickerListForm();
            frm.TickerList = new List<Holding>();

            DialogResult res = frm.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                portfolio.Positions = frm.TickerList.ToArray();
            }
            foreach (Holding hld in portfolio.Positions)
            {
                dataList.Add(new TickerData(hld));
            }
            ProcessTickers();
        }

        private void savePortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(portfolioPath))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.InitialDirectory = "c:\\temp";
                dlg.Filter = "Portfolio files (*.prtf)|*.prtf";
                dlg.FilterIndex = 2;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    portfolioPath = dlg.FileName;
                }
                else
                {
                    return;
                }
            }

            SavePortfolio(portfolioPath);
        }

        private void StockReaderForm_Load(object sender, EventArgs e)
        {
            if (portfolio != null)
                ProcessTickers();
        }

	}
}