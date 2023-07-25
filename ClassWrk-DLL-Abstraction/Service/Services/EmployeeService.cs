using System;
using Domain.Models;

namespace Service.Services
{
	public class EmployeeService
	{
        public Employee[] GetEmployees()
        {
            Employee[] employees =
            {

            new Employee
            {
                Id = 1,
                Name = "Ismayil",
                Surname = "Efendizade",
                Age = 29,
                Salary = 1200
            },

            new Employee
            {
                Id = 2,
                Name = "Xeyyam",
                Surname = "Isgenderov",
                Age = 29,
                Salary = 1100
            },

            new Employee
            {
                Id = 3,
                Name = "Cahangir",
                Surname = "Axundov",
                Age = 20,
                Salary = 1000
            }


            };

            return employees;
            }

        public Employee GetEmployeeById(int id)
        {
            var employees = GetEmployees();

            foreach (var employee in employees)
            {
                if (employee.Id==id)
                {
                    return employee;
                }
            }
            return null;
        }
	}
}

