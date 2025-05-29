using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Console.WriteLine("a trước khi vào hàm =" + a);
            Console.WriteLine("b trước khi vào hàm =" + b);
            //doicho(out a, out b);
            //doicho(ref a, ref b);
            Console.WriteLine("a sau khi vào hàm =" + a);
            Console.WriteLine("b sau khi vào hàm =" + b);
        }
        void doicho(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a trong hàm =" + a);
            Console.WriteLine("b trong hàm =" + b);
        }
    }
}
