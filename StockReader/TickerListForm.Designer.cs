namespace DavinSys.StockReader.UI
{
    partial class TickerListForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnRemoveTicker = new System.Windows.Forms.Button();
			this.btnAddTicker = new System.Windows.Forms.Button();
			this.txtTicker = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbTickers = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(8);
			this.panel1.Size = new System.Drawing.Size(292, 305);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.btnRemoveTicker);
			this.panel2.Controls.Add(this.btnAddTicker);
			this.panel2.Controls.Add(this.txtTicker);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lbTickers);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(8, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(276, 289);
			this.panel2.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(160, 252);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(56, 252);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnRemoveTicker
			// 
			this.btnRemoveTicker.Enabled = false;
			this.btnRemoveTicker.Location = new System.Drawing.Point(110, 208);
			this.btnRemoveTicker.Name = "btnRemoveTicker";
			this.btnRemoveTicker.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveTicker.TabIndex = 11;
			this.btnRemoveTicker.Text = "&Remove";
			this.btnRemoveTicker.UseVisualStyleBackColor = true;
			this.btnRemoveTicker.Click += new System.EventHandler(this.btnRemoveTicker_Click);
			// 
			// btnAddTicker
			// 
			this.btnAddTicker.Enabled = false;
			this.btnAddTicker.Location = new System.Drawing.Point(185, 13);
			this.btnAddTicker.Name = "btnAddTicker";
			this.btnAddTicker.Size = new System.Drawing.Size(75, 23);
			this.btnAddTicker.TabIndex = 10;
			this.btnAddTicker.Text = "&Add";
			this.btnAddTicker.UseVisualStyleBackColor = true;
			this.btnAddTicker.Click += new System.EventHandler(this.btnAddTicker_Click);
			// 
			// txtTicker
			// 
			this.txtTicker.Location = new System.Drawing.Point(67, 16);
			this.txtTicker.Name = "txtTicker";
			this.txtTicker.Size = new System.Drawing.Size(100, 20);
			this.txtTicker.TabIndex = 9;
			this.txtTicker.TextChanged += new System.EventHandler(this.txtTicker_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Ticker:";
			// 
			// lbTickers
			// 
			this.lbTickers.FormattingEnabled = true;
			this.lbTickers.Location = new System.Drawing.Point(88, 55);
			this.lbTickers.Name = "lbTickers";
			this.lbTickers.Size = new System.Drawing.Size(120, 147);
			this.lbTickers.TabIndex = 7;
			this.lbTickers.SelectedIndexChanged += new System.EventHandler(this.lbTickers_SelectedIndexChanged);
			// 
			// TickerListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 305);
			this.Controls.Add(this.panel1);
			this.Name = "TickerListForm";
			this.Text = "Ticker List";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnRemoveTicker;
		private System.Windows.Forms.Button btnAddTicker;
		private System.Windows.Forms.TextBox txtTicker;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbTickers;

	}
}