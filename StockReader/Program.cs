using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DavinSys.StockReader.UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            StockReaderForm frm = new StockReaderForm();

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1 && !string.IsNullOrEmpty(args[1]))
                frm.LoadPortfolio(args[1]);

			Application.Run(frm);
		}
	}
}