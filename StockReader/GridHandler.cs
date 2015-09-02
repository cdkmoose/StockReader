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

		private void BindColumns()
		{
			DataGridViewCellStyle style;
			DataGridViewTextBoxColumn column;

			foreach (ColumnDefType col in config.ColumnList)
			{
				column = new DataGridViewTextBoxColumn();
				column.DataPropertyName = col.BindingColumn;
				column.HeaderText = col.ColHeading;
				column.Name = col.ColName;
				column.ReadOnly = true;
				column.Visible = col.Selected;

				if (String.IsNullOrEmpty(col.ColFormat) == false)
				{
					style = new DataGridViewCellStyle();
					style.Format = col.ColFormat;
					style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

					column.DefaultCellStyle = style;
				}

				stockDataGridView.Columns.Add(column);
			}

		}

	}
}