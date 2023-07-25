using System;
namespace Domain.Models
{
	public class Employee:BaseEntity
	{

		public string Name { get; set; }
		public string Surname { get; set; }
        //private protected int Age { get; set; }
        //protected internal decimal Salary { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

  //      public Employee()
		//{
		//	Employee employee = new();
		//	employee.Salary = 1000;
		//}


	}
}

