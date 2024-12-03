﻿using Calabria.Helpers.Google;
using Calabria.Models;
using Calabria.Services.Google;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Calabria.Base.Forms.CRUDForm;

namespace Calabria.Stock
{
	public partial class frmStockItemList : Form
	{
		public readonly SpreadSheetConnector sheetConnector;
		public readonly SpreadSheetRange spreadSheetRange;
		private FrmCRUDStock _frmStockitem;

		public frmStockItemList()
		{
			InitializeComponent();
			sheetConnector = new SpreadSheetConnector();
			sheetConnector.ConnectToGoogle();

			spreadSheetRange = new SpreadSheetRange()
			{
				SheetName = "StockItems",
				FirstColumn = "A",
				FirstIndexOffset = 2,
				LastColumn = "D"
			};
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
			_frmStockitem = new FrmCRUDStock(CRUDStateEnum.Create, dgvIStockitems.Rows.Count, null);
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

			var rangeValues = sheetConnector.GetData(spreadSheetRange.ToString());

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
					Id = int.Parse((string)item[0]),
					Description = (string)item[1],
					Name = (string)item[2],
					ItemType = (string)item[3]
				});


				dgvIStockitems.Rows.Add(stockItems[i].Id, stockItems[i].Name, stockItems[i].ItemType, stockItems[i].Description);
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
				var description = (string)item.Cells[3].Value;
				var name = (string)item.Cells[1].Value;
				var itemType = (string)item.Cells[2].Value;

				_frmStockitem = new FrmCRUDStock(CRUDStateEnum.Update, e.RowIndex, new StockItem()
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