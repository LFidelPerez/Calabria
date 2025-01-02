using System;

namespace Calabria.Base
{
	public class Model : IModel
	{
		public bool IsDeleted { get; set; }
		public DateTime? DateDeleted { get; set; }
		public int Id { get; set; }
	}
}