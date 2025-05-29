using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInteraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string ho = "Nguyễn";
            string tenlot = "Thị";
            string ten = "Tèo";
            string tenfull = ho + " " + tenlot + " " + ten;
            Console.WriteLine(tenfull);
            StringBuilder sb = new StringBuilder();  // cọng chỗi sẽ chậm, nên dùng string builder sẽ nhanh hơn
            sb.Append(ho);
            sb.Append(" ");
            sb.Append(tenlot);
            sb.Append(" ");
            sb.Append(ten);
        }
    }
}
