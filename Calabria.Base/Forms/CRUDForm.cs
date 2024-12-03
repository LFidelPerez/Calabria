using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabria.Base.Forms
{
	public class CRUDForm : Form
	{
		public enum CRUDStateEnum
		{
			X, Create, Update, Delete
		}

		public CRUDStateEnum CRUDState { get; set; }


		public CRUDForm(CRUDStateEnum stateEnum)
		{
			CRUDState = stateEnum;
		}
	}
}