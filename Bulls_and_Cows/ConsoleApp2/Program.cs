using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        // 作業4: 要使用者猜出任意產生的一個整數
        static void Main(string[] args)
        {
            int randomNumber;
            randomNumber = Convert.ToInt32(new Random().NextDouble() * 100); //隨機變數(>=0.0,<1.0*100
            Console.WriteLine("=====猜數字開始=====");
            Console.Write("請輸入數字:");
            int UserNumber = int.Parse(Console.ReadLine()); //後端為使用者輸入值，強制轉使用者輸入質為int
            Console.WriteLine();
            while (randomNumber != UserNumber) 
            {
                if (randomNumber > UserNumber)
                {
                    Console.WriteLine("猜的數字太低囉");
                    Console.Write("請輸入數字:");
                    UserNumber = int.Parse(Console.ReadLine());
                }
                else if (randomNumber < UserNumber)
                {
                    Console.WriteLine("猜的數字太高囉");
                    Console.Write("請輸入數字:");
                    UserNumber = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("恭喜你猜對了!!!!!");
        }
    }
}
