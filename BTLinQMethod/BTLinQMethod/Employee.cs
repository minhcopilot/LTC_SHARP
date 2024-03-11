using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLinQMethod
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public int Age;
        public double Salary;
        public DateTime Birthday;
        public static List<Employee> getEmployees()
        {
            return new List<Employee>()
            {
                new Employee{ID=1,Name ="A",DepartmentID=1, Age=22,Salary=1500000,Birthday= new DateTime(2002, 1, 1)},
                new Employee{ID=2,Name ="B",DepartmentID=2, Age=21,Salary=3500000,Birthday= new DateTime(2003, 5, 3)},
                new Employee{ID=3,Name ="C",DepartmentID=3, Age=20,Salary=9500000,Birthday= new DateTime(2004, 7, 19)},
                new Employee{ID=4,Name ="D",DepartmentID=4, Age=19,Salary=5500000,Birthday= new DateTime(2005, 8, 23)},
                new Employee{ID=5,Name ="E",DepartmentID=5, Age=18,Salary=6500000,Birthday= new DateTime(2006, 11, 29)},
            };
        }

     }
}
