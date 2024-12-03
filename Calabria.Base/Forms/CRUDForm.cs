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
			X, C, U, D
		}

		public CRUDStateEnum CRUDState { get; set; }

		

	}
}