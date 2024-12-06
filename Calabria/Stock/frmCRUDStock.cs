﻿using Calabria.Base.Forms;
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

		private List<IList<object>> GetItemData(bool delete = false)
		{
			var item = new StockItem
			{
				Id = ItemId,
				Name = txtName.Text,
				Description = txtDescription.Text,
				ItemType = txtType.Text
			};

			return new List<IList<object>>
				{
					new List<object>
					{
						delete,
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

			switch (CRUDState)
			{
				case CRUDStateEnum.Create:
					ItemId = itemOffset + 1;
					btnUpdate.Enabled = false;
					break;
				case CRUDStateEnum.Update:
					_itemOffset = itemOffset;
					ItemId = (int)stockItem.Id;
					btnSave.Enabled = false;
					break;
				case CRUDStateEnum.Delete:
					_itemOffset = itemOffset;
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
			SetUpdateIndex();
			
			MyOwner.sheetConnector.UpdateData(GetItemData());

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			SetUpdateIndex();

			MyOwner.sheetConnector.DeleteData(GetItemData(true));

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}