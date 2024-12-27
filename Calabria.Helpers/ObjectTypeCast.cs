using System;

namespace Calabria.Helpers
{
	public static class ObjectTypeCast
	{
		public static int ToInt(object value)
		{
			return int.Parse((string)value);
		}

		public static bool ToBool(object value)
		{
			return bool.Parse((string)value);
		}

		public static DateTime ToDateTime(object value)
		{
			if (DateTime.TryParse(value.ToString(), out DateTime result))
			{
				return result;
			}
			return default;
		}
	}
}