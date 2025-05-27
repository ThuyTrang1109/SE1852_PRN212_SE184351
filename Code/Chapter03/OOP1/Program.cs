using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category();
            c1.Id = 1;
            c1.Name = "Nuoc mam";
            Console.OutputEncoding = Encoding.UTF8;
            c1.PrintInfor();

            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "Teo";
            emp1.Email = "teo@gmail.com";
            emp1.Phone = "1234567890";
            //để lấy giá trị thuộc tính
            //tự gọi get cho property Id
            Console.WriteLine($"Employee ID={emp1.Id}");
            //tự gọi get cho property Name
            Console.WriteLine($"Employee ID={emp1.Name}");
            //Hoặc chúng ta gọi hàm:
            emp1.PrintInfor();

            //Ngoài ra mọi lớp đối tượng có hàm toString() giống java
            //Để tự động triệu gọi hàm
            //Xuất ra màn hình
            Console.WriteLine("----------------");
            Console.WriteLine(emp1);//tự gọi hàm toString()

            //vừa tạo đối tượng khởi tạo giá trị cho thuộc tính:
            Employee employee2 = new Employee(2, "Tý Đại Bàng","ty@yahoo.com", "0987654321");
            //xuất thông tin của emp2
            Console.WriteLine(employee2);
            //hoặc ta có thể coding như sau:
            Employee emp3 = new Employee()
            {
                Id = 1,
                Name = "Tủn",
                Email = "tun@hotmail.com",
                Phone = "0897654321"
            };
            //xuất thông tin của emp3
            Console.WriteLine(emp3);
        }

    }

    
}
