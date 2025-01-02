using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Calabria.Models
{
	public class Person : Base.Model
	{
		public string Names { get; set; }
		public string Surnames { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string EmergencyContact { get; set; }
		public DateTime? Birthday { get; set; }
		public int Age { get; set; }
		public bool IsMember { get; set; }
		public bool IsExcempt { get; set; }
		public string Gender { get; set; }
		public DateTime? DischargeDate { get; set; }
		public DateTime? AssociateDate { get; set; }
		public bool IsWorkshopper { get; set; }
		public string BankTransferRef { get; set; }

		public static List<Person> ValueRangeToList(IList<IList<object>> values, out int maxItemid)
		{
			var list = new List<Person>();
			maxItemid = 0;

			for (int i = 0; values.Count > i; i++)
			{
				var item = values[i];

				list.Add(new Person()
				{
					IsDeleted = GetBoolItem(item, 0),
					Id = GetIntItem(item, 2),
					Names = GetStringItem(item,3),
					Surnames = GetStringItem(item, 4),
					Email = GetStringItem(item, 5),
					Phone = GetStringItem(item, 6),
					EmergencyContact = GetStringItem(item, 7),
					Birthday = GetDateTimeItem(item, 8),
					IsMember = GetBoolItem(item, 9),
					IsExcempt = GetBoolItem(item, 10),
					Gender = GetStringItem(item, 11),
					DischargeDate = GetDateTimeItem(item, 12),
					AssociateDate = GetDateTimeItem(item, 13),
					IsWorkshopper = GetBoolItem(item, 14),
					BankTransferRef = GetStringItem(item, 15),
				});

				maxItemid = list[i].Id;
			}

			return list;
		}
	}
}