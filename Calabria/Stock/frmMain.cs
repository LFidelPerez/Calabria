﻿using Calabria.Base.Forms;
using System;

namespace Calabria.Stock
{
	public partial class frmMain : BaseForm
	{
		private Items.frmList _frmStockItemList;
		private Invoices.frmList _frmInvoicesItemList;
		

		public frmMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_frmStockItemList = new Items.frmList();
			_frmStockItemList.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_frmInvoicesItemList= new Invoices.frmList();
			_frmInvoicesItemList.ShowDialog();
		}
	}
}
