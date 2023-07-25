using System;
using Service.Services;

namespace ClassWrk_DLL_Abstraction.Controllers
{
	public class EmployeeController
	{
		private readonly EmployeeService _employeeServie;
		public readonly int age;

		public const int number =55;

		public EmployeeController()
		{
			_employeeServie = new EmployeeService();
			age = 33;
		}

		public void GetAllemployees()
		{
			var employees = _employeeServie.GetEmployees();

			foreach (var employee in employees)
			{
				string result = $"{employee.Id}, {employee.Name} {employee.Surname}, {employee.Age}, {employee.Salary}$";
                Console.WriteLine(result);
            }
			
		}

		public void GetEmployeeById()
		{
			int id = 2;
			var employee = _employeeServie.GetEmployeeById(id);

			Console.WriteLine(employee.Id + ","+ employee.Name);

		}

		
	}
}

