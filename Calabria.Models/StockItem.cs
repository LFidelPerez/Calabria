using System;

namespace Calabria.Models
{
	public class StockItem
	{
		public StockItem() { }

		public int? Id { get; set; }
		public string ItemType { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DateDeleted { get; set; }
	}
}
