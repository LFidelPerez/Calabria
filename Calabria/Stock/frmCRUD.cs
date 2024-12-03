using Calabria.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Calabria.Base.Forms;
using Calabria.Services.Google;

namespace Calabria.Stock
{
	public partial class frmCRUDStock : CRUDForm
	{
		private readonly SpreadSheetConnector sheetConnector;
		private int indexOffset = 2;
		private int itemCount;
		private StockItem stockItem;

		public int ItemId { get; private set; }

		public frmCRUDStock(CRUDStateEnum stateEnum, int itemOffset, StockItem stockItem):base(stateEnum)
		{
			InitializeComponent();
			sheetConnector = new SpreadSheetConnector();
			this.itemCount = itemOffset;
			this.stockItem = stockItem;

			switch (this.CRUDState)
			{
				case CRUDStateEnum.Create:
					indexOffset += itemOffset;
					ItemId = itemOffset + 1;
					this.btnUpdate.Enabled = false;
					break;
				case CRUDStateEnum.Update:
					indexOffset = indexOffset + itemOffset;
					ItemId = itemOffset;
					this.btnSave.Enabled = false;
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
			//var range = "StockItems!A2:D";

			string range = $"StockItems!A{indexOffset}:D";

			sheetConnector.ConnectToGoogle();

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

			sheetConnector.AppendData(range, modelList);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string range = $"StockItems!A{indexOffset}:D";

			sheetConnector.ConnectToGoogle();

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

			sheetConnector.UpdateData(range, modelList);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string range = $"StockItems!A{indexOffset}:D";

			sheetConnector.ConnectToGoogle();

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

			sheetConnector.DeleteData(range, modelList);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}