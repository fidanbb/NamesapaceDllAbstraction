using System;
namespace Domain.Models
{
	public class Doctor:BaseEntity
	{
		public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
		public DateTime Birthday { get; set; }

		//public Doctor()
		//{
		//	Age = 20;
		//}

	}
}

