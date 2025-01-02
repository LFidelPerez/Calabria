using Calabria.Models;
using System.Collections.Generic;

namespace Calabria.Services.Models
{
	public class WorkshopDataService : BaseDataService<Workshop>
	{
		public WorkshopDataService() : base(
			sheetName: "Miembros",
			firstColumn: "A",
			lastColumn: "P",
			firstIndexOffset: 2)
		{

		}

		public override List<Workshop> GetDataListItems()
		{
			var rangeValues = GetDataItems();

			// Do nothing if range has no values
			if (rangeValues.Values == null)
			{
				return null;
			}

			return Workshop.ValueRangeToList(rangeValues.Values, out _maxItemId);
		}

		public List<Workshop> FilterItemsByAny(string filterArg)
		{
			var list = new List<Workshop>();
			var valueList = filterArg.Split(' ');

			foreach (var item in DataList)
			{
				foreach (var value in valueList)
				{
					if (item.Name.ToLower().Contains(value))
					{
						list.Add(item);
						break;
					}
				}
			}

			return list;
		}
	}
}