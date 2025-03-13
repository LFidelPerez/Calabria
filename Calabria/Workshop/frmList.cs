using Calabria.Base.Forms;
using Calabria.Services.Models;
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
using Calabria.Models;

namespace Calabria.Workshop
{
	public partial class frmList : BaseForm
	{
		private readonly WorkshopDataService _dataService = new WorkshopDataService();

		public frmList()
		{
			InitializeComponent();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			/*
			_frmCRUD = new frmCRUD(CRUDStateEnum.Create, null, _dataService);
			var result = _frmCRUD.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				LoadDataList(null);
			}
			*/
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmList_Load(object sender, EventArgs e)
		{
			LoadDataList(null);
		}

		private void LoadDataList(List<Models.Workshop> dataList)
		{
			dgvList.Rows.Clear();

			if (dataList == null)
			{
				dataList = _dataService.GetDataListItems();
			}

			foreach (Models.Workshop item in dataList)
			{
				if (!item.IsDeleted)
				{
					dgvList.Rows.Add(
						item.Id,
						item.Name,
						item.Time,
						item.Day,
						item.Age,
						item.Materials,
						item.StartDate,
						item.Classroom,
						item.WorkshopperId,
						item.Instagram,
						item.Summary
					);
				}
			}
		}

		private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*
			var item = dgvList.Rows[e.RowIndex];
			var id = int.Parse(item.Cells[0].Value.ToString());
			var person = _dataService.FindItemInList(id);

			_frmCRUD = new frmCRUD(CRUDStateEnum.Update, person, _dataService);

			var result = _frmCRUD.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				LoadDataList(null);
			}
			*/
		}

		private void FilterBySearch()
		{
			/*
			if (txt_search.Text.Length >= 3)
			{
				var filteredList = _dataService.FilterItemsByNames(txt_search.Text);
				LoadDataList(filteredList);
			}
			else
			{
				LoadDataList(null);
			}
			*/
		}
	}
}
