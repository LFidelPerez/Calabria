using Calabria.Base.Forms;
using Calabria.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calabria.Stock
{
	public partial class FrmCRUDStock : CRUDForm
	{
		//private readonly int _indexOffset = 2;
		private readonly int _itemOffset;

		private int ItemId { get; set; }
		private frmStockItemList MyOwner { get { return (frmStockItemList)Owner; } }

		public FrmCRUDStock(CRUDStateEnum stateEnum, int itemOffset, StockItem stockItem) : base(stateEnum)
		{
			InitializeComponent();

			switch (CRUDState)
			{
				case CRUDStateEnum.Create:
					ItemId = itemOffset + 1;
					btnUpdate.Enabled = false;
					break;
				case CRUDStateEnum.Update:
					_itemOffset = itemOffset;
					ItemId = itemOffset;
					btnSave.Enabled = false;
					break;
				case CRUDStateEnum.Delete:
					break;
				default:
					throw new Exception("CRUD State invalid");
			}

			if (stockItem != null)
			{
				txtName.Text = stockItem.Name;
				txtDescription.Text = stockItem.Description;
				txtType.Text = stockItem.ItemType;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var item = new StockItem { Id = ItemId, Name = txtName.Text, Description = txtDescription.Text, ItemType = txtType.Text };

			var modelList = new List<IList<object>>
				{
					new List<object>
					{
						item.Id,
						item.ItemType,
						item.Name,
						item.Description
					}
				};

			MyOwner.sheetConnector.SpreadSheetRange.FirstIndexOffset = int.MinValue;
			MyOwner.sheetConnector.AppendData(modelList);

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var item = new StockItem { Id = ItemId, Name = txtName.Text, Description = txtDescription.Text, ItemType = txtType.Text };

			var modelList = new List<IList<object>>
				{
					new List<object>
					{
						item.Id,
						item.ItemType,
						item.Name,
						item.Description
					}
				};

			var itemOffset = MyOwner.sheetConnector.SpreadSheetRange.InitialFirstIndexOffset + _itemOffset;

			MyOwner.sheetConnector.SpreadSheetRange.FirstIndexOffset = itemOffset;
			MyOwner.sheetConnector.UpdateData(modelList);

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var item = new StockItem { Id = ItemId, Name = txtName.Text, Description = txtDescription.Text, ItemType = txtType.Text };

			var modelList = new List<IList<object>>
				{
					new List<object>
					{
						item.Id,
						item.ItemType,
						item.Name,
						item.Description
					}
				};

			MyOwner.sheetConnector.DeleteData(modelList);

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}