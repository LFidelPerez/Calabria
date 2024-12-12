using Calabria.Base.Forms;
using Calabria.Stock.Items;
using System;

namespace Calabria
{
	public partial class frmStockMain : BaseForm
	{
		private frmStockItemList _frmStockItemList;

		public frmStockMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_frmStockItemList = new frmStockItemList();
			_frmStockItemList.ShowDialog();
		}
	}
}
