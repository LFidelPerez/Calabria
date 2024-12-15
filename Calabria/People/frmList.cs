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

namespace Calabria.People
{
	public partial class frmList : BaseForm
	{
		public readonly SpreadSheetConnector sheetConnector;
		private FrmCRUDStock _frmStockitem;
		private int _maxItemId = 1;

		public frmList()
		{
			InitializeComponent();
			sheetConnector = new SpreadSheetConnector(
				sheetName: "Miembros",
				firstColumn: "A",
				lastColumn: "K",
				firstIndexOffset: 2
			);
			sheetConnector.ConnectToGoogle();
		}
	}
}
