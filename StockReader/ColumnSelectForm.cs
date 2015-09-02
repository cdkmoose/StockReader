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
	public partial class ColumnSelectForm : Form
	{
		private List<ColumnDefType> columns;

		public ColumnSelectForm()
		{
			InitializeComponent();
		}

		public void SetColumnList(List<ColumnDefType> colList)
		{
			columns = colList;

			FillListBox();
		}

		private void FillListBox()
		{
			foreach (ColumnDefType col in columns)
			{
				columnListBox.Items.Add(col, col.Selected);
			}
		}

		private void columnListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked)
			{
				((ColumnDefType)columnListBox.Items[e.Index]).Selected = true;
			}
			else if (e.NewValue == CheckState.Unchecked)
			{
				((ColumnDefType)columnListBox.Items[e.Index]).Selected = false;
			}
		}

	}
}