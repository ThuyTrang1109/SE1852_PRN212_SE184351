using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n1 = 5;
            int n2 = 10;
            Console.WriteLine("Tổng n1=" + n1.TongTu1ToiN());
            Console.WriteLine("Tổng n2=" + n2.TongTu1ToiN());

            int[] M = new int[10];
            M.TaoMangNgauNhien();
            Console.WriteLine("Mảng trước khi sắp xếp:");
            M.XuatMang();
            M.SapXepTangDan();
            Console.WriteLine("Mảng sau khi sắp xếp:");
            M.XuatMang();


        }
    }
}
