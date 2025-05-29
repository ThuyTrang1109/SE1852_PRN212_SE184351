using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hãy viết 1 hàm có khả năng nhận vào bất cứ phần mềm nào cũng được và có khả năng trả về tất cả phần tử đó
            int sums(params int[] arr)
            {
                int s = 0;
                foreach (int x in arr)
                    s += x;
                return s;
            }
            int s1 = sums(1);
            int s2 = sums(1, 8);
            int s3 = sums(12, 15, 10);
            Console.WriteLine($"s1={s1}; s2={s2}; s3={s3}");
        }
    }
}
