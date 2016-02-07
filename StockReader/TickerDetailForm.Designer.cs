namespace DavinSys.StockReader.UI
{
	partial class TickerDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabTickerDetail = new System.Windows.Forms.TabControl();
            this.tabPricing = new System.Windows.Forms.TabPage();
            this.pnlPricing = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblPercentChange = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDividends = new System.Windows.Forms.TabPage();
            this.pnlDividends = new System.Windows.Forms.Panel();
            this.lblDividendYield = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblExDividend = new System.Windows.Forms.Label();
            this.lblDividend = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabEarnings = new System.Windows.Forms.TabPage();
            this.pnlEarnings = new System.Windows.Forms.Panel();
            this.lblPE = new System.Windows.Forms.Label();
            this.lblEPS = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabTrends = new System.Windows.Forms.TabPage();
            this.pnlTrends = new System.Windows.Forms.Panel();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.tabTransactions = new System.Windows.Forms.TabPage();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.transactionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.sharesTextbox = new System.Windows.Forms.TextBox();
            this.transactionTypeCombo = new System.Windows.Forms.ComboBox();
            this.transactionGrid = new System.Windows.Forms.DataGridView();
            this.transDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTickerDetail.SuspendLayout();
            this.tabPricing.SuspendLayout();
            this.pnlPricing.SuspendLayout();
            this.tabDividends.SuspendLayout();
            this.pnlDividends.SuspendLayout();
            this.tabEarnings.SuspendLayout();
            this.pnlEarnings.SuspendLayout();
            this.tabTrends.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTickerDetail
            // 
            this.tabTickerDetail.Controls.Add(this.tabPricing);
            this.tabTickerDetail.Controls.Add(this.tabDividends);
            this.tabTickerDetail.Controls.Add(this.tabEarnings);
            this.tabTickerDetail.Controls.Add(this.tabTrends);
            this.tabTickerDetail.Controls.Add(this.tabHistory);
            this.tabTickerDetail.Controls.Add(this.tabTransactions);
            this.tabTickerDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTickerDetail.Location = new System.Drawing.Point(0, 0);
            this.tabTickerDetail.Name = "tabTickerDetail";
            this.tabTickerDetail.SelectedIndex = 0;
            this.tabTickerDetail.Size = new System.Drawing.Size(714, 425);
            this.tabTickerDetail.TabIndex = 0;
            // 
            // tabPricing
            // 
            this.tabPricing.Controls.Add(this.pnlPricing);
            this.tabPricing.Location = new System.Drawing.Point(4, 22);
            this.tabPricing.Name = "tabPricing";
            this.tabPricing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPricing.Size = new System.Drawing.Size(706, 399);
            this.tabPricing.TabIndex = 0;
            this.tabPricing.Text = "Pricing";
            this.tabPricing.UseVisualStyleBackColor = true;
            // 
            // pnlPricing
            // 
            this.pnlPricing.Controls.Add(this.lblVolume);
            this.pnlPricing.Controls.Add(this.lblLow);
            this.pnlPricing.Controls.Add(this.lblHigh);
            this.pnlPricing.Controls.Add(this.lblOpen);
            this.pnlPricing.Controls.Add(this.lblPercentChange);
            this.pnlPricing.Controls.Add(this.lblChange);
            this.pnlPricing.Controls.Add(this.lblPrice);
            this.pnlPricing.Controls.Add(this.label7);
            this.pnlPricing.Controls.Add(this.label6);
            this.pnlPricing.Controls.Add(this.label5);
            this.pnlPricing.Controls.Add(this.label4);
            this.pnlPricing.Controls.Add(this.label3);
            this.pnlPricing.Controls.Add(this.label2);
            this.pnlPricing.Controls.Add(this.label1);
            this.pnlPricing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPricing.Location = new System.Drawing.Point(3, 3);
            this.pnlPricing.Name = "pnlPricing";
            this.pnlPricing.Size = new System.Drawing.Size(700, 393);
            this.pnlPricing.TabIndex = 0;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(252, 189);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(35, 13);
            this.lblVolume.TabIndex = 13;
            this.lblVolume.Text = "label8";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(363, 140);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(35, 13);
            this.lblLow.TabIndex = 12;
            this.lblLow.Text = "label8";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(363, 104);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(35, 13);
            this.lblHigh.TabIndex = 11;
            this.lblHigh.Text = "label8";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(363, 68);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(35, 13);
            this.lblOpen.TabIndex = 10;
            this.lblOpen.Text = "label8";
            // 
            // lblPercentChange
            // 
            this.lblPercentChange.AutoSize = true;
            this.lblPercentChange.Location = new System.Drawing.Point(143, 140);
            this.lblPercentChange.Name = "lblPercentChange";
            this.lblPercentChange.Size = new System.Drawing.Size(35, 13);
            this.lblPercentChange.TabIndex = 9;
            this.lblPercentChange.Text = "label8";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(143, 104);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(35, 13);
            this.lblChange.TabIndex = 8;
            this.lblChange.Text = "label8";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(143, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Volume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Low";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "High";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Open";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "% Change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // tabDividends
            // 
            this.tabDividends.Controls.Add(this.pnlDividends);
            this.tabDividends.Location = new System.Drawing.Point(4, 22);
            this.tabDividends.Name = "tabDividends";
            this.tabDividends.Padding = new System.Windows.Forms.Padding(3);
            this.tabDividends.Size = new System.Drawing.Size(706, 399);
            this.tabDividends.TabIndex = 1;
            this.tabDividends.Text = "Dividends";
            this.tabDividends.UseVisualStyleBackColor = true;
            // 
            // pnlDividends
            // 
            this.pnlDividends.Controls.Add(this.lblDividendYield);
            this.pnlDividends.Controls.Add(this.label10);
            this.pnlDividends.Controls.Add(this.lblExDividend);
            this.pnlDividends.Controls.Add(this.lblDividend);
            this.pnlDividends.Controls.Add(this.label9);
            this.pnlDividends.Controls.Add(this.label8);
            this.pnlDividends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDividends.Location = new System.Drawing.Point(3, 3);
            this.pnlDividends.Name = "pnlDividends";
            this.pnlDividends.Size = new System.Drawing.Size(700, 393);
            this.pnlDividends.TabIndex = 0;
            // 
            // lblDividendYield
            // 
            this.lblDividendYield.AutoSize = true;
            this.lblDividendYield.Location = new System.Drawing.Point(197, 96);
            this.lblDividendYield.Name = "lblDividendYield";
            this.lblDividendYield.Size = new System.Drawing.Size(41, 13);
            this.lblDividendYield.TabIndex = 5;
            this.lblDividendYield.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Dividend Yield";
            // 
            // lblExDividend
            // 
            this.lblExDividend.AutoSize = true;
            this.lblExDividend.Location = new System.Drawing.Point(197, 66);
            this.lblExDividend.Name = "lblExDividend";
            this.lblExDividend.Size = new System.Drawing.Size(41, 13);
            this.lblExDividend.TabIndex = 3;
            this.lblExDividend.Text = "label10";
            // 
            // lblDividend
            // 
            this.lblDividend.AutoSize = true;
            this.lblDividend.Location = new System.Drawing.Point(197, 36);
            this.lblDividend.Name = "lblDividend";
            this.lblDividend.Size = new System.Drawing.Size(41, 13);
            this.lblDividend.TabIndex = 2;
            this.lblDividend.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ex-Dividend";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dividend / Share";
            // 
            // tabEarnings
            // 
            this.tabEarnings.Controls.Add(this.pnlEarnings);
            this.tabEarnings.Location = new System.Drawing.Point(4, 22);
            this.tabEarnings.Name = "tabEarnings";
            this.tabEarnings.Size = new System.Drawing.Size(706, 399);
            this.tabEarnings.TabIndex = 2;
            this.tabEarnings.Text = "Earnings";
            this.tabEarnings.UseVisualStyleBackColor = true;
            // 
            // pnlEarnings
            // 
            this.pnlEarnings.Controls.Add(this.lblPE);
            this.pnlEarnings.Controls.Add(this.lblEPS);
            this.pnlEarnings.Controls.Add(this.label12);
            this.pnlEarnings.Controls.Add(this.label11);
            this.pnlEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEarnings.Location = new System.Drawing.Point(0, 0);
            this.pnlEarnings.Name = "pnlEarnings";
            this.pnlEarnings.Size = new System.Drawing.Size(706, 399);
            this.pnlEarnings.TabIndex = 0;
            // 
            // lblPE
            // 
            this.lblPE.AutoSize = true;
            this.lblPE.Location = new System.Drawing.Point(149, 79);
            this.lblPE.Name = "lblPE";
            this.lblPE.Size = new System.Drawing.Size(41, 13);
            this.lblPE.TabIndex = 3;
            this.lblPE.Text = "label13";
            // 
            // lblEPS
            // 
            this.lblEPS.AutoSize = true;
            this.lblEPS.Location = new System.Drawing.Point(149, 54);
            this.lblEPS.Name = "lblEPS";
            this.lblEPS.Size = new System.Drawing.Size(41, 13);
            this.lblEPS.TabIndex = 2;
            this.lblEPS.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(90, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "P/E";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "EPS";
            // 
            // tabTrends
            // 
            this.tabTrends.Controls.Add(this.pnlTrends);
            this.tabTrends.Location = new System.Drawing.Point(4, 22);
            this.tabTrends.Name = "tabTrends";
            this.tabTrends.Size = new System.Drawing.Size(706, 399);
            this.tabTrends.TabIndex = 3;
            this.tabTrends.Text = "Trends";
            this.tabTrends.UseVisualStyleBackColor = true;
            // 
            // pnlTrends
            // 
            this.pnlTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrends.Location = new System.Drawing.Point(0, 0);
            this.pnlTrends.Name = "pnlTrends";
            this.pnlTrends.Size = new System.Drawing.Size(706, 399);
            this.pnlTrends.TabIndex = 0;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.pnlHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(706, 399);
            this.tabHistory.TabIndex = 4;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // pnlHistory
            // 
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(706, 399);
            this.pnlHistory.TabIndex = 0;
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.pnlTransactions);
            this.tabTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Size = new System.Drawing.Size(706, 399);
            this.tabTransactions.TabIndex = 5;
            this.tabTransactions.Text = "Transactions";
            this.tabTransactions.UseVisualStyleBackColor = true;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.groupBox1);
            this.pnlTransactions.Controls.Add(this.transactionGrid);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 0);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(706, 399);
            this.pnlTransactions.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.transactionDatePicker);
            this.groupBox1.Controls.Add(this.addTransactionButton);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.sharesTextbox);
            this.groupBox1.Controls.Add(this.transactionTypeCombo);
            this.groupBox1.Location = new System.Drawing.Point(56, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(370, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Share Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(263, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Share Count";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Transaction Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "TransactionDate";
            // 
            // transactionDatePicker
            // 
            this.transactionDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transactionDatePicker.Location = new System.Drawing.Point(16, 62);
            this.transactionDatePicker.Name = "transactionDatePicker";
            this.transactionDatePicker.Size = new System.Drawing.Size(104, 20);
            this.transactionDatePicker.TabIndex = 5;
            this.transactionDatePicker.ValueChanged += new System.EventHandler(this.transactionDatePicker_ValueChanged);
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Enabled = false;
            this.addTransactionButton.Location = new System.Drawing.Point(476, 61);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(75, 23);
            this.addTransactionButton.TabIndex = 4;
            this.addTransactionButton.Text = "Add";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(370, 62);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // sharesTextbox
            // 
            this.sharesTextbox.Location = new System.Drawing.Point(263, 62);
            this.sharesTextbox.Name = "sharesTextbox";
            this.sharesTextbox.Size = new System.Drawing.Size(100, 20);
            this.sharesTextbox.TabIndex = 2;
            this.sharesTextbox.TextChanged += new System.EventHandler(this.SharesTextbox_TextChanged);
            // 
            // transactionTypeCombo
            // 
            this.transactionTypeCombo.FormattingEnabled = true;
            this.transactionTypeCombo.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "DivReInv"});
            this.transactionTypeCombo.Location = new System.Drawing.Point(126, 62);
            this.transactionTypeCombo.Name = "transactionTypeCombo";
            this.transactionTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.transactionTypeCombo.TabIndex = 1;
            this.transactionTypeCombo.SelectedIndexChanged += new System.EventHandler(this.transactionTypeCombo_SelectedIndexChanged);
            // 
            // transactionGrid
            // 
            this.transactionGrid.AllowUserToAddRows = false;
            this.transactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transDate,
            this.transType,
            this.shares,
            this.price,
            this.total});
            this.transactionGrid.Location = new System.Drawing.Point(56, 171);
            this.transactionGrid.Name = "transactionGrid";
            this.transactionGrid.RowHeadersWidth = 20;
            this.transactionGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transactionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionGrid.Size = new System.Drawing.Size(565, 181);
            this.transactionGrid.TabIndex = 0;
            // 
            // transDate
            // 
            this.transDate.DataPropertyName = "TransactionDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.transDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.transDate.HeaderText = "Date";
            this.transDate.Name = "transDate";
            // 
            // transType
            // 
            this.transType.DataPropertyName = "ActionString";
            this.transType.HeaderText = "Transaction Type";
            this.transType.Name = "transType";
            this.transType.Width = 150;
            // 
            // shares
            // 
            this.shares.DataPropertyName = "ShareCount";
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.shares.DefaultCellStyle = dataGridViewCellStyle2;
            this.shares.HeaderText = "Shares";
            this.shares.Name = "shares";
            // 
            // price
            // 
            this.price.DataPropertyName = "SharePrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // total
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle4;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // TickerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 425);
            this.Controls.Add(this.tabTickerDetail);
            this.Name = "TickerDetailForm";
            this.Text = "Equity Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TickerDetailForm_FormClosing);
            this.tabTickerDetail.ResumeLayout(false);
            this.tabPricing.ResumeLayout(false);
            this.pnlPricing.ResumeLayout(false);
            this.pnlPricing.PerformLayout();
            this.tabDividends.ResumeLayout(false);
            this.pnlDividends.ResumeLayout(false);
            this.pnlDividends.PerformLayout();
            this.tabEarnings.ResumeLayout(false);
            this.pnlEarnings.ResumeLayout(false);
            this.pnlEarnings.PerformLayout();
            this.tabTrends.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabTransactions.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabTickerDetail;
		private System.Windows.Forms.TabPage tabPricing;
		private System.Windows.Forms.TabPage tabDividends;
		private System.Windows.Forms.TabPage tabEarnings;
		private System.Windows.Forms.TabPage tabTrends;
		private System.Windows.Forms.TabPage tabHistory;
		private System.Windows.Forms.Panel pnlPricing;
		private System.Windows.Forms.Panel pnlDividends;
		private System.Windows.Forms.Panel pnlEarnings;
		private System.Windows.Forms.Panel pnlTrends;
		private System.Windows.Forms.Panel pnlHistory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblVolume;
		private System.Windows.Forms.Label lblLow;
		private System.Windows.Forms.Label lblHigh;
		private System.Windows.Forms.Label lblOpen;
		private System.Windows.Forms.Label lblPercentChange;
		private System.Windows.Forms.Label lblChange;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblExDividend;
		private System.Windows.Forms.Label lblDividend;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblDividendYield;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblPE;
		private System.Windows.Forms.Label lblEPS;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabTransactions;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.DataGridView transactionGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker transactionDatePicker;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox sharesTextbox;
        private System.Windows.Forms.ComboBox transactionTypeCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn transType;
        private System.Windows.Forms.DataGridViewTextBoxColumn shares;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
	}
}