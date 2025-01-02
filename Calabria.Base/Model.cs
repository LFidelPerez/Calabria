using System;
using System.Collections.Generic;

namespace Calabria.Base
{
	public class Model : IModel
	{
		public bool IsDeleted { get; set; }
		public DateTime? DateDeleted { get; set; }
		public int Id { get; set; }

		public static DateTime ToDateTime(object value)
		{
			if (DateTime.TryParse(value.ToString(), out DateTime result))
			{
				return result;
			}
			return default;
		}

		public static bool GetBoolItem(IList<object> item, int index)
		{
			try
			{
				if (bool.TryParse(item[index].ToString(), out bool result))
				{
					return result;
				}
			}
			catch { }

			return default;
		}

		public static DateTime GetDateTimeItem(IList<object> item, int index)
		{
			try
			{
				if (DateTime.TryParse(item[index].ToString(), out DateTime result))
				{
					return result;
				}
			}
			catch { }

			return default;
		}

		public static int GetIntItem(IList<object> item, int index)
		{
			try
			{
				if (int.TryParse(item[index].ToString(), out int result))
				{
					return result;
				}
			}
			catch { }

			return default;
		}

		public static string GetStringItem(IList<object> item, int index)
		{
			try
			{
				return item[index].ToString();
			}
			catch { }

			return default;
		}
	}
}