using System;

namespace Calabria.Models
{
	public class Person
	{
		public int Id { get; set; }
		public string Names { get; set; }
		public string Surnames { get; set; }
		public string Email{ get; set; }
		public int Age { get; set; }
		public DateTime? Birthday { get; set; }
		public int Gender { get; set; }
	}
}