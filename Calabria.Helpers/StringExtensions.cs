using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabria.Helpers
{
	public static class StringExtensions
	{
		public static int ParseInt(this string value, int defaultValue = 0)
		{
			if (int.TryParse(value, out var parsedValue))
			{
				return parsedValue;
			}

			return defaultValue;
		}

		public static int? ParseNullableInt(this string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return null;
			}

			return value.ParseInt();
		}
	}
}
