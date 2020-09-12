namespace DavinSys.StockReader.UI
{
	partial class StockReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReaderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newPortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tickerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbIncreaseFont = new System.Windows.Forms.ToolStripButton();
            this.tsbDecreaseFont = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.navStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.portProfitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.invProfitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.notifyContextMennu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tickerTimer = new System.Windows.Forms.Timer(this.components);
            this.showDetailsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceChartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.notifyContextMennu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(803, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPortfolioToolStripMenuItem,
            this.loadPortfolioToolStripMenuItem,
            this.savePortfolioToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newPortfolioToolStripMenuItem
            // 
            this.newPortfolioToolStripMenuItem.Name = "newPortfolioToolStripMenuItem";
            this.newPortfolioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newPortfolioToolStripMenuItem.Text = "New Portfolio...";
            this.newPortfolioToolStripMenuItem.Click += new System.EventHandler(this.newPortfolioToolStripMenuItem_Click);
            // 
            // loadPortfolioToolStripMenuItem
            // 
            this.loadPortfolioToolStripMenuItem.Name = "loadPortfolioToolStripMenuItem";
            this.loadPortfolioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadPortfolioToolStripMenuItem.Text = "Load Portfolio...";
            this.loadPortfolioToolStripMenuItem.Click += new System.EventHandler(this.loadPortfolioToolStripMenuItem_Click);
            // 
            // savePortfolioToolStripMenuItem
            // 
            this.savePortfolioToolStripMenuItem.Name = "savePortfolioToolStripMenuItem";
            this.savePortfolioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.savePortfolioToolStripMenuItem.Text = "Save Portfolio...";
            this.savePortfolioToolStripMenuItem.Click += new System.EventHandler(this.savePortfolioToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tickerListToolStripMenuItem,
            this.timerIntervalToolStripMenuItem,
            this.selectColumnsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // tickerListToolStripMenuItem
            // 
            this.tickerListToolStripMenuItem.Name = "tickerListToolStripMenuItem";
            this.tickerListToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.tickerListToolStripMenuItem.Text = "&Ticker List...";
            this.tickerListToolStripMenuItem.Click += new System.EventHandler(this.tickerListToolStripMenuItem_Click);
            // 
            // timerIntervalToolStripMenuItem
            // 
            this.timerIntervalToolStripMenuItem.Name = "timerIntervalToolStripMenuItem";
            this.timerIntervalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.timerIntervalToolStripMenuItem.Text = "Timer &Interval...";
            this.timerIntervalToolStripMenuItem.Click += new System.EventHandler(this.timerIntervalToolStripMenuItem_Click);
            // 
            // selectColumnsToolStripMenuItem
            // 
            this.selectColumnsToolStripMenuItem.Name = "selectColumnsToolStripMenuItem";
            this.selectColumnsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.selectColumnsToolStripMenuItem.Text = "Select &Columns...";
            this.selectColumnsToolStripMenuItem.Click += new System.EventHandler(this.selectColumnsToolStripMenuItem_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIncreaseFont,
            this.tsbDecreaseFont});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(803, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // tsbIncreaseFont
            // 
            this.tsbIncreaseFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbIncreaseFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbIncreaseFont.Image")));
            this.tsbIncreaseFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIncreaseFont.Name = "tsbIncreaseFont";
            this.tsbIncreaseFont.Size = new System.Drawing.Size(104, 22);
            this.tsbIncreaseFont.Text = "Increase Font Size";
            this.tsbIncreaseFont.Click += new System.EventHandler(this.tsbIncreaseFont_Click);
            // 
            // tsbDecreaseFont
            // 
            this.tsbDecreaseFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDecreaseFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbDecreaseFont.Image")));
            this.tsbDecreaseFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDecreaseFont.Name = "tsbDecreaseFont";
            this.tsbDecreaseFont.Size = new System.Drawing.Size(108, 22);
            this.tsbDecreaseFont.Text = "Decrease Font Size";
            this.tsbDecreaseFont.Click += new System.EventHandler(this.tsbDecreaseFont_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navStatusLabel,
            this.portProfitLabel,
            this.invProfitLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 423);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(803, 22);
            this.mainStatusStrip.TabIndex = 2;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // navStatusLabel
            // 
            this.navStatusLabel.Name = "navStatusLabel";
            this.navStatusLabel.Size = new System.Drawing.Size(30, 17);
            this.navStatusLabel.Text = "NAV";
            // 
            // portProfitLabel
            // 
            this.portProfitLabel.Name = "portProfitLabel";
            this.portProfitLabel.Size = new System.Drawing.Size(61, 17);
            this.portProfitLabel.Text = "Port Profit";
            // 
            // invProfitLabel
            // 
            this.invProfitLabel.Name = "invProfitLabel";
            this.invProfitLabel.Size = new System.Drawing.Size(55, 17);
            this.invProfitLabel.Text = "Inv Profit";
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.stockDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.ContextMenuStrip = this.notifyContextMennu;
            this.stockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stockDataGridView.Location = new System.Drawing.Point(0, 49);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.ReadOnly = true;
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(803, 374);
            this.stockDataGridView.TabIndex = 3;
            this.stockDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellDoubleClick);
            this.stockDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.stockDataGridView_CellFormatting);
            this.stockDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stockDataGridView_ColumnHeaderMouseClick);
            // 
            // notifyContextMennu
            // 
            this.notifyContextMennu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsMenuItem,
            this.priceChartMenuItem});
            this.notifyContextMennu.Name = "notifyContextMennu";
            this.notifyContextMennu.Size = new System.Drawing.Size(142, 48);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Stock Reader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // tickerTimer
            // 
            this.tickerTimer.Interval = 5000;
            this.tickerTimer.Tick += new System.EventHandler(this.tickerTimer_Tick);
            // 
            // showDetailsMenuItem
            // 
            this.showDetailsMenuItem.Name = "showDetailsMenuItem";
            this.showDetailsMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsMenuItem.Text = "Show Details";
            this.showDetailsMenuItem.Click += new System.EventHandler(this.showDetailsMenuItem_Click);
            // 
            // priceChartMenuItem
            // 
            this.priceChartMenuItem.Name = "priceChartMenuItem";
            this.priceChartMenuItem.Size = new System.Drawing.Size(141, 22);
            this.priceChartMenuItem.Text = "Price Chart";
            this.priceChartMenuItem.Click += new System.EventHandler(this.priceChartMenuItem_Click);
            // 
            // StockReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 445);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "StockReaderForm";
            this.Text = "Stock Reader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockReaderForm_FormClosed);
            this.Load += new System.EventHandler(this.StockReaderForm_Load);
            this.Resize += new System.EventHandler(this.StockReaderForm_Resize);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.notifyContextMennu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStrip mainToolStrip;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.DataGridView stockDataGridView;
		private System.Windows.Forms.ContextMenuStrip notifyContextMennu;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Timer tickerTimer;
        private System.Windows.Forms.ToolStripButton tsbIncreaseFont;
        private System.Windows.Forms.ToolStripButton tsbDecreaseFont;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tickerListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem timerIntervalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel navStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel portProfitLabel;
        private System.Windows.Forms.ToolStripStatusLabel invProfitLabel;
        private System.Windows.Forms.ToolStripMenuItem showDetailsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceChartMenuItem;
    }
}

