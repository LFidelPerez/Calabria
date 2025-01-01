using System;

namespace Calabria.Models
{
	public class Person
	{
		public bool IsDeleted { get; set; }
		public DateTime? DateDeleted { get; set; }
		public int Id { get; set; }
		public string Names { get; set; }
		public string Surnames { get; set; }
		public string Email{ get; set; }
		public string Phone { get; set; }
		public string EmergencyContact { get; set; }
		public DateTime? Birthday { get; set; }
		public int Age { get; set; }
		public bool IsMember{ get; set; }
		public bool IsExcempt{ get; set; }
		public string Gender { get; set; }
		public DateTime? DischargeDate { get; set; }
		public DateTime? AssociateDate { get; set; }
		public bool IsWorkshopper{ get; set; }

	}
}