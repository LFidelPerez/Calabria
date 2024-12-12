using Calabria.Base.Forms;
using Calabria.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calabria.Stock
{
	public partial class FrmCRUDStock : CRUDForm
	{
		private int ItemId { get; set; }
		private frmStockItemList MyOwner { get { return (frmStockItemList)Owner; } }
		private StockItem _stockItem;
		private int _itemOffset;

		private List<IList<object>> GetItemData(bool delete = false)
		{
			var item = new StockItem
			{
				Id = ItemId,
				Name = txtName.Text.Trim(),
				Description = txtDescription.Text.Trim(),
				ItemType = cmbType.Text.Trim()
			};

			return new List<IList<object>>
				{
					new List<object>
					{
						delete,
						delete?DateTime.Now:DateTime.MinValue,
						item.Id,
						item.ItemType,
						item.Name,
						item.Description
					}
				};
		}

		public FrmCRUDStock(CRUDStateEnum stateEnum, int itemOffset, StockItem stockItem) : base(stateEnum)
		{
			InitializeComponent();

			_stockItem = stockItem;
			_itemOffset = itemOffset;
		}

		private void FrmCRUDStock_Load(object sender, EventArgs e)
		{
			switch (CRUDState)
			{
				case CRUDStateEnum.Create:
					ItemId = _itemOffset + 1;
					btnUpdate.Enabled = false;
					break;
				case CRUDStateEnum.Update:
					ItemId = (int)_stockItem.Id;
					btnSave.Enabled = false;
					break;
			}

			SetUpdateIndex();
			InitCmbItemType();

			if (_stockItem != null)
			{
				txtName.Text = _stockItem.Name;
				txtDescription.Text = _stockItem.Description;
				cmbType.Text = _stockItem.ItemType;
			}
		}

		private void InitCmbItemType()
		{
			var typeList = MyOwner.sheetConnector.FilterData(3);

			foreach (var item in typeList)
			{
				cmbType.Items.Add(item);
			}
		}

		private void SetUpdateIndex()
		{
			var itemOffset = MyOwner.sheetConnector.SpreadSheetRange.InitialFirstIndexOffset + _itemOffset;

			MyOwner.sheetConnector.SpreadSheetRange.FirstIndexOffset = itemOffset;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MyOwner.sheetConnector.SpreadSheetRange.FirstIndexOffset = int.MinValue;
			MyOwner.sheetConnector.AppendData(GetItemData());

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			MyOwner.sheetConnector.UpdateData(GetItemData());

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			MyOwner.sheetConnector.DeleteData(GetItemData(true));

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}