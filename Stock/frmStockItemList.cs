using Calabria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calabria.Stock
{
	public partial class frmStockItemList : Form
	{
		private readonly SpreadSheetConnector sheetConnector;

		public frmStockItemList()
		{
			InitializeComponent();
			sheetConnector = new SpreadSheetConnector();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FrmStockItemList_Load(object sender, EventArgs e)
		{
			var range = "StockItems!A2:D";

			sheetConnector.ConnectToGoogle();
			var rangeValues = sheetConnector.GetData(range);

			List<StockItem> stockItems = new List<StockItem>();
			for (int i = 0; rangeValues.Values.Count > i; i++) { 
				var item = rangeValues.Values[i];

				stockItems.Add(new StockItem()
				{
					Id = int.Parse((string)item[0]),
					Description = (string)item[1],
					Name = (string)item[2],
					Type = (string)item[3]
				});


				dgvIStockitems.Rows.Add(stockItems[i].Id, stockItems[i].Name, stockItems[i].Type, stockItems[i].Description);
			}

			


			/*
			//use binding source to hold dummy data
			BindingSource binding = new BindingSource();
			binding.DataSource = stockItems;

			//bind datagridview to binding source
			dgvIStockitems.DataSource = binding;
			*/
		}
	}
}
