using Calabria.Models;
using System.Collections.Generic;

namespace Calabria.Services.Models
{
	public class PersonDataService : BaseDataService<Person>
	{
		public PersonDataService() : base(
			sheetName: "Miembros",
			firstColumn: "A",
			lastColumn: "P",
			firstIndexOffset: 2)
		{

		}

		public override List<Person> GetDataListItems()
		{
			var rangeValues = GetDataItems();

			// Do nothing if range has no values
			if (rangeValues.Values == null)
			{
				return null;
			}

			SetDataList (Person.ValueRangeToList(rangeValues.Values, out _maxItemId));

			return DataList;
		}

		public List<Person> FilterItemsByNames(string names)
		{
			var list = new List<Person>();
			var nameList = names.Split(' ');

			foreach (var item in DataList)
			{
				foreach (var name in nameList)
				{
					if (
						item.Names.ToLower().Contains(name)
						||
						item.Surnames.ToLower().Contains(name)
					)
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