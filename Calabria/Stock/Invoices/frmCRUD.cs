using Calabria.Base.Forms;
using Calabria.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calabria.Stock.Invoices
{
	public partial class FrmCRUD : CRUDForm
	{
		private int ItemId { get; set; }
		private frmList MyOwner { get { return (frmList)Owner; } }
		private StockItem _stockItem;
		private int _itemOffset;

		public FrmCRUD(CRUDStateEnum stateEnum, int itemOffset, StockItem stockItem) : base(stateEnum)
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
			//MyOwner.sheetConnector.AppendData(GetItemData());

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//MyOwner.sheetConnector.UpdateData(GetItemData());

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//MyOwner.sheetConnector.DeleteData(GetItemData(true));

			DialogResult = DialogResult.OK;
			Close();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}