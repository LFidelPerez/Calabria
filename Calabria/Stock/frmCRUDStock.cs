using Calabria.Base.Forms;
using Calabria.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Calabria.Stock
{
	public partial class FrmCRUDStock : CRUDForm
	{
		private readonly string sheetName = "StockItems";
		private readonly string rangeFirstColumn = "A";
		private readonly string rangeLastColumn = "D";
		private readonly string range = "{sheetName}!{rangeFirstColumn}{indexOffset}:{rangeLastColumn}";
		private readonly int indexOffset = 2;

		private int ItemId { get; set; }
		private frmStockItemList MyOwner { get { return (frmStockItemList)Owner; } }

		private string GetRange
		{
			get
			{
				StringBuilder sb = new StringBuilder(range);

				sb.Replace("{sheetName}", sheetName);
				sb.Replace("{rangeFirstColumn}", rangeFirstColumn);
				sb.Replace("{indexOffset}", indexOffset.ToString());
				sb.Replace("{rangeLastColumn}", rangeLastColumn);

				return sb.ToString();
			}
		}

		public FrmCRUDStock(CRUDStateEnum stateEnum, int itemOffset, StockItem stockItem) : base(stateEnum)
		{
			InitializeComponent();

			switch (CRUDState)
			{
				case CRUDStateEnum.Create:
					indexOffset += itemOffset;
					ItemId = itemOffset + 1;
					btnUpdate.Enabled = false;
					break;
				case CRUDStateEnum.Update:
					indexOffset += itemOffset;
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

			MyOwner.sheetConnector.AppendData("StockItems!A:D", modelList);

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

			MyOwner.sheetConnector.UpdateData(GetRange, modelList);

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

			MyOwner.sheetConnector.DeleteData(GetRange, modelList);

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}