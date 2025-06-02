using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse_as_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FulltimeEmployee e1 = new FulltimeEmployee();
            e1.Id = 1;
            e1.Name = "Tèo";
            e1.Birthday = new DateTime(1960,1,1);
            Console.WriteLine("=======Thông tin E1=======");
            Console.WriteLine(e1);
            Console.WriteLine("AGE===> " + e1.TinhTuoi());
        }
    }
}
