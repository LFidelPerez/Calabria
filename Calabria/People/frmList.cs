using Calabria.Base.Forms;
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

		public frmList()
		{
			InitializeComponent();
			sheetConnector = new SpreadSheetConnector(
				sheetName: "Miembros",
				firstColumn: "A",
				lastColumn: "O",
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
				//LoadStockItems();
			}
		}
	}
}
