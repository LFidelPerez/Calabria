using Calabria.Models;
using Calabria.Services.Google;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calabria.Base.Forms.CRUDForm;

namespace Calabria.Stock
{
	public partial class frmStockItemList : Form
	{
		private readonly SpreadSheetConnector sheetConnector;
		private frmCRUDStock _frmStockitem;

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
			this.LoadStockItems();
		}

		private void btn_addStockItem_Click(object sender, EventArgs e)
		{
			_frmStockitem = new frmCRUDStock(CRUDStateEnum.Create, dgvIStockitems.Rows.Count, null);
			var result = _frmStockitem.ShowDialog(this);

			if (result == DialogResult.OK) this.LoadStockItems();
		}

		private void LoadStockItems()
		{
			var range = "StockItems!A2:D";

			dgvIStockitems.Rows.Clear();

			sheetConnector.ConnectToGoogle();
			var rangeValues = sheetConnector.GetData(range);

			List<StockItem> stockItems = new List<StockItem>();
			for (int i = 0; rangeValues.Values.Count > i; i++)
			{
				var item = rangeValues.Values[i];

				stockItems.Add(new StockItem()
				{
					Id = int.Parse((string)item[0]),
					Description = (string)item[1],
					Name = (string)item[2],
					ItemType = (string)item[3]
				});


				dgvIStockitems.Rows.Add(stockItems[i].Id, stockItems[i].Name, stockItems[i].ItemType, stockItems[i].Description);
			}

			/*
			//use binding source to hold dummy data
			BindingSource binding = new BindingSource();
			binding.DataSource = stockItems;

			//bind datagridview to binding source
			dgvIStockitems.DataSource = binding;
			*/
		}
				
		private void dgvIStockitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
				e.RowIndex >= 0)
			{
				var item = dgvIStockitems.Rows[e.RowIndex];
				var id = int.Parse(item.Cells[0].Value.ToString());
				var description = (string)item.Cells[3].Value;
				var name = (string)item.Cells[1].Value;
				var itemType = (string)item.Cells[2].Value;

				_frmStockitem = new frmCRUDStock(CRUDStateEnum.Update, e.RowIndex, new StockItem()
				{
					Id = id,
					Description = description,
					Name = name,
					ItemType = itemType
				});

				var result = _frmStockitem.ShowDialog(this);

				if(result == DialogResult.OK) this.LoadStockItems();
			}
		}
	}
}
