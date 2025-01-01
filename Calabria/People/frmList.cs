using Calabria.Base.Forms;
using Calabria.Helpers;
using Calabria.Models;
using Calabria.Services.Google;
using Calabria.Stock.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calabria.Base.Forms.CRUDForm;

namespace Calabria.People
{
	public partial class frmList : BaseForm
	{
		public readonly SpreadSheetConnector sheetConnector;
		private frmCRUD _frmCRUD;
		private int _maxItemId = 1;
		private List<Person> _dataList = new List<Person>();

		public frmList()
		{
			InitializeComponent();
			sheetConnector = new SpreadSheetConnector(
				sheetName: "Miembros",
				firstColumn: "A",
				lastColumn: "P",
				firstIndexOffset: 2
			);
			sheetConnector.ConnectToGoogle();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			_frmCRUD = new frmCRUD(CRUDStateEnum.Create, _maxItemId, null);
			var result = _frmCRUD.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				LoadDataList();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmList_Load(object sender, EventArgs e)
		{
			LoadDataList();
		}

		private void LoadDataList()
		{
			//var range = "StockItems!A2:D";

			_dataList.Clear();
			dgvList.Rows.Clear();
			sheetConnector.SpreadSheetRange.Init();

			var rangeValues = sheetConnector.GetData();

			// Do nothing if range has no values
			if (rangeValues.Values == null)
			{
				return;
			}

			for (int i = 0; rangeValues.Values.Count > i; i++)
			{
				var item = rangeValues.Values[i];

				_dataList.Add(new Person()
				{
					IsDeleted = ObjectTypeCast.ToBool(item[0]),
					Id = ObjectTypeCast.ToInt(item[2]),
					Names = item[3].ToString(),
					Surnames = item[4].ToString(),
					Email = item[5].ToString(),
					Phone = item[6].ToString(),
					EmergencyContact = item[7].ToString(),
					Birthday = ObjectTypeCast.ToDateTime(item[8]),
					IsMember = ObjectTypeCast.ToBool(item[9]),
					IsExcempt = ObjectTypeCast.ToBool(item[10]),
					Gender = item[11].ToString(),
					DischargeDate = ObjectTypeCast.ToDateTime(item[12]),
					AssociateDate = ObjectTypeCast.ToDateTime(item[13]),
					IsWorkshopper = ObjectTypeCast.ToBool(item[14])
				});

				_maxItemId = (int)_dataList[i].Id;

				if (!_dataList[i].IsDeleted)
				{
					dgvList.Rows.Add(
						_dataList[i].Id,
						_dataList[i].Names,
						_dataList[i].Surnames,
						_dataList[i].Age,
						_dataList[i].Phone,
						_dataList[i].EmergencyContact,
						_dataList[i].IsMember
					);
				}
			}
		}

		private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//var senderGrid = (DataGridView)sender;

			/*
			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
				e.RowIndex >= 0)
			{
			*/
				var item = dgvList.Rows[e.RowIndex];
				var id = int.Parse(item.Cells[0].Value.ToString());
				var person = FindItemInList(id);
				var rowIndex = sheetConnector.FindRowIndexById(id);

				_frmCRUD = new frmCRUD(CRUDStateEnum.Update, (int)rowIndex, person);

				var result = _frmCRUD.ShowDialog(this);

				if (result == DialogResult.OK)
				{
					LoadDataList();
				}
			/*}*/
		}

		private Person FindItemInList(int id)
		{
			foreach (var item in _dataList)
			{
				if (item.Id == id)
				{
					return item;
				}
			}

			return null;
		}
	}
}
