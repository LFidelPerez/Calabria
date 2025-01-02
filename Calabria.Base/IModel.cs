using System;
using System.Collections.Generic;

namespace Calabria.Base
{
	public interface IModel
	{
		bool IsDeleted { get; set; }
		DateTime? DateDeleted { get; set; }
		int Id { get; set; }
	}
}
