using System;
using System.Linq;
using DBFirst.Models; // Replace with the actual namespace of your DbContext

class Program
{
    static void Main()
    {
        using (var context = new HandsOnContext())
        {
            var Employees = context.Employees.Where(p => p.Salary > 65000).ToList();

            foreach (var Employee in Employees)
            {
                Console.WriteLine($"ID: {Employee.EmployeeId}, Salary: {Employee.Salary}");
            }

            var joinED=from e in context.Employees join d in context.Departments on e.DepartmentId equals d.DepartmentId where e.Salary>65000
                       select new{EName=e.FirstName,Salary=e.Salary,DeptId=d.DepartmentId,Dept=d.DepartmentName}; 
            foreach (var Employee in joinED)
            {
                Console.WriteLine($"ID: {Employee.EName}, Salary: {Employee.Salary}, DeptId: {Employee.DeptId}, DeptName: {Employee.Dept}");
            }

            var distinctDepartments = context.Employees.Select(e => e.Department).Distinct();
            Console.WriteLine("Distinct Departments:");
            foreach (var department in distinctDepartments)
            {
                Console.WriteLine(department?.DepartmentName);
            }
        }
    }

}
