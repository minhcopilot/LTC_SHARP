using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLinQMethod
{
    class Program
    {
        static List<Department> departments = Department.GetDepartments();
        static List<Employee> employees = Employee.getEmployees();
        static void Main(string[] args)
        {

            // Linq query: Max, min, average salary
            double maxSalary = employees.Max(e => e.Salary);
            double minSalary = employees.Min(e => e.Salary);
            double avgSalary = employees.Average(e => e.Salary);
            Console.WriteLine("PHAN LE VAN MINH - 21115053120333");
            Console.WriteLine("BAI TAP LINQ TAI LOP NGAY 11/03/2024 ");
            Console.WriteLine("<<<<<<<<<<<<<<<<<< RESULT >>>>>>>>>>>>>>>>>>");
            Console.WriteLine($"Max Salary: {maxSalary}");
            Console.WriteLine($"Min Salary: {minSalary}");
            Console.WriteLine($"Average Salary: {avgSalary}");

            // Linq Join
            var joinQuery = from emp in employees
                            join dept in departments on emp.DepartmentID equals dept.ID
                            select new
                            {
                                EmployeeName = emp.Name,
                                DepartmentName = dept.Name
                            };

            Console.WriteLine("\nJoin Query:");
            foreach (var item in joinQuery)
            {
                Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentName}");
            }

            // Linq GroupJoin
            var groupJoinQuery = from dept in departments
                                 join emp in employees on dept.ID equals emp.DepartmentID into empGroup
                                 select new
                                 {
                                     DepartmentName = dept.Name,
                                     Employees = empGroup
                                 };

            Console.WriteLine("\nGroup Join Query:");
            foreach (var item in groupJoinQuery)
            {
                Console.WriteLine($"Department: {item.DepartmentName}");
                foreach (var emp in item.Employees)
                {
                    Console.WriteLine($"- Employee: {emp.Name}");
                }
            }

            // Linq Left Join
            var leftJoinQuery = from dept in departments
                                join emp in employees on dept.ID equals emp.DepartmentID into empGroup
                                from emp in empGroup.DefaultIfEmpty()
                                select new
                                {
                                    DepartmentName = dept.Name,
                                    EmployeeName = emp != null ? emp.Name : "No employee"
                                };

            Console.WriteLine("\nLeft Join Query:");
            foreach (var item in leftJoinQuery)
            {
                Console.WriteLine($"Department: {item.DepartmentName}, Employee: {item.EmployeeName}");
            }

            // Linq Right Join
            var rightJoinQuery = from emp in employees
                                 join dept in departments on emp.DepartmentID equals dept.ID into deptGroup
                                 from dept in deptGroup.DefaultIfEmpty()
                                 select new
                                 {
                                     EmployeeName = emp.Name,
                                     DepartmentName = dept != null ? dept.Name : "No department"
                                 };

            Console.WriteLine("\nRight Join Query:");
            foreach (var item in rightJoinQuery)
            {
                Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentName}");
            }

            // Max, min age
            int maxAge = employees.Max(e => e.Age);
            int minAge = employees.Min(e => e.Age);

            Console.WriteLine($"\nMax Age: {maxAge}");
            Console.WriteLine($"Min Age: {minAge}");
            Console.ReadKey();
        }
    }
}
