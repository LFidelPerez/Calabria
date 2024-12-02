using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabria.Models
{
	public class StockItem
	{
		public StockItem() { }

		public int? Id { get; set; }
		public string ItemType { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
