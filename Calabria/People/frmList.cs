using Calabria.Base.Forms;
using Calabria.Models;
using Calabria.Services.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Calabria.Base.Forms.CRUDForm;

namespace Calabria.People
{
	public partial class frmList : BaseForm
	{
		private frmCRUD _frmCRUD;
		internal PersonDataService DataService = new PersonDataService();

		public frmList()
		{
			InitializeComponent();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			_frmCRUD = new frmCRUD(CRUDStateEnum.Create, null);
			var result = _frmCRUD.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				LoadDataList(null);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmList_Load(object sender, EventArgs e)
		{
			LoadDataList(null);
		}

		private void LoadDataList(List<Person> dataList)
		{
			dgvList.Rows.Clear();

			if (dataList == null)
			{
				dataList = DataService.GetDataListItems();
			}

			foreach (Person item in dataList)
			{
				if (!item.IsDeleted)
				{
					dgvList.Rows.Add(
						item.Id,
						item.Names,
						item.Surnames,
						item.Age,
						item.Phone,
						item.EmergencyContact,
						item.IsMember
					);
				}
			}
		}

		private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var item = dgvList.Rows[e.RowIndex];
			var id = int.Parse(item.Cells[0].Value.ToString());
			var person = DataService.FindItemInList(id);

			_frmCRUD = new frmCRUD(CRUDStateEnum.Update, person);

			var result = _frmCRUD.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				LoadDataList(null);
			}
		}

		private void txt_search_TextChanged(object sender, EventArgs e)
		{
			if (sender.ToString().Length > 3)
			{

			}
		}
	}
}