using Calabria.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calabria
{
	public partial class frmStock : Form
	{
		private frmStockItemList _frmStockItemList;

		public frmStock()
		{
			InitializeComponent();
		}
				
		private void button1_Click(object sender, EventArgs e)
		{
			_frmStockItemList=new frmStockItemList();
			_frmStockItemList.ShowDialog();
		}
	}
}
