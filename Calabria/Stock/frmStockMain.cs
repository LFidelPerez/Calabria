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
	public partial class frmStockMain : Form
	{
		private frmStockItemList _frmStockItemList;

		public frmStockMain()
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
