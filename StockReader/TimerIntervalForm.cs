using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DavinSys.StockReader.UI
{
    public partial class TimerIntervalForm : Form
    {
        public TimerIntervalForm()
        {
            InitializeComponent();
        }

        private void updInterval_ValueChanged(object sender, EventArgs e)
        {
            if (updInterval.Value < 0.0M)
            {
                btnOK.Enabled = false;
            }
        }

        public int Interval
        {
            get
            {
                return Convert.ToInt32(updInterval.Value);
            }

            set
            {
                updInterval.Value = value;
            }

        }
    }
}