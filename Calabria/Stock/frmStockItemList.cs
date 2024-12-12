using Calabria.Base.Forms;
using Calabria.Models;
using Calabria.Services.Google;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Calabria.Base.Forms.CRUDForm;

namespace Calabria.Stock
{
	public partial class frmStockItemList : BaseForm
	{
		public readonly SpreadSheetConnector sheetConnector;
		private FrmCRUDStock _frmStockitem;
		private int _maxItemId = 1;

		public frmStockItemList()
		{
			InitializeComponent();
			sheetConnector = new SpreadSheetConnector(
				sheetName: "StockItems",
				firstColumn: "A",
				lastColumn: "F",
				firstIndexOffset: 2
			);
			sheetConnector.ConnectToGoogle();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FrmStockItemList_Load(object sender, EventArgs e)
		{
			LoadStockItems();
		}

		private void btn_addStockItem_Click(object sender, EventArgs e)
		{
			_frmStockitem = new FrmCRUDStock(CRUDStateEnum.Create, _maxItemId, null);
			var result = _frmStockitem.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				LoadStockItems();
			}
		}

		private void LoadStockItems()
		{
			//var range = "StockItems!A2:D";

			dgvIStockitems.Rows.Clear();
			sheetConnector.SpreadSheetRange.Init();

			var rangeValues = sheetConnector.GetData();

			// Do nothing if range has no values
			if (rangeValues.Values == null)
			{
				return;
			}

			List<StockItem> stockItems = new List<StockItem>();
			for (int i = 0; rangeValues.Values.Count > i; i++)
			{
				var item = rangeValues.Values[i];

				stockItems.Add(new StockItem()
				{
					IsDeleted = bool.Parse((string)item[0]),
					Id = int.Parse((string)item[2]),
					ItemType = (string)item[3],
					Name = (string)item[4],
					Description = (string)item[5]
				});

				_maxItemId = (int)stockItems[i].Id;

				if (!stockItems[i].IsDeleted)
				{
					dgvIStockitems.Rows.Add(
						stockItems[i].Id,
						stockItems[i].Name,
						stockItems[i].ItemType,
						stockItems[i].Description
					);
				}
			}
		}

		private void dgvIStockitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
				e.RowIndex >= 0)
			{
				var item = dgvIStockitems.Rows[e.RowIndex];
				var id = int.Parse(item.Cells[0].Value.ToString());
				var name = (string)item.Cells[1].Value;
				var itemType = (string)item.Cells[2].Value;
				var description = (string)item.Cells[3].Value;
				var rowIndex = sheetConnector.FindRowIndexById(id);

				_frmStockitem = new FrmCRUDStock(CRUDStateEnum.Update, (int)rowIndex, new StockItem()
				{
					Id = id,
					Description = description,
					Name = name,
					ItemType = itemType
				});

				var result = _frmStockitem.ShowDialog(this);

				if (result == DialogResult.OK)
				{
					LoadStockItems();
				}
			}
		}
	}
}