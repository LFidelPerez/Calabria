using Calabria.Helpers;
using System;
using System.Collections.Generic;

namespace Calabria.Models
{
	public class Workshop : Base.Model
	{
		public string Name { get; set; }
		public string Time { get; set; }
		public string Day { get; set; }
		public int Age { get; set; }
		public string Materials { get; set; }
		public DateTime StartDate { get; set; }
		public string Classroom { get; set; }
		public Person Workshopper { get; set; }
		public int WorkshopperId { get; set; }
		public string Instagram { get; set; }
		public string Summary { get; set; }

		public static List<Workshop> ValueRangeToList(IList<IList<object>> values, out int maxItemid)
		{
			var list = new List<Workshop>();
			maxItemid = 0;

			for (int i = 0; values.Count > i; i++)
			{
				var item = values[i];

				list.Add(new Workshop()
				{
					IsDeleted = bool.Parse(item[0].ToString()),
					Id = int.Parse(item[2].ToString()),
					Name = item[3].ToString(),
					Time = item[4].ToString(),
					Day = item[5].ToString(),
					Age = int.Parse(item[6].ToString()),
					Materials = item[7].ToString(),
					StartDate = ObjectTypeCast.ToDateTime(item[8]),
					Classroom = item[9].ToString(),
					WorkshopperId = int.Parse(item[10].ToString()),
					Instagram = item[11].ToString(),
					Summary = item[12].ToString()
				});

				maxItemid = list[i].Id;
			}

			return list;
		}
	}
}