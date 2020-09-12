namespace DavinSys.StockReader.UI
{
    partial class PriceChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.priceChart = new LiveCharts.WinForms.CartesianChart();
            this.graphMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oneDayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeDayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenDayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneMonthMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeMonthMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sixMonthMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneYearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceChart
            // 
            this.priceChart.ContextMenuStrip = this.graphMenu;
            this.priceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceChart.Location = new System.Drawing.Point(0, 0);
            this.priceChart.Name = "priceChart";
            this.priceChart.Size = new System.Drawing.Size(1034, 672);
            this.priceChart.TabIndex = 0;
            this.priceChart.Text = "cartesianChart1";
            // 
            // graphMenu
            // 
            this.graphMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneDayMenuItem,
            this.threeDayMenuItem,
            this.tenDayMenuItem,
            this.oneMonthMenuItem,
            this.threeMonthMenuItem,
            this.sixMonthMenuItem,
            this.oneYearMenuItem});
            this.graphMenu.Name = "graphMenu";
            this.graphMenu.Size = new System.Drawing.Size(120, 158);
            // 
            // oneDayMenuItem
            // 
            this.oneDayMenuItem.Name = "oneDayMenuItem";
            this.oneDayMenuItem.Size = new System.Drawing.Size(119, 22);
            this.oneDayMenuItem.Text = "1 day";
            this.oneDayMenuItem.Click += new System.EventHandler(this.oneDayMenuItem_Click);
            // 
            // threeDayMenuItem
            // 
            this.threeDayMenuItem.Name = "threeDayMenuItem";
            this.threeDayMenuItem.Size = new System.Drawing.Size(119, 22);
            this.threeDayMenuItem.Text = "3 Day";
            this.threeDayMenuItem.Click += new System.EventHandler(this.threeDayMenuItem_Click);
            // 
            // tenDayMenuItem
            // 
            this.tenDayMenuItem.Name = "tenDayMenuItem";
            this.tenDayMenuItem.Size = new System.Drawing.Size(119, 22);
            this.tenDayMenuItem.Text = "10 Day";
            this.tenDayMenuItem.Click += new System.EventHandler(this.tenDayMenuItem_Click);
            // 
            // oneMonthMenuItem
            // 
            this.oneMonthMenuItem.Name = "oneMonthMenuItem";
            this.oneMonthMenuItem.Size = new System.Drawing.Size(119, 22);
            this.oneMonthMenuItem.Text = "1 Month";
            this.oneMonthMenuItem.Click += new System.EventHandler(this.oneMonthMenuItem_Click);
            // 
            // threeMonthMenuItem
            // 
            this.threeMonthMenuItem.Name = "threeMonthMenuItem";
            this.threeMonthMenuItem.Size = new System.Drawing.Size(119, 22);
            this.threeMonthMenuItem.Text = "3 Month";
            this.threeMonthMenuItem.Click += new System.EventHandler(this.threeMonthMenuItem_Click);
            // 
            // sixMonthMenuItem
            // 
            this.sixMonthMenuItem.Name = "sixMonthMenuItem";
            this.sixMonthMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sixMonthMenuItem.Text = "6 Month";
            this.sixMonthMenuItem.Click += new System.EventHandler(this.sixMonthMenuItem_Click);
            // 
            // oneYearMenuItem
            // 
            this.oneYearMenuItem.Name = "oneYearMenuItem";
            this.oneYearMenuItem.Size = new System.Drawing.Size(119, 22);
            this.oneYearMenuItem.Text = "1 Year";
            this.oneYearMenuItem.Click += new System.EventHandler(this.oneYearMenuItem_Click);
            // 
            // PriceChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 672);
            this.Controls.Add(this.priceChart);
            this.Name = "PriceChartForm";
            this.Text = "Price Chart";
            this.graphMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart priceChart;
        private System.Windows.Forms.ContextMenuStrip graphMenu;
        private System.Windows.Forms.ToolStripMenuItem oneDayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeDayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenDayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneMonthMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeMonthMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sixMonthMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneYearMenuItem;
    }
}