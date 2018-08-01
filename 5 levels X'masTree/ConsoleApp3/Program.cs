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
            // 第一段為加五個空白
            int a = 1;
           
            for (int i = 1; i <= 5; i++)  //整個For i先定義為1 當i小於5 i會加1
            {
                for (a = i; a <= 5; a++) //a 先定義為i ( 第一次迴圈 a為1 當a小於 a會加1
                {
                    Console.Write(" "); // 印下空白
                }
                
                //區分For
                for (int b = 1; b <= 2 * i - 1; b++) //定義b為1 當b小於等於2*6-1 b加1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
