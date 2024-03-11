using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh1
{
    public class Customer : Person
    {
        public CustomerType CustomerType { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Thông tin khách hàng ----");
            Console.WriteLine("Tên: " + Name);
            Console.WriteLine("Địa chỉ: " + Address);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Số điện thoại: " + PhoneNumber);
            Console.WriteLine("Loại khách hàng: " + CustomerType);
        }

        public override void InputInfo()
        {
            Console.WriteLine("---- Nhập thông tin khách hàng ----");
            Console.Write("Tên: ");
            Name = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            Address = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Số điện thoại: ");
            PhoneNumber = Console.ReadLine();
            Console.Write("Loại khách hàng (1 - Cá nhân, 2 - Doanh nghiệp): ");
            CustomerType = (CustomerType)int.Parse(Console.ReadLine());
        }

    }
    public enum CustomerType
    {
        Individual,
        Company
    }
}
