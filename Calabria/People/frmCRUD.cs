using Calabria.Base.Forms;
using Calabria.Models;
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
	public partial class frmCRUD : CRUDForm
	{
		private Person _person;
		private int _itemOffset;

		public frmCRUD(CRUDStateEnum stateEnum, int itemOffset, Person person) : base(stateEnum)
		{
			InitializeComponent();

			_person = person;
			_itemOffset = itemOffset;
		}
	}
}
