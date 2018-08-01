using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開始");
            // fix #1    印出 九九乘法表

            int A, B; // A 被乘數 B乘數
            int product; //product 積
            A = 1;

            while (A <= 9)
            {
                B = 1;
                while (B <= 9)
                {
                    product = A * B;
                    Console.Write(A);
                    Console.Write("*");
                    Console.Write(B);
                    Console.Write("=");
                    if (product < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(product + " ");
                    B = B + 1;
                }
                Console.WriteLine("");
                A = A + 1;
            }

            //Console.WriteLine("1x1= 1 1x2= 2 1x3= 3 1x4= 4 1x5= 5 1x6= 6 1x7= 7 1x8= 8 1x9= 9 ");
            //Console.WriteLine("2x1= 2 2x2= 4 2x3= 6 2x4= 8 2x5=10 2x6=12 2x7=14 2x8=16 2x9=18 ");

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("結束");
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine();
        }
    }

}
    

