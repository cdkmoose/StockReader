using DavinSys.StockReader.Data;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavinSys.StockReader.UI
{
    public partial class PriceChartForm : Form
    {
        CandleData cData;

        public PriceChartForm(string ticker)
        {
            InitializeComponent();

            Text = "Price Chart: " + ticker;

            cData = FinnHubReader.GetCandleData(ticker);

            priceChart.AxisY.Add(new Axis
                {
                Title = "Price",
                LabelFormatter = value => value.ToString("C")
            });

            SetDataWindow(5);

        }
        private void SetDataWindow(int nDays)
        {
            SeriesCollection data = new SeriesCollection
            {
                new LineSeries
                {
                    LineSmoothness = 0,
                    Values = new ChartValues<Decimal>(cData.CloseData.Skip(cData.CloseData.Count-nDays))
                }
            };

            priceChart.Series = data;

            priceChart.AxisX.Clear();
            priceChart.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = cData.TimeStampData.Skip(cData.TimeStampData.Count - nDays).Select(x => x.Date.ToString("d")).ToArray()
            }
            );


        }

        private void oneDayMenuItem_Click(object sender, EventArgs e)
        {
            SetDataWindow(1);
        }

        private void oneMonthMenuItem_Click(object sender, EventArgs e)
        {
            SetDataWindow(30);
        }

        private void oneYearMenuItem_Click(object sender, EventArgs e)
        {
            SetDataWindow(cData.CloseData.Count);
        }

        private void sixMonthMenuItem_Click(object sender, EventArgs e)
        {
            SetDataWindow(180);
        }

        private void tenDayMenuItem_Click(object sender, EventArgs e)
        {
            SetDataWindow(10);
        }

        private void threeDayMenuItem_Click(object sender, EventArgs e)
        {
            SetDataWindow(3);
        }

        private void threeMonthMenuItem_Click(object sender, EventArgs e)
        {
            SetDataWindow(90);
        }
    }
}
