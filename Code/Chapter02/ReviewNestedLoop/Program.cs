using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewNestedLoop
{
    internal class Program
    {
        //Câu 1: vẽ hình
        static void hinh1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j == 0 || j == n-1 || i == j)
                    {
                        Console.Write("*");
                    } 
                    else
                    {
                        Console.Write(" ");
                    }    
                }
                Console.WriteLine(); // Xuống dòng sau mỗi dòng của hình

            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //hinh1(15);
            //Console.ReadLine(); // Dừng màn hình chờ xem kết quả
            int[] arr = { 10, 3, 7, 2, 9 };
            Console.WriteLine("Mảng trước khi sắp xếp");
            foreach (int x in arr)
                Console.WriteLine($"{x}\t");
            mysort(arr);
            Console.WriteLine("Mảng sau khi sắp xếp");
            foreach (int x in arr)
                Console.WriteLine($"{x}\t");

        }
        //Câu 2: dùng 2 dòng do while lòng nhau để sắp xếp mảng tăng dần
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void mysort(int[]arr)
        {
            int i = 0;
            int j = i + 1;
            do
            {
                do
                {
                    if (arr[i] > arr[j])
                    {
                        swap(ref arr[i], ref arr[j]);
                    }
                    j++;
                } while (j<arr.Length-1);
                i++;
                j = i + 1;
            } while (i<arr.Length-1);
        }
        

    }
}
