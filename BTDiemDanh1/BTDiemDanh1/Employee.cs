using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh1
{
    public class Employee : Person
    {
        public string Degree { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine("---- Thông tin nhân viên ----");
            Console.WriteLine("Tên: " + Name);
            Console.WriteLine("Địa chỉ: " + Address);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Số điện thoại: " + PhoneNumber);
            Console.WriteLine("Bằng cấp: " + Degree);
        }
        public override void InputInfo()
        {
            Console.WriteLine("---- Nhập thông tin nhân viên ----");
            Console.Write("Tên: ");
            Name = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            Address = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Số điện thoại: ");
            PhoneNumber = Console.ReadLine();
            Console.Write("Bằng cấp: ");
            Degree = Console.ReadLine();
        }
    }
}
