using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLinq2_PhanLeVanMinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Department> departments = new List<Department>()
                {
                    new Department(1, "Department1", "This is department 1"),
                    new Department(2, "Department2", "This is department 2"),
                    new Department(3, "Department3", "This is department 3"),
                };

                 List<Position> positions = new List<Position>()
                {
                    new Position(1, "Position1", "This is position 1"),
                    new Position(2, "Position2", "This is position 2"),
                    new Position(3, "Position3", "This is position 3"),
                };

                 List<Employee> employees = new List<Employee>()
                {
                    new Employee(1, "Phan Le Van Minh", 30, departments[0], positions[0]),
                    new Employee(2, "Employee2", 35, departments[1], positions[1]),
                    new Employee(3, "Employee3", 40, departments[2], positions[2]),
                };
            while (true)
            {
                Console.WriteLine("Enter search keyword:");
                string keyword = Console.ReadLine();

                Console.WriteLine("Enter age from:");
                int ageFrom = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter age to:");
                int ageTo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter position:");
                string positionName = Console.ReadLine();

                Console.WriteLine("Enter department:");
                string departmentName = Console.ReadLine();

                var results = employees.Where(e =>
                    (e.Name.ToLower().Contains(keyword.ToLower()) ||
                    e.Position.Name.ToLower().Contains(keyword.ToLower()) ||
                    e.Department.Name.ToLower().Contains(keyword.ToLower())||
                    e.Position.Description.ToLower().Contains(keyword.ToLower()) ||
                    e.Department.Description.ToLower().Contains(keyword.ToLower())
                    ) &&
                    e.Age >= ageFrom && e.Age <= ageTo &&
                    e.Position.Name == positionName &&
                    e.Department.Name == departmentName
                );
                if (results.Count() > 0)
                {
                    Console.WriteLine("----- Kết quả tìm kiếm -----");

                    foreach (var result in results)
                    {
                        Console.WriteLine($"Name: {result.Name}, Age: {result.Age}, Position: {result.Position.Name}, Department: {result.Department.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Không tìm thấy kết quả phù hợp!");
                }

                Console.WriteLine("Nhấn Enter để tiếp tục tìm kiếm hoặc 'q' để thoát...");
                string exit = Console.ReadLine();
                if (exit == "q") break;
            }
                Console.ReadKey();
        }
    }
}
