using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        //Employee id property
        public int Id { get; set; }

        //Employee name property
        public string Name { get; set; }

        //Employee email property
        public string Email { get; set; }

        //Employee phone property
        public string Phone { get; set; }

        //Employee address property
        public string Address { get; set; }

        //Employee position property
        public string Position { get; set; }

        //Employee salary property
        public int Salary { get; set; }

        //Constructor to create new employee object
        public Employee(int id, string name, string email, string phone, string address, string position, int salary)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            Position = position;
            Salary = salary;
        }
        
        //method to get employee details
        public string GetDetails()
        {
            //return Employee Details
            return "(" + Id + ")" + Name + Email + Phone + Address + Position + Salary;
        }

        //method to update employee salary
        public void UpdateSalary(int newSalary)
        {
            Salary = newSalary;
        }
    }
}
